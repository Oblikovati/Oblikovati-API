namespace Oblikovati.API;

/// <summary>
/// The ReplaceFaceFeatures collection object represents a collection of objects.
/// </summary>
public interface ReplaceFaceFeatures : IEnumerable
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
    /// Method that returns the specified ReplaceFaceFeature object from the collection.
    /// </summary>
    ReplaceFaceFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ReplaceFaceFeature. The newly created ReplaceFaceFeature is returned.
    /// </summary>
    /// <param name="Definition">Input ReplaceFaceDefinition object created using the CreateDefinition method.</param>
    /// <returns></returns>
    [PreserveSig]
    ReplaceFaceFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ReplaceFaceDefinition Definition);
    /// <summary>
    /// Method that creates a ReplaceFaceDefinition.
    /// </summary>
    /// <param name="ExistingFaces">Input FaceCollection object that specifies the faces that will be replaced. The faces must be part of a solid SurfaceBody and must all belong to the same SurfaceBody.
    /// All faces to be replaced need to be specified. All of the input faces must belong to the same SurfaceBody. The TangentiallyConnectedFaces method of the Face object can be useful in finding the set of faces.</param>
    /// <param name="NewFaces">Input ObjectCollection object that specifies the new faces.  The new faces can be work planes or Face objects, the Face objects can be from multiple SurfaceBody objects</param>
    /// <returns></returns>
    [PreserveSig]
    ReplaceFaceDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection ExistingFaces, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection NewFaces);
}
