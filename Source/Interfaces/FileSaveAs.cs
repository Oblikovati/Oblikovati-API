namespace Oblikovati.API;

/// <summary>
/// Custom interface to access management information about a particular file version.
/// </summary>
public interface FileSaveAs
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="OwningDocuments">OwningDocuments</param>
    [PreserveSig]
    void _WhereUsed([In] [MarshalAs(UnmanagedType.IUnknown)] object Document, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref object[] OwningDocuments);
    /// <summary>
    /// Adds a document, taken from within this tree, to the set of documents to be saved. Please note: Saving of files in Apprentice is not allowed on files that require migration (any file that has not already been migrated to the same version of the Apprentice server). The current document's NeedsMigrating property must return False before the FileSaveAs object can successfully be returned.
    /// </summary>
    /// <param name="Document">Input object that specifies the to be saved.</param>
    /// <param name="TargetFileName">Input String that specifies the name of the file to be saved.</param>
    [PreserveSig]
    void AddFileToSave([In] [MarshalAs(UnmanagedType.IUnknown)] object Document, [In] [MarshalAs(UnmanagedType.BStr)] string TargetFileName);
    /// <summary>
    /// Executes the Save As operation on each of the documents specified via the AddFileToSave method.
    /// </summary>
    [PreserveSig]
    void ExecuteSaveAs();
    /// <summary>
    /// Executes the Save Copy As operation on each of the documents specified via the AddFileToSave method.
    /// </summary>
    [PreserveSig]
    void ExecuteSaveCopyAs();
    /// <summary>
    /// Executes the Save operation on each of the documents specified via the AddFileToSave method.
    /// </summary>
    [PreserveSig]
    void ExecuteSave();
}
