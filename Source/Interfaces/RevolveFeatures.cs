namespace Oblikovati.API;

/// <summary>
/// The RevolveFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional RevolveFeatures.
/// </summary>
public interface RevolveFeatures : IEnumerable
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
    /// Returns the specified RevolveFeature object from the collection.
    /// </summary>
    RevolveFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="AxisEntity">AxisEntity</param>
    /// <param name="Operation">Operation</param>
    [PreserveSig]
    RevolveFeature _AddFull([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine AxisEntity, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="AxisEntity">AxisEntity</param>
    /// <param name="Angle">Angle</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Operation">Operation</param>
    [PreserveSig]
    RevolveFeature _AddByAngle([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine AxisEntity, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates a new RevolveFeature that is a full 360-degree sweep. The new RevolveFeature is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object used to define the shape of the revolution. If the AsSolid argument is True, then the input profile must have closed paths. Open paths are valid when creating surfaces.</param>
    /// <param name="AxisEntity">Input linear entity that defines the axis of the revolution. This must be a sketch line in the same sketch that was used to generate the profile.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, or kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    RevolveFeature AddFull([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates a new RevolveFeature that sweeps a specified angle. The new RevolveFeature is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object used to define the shape of the revolution. If the AsSolid argument is True, then the input profile must have closed paths. Open paths are valid when creating surfaces.</param>
    /// <param name="AxisEntity">Input linear entity that defines the axis of the revolution. This can either be a sketch line in the same sketch that was used to generate the profile or a WorkAxis object.</param>
    /// <param name="Angle">Input Variant that defines the sweep angle of the revolution. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive, kNegative, or kSymmetric. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, or kSurfaceOperation</param>
    /// <returns></returns>
    [PreserveSig]
    RevolveFeature AddByAngle([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates a new RevolveFeature using 'from and to face' extents. The new RevolveFeature is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object used to define the shape of the revolution. If the Operation argument is anything except kSurfaceOperation, then the input profile must have closed paths. Open paths are valid when creating surfaces.</param>
    /// <param name="AxisEntity">Input linear entity that defines the axis of the revolution. This can either be a sketch line in the same sketch that was used to generate the profile or a WorkAxis object.</param>
    /// <param name="FromFace">Input Object that defines the 'from face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendFromFace">Input Boolean that defines whether the 'from face' should be extended to contain the extents of the profile.</param>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="MinimumSolution">Input Boolean that defines whether the feature terminates on the nearest valid face when there are multiple options for valid termination faces.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    RevolveFeature AddByFromToExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool MinimumSolution, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates a new RevolveFeature using 'to face' extents. The new RevolveFeature is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object used to define the shape of the revolution. If the Operation argument is anything except kSurfaceOperation, then the input profile must have closed paths. Open paths are valid when creating surfaces.</param>
    /// <param name="AxisEntity">Input linear entity that defines the axis of the revolution. This can either be a sketch line in the same sketch that was used to generate the profile or a WorkAxis object.</param>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection, kNegativeExtentDirection or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="MinimumSolution">Input Boolean that defines whether the feature terminates on the nearest valid face when there are multiple options for valid termination faces.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    RevolveFeature AddByToFaceExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool MinimumSolution, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates a new RevolveFeature using 'to next' extents. The new RevolveFeature is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object used to define the shape of the revolution. If the Operation argument is anything except kSurfaceOperation, then the input profile must have closed paths. Open paths are valid when creating surfaces.</param>
    /// <param name="AxisEntity">Input linear entity that defines the axis of the revolution. This can either be a sketch line in the same sketch that was used to generate the profile or a WorkAxis object.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="Terminator">Input SurfaceBody object that specifies the solid or the surface on which to terminate the revolution.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    RevolveFeature AddByToNextExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Terminator, [In] PartFeatureOperationEnum Operation);
}
