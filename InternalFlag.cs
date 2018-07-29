namespace ARJArchive
{
    public enum InternalFlag : byte
    {
        Password = 0,
        Reserved = 1,
        FileContinuesOnNextDisk = 2,
        FileStartPositionFieldIsAvailable = 3,
        PathTranslation = 4,
    }
}