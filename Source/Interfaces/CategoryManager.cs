namespace Oblikovati.API;

/// <summary>
/// CategoryManager Object.
/// </summary>
public interface CategoryManager
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string GetCategory([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentCategory">ParentCategory</param>
    /// <param name="NewCategoryXml">NewCategoryXml</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string AddCategory([In] [MarshalAs(UnmanagedType.BStr)] string ParentCategory, [In] [MarshalAs(UnmanagedType.BStr)] string NewCategoryXml, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryXml">CategoryXml</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    void EditCategory([In] [MarshalAs(UnmanagedType.BStr)] string CategoryXml, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    void DeleteCategory([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="Language">Language</param>
    /// <param name="EnumerationOnly">EnumerationOnly</param>
    [PreserveSig]
    string GetCategoryStrings([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Language = "", [In] bool? EnumerationOnly = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CategoryStrings">CategoryStrings</param>
    [PreserveSig]
    void EditCategoryStrings([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string CategoryStrings);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryIds">CategoryIds</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string[,] GetCategoryIcons([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] CategoryIds, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="IconFile">IconFile</param>
    [PreserveSig]
    void EditCategoryIcon([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string IconFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CategoryId">CategoryId</param>
    [PreserveSig]
    string GetItem([In] [MarshalAs(UnmanagedType.BStr)] string CategoryId);
}
