using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARJArchive
{
    public static class BinaryReaderExtensions
    {
        static public string ReadNullTerminatedString(this BinaryReader reader)
        {
            List<byte> byteList = new List<byte>();
            byte currentByte = reader.ReadByte();
            while (currentByte != 0x00)
            {
                byteList.Add(currentByte);
                currentByte = reader.ReadByte();
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}