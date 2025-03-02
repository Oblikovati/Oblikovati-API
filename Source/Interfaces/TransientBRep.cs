namespace Oblikovati.API;

/// <summary>
/// The TransientBRep object is used to create and manipulate B-Rep objects within a transient space.
/// </summary>
public interface TransientBRep
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ApplicationUtilities ApplicationUtilities { get; }
    /// <summary>
    /// Method that calculates the silhouette curve geometry for a given face as viewed from a given direction.
    /// </summary>
    /// <param name="Face">Input Face object to calculate the silhouette curve for.</param>
    /// <param name="ViewDirection">Input UnitVector that defines the view direction to calculate the silhouette curve relative to. The silhouette curve will lie on the input where the face normal is perpendicular to the view direction.</param>
    /// <param name="ReturnCoincidentSilhouettes">Input Boolean that specifies if silhouette curves that are coincident to the edges of the face should be returned or not. If True, these curves will be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSilhouetteCurve([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector ViewDirection, [In] bool ReturnCoincidentSilhouettes);
    /// <summary>
    /// Method that create a solid cylinder or cone.
    /// </summary>
    /// <param name="BottomPoint">Input Point that defines the center of the bottom of the cylinder or cone.</param>
    /// <param name="TopPoint">Input Point that defines the center of the top of the cylinder or cone.</param>
    /// <param name="BottomMajorRadius">Input Double that defines the major axis radius at the bottom of an elliptical cylinder or cone or the radius at the bottom of a circular cylinder or cone.</param>
    /// <param name="BottomMinorRadius">Input Double that define the minor axis radius at the bottom of an elliptical cylinder or cone. For a circular cylinder or cone this value should be the same at the BottomMajorRadius argument.</param>
    /// <param name="TopMajorRadius">Input Double that specifies the radius at the top of the cylinder or cone. In the case of an elliptical cylinder or cone this is the radius of the major axis.</param>
    /// <param name="MajorAxisPosition">Optional input Point that specifies the orientation of the major axis. This is only needed in the case of an elliptical cylinder or cone. If not provided the major axis is determined based on the model coordinate system.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSolidCylinderCone([In] [MarshalAs(UnmanagedType.Interface)] Point BottomPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point TopPoint, [In] double BottomMajorRadius, [In] double BottomMinorRadius, [In] double TopMajorRadius, [In] [MarshalAs(UnmanagedType.Struct)] object? MajorAxisPosition = default);
    /// <summary>
    /// Method that create a solid sphere.
    /// </summary>
    /// <param name="Center">Input Point that defines the center of the sphere.</param>
    /// <param name="Radius">Input Point Double that defines the radius of the sphere in centimeters</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSolidSphere([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] double Radius);
    /// <summary>
    /// Method that creates a solid torus.
    /// </summary>
    /// <param name="Center">Input Point that defines the center of the torus.</param>
    /// <param name="MajorRadius">Input Double that defines the major radius of the torus in centimeters.</param>
    /// <param name="MinorRadius">Input Double that defines the minor radius of the torus in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSolidTorus([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] double MajorRadius, [In] double MinorRadius);
    /// <summary>
    /// Method that creates a solid box.
    /// </summary>
    /// <param name="Box">Input Box object that defines the size of the solid block.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSolidBlock([In] [MarshalAs(UnmanagedType.Interface)] Box Box);
    /// <summary>
    /// Method that performs the specified Boolean operation between the blank and tool bodies.
    /// </summary>
    /// <param name="BlankBody">Input/Output SurfaceBody that will be modified as a result.</param>
    /// <param name="ToolBody">Input SurfaceBody that is used to operate on the blank body.</param>
    /// <param name="BooleanType">Input BooleanTypeEnum that specifies the type of Boolean operation to perform. Valid values are kBooleanTypeDifference, kBooleanTypeUnion, and kBooleanTypeIntersect.</param>
    [PreserveSig]
    void DoBoolean([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody BlankBody, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody ToolBody, [In] BooleanTypeEnum BooleanType);
    /// <summary>
    /// Method that transforms the input SurfaceBody.
    /// </summary>
    /// <param name="SurfaceBody">Input SurfaceBody object.</param>
    /// <param name="Transform">Input Matrix that defines the transform to apply to the input B-Rep entity. This matrix can only define rotations and translations, it cannot define scaling, shearing, or perspective and will fail for these cases.</param>
    [PreserveSig]
    void Transform([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody SurfaceBody, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Transform);
    /// <summary>
    /// Method that creates a copy of the input SurfaceBody, Face, or Edge object.
    /// </summary>
    /// <param name="Entity">The input B-Rep entity, which can be a SurfaceBody, Face, or Edge object.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody Copy([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Method that intersects a body with a plane.
    /// </summary>
    /// <param name="Body">Input SurfaceBody to intersect.</param>
    /// <param name="Plane">Input Plane that defines the plane to intersect the body with.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateIntersectionWithPlane([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body, [In] [MarshalAs(UnmanagedType.Interface)] Plane Plane);
    /// <summary>
    /// Method that modifies an existing transient surface body by deleting specified faces.
    /// </summary>
    /// <param name="Faces">Input Object to specifies the Face object(s) to either delete or save. This argument can be a single Face object or it can be a FaceCollection to specify more than one face. Depending on the value of the second argument these faces will be deleted or saved in the SurfaceBody. If a FaceCollection is provided as input all of the input faces must exist within the same transient SurfaceBody object.</param>
    /// <param name="DeleteSpecifiedFaces">Input Boolean that indicates if the face(s) specified in the Faces argument should be deleted or saved. If True, then the specified face(s) will be deleted from the SurfaceBody. If False, the specified face(s) will be saved and all other faces in the SurfaceBody will be deleted.</param>
    [PreserveSig]
    void DeleteFaces([In] [MarshalAs(UnmanagedType.IDispatch)] object Faces, [In] bool DeleteSpecifiedFaces);
    /// <summary>
    /// Method that creates a new SurfaceBodyDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBodyDefinition CreateSurfaceBodyDefinition();
    /// <summary>
    /// Method that creates one or more new SurfaceBody objects based on the content of the input file. A SurfaceBodies collection is returned that can contain one or more SurfaceBody object.
    /// </summary>
    /// <param name="FileName">Input String that defines the full filename of the file to read in. This can be either a SAT, SAB, or a DWG file that contains solids or surfaces.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBodies ReadFromFile([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Method that creates a ruled surface between the two sections.
    /// </summary>
    /// <param name="SectionOne">Input Wire that defines the shape of the first section.</param>
    /// <param name="SectionTwo">Input Wire that defines the shape of the second section.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateRuledSurface([In] [MarshalAs(UnmanagedType.Interface)] Wire SectionOne, [In] [MarshalAs(UnmanagedType.Interface)] Wire SectionTwo);
    /// <summary>
    /// Writes out the specified bodies as a file.
    /// </summary>
    /// <param name="Bodies">Input ObjectCollection of Bodies that are to be written out.</param>
    /// <param name="FileName">Input String containing the full filename of the file to write to.</param>
    /// <param name="Format">Input String that defines the file format to write the body information.  This can be one of the formats defined in SDK\DeveloperTools\Include\ClipboardFormats.h</param>
    [PreserveSig]
    void WriteToFile([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Bodies, [In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] [MarshalAs(UnmanagedType.BStr)] string? Format = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InputBodyOne">InputBodyOne</param>
    /// <param name="InputBodyTwo">InputBodyTwo</param>
    /// <param name="ImprintCoincidentEdges">ImprintCoincidentEdges</param>
    /// <param name="OutputBodyOne">OutputBodyOne</param>
    /// <param name="OutputBodyTwo">OutputBodyTwo</param>
    /// <param name="BodyOneOverlappingFaces">BodyOneOverlappingFaces</param>
    /// <param name="BodyTwoOverlappingFaces">BodyTwoOverlappingFaces</param>
    /// <param name="BodyOneOverlappingEdges">BodyOneOverlappingEdges</param>
    /// <param name="BodyTwoOverlappingEdges">BodyTwoOverlappingEdges</param>
    /// <param name="Tolerance">Tolerance</param>
    [PreserveSig]
    void ImprintBodies([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody InputBodyOne, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody InputBodyTwo, [In] bool ImprintCoincidentEdges, [Out] [MarshalAs(UnmanagedType.Interface)] out SurfaceBody OutputBodyOne, [Out] [MarshalAs(UnmanagedType.Interface)] out SurfaceBody OutputBodyTwo, [Out] [MarshalAs(UnmanagedType.Interface)] out Faces BodyOneOverlappingFaces, [Out] [MarshalAs(UnmanagedType.Interface)] out Faces BodyTwoOverlappingFaces, [Out] [MarshalAs(UnmanagedType.Interface)] out Edges BodyOneOverlappingEdges, [Out] [MarshalAs(UnmanagedType.Interface)] out Edges BodyTwoOverlappingEdges, [In] double? Tolerance = default);
    /// <summary>
    /// Method that find the identical SurfaceBody objects in a SurfaceBody objects collection. In the return value, all the identical surface bodies will be placed in the same ObjectCollection.
    /// </summary>
    /// <param name="InputSurfaceBodies">Input ObjectCollection that includes the SurfaceBody objects to compute the identity ones in it.</param>
    /// <param name="Options">Optional input NameValueMap that specifies the options when compute the comparison. Valid options includes:
    /// Name = Tolerance. Value = Double that specifies the tolerance when compare the surface bodies. If this is not specified, the default tolerance value 0.000001 will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection GetIdenticalBodies([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection InputSurfaceBodies, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
