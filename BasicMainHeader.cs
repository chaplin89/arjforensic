using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARJArchive
{
    public class BasicMainHeader
    {
        public byte ArchiverVersionNumber { get; internal set; }
        public byte MinimumVersionNeededToExtract { get; internal set; }
        public HostType HostOS { get; internal set; }
        public InternalFlag InternalFlags { get; internal set; }
        public CompressionMethod CompressionMethod { get; internal set; }
        public FileType FileType { get; internal set; }
        public byte Reserved { get; internal set; }
        public uint ArchiveCreationDateTime { get; internal set; }
        public uint ArchiveLastEditDateTime { get; internal set; }
        public uint ArchiveSize { get; internal set; }
        public uint SecurityEnvelopeFilePosition { get; internal set; }
        public ushort FilespecPositionInFilename { get; internal set; }
        public ushort SecurityEnvelopeLenght { get; internal set; }
        public ushort NotUsed { get; internal set; }
        public string ASCIIFileName { get; internal set; }
        public string Comment { get; internal set; }
        public byte SecurityVersion { get; internal set; }
    }
}
