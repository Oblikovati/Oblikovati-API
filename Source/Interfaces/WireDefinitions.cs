namespace Oblikovati.API;

/// <summary>
/// Represents a set of definitions of 3D wireframe geometry that will be used to create an Wire object.
/// </summary>
public interface WireDefinitions : IEnumerable
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
    /// Returns the specified WireDefinition object from the collection
    /// </summary>
    WireDefinition this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Creates a new WireDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    WireDefinition Add();
}
