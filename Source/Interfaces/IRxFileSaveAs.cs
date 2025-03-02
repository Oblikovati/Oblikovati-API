namespace Oblikovati.API;

public interface IRxFileSaveAs
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pDocument">pDocument</param>
    /// <param name="pnOwningDocuments">pnOwningDocuments</param>
    /// <param name="pppOwningDocuments">pppOwningDocuments</param>
    void _WhereUsed([In] [MarshalAs(UnmanagedType.IUnknown)] object pDocument, [In] [Out] ref int pnOwningDocuments, [Out] out IntPtr pppOwningDocuments);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pDocument">pDocument</param>
    /// <param name="pTargetFileName">pTargetFileName</param>
    void AddFileToSave([In] [MarshalAs(UnmanagedType.IUnknown)] object pDocument, [In] [MarshalAs(UnmanagedType.BStr)] string pTargetFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void ExecuteSaveAs();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void ExecuteSaveCopyAs();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void ExecuteSave();
}
