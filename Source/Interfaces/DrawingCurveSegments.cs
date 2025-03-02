namespace Oblikovati.API;

/// <summary>
/// The DrawingCurveSegments object provides access to the segments of a drawing curve.
/// </summary>
public interface DrawingCurveSegments : IEnumerable
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
    /// Method that returns the specified DrawingCurveSegment object from the collection. This is the default property of the DrawingCurveSegments collection object.
    /// </summary>
    DrawingCurveSegment this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
