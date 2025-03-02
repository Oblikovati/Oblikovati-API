namespace Oblikovati.API;

/// <summary>
/// The SculptFeatures collection object provides access to all of the SculptFeature objects in a part component definition and provides methods to create additional SculptFeatures.
/// </summary>
public interface SculptFeatures : IEnumerable
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
    /// Method that returns the specified SculptFeature object from the collection.
    /// </summary>
    SculptFeature this[object Index] { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Surfaces">Surfaces</param>
    /// <param name="FillOperation">FillOperation</param>
    [PreserveSig]
    SculptFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Surfaces, [In] bool FillOperation);
    /// <summary>
    /// Method that creates a new SculptSurface object. The new SculptSurface is returned.
    /// </summary>
    /// <param name="Surface">Object that defines a boundary surface for the sculpt feature. Valid input objects for the surface are WorkSurface and WorkPlane.</param>
    /// <param name="Direction">Optional input constant that specifies the sculpt direction for the surface specified by the Surface argument. The direction specifies the side of the surface that should be used when creating the sculpt feature. Valid input is kPositiveExtentDirection, kNegativeExtentDirection or kSymmetricExtentDirection. If no value is specified, then kPositiveExtentDirection will be assumed for the direction.</param>
    /// <returns></returns>
    [PreserveSig]
    SculptSurface CreateSculptSurface([In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] PartFeatureExtentDirectionEnum? Direction = PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
    /// <summary>
    /// Method that creates a new SculptFeature. If the sculpt feature is created successfully, a SculptFeature object corresponding to the newly created sculpt feature is returned from this method.
    /// </summary>
    /// <param name="Surfaces">ObjectCollection that contains SculptSurface objects that represent the set of surfaces and the corresponding directions that are required to create the sculpt feature. The CreateSculptSurface method should be used to create each of the SculptSurface objects which should then be added to an ObjectCollection. The ObjectCollection that contains these SculptSurface objects can be created using the CreateObjectCollection method of the TransientObjects object. The ObjectCollection should contain only SculptSurface objects, if the collection contains other types of objects, then the creation of the sculpt feature will fail.</param>
    /// <param name="Operation">Input PartFeatureOperationEnum that specifies the operation type (kJoinOperation, kCutOperation and kNewBodyOperation).
    /// If kJoinOperation is specified, then the fill operation will be performed to add material. If kCutOperation is specified, then the drain operation will be performed to remove material.  If kCutOperation is specified, then the part model should contain solid material that can be removed. Specifying kNewBodyOperation will result in creation of a new body.</param>
    /// <param name="AffectedBody">Optional input SurfaceBody object that specifies the body that should be affected by this sculpt operation.  Applies only if kJoinOperation or kCutOperation is specified as the operation type.  If not specified, a default body is used.</param>
    /// <returns></returns>
    [PreserveSig]
    SculptFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Surfaces, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? AffectedBody = default);
}
