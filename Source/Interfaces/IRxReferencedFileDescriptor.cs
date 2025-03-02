namespace Oblikovati.API;

public interface IRxReferencedFileDescriptor
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DocumentTypeEnum DocumentType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; }
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
    object FileVersion { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFileAndReferences ReferencedDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pbstrRelativeFileName">pbstrRelativeFileName</param>
    /// <param name="pbstrLibraryName">pbstrLibraryName</param>
    void GetLogicalFileName([Out] [MarshalAs(UnmanagedType.BStr)] out string pbstrRelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string pbstrLibraryName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrRelativeFileName">bstrRelativeFileName</param>
    /// <param name="bstrLibraryName">bstrLibraryName</param>
    void _PutLogicalFileName([In] [MarshalAs(UnmanagedType.BStr)] string bstrRelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string bstrLibraryName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrFullFileName">bstrFullFileName</param>
    void PutLogicalFileNameUsingFull([In] [MarshalAs(UnmanagedType.BStr)] string bstrFullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnSize">pnSize</param>
    /// <param name="ppCustomLogicalFileName">ppCustomLogicalFileName</param>
    void GetCustomLogicalFileName([Out] out int pnSize, [Out] out IntPtr ppCustomLogicalFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nSize">nSize</param>
    /// <param name="pCustomLogicalFileName">pCustomLogicalFileName</param>
    void PutCustomLogicalFileName([In] int nSize, [In] ref byte pCustomLogicalFileName);
}
