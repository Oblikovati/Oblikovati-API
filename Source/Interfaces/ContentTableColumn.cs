namespace Oblikovati.API;

/// <summary>
/// The ContentTableColumn object represents the column of the table associated with a particular content center family.
/// </summary>
public interface ContentTableColumn
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the display name of this column.
    /// </summary>
    string DisplayHeading { get; set; }
    /// <summary>
    /// Property that indicates the type of value defined for this column. Values this property can return are kIntegerType, kDoubleType, kStringType, and kBooleanType.
    /// </summary>
    ValueTypeEnum DataType { get; }
    /// <summary>
    /// Gets/Sets the expression to use to automatically populate the rows of this column.
    /// </summary>
    object Expression { get; set; }
    /// <summary>
    /// Property that indicates if this column is mapped to an iProperty.
    /// </summary>
    bool HasPropertyMap { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsInvProperty { get; }
    /// <summary>
    /// Property that gets and sets the name of this column.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the ContentFamily object this column is associated with.
    /// </summary>
    ContentFamily Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write Property that allows you to get and set the units of the column.
    /// </summary>
    object Units { get; set; }
    /// <summary>
    /// Read-write Property that allows you to get and set the KeyWeight of the column.
    /// </summary>
    int KeyColumnOrder { get; set; }
    /// <summary>
    /// Read-only property that returns True if the column is a custom column.
    /// </summary>
    bool IsCustom { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertySetId">PropertySetId</param>
    /// <param name="PropertyIdentifier">PropertyIdentifier</param>
    [PreserveSig]
    void GetPropertyMap([Out] [MarshalAs(UnmanagedType.BStr)] out string PropertySetId, [Out] [MarshalAs(UnmanagedType.BStr)] out string PropertyIdentifier);
    /// <summary>
    /// Method that sets the information associated with a custom expression.
    /// </summary>
    /// <param name="PropertySetId">Input String that specifies the name of the property set that contains the property. This is the InternalName or Name associated with the property set.</param>
    /// <param name="PropertyIdentifier">Input Variant that identifies a property. This can be a Long value that specifies the PropId of a property within the specified property set or the name of a property.</param>
    [PreserveSig]
    void SetPropertyMap([In] [MarshalAs(UnmanagedType.BStr)] string PropertySetId, [In] [MarshalAs(UnmanagedType.Struct)] object PropertyIdentifier);
    /// <summary>
    /// Method that removes any property mapping for this column.
    /// </summary>
    [PreserveSig]
    void ClearPropertyMap();
}
