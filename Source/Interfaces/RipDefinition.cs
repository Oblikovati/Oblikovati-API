namespace Oblikovati.API;

/// <summary>
/// The RipDefinition object represents all of the information that defines a rip feature. The RipDefinition object is used in two ways. First it is used as input when creating a rip feature. Second it is used to query and edit existing rip features.
/// </summary>
public interface RipDefinition
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
    /// Property that returns the parent rip definition feature.
    /// </summary>
    RipFeature Parent { get; }
    /// <summary>
    /// Gets and sets the face that the rip is defined along.
    /// </summary>
    Face RipFace { get; set; }
    /// <summary>
    /// Property that returns the method used to define the type of rip. The valid values for this property are kSinglePointRipType, kPointToPointRipType, and kFaceExtentsRipType.
    /// </summary>
    RipTypeEnum RipType { get; }
    /// <summary>
    /// Property that returns the RipTypeDefinition object that defines the type of rip.
    /// </summary>
    object RipTypeDefinition { get; }
    /// <summary>
    /// Method that sets the RipDefinition so that it defines a single point rip.
    /// </summary>
    /// <param name="RipFace">The face that the rip is defined along. This must be a face this is valid for defining a rip extent. For example a face along the edge of the part where the thickness of the part is represented is not valid as input.</param>
    /// <param name="Point">The point that defines the location of the rip. Valid input includes Vertex, WorkPoint, SketchPoint, and SketchPoint3D objects.</param>
    /// <param name="GapSize">Variant that defines the width of the gap. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="GapSide">Input PartFeatureExtentDirectionEnum value to indicate the position of the gap. Valid values are kPositiveExtentDirection, kNegativeExtentDirection, and kSymmetricExtentDirection. kPositiveExtentDirection indicates that the material will be removed from the right from the perspective of the rip point where 'up' is along the normal of the rip face and you're looking towards the other edge of the face where the rip will end.</param>
    [PreserveSig]
    void SetSinglePointRipType([In] [MarshalAs(UnmanagedType.Interface)] Face RipFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] [MarshalAs(UnmanagedType.Struct)] object GapSize, [In] PartFeatureExtentDirectionEnum GapSide);
    /// <summary>
    /// Method that sets the RipDefinition so that it defines a point to point rip.
    /// </summary>
    /// <param name="RipFace">The face that the rip is defined along. This must be a face this is valid for defining a rip extent. For example a face along the edge of the part where the thickness of the part is represented is not valid as input.</param>
    /// <param name="PointOne">Point that defines the location of the first rip point. Valid input includes Vertex, WorkPoint, SketchPoint, and SketchPoint3D objects.</param>
    /// <param name="PointTwo">Point that defines the location of the second rip point. Valid input includes Vertex, WorkPoint, SketchPoint, and SketchPoint3D objects.</param>
    /// <param name="GapSize">Variant that defines the width of the gap. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="GapSide">Input PartFeatureExtentDirectionEnum value to indicate the position of the gap. Valid values are kPositiveExtentDirection, kNegativeExtentDirection, and kSymmetricExtentDirection. kPositiveExtentDirection indicates that the material will be removed from the right from the perspective of the first rip point where 'up' is along the normal of the rip face and you're looking towards the second rip point.</param>
    [PreserveSig]
    void SetPointToPointRipType([In] [MarshalAs(UnmanagedType.Interface)] Face RipFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object PointOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object PointTwo, [In] [MarshalAs(UnmanagedType.Struct)] object GapSize, [In] PartFeatureExtentDirectionEnum GapSide);
    /// <summary>
    /// Method that sets the RipDefinition so that it defines a rip that uses the entire rip face to determine the extent of the rip.
    /// </summary>
    /// <param name="RipFace">The face that defines the extent of the rip. This must be a face this is valid for defining a rip extent. For example a face along the edge of the part where the thickness of the part is represented is not valid as input.</param>
    [PreserveSig]
    void SetFaceExtentsRipType([In] [MarshalAs(UnmanagedType.Interface)] Face RipFace);
    /// <summary>
    /// Method that creates a copy of this RipDefinition object. The new RipDefinition object is independent of any feature. It can be edited and used as input to edit an existing feature or to create a new rip feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RipDefinition Copy();
}
