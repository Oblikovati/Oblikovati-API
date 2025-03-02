namespace Oblikovati.API;

/// <summary>
/// The BoundaryPatchFeatures collection object provides access to all of the objects in a part component definition and provides methods to create additional BoundaryPatchFeatures.
/// </summary>
public interface BoundaryPatchFeatures : IEnumerable
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
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    BoundaryPatchFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new boundary patch feature.
    /// </summary>
    /// <param name="Definition">Input BoundaryPatchDefinition object that defines the input definition for the boundary patch feature. The BoundaryPatchDefinition object can be created using the CreateBoundaryPatchDefinition method of the BoundaryPatchFeatures object. The BoundaryPatchDefinition object defines the boundary loops for creating the boundary patch feature.</param>
    /// <returns></returns>
    [PreserveSig]
    BoundaryPatchFeature Add([In] [MarshalAs(UnmanagedType.Interface)] BoundaryPatchDefinition Definition);
    /// <summary>
    /// Method that creates a BoundaryPatchDefinition object that defines the input definition for a boundary patch feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BoundaryPatchDefinition CreateBoundaryPatchDefinition();
}
