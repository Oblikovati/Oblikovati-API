namespace Oblikovati.API;

/// <summary>
/// The HoleTableColumns collection object provides access to the existing collection of HoleTableColumn objects.
/// </summary>
public interface HoleTableColumns : IEnumerable
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
    /// Returns the specified Column object from the collection.
    /// </summary>
    HoleTableColumn Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new HoleTableColumn based on a property. The newly created HoleTableColumn is returned.
    /// </summary>
    /// <param name="PropertyType">Input HolePropertyEnum that specifies the property type to associate with the column. If kCustomHoleProperty is specified, the CustomPropertyName argument is required.</param>
    /// <param name="CustomPropertyName">Optional input String that specifies the name of the custom property to associate with the column. This argument must be specified if the PropertyType is specified to be kCustomHoleProperty, else the method returns an error.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the new column will be inserted. The valid range of values is 0 to the number of existing columns in the table. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the column will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is 0.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTableColumn Add([In] HolePropertyEnum PropertyType, [In] [MarshalAs(UnmanagedType.BStr)] string? CustomPropertyName = "", [In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
