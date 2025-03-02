namespace Oblikovati.API;

/// <summary>
/// The BoundaryPatchLoops object is used to define the boundary loops for a boundary patch feature.
/// </summary>
public interface BoundaryPatchLoops : IEnumerable
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
    /// Method that returns the specified BoundaryPatchLoop object from the collection.
    /// </summary>
    BoundaryPatchLoop this[int Index] { get; }
    /// <summary>
    /// Property that specifies the number of BoundaryPatchLoop objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new BoundaryPatchLoop object using the specified boundary path.
    /// </summary>
    /// <param name="BoundaryPath">Input Object that defines the boundary path for a boundary patch loop. Valid objects for the boundary path can be one of the following types:
    /// One of the following objects: Path, Profile, Profile3D, EdgeLoop or EdgeCollection If a Path, Profile or Profile3D object is specified, then it must represent a set of connected sketch entities that form a closed loop, otherwise the creation of the boundary loop will fail. If an EdgeCollection object is specified, then it must contain a set of tangentially connected edges that form a closed loop, otherwise the creation of the boundary loop will fail.
    /// An ObjectCollection that can contain any combination of SketchEntity, SketchEntity3D and Edge objects These objects can be used to specify a set of connected entities that form a closed boundary loop. Also, the order of the objects in the collection must be such that the entities that represent them are end-to-end connected. If the entities do not form a closed loop or if their order in the collection does not represent a set of end-to-end connected entities, then the creation of the boundary loop will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    BoundaryPatchLoop Add([In] [MarshalAs(UnmanagedType.IDispatch)] object BoundaryPath);
}
