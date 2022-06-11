using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocol_01
{
    public class CONSTANTS
    {
        public const string SUCCESS = "ACK";
        public const string FAIL = "NCK";

        enum PICKER_ITEM
        {
            P0, P1, P2, P3, P4, P5
        }

        enum ROTATION_ITEM
        {
            ROTATION1, ROTATION2, ROTATION3
        }
    }

    public interface ISerializable 
    {
        byte[] GetBytes();
        int GetSize();
    }

    public class Message : ISerializable
    {
        public string STX { get; set; }
        public string ETX { get; set; }
        public Base Base { get; set; }
        public Data? Data { get; set; }
        public Error? Error { get; set; }
        public Value? Value { get; set; }

        public Message()
        {
        }

        public Message(Base @base)
        {
            Base = @base;
        }

        public Message(Base @base, Data? data) : this(@base)
        {
            Data = data;
        }

        public Message(Base @base, Data? data, Error? error) : this(@base, data)
        {
            Error = error;
        }

        public Message(Base @base, Data? data, Value? value) : this(@base, data)
        {
            Value = value;
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            if (Value != null)
            {
                Encoding.UTF8.GetBytes(STX).CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, STX.Length);
                Data.GetBytes().CopyTo(bytes, STX.Length + Base.GetSize());
                Value.GetBytes().CopyTo(bytes, STX.Length + Base.GetSize() + Data.GetSize());
                Encoding.UTF8.GetBytes(ETX).CopyTo(bytes, STX.Length + Base.GetSize() + Data.GetSize() + Value.GetSize());
                return bytes;
            }
            else if (Error != null)
            {
                Encoding.UTF8.GetBytes(STX).CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, STX.Length);
                Data.GetBytes().CopyTo(bytes, STX.Length + Base.GetSize());
                Error.GetBytes().CopyTo(bytes, STX.Length + Base.GetSize() + Data.GetSize());
                Encoding.UTF8.GetBytes(ETX).CopyTo(bytes, STX.Length + Base.GetSize() + Data.GetSize() + Error.GetSize());
                return bytes;
            }
            else if (Data != null)
            {
                Encoding.UTF8.GetBytes(STX).CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, STX.Length);
                Data.GetBytes().CopyTo(bytes, STX.Length + Base.GetSize());
                Encoding.UTF8.GetBytes(ETX).CopyTo(bytes, STX.Length + Base.GetSize() + Data.GetSize());
                return bytes;
            }
            else
            {
                Encoding.UTF8.GetBytes(STX).CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, STX.Length);
                Encoding.UTF8.GetBytes(ETX).CopyTo(bytes, STX.Length + Base.GetSize());
                return bytes;
            }
        }

        public int GetSize()
        {
            if(Value != null)
            {
                return Base.GetSize() + Data.GetSize() + Value.GetSize();
            }
            else if(Error != null)
            {
                return Base.GetSize() + Data.GetSize() + Error.GetSize();
            }
            else if(Data != null)
            {
                return Base.GetSize() + Data.GetSize();
            }
            else
            {
                return Base.GetSize();
            }
        }
    }

    public class Base : ISerializable
    {
        // P0                   : 인터페이스
        // P1, P2, P3, P4, P5   : P 번호
        public string PICKER { get; set; }
        public string VISION { get; set; }
        public string COMMAND { get; set; }
        public byte[] GetBytes()
        {
            string baseStr = PICKER + VISION + COMMAND;
            return Encoding.UTF8.GetBytes(baseStr);
        }

        public int GetSize()
        {
            return PICKER.Length + VISION.Length + COMMAND.Length;
        }
    }

    public class Data : ISerializable
    {
        public string innerData { get; set; }
        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(innerData);
        }

        public int GetSize()
        {
            return innerData.Length;
        }
    }

    public class Error : ISerializable
    {
        public string innerData { get; set; }
        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(innerData);
        }

        public int GetSize()
        {
            return innerData.Length;
        }
    }

    public class Value : ISerializable
    {
        string X { get; set; }
        string Y { get; set; }
        string Z { get; set; }
        public byte[] GetBytes()
        {
            string valueStr = X + Y + Z;
            return Encoding.UTF8.GetBytes(valueStr);
        }

        public int GetSize()
        {
            return X.Length + Y.Length + Z.Length;
        }
    }
}
