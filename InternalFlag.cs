using System;

namespace ARJArchive
{
    [Flags]
    public enum InternalFlag : byte
    {
        Password = 0x01,
        Reserved = 0x02,
        FileContinuesOnNextDisk = 0x04,
        FileStartPositionFieldIsAvailable = 0x08,
        PathTranslation = 0x10,
        BackupFlag = 0x20
    }
}