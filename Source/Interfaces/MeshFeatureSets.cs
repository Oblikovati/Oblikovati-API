namespace Oblikovati.API;

/// <summary>
/// MeshFeatureSets Object.
/// </summary>
public interface MeshFeatureSets : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    MeshFeatureSet Item { get; }
    /// <summary>
    /// Method that creates a new MeshFeatureSet object. The newly created MeshFeatureSet object is returned.
    /// </summary>
    /// <param name="FullName">Input String value that specifies the full filename of a file which is being imported. Valid file types include STL, Obj, Catia V4, Catia V5, JT, STEP, NX, Alias and  Rhino files.</param>
    /// <returns></returns>
    [PreserveSig]
    MeshFeatureSet Add([In] [MarshalAs(UnmanagedType.BStr)] string FullName);
}
