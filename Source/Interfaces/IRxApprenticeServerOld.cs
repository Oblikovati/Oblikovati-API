namespace Oblikovati.API;

public interface IRxApprenticeServerOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDocument Document { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFileAndReferences FileAndReferences { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFileLocations FileLocations { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFileSaveAs FileSaveAs { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte MultiUsersEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _NumberOfVersionsKept { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _MajorVersion { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _MinorVersion { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    IRxComponentDocument Open([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Close();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="NumVersionsToKeep">NumVersionsToKeep</param>
    void _MinimizeFileSize([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int NumVersionsToKeep);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="pbAlreadyOpen">pbAlreadyOpen</param>
    /// <param name="pbOpenInThisProcess">pbOpenInThisProcess</param>
    void _FileAlreadyOpen([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [Out] out sbyte pbAlreadyOpen, [Out] out sbyte pbOpenInThisProcess);
}
