namespace Oblikovati.API;

/// <summary>
/// The FaceShellDefinitions object represents a collection of FaceShellDefinition objects.
/// </summary>
public interface FaceShellDefinitions : IEnumerable
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
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    FaceShellDefinition this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new FaceShellDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FaceShellDefinition Add();
}
