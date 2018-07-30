namespace ARJArchive
{
    public class BasicFileHeader
    {
        public byte ArchiverVersionNumber { get; internal set; }
        public byte MinimumVersionNeededToExtract { get; internal set; }
        public HostType HostOS { get; internal set; }
        public InternalFlag InternalFlags { get; internal set; }
        public CompressionMethod CompressionMethod { get; internal set; }
        public FileType FileType { get; internal set; }
        public byte Reserved { get; internal set; }
        public uint DateTimeOfOriginalFileInMSDOSFormat { get; internal set; }
        public uint CompressedSizeOfFile { get; internal set; }
        public uint OriginalSizeOfFile { get; internal set; }
        public uint OriginalFileCRCMinus32 { get; internal set; }
        public ushort FilespecPositionInFilename { get; internal set; }
        public ushort FileAttributes { get; internal set; }
        public ushort HostDataCurrentlyNotUsed { get; internal set; }
        public uint ExtendedFileStartingPositionWhenUsed { get; internal set; }
        public string ASCIIFileName { get; internal set; }
        public string Comment { get; internal set; }
    }
}