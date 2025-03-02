namespace Oblikovati.API;

public interface IRxFileAndReferencesOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DocumentTypeEnum DocumentType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int FileSaveCounter { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _FileVersion { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _AppMajorVersionCreated { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _AppMinorVersionCreated { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _AppMajorVersionSaved { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _AppMinorVersionSaved { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object FileVersions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte NeedsMigrating { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte Dirty { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte ReservedForWrite { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte ReservedForWriteByMe { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ReservedForWriteName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ReservedForWriteLogin { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ReservedForWriteVersion { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _FILETIME ReservedForWriteTime { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFileAndReferences ReferencedFiles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFileAndReferences AllReferencedFiles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumReferencedFileDescriptors ReferencedFileDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object ReferencedOLEFileDescriptors2 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _AssociatedFileDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPropertySets PropertySets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pbstrLocationName">pbstrLocationName</param>
    /// <param name="pLocationType">pLocationType</param>
    void GetLocationFoundIn([Out] [MarshalAs(UnmanagedType.BStr)] out string pbstrLocationName, [Out] out LocationTypeEnum pLocationType);
}
