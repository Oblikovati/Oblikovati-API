namespace Oblikovati.API;

/// <summary>
/// ExtrudeDefinition Object.
/// </summary>
public interface ExtrudeDefinition
{
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the collection of occurrences that should participate in this feature.&nbsp;If this property is not set, all possible occurrences will participate.&nbsp;This property applies only to features in an assembly.
    /// </summary>
    ObjectCollection AffectedOccurrences { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the PartFeatureExtent object that defines how the extent of the feature is defined.&nbsp;The type of extent object returne.
    /// </summary>
    PartFeatureExtent Extent { get; }
    /// <summary>
    /// Read-only property that returns the PartFeatureExtent object that defines how the second direction extent of the feature is defined.&nbsp;The type of exte.
    /// </summary>
    PartFeatureExtent ExtentTwo { get; }
    /// <summary>
    /// Read-only property that returns an enum indicating how the extent of the feature is defined.&nbsp;This indicates the type of object returned by the Extent.
    /// </summary>
    PartFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Read-only property that returns an enum indicating how the second direction extent of the feature is defined.&nbsp;This indicates the type of object retur.
    /// </summary>
    PartFeatureExtentEnum ExtentTwoType { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to automatically place iMates on full circular edges.&nbsp;If set to True, Inventor places the iMates on cl.
    /// </summary>
    bool InferiMates { get; set; }
    /// <summary>
    /// Read-only property that returns whether extents have been defined in two directions for the extrude.&nbsp;If this property returns True, the ExtentTwoType.
    /// </summary>
    bool IsTwoDirectional { get; }
    /// <summary>
    /// Read-write property that gets and sets how open profiles are handled.
    /// </summary>
    bool MatchShape { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.&nbsp;Valid inputs are kNewBodyOperation, kJoinOperation, kCutOperation, kIntersectOperation and kSurfaceOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ExtrudeFeature Parent { get; }
    /// <summary>
    /// Read-write property gets and sets the sketch profile used for the extrude feature.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Read-write property that provides access to the taper angle of an extrude feature.&nbsp;If not supplied, the feature will be created with a taper angle of.
    /// </summary>
    object TaperAngle { get; set; }
    /// <summary>
    /// Read-write property that provides access to the second direction taper angle of an asymmetric extrude feature. This property is not applicable and ret.
    /// </summary>
    object TaperAngleTwo { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a copy of this ExtrudeDefinition object.&nbsp;The new ExtrudeDefinition object is independent of any feature.&nbsp;It can edited and used as input to edit an existing feature or to create a new Extrude feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ExtrudeDefinition Copy();
    /// <summary>
    /// Method that changes the extents to be “distance” extents.&nbsp;If this method is called on an asymmetric extrude, the second direction extent is removed.&nbsp;To change extent values, use the properties on the object returned by the Extent property.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the length of the extrusion.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards.  Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection.  kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetDistanceExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that sets the second direction extent to be “distance” extents.&nbsp;This method returns an error if the first extent type is not distance extent.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the length of the extrusion in the other direction for an asymmetric extrude.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetDistanceExtentTwo([In] [MarshalAs(UnmanagedType.Struct)] object Distance);
    /// <summary>
    /// Method that changes the extents to be “from and to face” extents.
    /// </summary>
    /// <param name="FromFace">Input Object that defines the “from face”.  This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendFromFace">Input Boolean that defines whether the “from face” should be extended to contain the extents of the profile.</param>
    /// <param name="ToFace">Input Object that defines the “to face”.  This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the “to face” should be extended to contain the extents of the profile.</param>
    [PreserveSig]
    void SetFromToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace);
    /// <summary>
    /// Method that changes the extents to be “through all” extents.
    /// </summary>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards.  Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection.  kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetThroughAllExtent([In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that changes the extents to be “to entity” extents.
    /// </summary>
    /// <param name="ToEntity">Input Object that defines the “to entity”.
    /// This can be one of the following types:
    /// Planar entity: Face or WorkPlane object.
    /// Point entity: Vertex, SketchPoint, SketchPoint3D, WorkPoint or Edge object.
    /// If an Edge object is specified, only its mid-point will be used as input. If other points (e.g. start point or end point) of the edge need to be used as input, they have to be specified using the corresponding Vertex object.</param>
    /// <param name="ExtendToFace">Optional Input Boolean that defines whether the plane defined by the “to entity” should be extended to contain the extents of the profile.
    /// This argument is applicable only if the ToEntity argument is a Face. If no value is explicitly specified, a default value of False will be assumed.
    /// If the ToEntity argument is not a Face, this argument will be ignored.</param>
    [PreserveSig]
    void SetToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity, [In] bool? ExtendToFace = false);
    /// <summary>
    /// Method that changes the extents to be “to next face” extents.
    /// </summary>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards.  Valid input is kPositiveExtentDirection or kNegativeExtentDirection.  kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="Terminator">Input SurfaceBody object that specifies the solid or the surface on which to terminate the extrude.</param>
    [PreserveSig]
    void SetToNextExtent([In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Terminator);
    /// <summary>
    /// Method that changes the extents to be “Distance From Face” extents.
    /// </summary>
    /// <param name="FromFace">Input object that indicates from which to do the offset extrusion. This can be a Face or WorkPlane object.</param>
    /// <param name="ExtendFromFace">Input Boolean that defines whether the “from face” should be extended to contain the extents of the profile.</param>
    /// <param name="ExtentDirection">Input PartFeatureExtentDirectionEnum that defines the distance direction of the feature.  Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="Distance">Input Variant that defines the length of the extrusion.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="IsTwoDirectional">Optional input Boolean that indicates if the extents have been defined in two directions for the extrusion. This is ignored if the ExtentDirection is set to kSymmetricExtentDirection. This defaults to False if not specified.</param>
    /// <param name="DistanceTwo">Optional input Variant that defines the length of the extrusion in the other direction for an asymmetric extrude. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is ignored if the IsTwoDirectional is set to False, otherwise this is required to specify the distance for the extrusion in the other direction for an asymmetric extrude.</param>
    [PreserveSig]
    void SetDistanceFromFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object? IsTwoDirectional = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DistanceTwo = default);
}
