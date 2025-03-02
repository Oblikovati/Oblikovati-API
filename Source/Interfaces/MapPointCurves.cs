namespace Oblikovati.API;

/// <summary>
/// The MapPointCurves object represents a collection of objects, used to define mapping points between sections in a loft feature.
/// </summary>
public interface MapPointCurves : IEnumerable
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
    /// Method that returns the specified MapPointCurve object from the collection.
    /// </summary>
    MapPointCurve Item { get; }
    /// <summary>
    /// Property that returns the number of MapPointCurve objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new MapPointCurve. This method is only valid for MapPointCurves objects that were created using the LoftFeatures.CreateMapCurves. A error will occur if you use this method for a MapPointCurves object obtained from an existing LoftFeature object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MapPointCurve AddMapCurve();
}
