namespace Oblikovati.API;

/// <summary>
/// The iFeatureTableColumn object represents a single column of a table associated with a table driven iFeature.
/// </summary>
public interface iFeatureTableColumn : IEnumerable
{
    /// <summary>
    /// Property that returns the parent iFeatureTable.
    /// </summary>
    iFeatureTable Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that specifies the number of rows in the column.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified iFeatureTableCell object from the row.
    /// </summary>
    iFeatureTableCell this[object Index] { get; }
    /// <summary>
    /// Property that returns the heading of the column as seen in the iFeature author command.
    /// </summary>
    string DisplayHeading { get; }
    /// <summary>
    /// Property that returns the heading of the column in XML format.
    /// </summary>
    string FormattedHeading { get; }
    /// <summary>
    /// Property that returns the heading of the column in XML format.
    /// </summary>
    string Heading { get; }
    /// <summary>
    /// Property that returns the index of this column within the iFeatureTableColumns collection where the first column has an index of 1.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Read-write property that gets and sets the key order for the column.
    /// </summary>
    int Key { get; set; }
    /// <summary>
    /// Gets and sets whether this is a custom parameter column.
    /// </summary>
    bool CustomColumn { get; set; }
    /// <summary>
    /// Gets and sets the increment value for custom parameter column.
    /// </summary>
    string CustomIncrement { get; set; }
    /// <summary>
    /// Gets and sets the maximum value for a custom parameter column.
    /// </summary>
    string CustomRangeMaximum { get; set; }
    /// <summary>
    /// Gets and sets the minimum value for a custom parameter column.
    /// </summary>
    string CustomRangeMinimum { get; set; }
    /// <summary>
    /// Method that deletes the column from the table.
    /// </summary>
    [PreserveSig]
    void Delete();
}
