namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMRow object represents a row within the drawing BOM.
/// </summary>
public interface DrawingBOMRow : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the corresponding BOMRow from the model.
    /// </summary>
    BOMRow BOMRow { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns whether the item represented by this row in the drawing BOM has been ballooned in the drawing.
    /// </summary>
    bool Ballooned { get; }
    /// <summary>
    /// Property that returns whether this row is a custom row.
    /// </summary>
    bool Custom { get; }
    /// <summary>
    /// Property that returns whether this row references a virtual component in the assembly.
    /// </summary>
    bool Virtual { get; }
    /// <summary>
    /// </summary>
    DrawingBOMCell this[object Index] { get; }
    /// <summary>
    /// Property that returns the parent DrawingBOM object.
    /// </summary>
    DrawingBOM Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
