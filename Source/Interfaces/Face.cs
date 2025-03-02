namespace Oblikovati.API;

/// <summary>
/// The Face object. See the article in the overviews section.
/// </summary>
public interface Face
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    SurfaceBody Parent { get; }
    /// <summary>
    /// Property that returns the feature that resulted in the creation of this face. This property is not currently supported for FaceProxy objects and will return Nothing in those cases. It is also not currently supported for Assembly Features and will fail in that case.
    /// </summary>
    PartFeature CreatedByFeature { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectCollection _CreatedByFeatures { get; }
    /// <summary>
    /// Gets the EdgeLoops collection referenced by this Face.
    /// </summary>
    EdgeLoops EdgeLoops { get; }
    /// <summary>
    /// Gets the Edges referenced by this Face.
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Gets the vertices for this Face.
    /// </summary>
    Vertices Vertices { get; }
    /// <summary>
    /// Property that returns the FaceShell object.
    /// </summary>
    FaceShell FaceShell { get; }
    /// <summary>
    /// Property that returns the associated with this object or feature.
    /// </summary>
    SurfaceBody SurfaceBody { get; }
    /// <summary>
    /// Gets whether the parameterization of the geometry obtained from the Geometry property is aligned or opposed to the topological sense of this Face.
    /// </summary>
    bool IsParamReversed { get; }
    /// <summary>
    /// Property that returns a SurfaceTypeEnum that specifies the surface type for this Face.
    /// </summary>
    SurfaceTypeEnum SurfaceType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Surface { get; }
    /// <summary>
    /// Property that returns the underlying geometry of the face.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Gets the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Gets the surface evaluator for this face.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Property that returns the alternate SurfaceBody.
    /// </summary>
    SurfaceBody AlternateBody { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that obtains an ID key that can be used to bind back to the live object. This transient key is only valid as long as the document state has not changed. For more information, see the ReferenceKeys overview.
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Property that returns a characteristic somewhere on the interior of the Face.
    /// </summary>
    Point PointOnFace { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SketchEntity _CreatedFromCurve { get; }
    /// <summary>
    /// Gets the texture maps associated with this face.
    /// </summary>
    TextureMaps TextureMaps { get; }
    /// <summary>
    /// Property that returns a FaceCollection that contains the input face and all tangentially connected faces. The CollectionType of the output FaceCollection is set to kFaceTangentiallyConnected.
    /// </summary>
    FaceCollection TangentiallyConnectedFaces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the referenced face(s) from the source part. This could be a proxy object in case of a derived assembly. The property returns Nothing if there isn't a referenced entity.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that returns a ThreadInfo object for each thread affecting this face.
    /// </summary>
    ObjectCollection ThreadInfos { get; }
    /// <summary>
    /// Property that returns a unique string identifying this face. This identifier is valid only so long as there are no further modifications to the face.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets and sets the current appearance of the face.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Gets and sets the source of the appearance for the face.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateFacets([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void GetExistingFacets([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingFacetTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] ExistingTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="SegmentCount">SegmentCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateStrokes([In] double Tolerance, [Out] out int VertexCount, [Out] out int SegmentCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void GetExistingStrokes([In] double ToleranceIndex, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] PolylineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingStrokeTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] ExistingTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    [PreserveSig]
    RenderStyle GetRenderStyle([Out] out StyleSourceTypeEnum StyleSourceType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    /// <param name="RenderStyle">RenderStyle</param>
    [PreserveSig]
    void SetRenderStyle([In] StyleSourceTypeEnum StyleSourceType, [In] [MarshalAs(UnmanagedType.Struct)] object? RenderStyle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void GetExistingFacetsAndTextureMap([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void CalculateFacetsAndTextureMap([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates);
    /// <summary>
    /// Method that gets the source face that has been overridden by this face. The method returns Nothing if this face is not an override. An error is returned if this method is called on a face in a part.
    /// </summary>
    /// <param name="GetLeafSource">Optional input Boolean that specifies whether to get the 'leaf' source face in the case where there are multiple levels of override. If specified to be False, the method returns the next level override face. If not specified, the argument defaults to True indicating that the leaf source will be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Face GetSourceFace([In] bool? GetLeafSource = true);
    /// <summary>
    /// Method that returns a point on the face that is closest to the input point. A single point is returned even if multiple equidistant points are found. To get the u-v parameters of the returned point on the face, use Face.Evaluator.GetParamAtPoint method.
    /// </summary>
    /// <param name="InputPoint">Point object that specifies the point for which the closest point on the face is to be located. If the input point lies on the Face, the coordinates of the input point are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Point GetClosestPointTo([In] [MarshalAs(UnmanagedType.Interface)] Point InputPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.Struct)] out object TextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    /// <param name="IndexCountPerFace">IndexCountPerFace</param>
    [PreserveSig]
    void GetExistingFacetsAndTextureMap2([In] double ChordalTolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] IndexCountPerFace);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] PolylineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="UScale">UScale</param>
    /// <param name="VScale">VScale</param>
    [PreserveSig]
    void GetTextureScale([Out] out double UScale, [Out] out double VScale);
}
