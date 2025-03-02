namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMRows collection object represents the collection of all rows of a drawing BOM.
/// </summary>
public interface DrawingBOMRows : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DrawingBOMRow object from the collection.
    /// </summary>
    DrawingBOMRow Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
