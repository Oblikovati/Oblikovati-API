namespace Oblikovati.API;

/// <summary>
/// The ContentCenter object provides the API interface to the Content Center functionality.
/// </summary>
public interface ContentCenter
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentQuery Query { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Language { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CategoryManager CategoryManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FamilyManager FamilyManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MemberManager MemberManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    QueryManager QueryManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LibraryManager LibraryManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentCenterEvents ContentCenterEvents { get; }
    /// <summary>
    /// Property that returns the top-most node in the Content Center tree. The entire tree can be accessed by traversing the tree beginning at this node.
    /// </summary>
    ContentTreeViewNode TreeViewTopNode { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Full">Full</param>
    [PreserveSig]
    void Refresh([In] bool? Full = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    bool ContentCenterControlled([In] [MarshalAs(UnmanagedType.Struct)] object Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    string GetMoniker([In] [MarshalAs(UnmanagedType.Struct)] object Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    ContentCenterDialog CreateContentCenterDialog();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReturnAs">ReturnAs</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    object GetTableOfContents([In] GeneralDataTypeEnum ReturnAs, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ForceRefreshCache();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Recursive">Recursive</param>
    [PreserveSig]
    object GetOutOfDateParts([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] bool? Recursive = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Recursive">Recursive</param>
    /// <param name="Settings">Settings</param>
    /// <param name="AssemblyRefreshInfo">AssemblyRefreshInfo</param>
    [PreserveSig]
    bool RefreshStandardComponents([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] bool? Recursive = true, [In] [MarshalAs(UnmanagedType.Struct)] object? Settings = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AssemblyRefreshInfo = default);
    /// <summary>
    /// Property that returns the specified content center object specified by the content identifier. If the object cannot be found then Nothing is returned. This can return a ContentFamily or ContentRow depending on what the identifier represents.
    /// </summary>
    /// <param name="ContentIdentifier">Input String that was previously obtained using the ContentIdentifier property of a content center object.</param>
    /// <param name="LibraryId">Not currently supported.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetContentObject([In] [MarshalAs(UnmanagedType.BStr)] string ContentIdentifier, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
}
