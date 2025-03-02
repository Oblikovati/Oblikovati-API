namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrameStylesEnumerator object provides access to the existing FeatureControlFrameStyle objects.
/// </summary>
public interface FeatureControlFrameStylesEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified FeatureControlFrameStyle object from the collection.
    /// </summary>
    FeatureControlFrameStyle Item { get; }
}
