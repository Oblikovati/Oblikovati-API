namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface LumpDefinitions : IEnumerable
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
    /// Returns the specified LumpDefinition object from the collection.
    /// </summary>
    LumpDefinition this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of LumpDefinition objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new LumpDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LumpDefinition Add();
}
