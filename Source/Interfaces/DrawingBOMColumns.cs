namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMColumns collection object represents the collection of all columns of a drawing BOM.
/// </summary>
public interface DrawingBOMColumns : IEnumerable
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
    /// Returns the specified DrawingBOMColumn object from the collection.
    /// </summary>
    DrawingBOMColumn this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
