namespace Oblikovati.API;

/// <summary>
/// The BoundaryPatchLoop object is used to define a boundary loop for a boundary patch feature.
/// </summary>
public interface BoundaryPatchLoop
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that gets and sets the boundary path for a boundary patch loop.
    /// </summary>
    object BoundaryPath { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that gets the boundary condition for the specified boundary path loop entity.
    /// </summary>
    /// <param name="BoundaryPathEntity">Input object that specifies the boundary path loop entity for which the boundary condition needs to be returned. If a boundary condition is not applicable to the boundary path entity, then this method will fail. The valid objects for the boundary path entity depend on the type of the boundary path object, i.e. the object returned by the BoundaryPath property. The following list shows the valid BoundaryPathEntity objects for the corresponding BoundaryPath object: * If BoundaryPath object is Profile3D, then the BoundaryPathEntity object can be one of the sketch 3D entities that constitute the Profile3D. * If BoundaryPath object is Path, then the BoundaryPathEntity object can be one of the sketch 2D or 3D entities that constitute the Path. * If BoundaryPath object is EdgeLoop, then the BoundaryPathEntity object can be one of the edges that constitute the EdgeLoop. * If BoundaryPath object is EdgeCollection, then the BoundaryPathEntity object can be one of the edges that belong to the EdgeCollection. * If BoundaryPath object is an ObjectCollection that contains SketchEntity, SketchEntity3D or Edge objects, then the BoundaryPathEntity object can be one of the entities that belong to the ObjectCollection.</param>
    /// <returns></returns>
    [PreserveSig]
    BoundaryPatchConditionEnum GetBoundaryCondition([In] [MarshalAs(UnmanagedType.IDispatch)] object BoundaryPathEntity);
    /// <summary>
    /// Method that sets the boundary condition for the specified boundary path loop entity.
    /// </summary>
    /// <param name="BoundaryPathEntity">Input object that specifies the boundary path loop entity to which the boundary condition needs to be applied. If a boundary condition is not applicable to the boundary path entity, then this method will fail. The valid objects for the boundary path entity depend on the type of the boundary path object, i.e. the object returned by the BoundaryPath property. The following table lists the valid BoundaryPathEntity objects for the corresponding BoundaryPath object:
    /// If BoundaryPath object is: Then, the BoundaryPathEntity object can be:
    /// Profile3D One of the sketch 3D entities that constitute the Profile3D
    /// Path One of the sketch 2D or 3D entities that constitute the Path
    /// EdgeLoop One of the edges that constitute the EdgeLoop
    /// EdgeCollection One of the edges that belong to the EdgeCollection
    /// ObjectCollection that contains SketchEntity, SketchEntity3D or Edge objects One of the entities that belong to the ObjectCollectionNote: If the boundary path object, i.e. the object returned by the BoundaryPath property is a Profile then the boundary condition does not apply. If the Profile object or one of the sketch 2D entities that constitute the profile is specified for the BoundaryPathEntity argument then, this method will fail.</param>
    /// <param name="BoundaryPathCondition">Input constant that specifies the type of boundary condition to apply. Valid input is one of the values in BoundaryPatchConditionEnum: kFreeBoundaryPatchCondition or kTangentBoundaryPatchCondition. If the specified condition cannot be applied to the boundary path entity, then this method will fail.</param>
    [PreserveSig]
    void SetBoundaryCondition([In] [MarshalAs(UnmanagedType.IDispatch)] object BoundaryPathEntity, [In] BoundaryPatchConditionEnum BoundaryPathCondition);
    /// <summary>
    /// Method that deletes this boundary patch loop.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that gets the tangent weight for the specified boundary path loop entity.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    object GetBoundaryTangentWeight([In] [MarshalAs(UnmanagedType.IDispatch)] object BoundaryPathEntity);
    /// <summary>
    /// Method that sets the tangetn weight for the specified boundary path loop entity.
    /// </summary>
    [PreserveSig]
    void SetBoundaryTangentWeight([In] [MarshalAs(UnmanagedType.IDispatch)] object BoundaryPathEntity, [In] [MarshalAs(UnmanagedType.Struct)] object BoundaryPathTangentWeight);
}
