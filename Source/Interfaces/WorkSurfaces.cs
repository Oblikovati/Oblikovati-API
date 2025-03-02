namespace Oblikovati.API;

/// <summary>
/// The WorkSurfaces collection object represents all of the <link Inventor::WorkSurface, WorkSurface> objects associated with this part or component.
/// </summary>
public interface WorkSurfaces : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified WorkSurface object from the collection. This is the default property of the WorkSurfaces collection object.
    /// </summary>
    WorkSurface this[object Index] { get; }
    /// <summary>
    /// Property that returns the parent <link Inventor::ComponentDefinition, ComponentDefinition> object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
