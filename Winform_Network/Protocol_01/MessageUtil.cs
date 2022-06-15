using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Protocol_01
{
    public class MessageUtil
    {
        #region Delegate
        public delegate void WriteLogEvent(string msg, string flag);
        public static event WriteLogEvent WriteLog;
        #endregion

        #region Send, Receive
        public static void Send(TcpClient client, Message message)
        {
            NetworkStream stream = client.GetStream();
            // 보낼메세지 로그에 출력
            WriteLog(message.ToString(), "send");
            Debug.WriteLine("MessageUtil_Send()_1 : " + message.ToString() + message.GetSize());
            
            stream.Write(Encoding.UTF8.GetBytes(message.ToString()), 0, message.GetSize());

            byte[] outbuf = new byte[1024];
            int nbyte = stream.Read(outbuf, 0, outbuf.Length);
            Debug.WriteLine("MessageUtil_Send()_2 : " + nbyte);
            string output = Encoding.UTF8.GetString(outbuf, 0, outbuf.Length);
            Debug.WriteLine("MessageUtil_Send()_3 : " + output);
            // 응답받은 메세지 로그에 출력
            WriteLog(output, "result");

            stream.Close();
        }
        async public static void Receive(object o)
        {
            TcpClient tc = (TcpClient)o;

            int MAX_SIZE = 1024;
            NetworkStream stream = tc.GetStream();

            string msg = "";
            Message respMsg = null;
            var buff = new byte[MAX_SIZE];
            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);
            Debug.WriteLine("MessageUtil_Receive()_2 : " + nbytes);
            if (nbytes > 0)
            {
                Debug.WriteLine("MessageUtil_Receive()_3");
                msg = Encoding.UTF8.GetString(buff, 0, nbytes);
                Debug.WriteLine("MessageUtil_Receive()_4 : " + msg);
                //msg.Substring(1, msg.Length);
                Debug.WriteLine("MessageUtil_Receive()_5 : " + msg.Substring(msg.Length-1));
                // 받은메세지 로그에 출력

                //WriteLog.Invoke(msg, "rec");

                if (msg.Substring(0, 1) != "<" || msg.Substring(msg.Length - 1) != ">")
                {
                    Debug.WriteLine("MessageUtil_Receive()_6-1 : " + msg);
                    // STX, ETX 가 잘못된경우 null을 반환
                    //WriteLog(respMsg.ToString(), "resp");
                }
                else
                {
                    Debug.WriteLine("MessageUtil_Receive()_6-2 : " + msg);
                    
                    string[] splitMsg = msg.Substring(1, msg.Length-2).Split(","); // STX, ETX 제거 맟 ','로 프로토콜 요소 분리

                    foreach(string s in splitMsg)
                        Debug.WriteLine("MessageUtil_Receive()_7 : " + s);
                    // COMMAND 별로 각 메소드 호출해서 응답할 값을 받아온다.
                    // respMsg = StartResp();
                    switch (splitMsg[2].Substring(0, 3))
                    {
                        case "STA":
                            respMsg = GetStartResp(splitMsg);
                            break;
                        case "STO":
                            respMsg = GetEndResp(splitMsg);
                            break;
                        case "REQ":
                            respMsg = GetRequestResp(splitMsg);
                            break;
                        case "ROT":
                            respMsg = GetRotationResp(splitMsg);
                            break;
                    }
                    Debug.WriteLine("MessageUtil_Receive()_8 : " + respMsg.ToString());
                    // 보낼메세지 로그에 출력
                    //WriteLog(respMsg.ToString(), "resp");
                }
                Debug.WriteLine("MessageUtil_Receive()_9");
                // 송신자에게 결과 메세지 응답
                byte[] respMsgByte = Encoding.UTF8.GetBytes(respMsg.ToString());
                stream.Write(respMsgByte, 0, respMsg.GetSize());
            }
            Debug.WriteLine("MessageUtil_Receive()_10");
            stream.Close();
            tc.Close();
        }
        #endregion

        #region Create Send Message
        public static Message GetStartMsg(string data)
        {
            Base startBase = new Base(CONSTANTS.PICKER_ITEM.P0.ToString(), CONSTANTS.VISION_ITEM.ALL.ToString(), "START");
            Data startData = new Data(data);
            return new Message(startBase, startData);
        }
        public static Message GetEndMsg()
        {
            Base endBase = new Base(CONSTANTS.PICKER_ITEM.P0.ToString(), CONSTANTS.VISION_ITEM.ALL.ToString(), "STOP");
            return new Message(endBase);
        }
        public static Message GetRequestMsg(string pickerNo, string visionName)
        {
            Base requestBase = new Base(pickerNo, visionName, "REQUEST");
            return new Message(requestBase);
        }
        public static Message GetRotationMsg(string pickerNo, string rotationNo, string data)
        {
            Base rotationBase = new Base(pickerNo, CONSTANTS.VISION_ITEM.GLASS.ToString(), rotationNo);
            Data rotationData = new Data(data);
            return new Message(rotationBase, rotationData);
        }
        #endregion

        #region Create Response Message
        public static Message GetStartResp(string[] message)
        {
            Message msg;
            Base startBase = new Base(CONSTANTS.PICKER_ITEM.P0.ToString(), CONSTANTS.VISION_ITEM.ALL.ToString(), message[2]);
            Data startData;

            // Start 메시지 관련 로직
            // true 반환되면 ACK, false는 NCK

            if (StartResult(message[3]) == true)
            {
                // 1. ACK
                startData = new Data(CONSTANTS.SUCCESS);
                msg = new Message(startBase, startData);
            }
            else
            {
                // 2. NCK
                startData = new Data(CONSTANTS.FAIL);
                Error startError = new Error(CONSTANTS.ERROR);
                msg = new Message(startBase, startData, startError);
            }

            return msg;
        }

        public static Message GetEndResp(string[] message)
        {
            Message msg;
            Base endBase = new Base(CONSTANTS.PICKER_ITEM.P0.ToString(), CONSTANTS.VISION_ITEM.ALL.ToString(), message[2]);
            Data endData;

            if (EndResult() == true)
            {
                // 1. ACK
                endData = new Data(CONSTANTS.SUCCESS);
                msg = new Message(endBase, endData);
            }
            else
            {
                // 2. NCK
                endData = new Data(CONSTANTS.FAIL);
                Error endError = new Error(CONSTANTS.ERROR);
                msg = new Message(endBase, endData, endError);
            }

            return msg;
        }

        public static Message GetRequestResp(string[] message)
        {
            Message msg;
            Base requestBase = new Base(message[0], message[1], message[2]);
            Data requestData;

            string tempNo = message[0].Substring(1);

            Value requestValue;

            if ((requestValue = RequestResult("P" + tempNo, message[1])).X != "") // 값이 null이 아니면 ACK
            {
                requestData = new Data(CONSTANTS.SUCCESS);
                msg = new Message(requestBase, requestData, requestValue);
            }
            else
            {
                requestData = new Data(CONSTANTS.FAIL);
                Error requestError = new Error(CONSTANTS.ERROR);
                msg = new Message(requestBase, requestData, requestError);
            }

            return msg;
        }

        public static Message GetRotationResp(string[] message)
        {

            Message msg;
            Base rotationBase = new Base(message[0], message[1], message[2]);
            Data rotationData;

            string pickerNo = message[0].Substring(1);
            string rotationNo = message[2].Substring(8);

            if (RotationResult(pickerNo, rotationNo, message[3]) == true)
            {
                rotationData = new Data(CONSTANTS.SUCCESS);
                msg = new Message(rotationBase, rotationData);
            }
            else
            {
                rotationData = new Data(CONSTANTS.FAIL);
                Error rotationError = new Error(CONSTANTS.ERROR);
                msg = new Message(rotationBase, rotationData, rotationError);
            }

            return msg;
        }
        #endregion

        #region Logic(미구현)
        public static bool StartResult(string data)
        {
            // 성공 true
            if (data == "error")
            {
                Debug.WriteLine("@@@@@@@@@ Error string check");
                return false;
            }
            Debug.WriteLine("@########@ Error string check");
            // 실패 flase
            return true;
        }
        public static bool EndResult()
        {
            // 성공 true

            // Test

            // 실패 flase
            return true;
        }
        public static Value RequestResult(string pickerNo, string visionName)
        {
            // 성공 x, y, z 에 값 넣기

            // 실패 x, y, z 모두 ""
            return new Value("234.231", "231.221", "122.743");
        }
        public static bool RotationResult(string pickerNo, string rotationNo, string data)
        {
            // 성공 true
            if(data == "error")
            {
                return false;
            }
            // 실패 flase 
            return true;
        }
        #endregion
    }
}
