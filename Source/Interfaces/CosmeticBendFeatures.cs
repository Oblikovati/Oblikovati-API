namespace Oblikovati.API;

/// <summary>
/// The CosmeticBendFeatures collection object provides access to the CosmeticBendFeature objects that have been created within a flat pattern.
/// </summary>
public interface CosmeticBendFeatures : IEnumerable
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
    /// Returns the specified CosmeticBendFeature object from the collection.
    /// </summary>
    CosmeticBendFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of LoftedFlangeFeature objects in the collection.
    /// </summary>
    int Count { get; }
}
