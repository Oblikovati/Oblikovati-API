namespace Oblikovati.API;

/// <summary>
/// The DrawingCurvesEnumerator object provides access to drawing view curves.
/// </summary>
public interface DrawingCurvesEnumerator : IEnumerable
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
    /// Method that returns the specified DrawingCurve object from the collection. This is the default property of the DrawingCurves collection object.
    /// </summary>
    DrawingCurve Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
