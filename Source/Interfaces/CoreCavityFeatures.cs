namespace Oblikovati.API;

/// <summary>
/// This CoreCavityFeatures collection provides access to existing CoreCavityFeature objects. It's also through the CoreCavityFeatures object that you create new CoreCavityFeature objects.
/// </summary>
public interface CoreCavityFeatures : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns specified CoreCavityFeature object from the collection.
    /// </summary>
    CoreCavityFeature this[object Index] { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new CoreCavityFeature object. The newly created CoreCavityFeature object is returned.
    /// </summary>
    /// <param name="Definition">Input CoreCavityDefinition object that defines the core-cavity feature you want to create.
    /// A CoreCavityDefinition object can be created using the CreateCoreCavityDefinition method on the CoreCavityFeatures object.</param>
    /// <returns></returns>
    [PreserveSig]
    CoreCavityFeature Add([In] [MarshalAs(UnmanagedType.Interface)] CoreCavityDefinition Definition);
    /// <summary>
    /// Method that creates a new CoreCavityDefinition object. This object is not a core-cavity feature but contains the information that defines a core-cavity feature and can be used to create a new core-cavity feature. Properties on the returned CoreCavityDefinition object can be used to define additional inputs for the core-cavity feature.
    /// </summary>
    /// <param name="PartBody">solid SurfaceBody object used to define the geometry of the part. This body represents the part that is being molded.</param>
    /// <param name="WorkpieceBody">Input solid SurfaceBody object used to define the work piece used for a CoreCavityFeature object. The work piece is a solid that represents the shape of the mold base and will be split into the core and cavity pieces.</param>
    /// <param name="RunoffSurfaces">Input ObjectCollection of SurfaceBody objects that define the run off surfaces. The ObjectCollection must contain at least one surface body.</param>
    /// <param name="PullDirection">Input UnitVector that defines the pull direction. The portion generated on the positive direction side is the cavity, the other is the core.</param>
    /// <returns></returns>
    [PreserveSig]
    CoreCavityDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody PartBody, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody WorkpieceBody, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RunoffSurfaces, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector PullDirection);
}
