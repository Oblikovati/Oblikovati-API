namespace Oblikovati.API;

/// <summary>
/// The iFeatureTableRow object represents a single row of a table associated with a table driven iFeature.
/// </summary>
public interface iFeatureTableRow : IEnumerable
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
    /// Method that returns the specified iFeatureTableCell object from the row.
    /// </summary>
    iFeatureTableCell Item { get; }
    /// <summary>
    /// Property that specifies the number of columns in the row.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the name that identifies this row.
    /// </summary>
    string MemberName { get; }
    /// <summary>
    /// Property that returns the index of this row within the iFeatureTableRows collection where the first row has an index of 1.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Method that deletes the row from the table.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a new row with all cell values equal to the original row with the exception of columns whose values must be unique for each row. These are automatically modified to be unique using the same behavior that you see when inserting a new row in the user-interface.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    iFeatureTableRow Copy();
}
