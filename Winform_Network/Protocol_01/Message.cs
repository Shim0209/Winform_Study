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
        public const string ERROR = "ERROR";

        public enum PICKER_ITEM
        {
            P0, P1, P2, P3, P4, P5
        }

        public enum VISION_ITEM
        {
            ALL, GLASS, PCB
        }

        public enum ROTATION_ITEM
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
/*        public string STX { get; set; }
        public string ETX { get; set; }*/
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
                Encoding.UTF8.GetBytes("<").CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, "<".Length);
                Encoding.UTF8.GetBytes(",").CopyTo(bytes, "<".Length + Base.GetSize());
                Data.GetBytes().CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length);
                Encoding.UTF8.GetBytes(",").CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize());
                Value.GetBytes().CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize() + ",".Length);
                Encoding.UTF8.GetBytes(">").CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize() + ",".Length + Value.GetSize());
                return bytes;
            }
            else if (Error != null)
            {
                Encoding.UTF8.GetBytes("<").CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, "<".Length);
                Encoding.UTF8.GetBytes(",").CopyTo(bytes, "<".Length + Base.GetSize());
                Data.GetBytes().CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length);
                Encoding.UTF8.GetBytes(",").CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize());
                Error.GetBytes().CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize() + ",".Length);
                Encoding.UTF8.GetBytes(">").CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize() + ",".Length + Error.GetSize());
                return bytes;
            }
            else if (Data != null)
            {
                Encoding.UTF8.GetBytes("<").CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, "<".Length);
                Encoding.UTF8.GetBytes(",").CopyTo(bytes, "<".Length + Base.GetSize());
                Data.GetBytes().CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length);
                Encoding.UTF8.GetBytes(">").CopyTo(bytes, "<".Length + Base.GetSize() + ",".Length + Data.GetSize());
                return bytes;
            }
            else
            {
                Encoding.UTF8.GetBytes("<").CopyTo(bytes, 0);
                Base.GetBytes().CopyTo(bytes, "<".Length);
                Encoding.UTF8.GetBytes(">").CopyTo(bytes, "<".Length + Base.GetSize());
                return bytes;
            }
        }

        public int GetSize()
        {
            if(Value != null)
            {
                return Base.GetSize() + ",".Length + Data.GetSize() + ",".Length + Value.GetSize();
            }
            else if(Error != null)
            {
                return Base.GetSize() + ",".Length + Data.GetSize() + ",".Length + Error.GetSize();
            }
            else if(Data != null)
            {
                return Base.GetSize() + ",".Length + Data.GetSize();
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

        public Base(string pICKER, string vISION, string cOMMAND)
        {
            PICKER = pICKER;
            VISION = vISION;
            COMMAND = cOMMAND;
        }

        public byte[] GetBytes()
        {
            string baseStr = PICKER + "," + VISION + "," + COMMAND;
            return Encoding.UTF8.GetBytes(baseStr);
        }

        public int GetSize()
        {
            return PICKER.Length + ",".Length + VISION.Length + ",".Length + COMMAND.Length;
        }
    }

    public class Data : ISerializable
    {
        public string innerData { get; set; }

        public Data(string innerData)
        {
            this.innerData = innerData;
        }

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

        public Error(string innerData)
        {
            this.innerData = innerData;
        }

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
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }

        public Value(string x, string y, string z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public byte[] GetBytes()
        {
            string valueStr = X + "," + Y + "," + Z;
            return Encoding.UTF8.GetBytes(valueStr);
        }

        public int GetSize()
        {
            return X.Length + ",".Length + Y.Length + ",".Length + Z.Length;
        }
    }
}
