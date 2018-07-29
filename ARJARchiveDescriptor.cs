namespace ARJArchive
{
    internal class ARJARchiveDescriptor
    {
        internal byte Reserved;

        public ARJARchiveDescriptor()
        {
        }

        public ushort ID { get; internal set; }
        public ushort BasicHeaderSize { get; internal set; }
        public byte SizeOfHeaderIncludingExtraData { get; internal set; }
        public byte ArchiverVersionNumber { get; internal set; }
        public byte MinimumVersionNeededToExtract { get; internal set; }
        public HostType HostOS { get; internal set; }
        public InternalFlag InternalFlags { get; internal set; }
        public CompressionMethod CompressionMethod { get; internal set; }
        public FileType FileType { get; internal set; }
        public uint DateTimeOfOriginalFileInMSDOSFormat { get; internal set; }
        public uint CompressedSizeOfFile { get; internal set; }
        public uint OriginalSizeOfFile { get; internal set; }
        public uint OriginalFileCRCMinus32 { get; internal set; }
        public ushort FilespecPositionInFilename { get; internal set; }
        public ushort FileAttributes { get; internal set; }
        public ushort HostDataCurrentlyNotUsed { get; internal set; }
        public uint ExtendedFileStartingPositionWhenUsed { get; internal set; }
        public int ASCIIFileName { get; internal set; }
        public int Comment { get; internal set; }
        public uint BasicHeaderCRC32 { get; internal set; }
        public ushort SizeOfFirstExtendedHeader { get; internal set; }
        public uint ExtendedHeaderCRC32 { get; internal set; }
        public int CompressedFile { get; internal set; }
    }
}