namespace Oblikovati.API;

/// <summary>
/// The EdgeLoopsDefinitions collection provides access to existing EdgeLoopDefinition objects and allows creation of new EdgeLoopDefinition objects.
/// </summary>
public interface EdgeLoopDefinitions : IEnumerable
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
    EdgeLoopDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new EdgeLoopDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EdgeLoopDefinition Add();
}
