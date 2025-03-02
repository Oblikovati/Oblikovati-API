namespace Oblikovati.API;

/// <summary>
/// The SheetFormats collection object provides access to all the existing SheetFormat objects in a drawing document and provides methods to create additional sheet formats.
/// </summary>
public interface SheetFormats : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified SheetFormat object from the collection.
    /// </summary>
    SheetFormat this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new SheetFormat. The newly created SheetFormat is returned.
    /// </summary>
    /// <param name="Sheet">Input Sheet object that specifies the sheet to be used as the template for creating the sheet format.</param>
    /// <param name="Name">Input String that defines the name of the sheet format. The name must be unique with respect to all other SheetFormats in the document or an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    SheetFormat Add([In] [MarshalAs(UnmanagedType.Interface)] Sheet Sheet, [In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Creates a new SheetFormat object.
    /// </summary>
    /// <param name="Sheet">Input Sheet object that specifies the sheet to be used as the template for creating the sheet format.</param>
    /// <param name="Name">Input String that defines the name of the sheet format.  The name must be unique with respect to all other SheetFormats in the document or an error will occur.</param>
    /// <param name="Options">Optional input NameValueMap that specifies more options for creating the sheet format. Valid values are:
    /// Name = “FitViewsToSheet”, Value = Boolean value that specifies whether to fit drawing views to sheet or not. If set this to True then the drawing views that are created on this sheet format will be auto-scaled according to the model and the sheet. If set this to False then the drawing views that are created on this sheet format will honor the scale that was saved in the drawing views in the sheet format. If not specified this default to False.</param>
    /// <returns></returns>
    [PreserveSig]
    SheetFormat AddWithOptions([In] [MarshalAs(UnmanagedType.Interface)] Sheet Sheet, [In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
