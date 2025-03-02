namespace Oblikovati.API;

public interface FileUIEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TemplateDir">TemplateDir</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="TemplateFileName">TemplateFileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileNewDialog([In] [MarshalAs(UnmanagedType.BStr)] string TemplateDir, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string TemplateFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="FileName">FileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileOpenDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="SaveCopyAs">SaveCopyAs</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="FileName">FileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileSaveAsDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] bool SaveCopyAs, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TemplateDir">TemplateDir</param>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="TemplateFileName">TemplateFileName</param>
    /// <param name="FileName">FileName</param>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileInsertNewDialog([In] [MarshalAs(UnmanagedType.BStr)] string TemplateDir, [In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string TemplateFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibraryName, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="FileName">FileName</param>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileInsertDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibraryName, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileOpenFromMRU([In] [Out] [MarshalAs(UnmanagedType.BStr)] ref string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentType">DocumentType</param>
    /// <param name="TemplateFileName">TemplateFileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileNew([In] DocumentTypeEnum DocumentType, [In] [Out] [MarshalAs(UnmanagedType.BStr)] ref string TemplateFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileMetadataObjects">FileMetadataObjects</param>
    /// <param name="Formulae">Formulae</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPopulateFileMetadata([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator FileMetadataObjects, [In] [MarshalAs(UnmanagedType.BStr)] string Formulae, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
