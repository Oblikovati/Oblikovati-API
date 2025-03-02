namespace Oblikovati.API;

/// <summary>
/// The ThickenFeatures collection object represents a collection of objects on a part.
/// </summary>
public interface ThickenFeatures : IEnumerable
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
    /// Returns the specified ThickenFeature object from the collection.
    /// </summary>
    ThickenFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Faces">Faces</param>
    /// <param name="Distance">Distance</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Operation">Operation</param>
    /// <param name="AutomaticFaceChain">AutomaticFaceChain</param>
    /// <param name="CreateVerticalSurfaces">CreateVerticalSurfaces</param>
    [PreserveSig]
    ThickenFeature _Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Faces, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation, [In] bool? AutomaticFaceChain = false, [In] bool? CreateVerticalSurfaces = false);
    /// <summary>
    /// Method that creates a new ThickenFeature. The new created ThickenFeature is returned.
    /// </summary>
    /// <param name="Faces">Input object that defines the faces to thicken or faces from which to create an offset surface. This can either be a WorkSurface or a FaceCollection. If multiple faces are provided, they must be connected.</param>
    /// <param name="Distance">Input Variant that defines the thickness of the Thicken feature or specifies distance for the Offset feature. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. When the output is a surface, the offset distance can be zero.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the input faces to thicken or offset towards. Valid input is kPositive, kNegative, or kSymmetric. kPositive defines the offset direction to be in the same direction as the normal of the input faces.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid \input is kJoinOperation, kCutOperation, kIntersectOperation, or kSurfaceOperation.</param>
    /// <param name="AutomaticFaceChain">Optional input Boolean that specifies whether or not to perform chaining of tangent continuous faces. The default value is False indicating that automatic chaining will not be performed.</param>
    /// <param name="CreateVerticalSurfaces">Optional input Boolean that specifies whether or not to create vertical or "side" faces connecting the offset faces to the original work surface. Vertical surfaces are created only at internal surface edges, not at boundary edges of surfaces. The default value is False.</param>
    /// <param name="AutomaticBlending">Optional input Boolean that specifies whether or not to perform automatic blending or not. The default value is False.</param>
    /// <returns></returns>
    [PreserveSig]
    ThickenFeature Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Faces, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation, [In] bool? AutomaticFaceChain = false, [In] bool? CreateVerticalSurfaces = false, [In] bool? AutomaticBlending = false);
}
