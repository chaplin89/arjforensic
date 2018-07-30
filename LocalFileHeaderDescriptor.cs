namespace ARJArchive
{
    internal class LocalFileHeaderDescriptor
    {
        public ushort ID { get; internal set; }
        public ushort BasicHeaderSize { get; internal set; }
        public byte SizeOfHeaderIncludingExtraData { get; internal set; }

        public BasicFileHeader BasicHeader { get; internal set; }

        public uint BasicHeaderCRC32 { get; internal set; }
        public ushort SizeOfFirstExtendedHeader { get; internal set; }
        public uint ExtendedHeaderCRC32 { get; internal set; }

        public byte[] CompressedFile { get; internal set; }
    }
}