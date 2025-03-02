namespace Oblikovati.API;

public interface IRxFileUIEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TemplateDir">TemplateDir</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="TemplateFileName">TemplateFileName</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileNewDialog([In] [MarshalAs(UnmanagedType.BStr)] string TemplateDir, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string TemplateFileName, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="FileName">FileName</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileOpenDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileTypes">FileTypes</param>
    /// <param name="SaveCopyAs">SaveCopyAs</param>
    /// <param name="ParentHWND">ParentHWND</param>
    /// <param name="FileName">FileName</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileSaveAsDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] bool SaveCopyAs, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] out HandlingCodeEnum HandlingCode);
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
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileInsertNewDialog([In] [MarshalAs(UnmanagedType.BStr)] string TemplateDir, [In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string TemplateFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibraryName, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[] CustomLogicalName, [Out] out HandlingCodeEnum HandlingCode);
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
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileInsertDialog([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FileTypes, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] int ParentHWND, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibraryName, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[] CustomLogicalName, [Out] out HandlingCodeEnum HandlingCode);
}
