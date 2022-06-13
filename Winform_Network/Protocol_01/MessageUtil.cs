using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Protocol_01
{
    public class MessageUtil
    {
        public static void Send(Stream stream, Message message)
        {
            // 보낼메세지 로그에 출력
            // writeLog(msg, "send");
            stream.Write(message.GetBytes(), 0, message.GetBytes().Length);

            byte[] outbuf = new byte[1024];
            int nbyte = stream.Read(outbuf, 0, outbuf.Length);
            string output = Encoding.UTF8.GetString(outbuf, 0, outbuf.Length);

            // 응답받은 메세지 로그에 출력
            // writeLog(msg, "result")

            stream.Close();
        }

        // 수신 -> COMMAND분석 -> COM에 따른 처리 메소드호출 -> 응답할 메세지 반환
        // 각 COMMAND에 따른 ACK, NCK를 반환할 메소드를 매개변수로 받는다.

        // 수신 -> COMMAND분석 -> COM에 따른 처리 메소드호출 -> 응답할 메세지 반환
        // 각 COMMAND에 따른 ACK, NCK를 반환할 메소드를 매개변수로 받는다.
        async public static void Receive(object o)
        {
            TcpClient tc = (TcpClient)o;

            int MAX_SIZE = 1024;
            NetworkStream stream = tc.GetStream();

            string msg = "";
            Message respMsg = null;
            var buff = new byte[MAX_SIZE];
            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);
            if (nbytes > 0)
            {
                msg = Encoding.UTF8.GetString(buff, 0, nbytes).Substring(1, msg.Length);

                // 받은메세지 로그에 출력
                //writeLog(msg, "rec");

                if (msg.Substring(0) != "<" || msg.Substring(msg.Length, msg.Length + 1) != ">")
                {
                    // STX, ETX 가 잘못된경우 null을 반환
                    //writeLog(respMsg.ToString(), "resp");
                }
                else
                {
                    string[] splitMsg = msg.Substring(1, msg.Length).Split(","); // STX, ETX 제거 맟 ','로 프로토콜 요소 분리

                    // COMMAND 별로 각 메소드 호출해서 응답할 값을 받아온다.
                    // respMsg = StartResp();
                    switch (splitMsg[2].Substring(0, 3))
                    {
                        case "STA":
                            respMsg = GetStartResp(splitMsg);
                            break;
                        case "END":
                            respMsg = GetEndResp(splitMsg);
                            break;
                        case "REQ":
                            respMsg = GetRequestResp(splitMsg);
                            break;
                        case "ROT":
                            respMsg = GetRotationResp(splitMsg);
                            break;
                    }

                    // 보낼메세지 로그에 출력
                    //writeLog(respMsg.ToString(), "resp");
                }

                // 송신자에게 결과 메세지 응답
                Send(stream, respMsg);
            }
            stream.Close();
            tc.Close();
        }

        #region Send Message
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
            Base rotationBase = new Base(pickerNo, CONSTANTS.VISION_ITEM.GLASS.ToString(), "ROTATION" + rotationNo);
            Data rotationData = new Data(data);
            return new Message(rotationBase, rotationData);
        }
        #endregion

        #region Response Message
        public static Message GetStartResp(string[] message)
        {
            Message msg;
            Base startBase = new Base(CONSTANTS.PICKER_ITEM.P0.ToString(), CONSTANTS.VISION_ITEM.ALL.ToString(), message[2]);
            Data startData;

            // Start 메시지 관련 로직
            // true 반환되면 ACK, false는 NCK

            if (StartResult(message[2]) == true)
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

            string pickerNo = Enum.GetName(typeof(CONSTANTS.PICKER_ITEM), "P" + tempNo);
            string visionName = Enum.GetName(typeof(CONSTANTS.VISION_ITEM), message[1]);

            Value requestValue;

            if ((requestValue = RequestResult(pickerNo, visionName)).X != "") // 값이 null이 아니면 ACK
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
            string rotationNo = message[3].Substring(8);

            if (RotationResult(pickerNo, rotationNo) == true)
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

        public static bool StartResult(string data)
        {
            // 성공 true

            // 실패 flase
            return true;
        }
        public static bool EndResult()
        {
            // 성공 true

            // 실패 flase
            return true;
        }
        public static Value RequestResult(string pickerNo, string visionName)
        {
            // 성공 x, y, z 에 값 넣기

            // 실패 x, y, z 모두 ""
            return new Value("", "", "");
        }
        public static bool RotationResult(string pickerNo, string rotationNo)
        {
            // 성공 true

            // 실패 flase 
            return true;
        }

        // 클래스에서 윈폼에 접근할 방법 찾아야함.
        /*public void WriteLog(string message, string flag)
        {
            if (flag == "rec") // 받은 메세지
            {
                LogTB.Text = "받은메세지 : " + message;
            }
            else // 보낼 메세지
            {
                LogTB.Text = "응답한메세지 : " + message;
            }
        }*/
    }
}
