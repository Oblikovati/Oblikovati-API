namespace Oblikovati.API;

/// <summary>
/// The GrillFeatures collection object provides access to existing grill features.
/// </summary>
public interface GrillFeatures : IEnumerable
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
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    GrillFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
