using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARJArchive
{
    class Program
    {
        static void Main(string[] args)
        {

            var archive = new ARJARchiveDescriptor();

            using (var file = File.OpenRead("PHRAKIDX.arj"))
            using (var reader = new BinaryReader(file))
            {
                archive.ID = reader.ReadUInt16();
                archive.BasicHeaderSize = reader.ReadUInt16();
                archive.SizeOfHeaderIncludingExtraData = reader.ReadByte();
                archive.ArchiverVersionNumber = reader.ReadByte();
                archive.MinimumVersionNeededToExtract = reader.ReadByte();
                archive.HostOS = (HostType)reader.ReadByte();
                archive.InternalFlags = (InternalFlag)reader.ReadByte();
                archive.CompressionMethod = (CompressionMethod)reader.ReadByte();
                archive.FileType = (FileType)reader.ReadByte();
                archive.Reserved = reader.ReadByte();
                archive.DateTimeOfOriginalFileInMSDOSFormat = reader.ReadUInt32();
                archive.CompressedSizeOfFile = reader.ReadUInt32();
                archive.OriginalSizeOfFile = reader.ReadUInt32();
                archive.OriginalFileCRCMinus32 = reader.ReadUInt32();
                archive.FilespecPositionInFilename = reader.ReadUInt16();
                archive.FileAttributes = reader.ReadUInt16();
                archive.HostDataCurrentlyNotUsed = reader.ReadUInt16();
                archive.ExtendedFileStartingPositionWhenUsed = reader.ReadUInt32();
                archive.ASCIIFileName = 0x00;
                archive.Comment = 0x00;
                archive.BasicHeaderCRC32 = reader.ReadUInt32();
                archive.SizeOfFirstExtendedHeader = reader.ReadUInt16();
                archive.ExtendedHeaderCRC32 = reader.ReadUInt32();
                archive.CompressedFile = 0x00;
            }
        }
    }
}
