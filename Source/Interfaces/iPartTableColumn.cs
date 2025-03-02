namespace Oblikovati.API;

/// <summary>
/// The iPartTableColumn object represents a column in the iPart factory table.
/// </summary>
public interface iPartTableColumn : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iPartTableCell object from the collection. This is the default property of the iPartTableColumn object.
    /// </summary>
    iPartTableCell this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent iPartFactory object.
    /// </summary>
    iPartFactory Parent { get; }
    /// <summary>
    /// Property that returns the heading of the column.
    /// </summary>
    string Heading { get; }
    /// <summary>
    /// Property that returns the localized heading of the column.
    /// </summary>
    string DisplayHeading { get; }
    /// <summary>
    /// Property that returns the heading of the column in XML format.
    /// </summary>
    string FormattedHeading { get; }
    /// <summary>
    /// Property that returns the index of this column within the iPart factory table.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets and sets whether this is a custom parameter column.
    /// </summary>
    bool CustomColumn { get; set; }
    /// <summary>
    /// Gets and sets the increment value for custom parameter columns.
    /// </summary>
    string CustomIncrement { get; set; }
    /// <summary>
    /// Gets and sets the maximum value for a custom parameter.
    /// </summary>
    string CustomRangeMaximum { get; set; }
    /// <summary>
    /// Gets and sets the minimum value for a custom parameter.
    /// </summary>
    string CustomRangeMinimum { get; set; }
    /// <summary>
    /// Gets and sets the key order for the column.
    /// </summary>
    int Key { get; set; }
    /// <summary>
    /// Property that returns the data type contained in the column.
    /// </summary>
    iComponentColumnTypeEnum ReferencedDataType { get; }
    /// <summary>
    /// Property that returns the object referenced by the column. For instance, if the column references a fillet feature suppression, the corresponding FilletFeature object is returned. Similarly, if a file property is referenced, the corresponding Property object is returned.
    /// </summary>
    object ReferencedObject { get; }
    /// <summary>
    /// Method that deletes this column in the factory. The "Member" and "Part Number" columns cannot be deleted.
    /// </summary>
    [PreserveSig]
    void Delete();
}
