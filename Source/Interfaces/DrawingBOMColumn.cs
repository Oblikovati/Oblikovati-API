namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMColumn object represents a column within the drawing BOM.
/// </summary>
public interface DrawingBOMColumn
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the name of the custom property associated with this column.
    /// </summary>
    string CustomPropertyName { get; }
    /// <summary>
    /// Property that returns the parent DrawingBOM object.
    /// </summary>
    DrawingBOM Parent { get; }
    /// <summary>
    /// Property that returns the property type associated with this column.
    /// </summary>
    PropertyTypeEnum PropertyType { get; }
    /// <summary>
    /// Property that returns the title of the column.
    /// </summary>
    string Title { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropSetId">PropSetId</param>
    /// <param name="PropId">PropId</param>
    [PreserveSig]
    void GetFilePropertyId([Out] [MarshalAs(UnmanagedType.BStr)] out string PropSetId, [Out] out int PropId);
}
