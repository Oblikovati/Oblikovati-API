namespace Oblikovati.API;

/// <summary>
/// The iAssemblyTableColumn object represents a column in the iAssembly factory table.
/// </summary>
public interface iAssemblyTableColumn : IEnumerable
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
    /// Property that returns the parent iAssemblyFactory object.
    /// </summary>
    iAssemblyFactory Parent { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iAssemblyTableCell object from the collection.
    /// </summary>
    iAssemblyTableCell this[object Index] { get; }
    /// <summary>
    /// Property that returns the index of this column within the iAssembly factory table.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns the non-localized heading of the column.
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
    /// Read-write property that gets and sets the key order for the column.
    /// </summary>
    int Key { get; set; }
    /// <summary>
    /// Property that returns the data type contained in the column.
    /// </summary>
    iComponentColumnTypeEnum ReferencedDataType { get; }
    /// <summary>
    /// Property that returns the object referenced by the column. For instance, if the column references a fillet feature suppression, the corresponding FilletFeature object is returned. Similarly, if a file property is referenced, the corresponding Property object is returned.  The property returns Nothing if there is no corresponding object (e.g. when the ReferencedDataType returns kMemberNameColumn).
    /// </summary>
    object ReferencedObject { get; }
    /// <summary>
    /// Deletes this column in the factory.
    /// </summary>
    [PreserveSig]
    void Delete();
}
