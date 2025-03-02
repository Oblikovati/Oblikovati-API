namespace Oblikovati.API;

/// <summary>
/// The HoleTableRow object defines a row within the hole table, including the row height.
/// </summary>
public interface HoleTableRow : IEnumerable
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
    /// Property that returns the parent HoleTable.
    /// </summary>
    HoleTable Parent { get; }
    /// <summary>
    /// Returns the specified Cell object from the collection.
    /// </summary>
    HoleTableCell Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets/Sets the height of the HoleTable row.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Property that returns the hole tag associated with this hole in the table.
    /// </summary>
    HoleTag HoleTag { get; }
    /// <summary>
    /// Property that returns the hole associated with this row.
    /// </summary>
    object ReferencedHole { get; }
    /// <summary>
    /// Method that deletes the HoleTableRow and the associated hole tag.
    /// </summary>
    [PreserveSig]
    void Delete();
}
