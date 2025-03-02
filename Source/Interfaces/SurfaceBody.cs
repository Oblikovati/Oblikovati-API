namespace Oblikovati.API;

/// <summary>
/// The SurfaceBody object. See the article in the overviews section.
/// </summary>
public interface SurfaceBody
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
    object Parent { get; }
    /// <summary>
    /// Property that returns the collection object.
    /// </summary>
    FaceShells FaceShells { get; }
    /// <summary>
    /// Property that returns a collection object generated as a result of the feature.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Gets the referenced by this SurfaceBody.
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Property that retrieves all vertices on the body.
    /// </summary>
    Vertices Vertices { get; }
    /// <summary>
    /// Property returning the Wires collection object associated with this SurfaceBody.
    /// </summary>
    Wires Wires { get; }
    /// <summary>
    /// Gets the primary that resides in this file.
    /// </summary>
    ComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Gets a tight fitting bounding box for this body.
    /// </summary>
    Box PreciseRangeBox { get; }
    /// <summary>
    /// Determine if this SurfaceBody is solid.
    /// </summary>
    bool IsSolid { get; }
    /// <summary>
    /// Property that returns the volume of the component in database units.
    /// </summary>
    double Volume { get; }
    /// <summary>
    /// Gets the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Property that returns a new SurfaceBody that was derived from the existing body using the specified form input. The primary purpose of this property is to obtain a body that consists entirely of NURBS surfaces.
    /// </summary>
    SurfaceBody AlternateBody { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns an that contains all of the concave edges of the surface body. The CollectionType of the output EdgeCollection is set to kAllConcave.
    /// </summary>
    EdgeCollection ConcaveEdges { get; }
    /// <summary>
    /// Property that returns an that contains all of the convex edges of the surface body. The CollectionType of the output EdgeCollection is set to kAllConvex.
    /// </summary>
    EdgeCollection ConvexEdges { get; }
    /// <summary>
    /// Gets and sets the visibility of the body.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns a constant indicating whether the specified point is inside, on or outside the body.
    /// </summary>
    ContainmentEnum IsPointInside { get; }
    /// <summary>
    /// Returns the DataIO object.
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Property that specified if this SurfaceBody is transient or not.
    /// </summary>
    bool IsTransient { get; }
    /// <summary>
    /// Property that returns the feature that resulted in the creation of this body. This property returns Nothing for transient bodies.
    /// </summary>
    PartFeature CreatedByFeature { get; }
    /// <summary>
    /// Property that returns the features that affected this body. The returned enumerator includes the feature that created this body. This property returns Nothing for transient bodies
    /// </summary>
    PartFeaturesEnumerator AffectedByFeatures { get; }
    /// <summary>
    /// Gets and sets the name of the body.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Gets and sets the current appearance of the body.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Gets and sets the source of the appearance for the body.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Retrieves the oriented minimum range box for this object.
    /// </summary>
    OrientedBox OrientedMinimumRangeBox { get; }
    /// <summary>
    /// Read-only property that returns mass properties for this body.
    /// </summary>
    SurfaceBodyMassProperties MassProperties { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
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
    void CalculateFacets([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
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
    void GetExistingFacets([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingFacetTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] ExistingTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="SegmentCount">SegmentCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateStrokes([In] double Tolerance, [Out] out int VertexCount, [Out] out int SegmentCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void GetExistingStrokes([In] double ToleranceIndex, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingStrokeTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] ExistingTolerances);
    /// <summary>
    /// Finds the object of specified type within the proximity of the given point. By default an internal tolerance is used to gauge the proximity.
    /// </summary>
    /// <param name="ObjectType">Input ObjectType of object to find.</param>
    /// <param name="PointOnObject">Input .</param>
    /// <param name="ProximityTolerance">Optional input Variant that specifies the tolerance to use to test proximity. If this value is not specified, the internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    object LocateUsingPoint([In] ObjectTypeEnum ObjectType, [In] [MarshalAs(UnmanagedType.Interface)] Point PointOnObject, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RayStartPoint">RayStartPoint</param>
    /// <param name="RayDirection">RayDirection</param>
    /// <param name="Radius">Radius</param>
    /// <param name="FoundEntities">FoundEntities</param>
    /// <param name="LocationPoints">LocationPoints</param>
    /// <param name="FindFirstOnly">FindFirstOnly</param>
    [PreserveSig]
    void FindUsingRay([In] [MarshalAs(UnmanagedType.Interface)] Point RayStartPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector RayDirection, [In] double Radius, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator FoundEntities, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator LocationPoints, [In] bool? FindFirstOnly = false);
    /// <summary>
    /// Bind the transient key of a subentity on this body to a live object.
    /// </summary>
    /// <param name="TransientKey">Transient key to bind.</param>
    /// <returns></returns>
    [PreserveSig]
    object BindTransientKeyToObject([In] int TransientKey);
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
    void CalculateFacetsAndTextureMap([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates);
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
    void GetExistingFacetsAndTextureMap([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates);
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
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors);
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
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.Struct)] out object TextureCoordinates);
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
    void GetExistingFacetsAndTextureMap2([In] double ChordalTolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] IndexCountPerFace);
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
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylineLengths);
    /// <summary>
    /// Method that deletes this SurfaceBody object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityToCheck">EntityToCheck</param>
    /// <param name="CheckLevel">CheckLevel</param>
    /// <param name="ProblemEntities">ProblemEntities</param>
    [PreserveSig]
    bool IsEntityValid([In] [MarshalAs(UnmanagedType.Struct)] object? EntityToCheck = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityToCheck">EntityToCheck</param>
    /// <param name="CheckLevel">CheckLevel</param>
    /// <param name="ProblemEntities">ProblemEntities</param>
    [PreserveSig]
    bool IsEntityValid([In] [MarshalAs(UnmanagedType.Struct)] object EntityToCheck, [In] int CheckLevel, [Out] [MarshalAs(UnmanagedType.Struct)] out object ProblemEntities);
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
    /// <param name="StripOverrides">StripOverrides</param>
    [PreserveSig]
    void SetRenderStyle([In] StyleSourceTypeEnum StyleSourceType, [In] [MarshalAs(UnmanagedType.Struct)] object? RenderStyle = default, [In] bool? StripOverrides = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Entity">Entity</param>
    [PreserveSig]
    NameValueMap GetASMAttributes([In] [MarshalAs(UnmanagedType.Struct)] object? Entity = default);
    /// <summary>
    /// Method that clears all the appearance overrides that have been applied to faces or features in the body. When the SurfaceBody has its IsSolid return True, this method sets the AppearanceSourceType to kBodyAppearance for all the features and kFeatureAppearance for all the faces in the body. When the SurfaceBody has its IsSolid return False, this method sets the AppearanceSourceType to kBodyAppearance for all the features directly owned by the work surface and kFeatureAppearance for all the faces in the body.
    /// </summary>
    [PreserveSig]
    void ClearAppearanceOverrides();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TextureMappingType">TextureMappingType</param>
    /// <param name="TextureMappingAlignment">TextureMappingAlignment</param>
    [PreserveSig]
    void GetAppearanceTextureMappingData();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TextureMappingType">TextureMappingType</param>
    /// <param name="TextureMappingAlignment">TextureMappingAlignment</param>
    [PreserveSig]
    void GetAppearanceTextureMappingData([Out] out TextureMappingTypeEnum TextureMappingType, [Out] [MarshalAs(UnmanagedType.Struct)] out object TextureMappingAlignment);
    /// <summary>
    /// Method that sets the texture mapping type and alignment. Setting this value is only valid when the appearance assigned to the body has a texture defined.
    /// </summary>
    /// <param name="TextureMappingType">Input texture mapping type applies to the object.</param>
    /// <param name="TextureMappingAlignment">Optional input unit vector that indicates the texture mapping alignment. This argument will be ignored if the TextureMappingType is not kCylindricalMappingType or kSphericalMappingType.</param>
    [PreserveSig]
    void SetAppearanceTextureMappingData([In] TextureMappingTypeEnum TextureMappingType, [In] [MarshalAs(UnmanagedType.Struct)] object? TextureMappingAlignment = default);
    /// <summary>
    /// Method that gets the appearance colors for the faces. The returned ObjectCollection contains the Color objects with the same sequence as the corresponding Face objects in the input Faces argument.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection GetFaceColors([In] [MarshalAs(UnmanagedType.Struct)] object? Faces = default);
}
