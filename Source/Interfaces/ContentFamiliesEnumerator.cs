namespace Oblikovati.API;

/// <summary>
/// Object allowing enumeration of ContentFamily objects.
/// </summary>
public interface ContentFamiliesEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of ContentFamily objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the constant that indicates the type of this object.
    /// </summary>
    ContentFamily this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
