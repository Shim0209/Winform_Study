namespace LightController_Protocol
{
    /*
     * 모든 채널의 밝기 설정
     * STX  CMD  CH1 CH2 ... CHN ETX
     * 0x02 0x50 HEX             N+3
     * 
     * 개별 채널의 밝기 설정
     * STX  CHno  ETX
     * [    No    value
     * 
     * 개별 채널의 온/오프 설정
     * STX  CHno  ETX
     * ]    No    o/1
     * 
     * 페이지 데이터 전송
     * STX  BYTE  CMD  PAGE  CH1  CH2  ... CHN  ETX
     * 0x02 0xXX  0x80 No    HEX                N+5
     * 
     * 페이지 호출
     * STX  PAGE
     * 0x02 No
     * 
     * 설정 저장
     * STX  BYTE  CMD  ETX
     * 0x02 0x02  0x89 0x03
     */
    public class STX
    {
        const string STX_0x02 = "0x02";
        const string STX_0xAA = "0xAA";
        const string STX_IndivisualBrightness = "[";
        const string STX_IndivisualOnOff = "]";
    }

    public class CH
    {
        const int CH1 = 01;
        const int CH2 = 02;
        const int CH3 = 03;
        const int CH4 = 04;
        private string GetHEX(int value)
        {
            if(value >= 0 && value < 256)
                return value.ToString("0x");
            return "0x00";
        }
    }

    public class ETX
    {
        const string ETX_0x03 = "0x03";
        const string ETX_ON = "1";
        const string ETX_OFF = "0";

        private string GetValue(int value)
        {
            return value.ToString();
        }
    }

    public class BYTE
    {
        const string BYTE_PageDataTx = "0xXX";
        const string BYTE_SaveSetting = "0x02";
    }

    public class CMD
    {
        const string CMD_PageDataTx = "0x80";
        const string CMD_SaveSetting = "0x89";
    }

    public class PAGE
    {
        const string PAGE_One = "0x01";
        const string PAGE_Two = "0x02";
        const string PAGE_Three = "0x03";
        const string PAGE_four = "0x04";
    }
}