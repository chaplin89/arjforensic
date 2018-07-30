using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARJArchive
{
    public class GlobalHeaderDescriptor
    {
        public ushort ID { get; internal set; }
        public ushort BasicHeaderSize { get; internal set; }
        public byte SizeOfHeaderIncludingExtraData { get; internal set; }

        public BasicMainHeader BasicHeader { get; internal set; }

        public uint BasicHeaderCRC32 { get; internal set; }
        public ushort SizeOfFirstExtendedHeader { get; internal set; }
        public byte[] ExtendedHeader { get; internal set; }
        public uint ExtendedHeaderCRC32 { get; internal set; }
    }
}
