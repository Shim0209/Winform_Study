using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocol_01
{
    class MessageUtil
    {
        public static void Send(Stream stream, Message message)
        {
            stream.Write(message.GetBytes());
        }

        // 수신 -> COMMAND분석 -> COM에 따른 처리 메소드호출 -> 응답할 메세지 반환
        async public static Task<Message> Receive(Stream stream)
        {
            int MAX_SIZE = 1024;
            string msg = "";
            Task<Message> respMsg = null;
            var buff = new byte[MAX_SIZE];  
            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);
            if(nbytes > 0)
            {
                msg = Encoding.UTF8.GetString(buff, 0, nbytes).Substring(1, msg.Length);

                // 받은메세지 로그에 출력
                writeLog(msg, "rec");

                msg.Substring(1, msg.Length); // STX, ETX 제거
                string[] splitMsg = msg.Split(","); // ,로 프로토콜 요소 분리


                // COMMAND 별로 각 메소드 호출해서 응답할 값을 받아온다.
                // respMsg = StartResp();
                switch (splitMsg[2].Substring(0,3))
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
            }

            // 보낼메세지 로그에 출력
            writeLog(respMsg.ToString(), "resp");

            // 송신자에게 결과 메세지 응답
            Send(stream, respMsg.Result);

            stream.Close();

            return respMsg.Result;
        }

        async public static Task<Message> GetStartResp(string[] message)
        {
            // @@@구현해야함
            return new Message();
        }

        async public static Task<Message> GetEndResp(string[] message)
        {
            // @@@구현해야함
            return new Message();
        }

        async public static Task<Message> GetRequestResp(string[] message)
        {
            // @@@구현해야함
            return new Message();
        }

        async public static Task<Message> GetRotationResp(string[] message)
        {
            // @@@구현해야함
            return new Message();
        }

        // 받은메세지 rev, 보낼메세지 resp
        public static void writeLog(string message, string flag)
        {
            // 받은 메시지, 보낼 메세지 구별해서 로그에 출력
            if(flag == "rev")
            {
                // @@@구현해야함
            }
            else if(flag == "resp")
            {
                // @@@구현해야함
            }
        }
    }
}
