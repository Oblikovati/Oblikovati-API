namespace Oblikovati.API;

/// <summary>
/// The ModelStateTableColumn Object.
/// </summary>
public interface ModelStateTableColumn : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelStateTableCell this[object Index] { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelStateTable Parent { get; }
    /// <summary>
    /// Read - only property that returns the non - localized heading of the column.
    /// </summary>
    string Heading { get; }
    /// <summary>
    /// Read - only property that returns the localized heading of the column.
    /// </summary>
    string DisplayHeading { get; }
    /// <summary>
    /// Read - only property that returns the heading of the column in XML format.
    /// </summary>
    string FormattedHeading { get; }
    /// <summary>
    /// Gets the the index of this column within the ModelStateTableColumns collection where the first column has an index of 1.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Read - only property that returns the data type contained in the column.
    /// </summary>
    iComponentColumnTypeEnum ReferencedDataType { get; }
    /// <summary>
    /// Read - only property that returns the object referenced by the column.
    /// </summary>
    object ReferencedObject { get; }
    /// <summary>
    /// Method that deletes the ModelStateTableColumn.
    /// </summary>
    [PreserveSig]
    void Delete();
}
