using System.IO;

namespace ARJArchive
{
    class Program
    {
        static void Main(string[] args)
        {

            var archive = new GlobalHeaderDescriptor();

            using (var file = File.OpenRead("PHRAKIDX.arj"))
            using (var reader = new BinaryReader(file))
            {
                archive.ID = reader.ReadUInt16();
                archive.BasicHeaderSize = reader.ReadUInt16();
                archive.SizeOfHeaderIncludingExtraData = reader.ReadByte();

                archive.BasicHeader = new BasicMainHeader();
                archive.BasicHeader.ArchiverVersionNumber = reader.ReadByte();
                archive.BasicHeader.MinimumVersionNeededToExtract = reader.ReadByte();
                archive.BasicHeader.HostOS = (HostType)reader.ReadByte();
                archive.BasicHeader.InternalFlags = (InternalFlag)reader.ReadByte();
                archive.BasicHeader.SecurityVersion = reader.ReadByte();
                archive.BasicHeader.FileType = (FileType)reader.ReadByte();
                archive.BasicHeader.Reserved = reader.ReadByte();
                archive.BasicHeader.ArchiveCreationDateTime = reader.ReadUInt32();
                archive.BasicHeader.ArchiveLastEditDateTime = reader.ReadUInt32();
                archive.BasicHeader.ArchiveSize = reader.ReadUInt32();
                archive.BasicHeader.SecurityEnvelopeFilePosition = reader.ReadUInt32();
                archive.BasicHeader.FilespecPositionInFilename = reader.ReadUInt16();
                archive.BasicHeader.FilespecPositionInFilename = reader.ReadUInt16();
                archive.BasicHeader.SecurityEnvelopeLenght = reader.ReadUInt16();
                archive.BasicHeader.ASCIIFileName = reader.ReadNullTerminatedString();
                archive.BasicHeader.Comment = reader.ReadNullTerminatedString();

                archive.BasicHeaderCRC32 = reader.ReadUInt32();
                archive.SizeOfFirstExtendedHeader = reader.ReadUInt16();

                var fileHeader = new LocalFileHeaderDescriptor();
                fileHeader.ID = reader.ReadUInt16();
                fileHeader.BasicHeaderSize = reader.ReadUInt16();
                fileHeader.SizeOfHeaderIncludingExtraData = reader.ReadByte();

                fileHeader.BasicHeader = new BasicFileHeader();
                fileHeader.BasicHeader.ArchiverVersionNumber = reader.ReadByte();
                fileHeader.BasicHeader.MinimumVersionNeededToExtract = reader.ReadByte();
                fileHeader.BasicHeader.HostOS = (HostType)reader.ReadByte();
                fileHeader.BasicHeader.InternalFlags = (InternalFlag)reader.ReadByte();
                fileHeader.BasicHeader.CompressionMethod = (CompressionMethod)reader.ReadByte();
                fileHeader.BasicHeader.FileType = (FileType)reader.ReadByte();
                fileHeader.BasicHeader.Reserved = reader.ReadByte();
                fileHeader.BasicHeader.DateTimeOfOriginalFileInMSDOSFormat = reader.ReadUInt32();
                fileHeader.BasicHeader.CompressedSizeOfFile = reader.ReadUInt32();
                fileHeader.BasicHeader.OriginalSizeOfFile = reader.ReadUInt32();
                fileHeader.BasicHeader.OriginalFileCRCMinus32 = reader.ReadUInt32();
                fileHeader.BasicHeader.FilespecPositionInFilename = reader.ReadUInt16();
                fileHeader.BasicHeader.FileAttributes = reader.ReadUInt16();
                fileHeader.BasicHeader.HostDataCurrentlyNotUsed = reader.ReadUInt16();
                fileHeader.BasicHeader.ASCIIFileName = reader.ReadNullTerminatedString();
                fileHeader.BasicHeader.Comment = reader.ReadNullTerminatedString();

                fileHeader.BasicHeaderCRC32 = reader.ReadUInt32();
                fileHeader.SizeOfFirstExtendedHeader = reader.ReadUInt16();
                fileHeader.CompressedFile = reader.ReadBytes((int)fileHeader.BasicHeader.CompressedSizeOfFile);

                var remainingBytes = reader.BaseStream.Length - reader.BaseStream.Position;

                if (remainingBytes != 0)
                {
                    byte[] remainingBuffer = new byte[remainingBytes];
                    reader.BaseStream.Read(remainingBuffer, 0, (int)remainingBytes);
                }
            }
        }
    }
}
