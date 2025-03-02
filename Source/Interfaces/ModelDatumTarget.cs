namespace Oblikovati.API;

/// <summary>
/// ModelDatumTarget Object.
/// </summary>
public interface ModelDatumTarget
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-only property that returns the parent component definition of the object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Gets and sets the visibility of the annotation.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the annotation.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Returns whether this annotation is a member of a ModelCompositeAnnotation.
    /// </summary>
    bool IsMemberOfCompositeAnnotation { get; }
    /// <summary>
    /// Read-only property that returns the ModelCompositeAnnotation object if this annotation is a member of it. This returns Nothing if the IsMemberOfCompositeAnnotation returns False.
    /// </summary>
    ModelCompositeAnnotation CompositeAnnotation { get; }
    /// <summary>
    /// Returns whether this annotation is owned by a ModelToleranceFeature.
    /// </summary>
    bool IsOwnedByToleranceFeature { get; }
    /// <summary>
    /// Returns the owning ModelToleranceFeature object.
    /// </summary>
    ModelToleranceFeature OwnedByToleranceFeature { get; }
    /// <summary>
    /// Returns the top ModelToleranceFeature object.
    /// </summary>
    ModelToleranceFeature TopToleranceFeature { get; }
    /// <summary>
    /// Gets the internal name (GUID) of the model annotation.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets and sets the annotation plane for the model datum target.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Gets and sets the placement point of this model datum target object.
    /// </summary>
    object TargetPoint { get; set; }
    /// <summary>
    /// Gets and sets the position of the datum target text.
    /// </summary>
    Point TextPosition { get; set; }
    /// <summary>
    /// Gets and sets the index of this model datum target object.
    /// </summary>
    int Index { get; set; }
    /// <summary>
    /// Returns the parent model datum object.
    /// </summary>
    ModelDatum ModelDatum { get; }
    /// <summary>
    /// Returns the parameter that controls the datum target area diameter.
    /// </summary>
    Parameter AreaDiameter { get; }
    /// <summary>
    /// Returns the parameter that controls the datum target area width.
    /// </summary>
    Parameter AreaWidth { get; }
    /// <summary>
    /// Returns the parameter that controls the datum target area height.
    /// </summary>
    Parameter AreaHeight { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the ModelDimension.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Camera">Camera</param>
    /// <param name="GroupCount">GroupCount</param>
    /// <param name="PolylinesPerGroup">PolylinesPerGroup</param>
    /// <param name="FilledGroups">FilledGroups</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    [PreserveSig]
    void GetDisplayGeometry([In] [MarshalAs(UnmanagedType.Interface)] Camera Camera, [Out] out int GroupCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylinesPerGroup, [Out] [MarshalAs(UnmanagedType.SafeArray)] out bool[,] FilledGroups, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylineLengths, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Camera">Camera</param>
    /// <param name="TextVertexCount">TextVertexCount</param>
    /// <param name="TextFacetCount">TextFacetCount</param>
    /// <param name="TextVertexCoordinates">TextVertexCoordinates</param>
    /// <param name="TextVertexIndices">TextVertexIndices</param>
    /// <param name="SymbolVertexCount">SymbolVertexCount</param>
    /// <param name="SymbolFacetCount">SymbolFacetCount</param>
    /// <param name="SymbolVertexCoordinates">SymbolVertexCoordinates</param>
    /// <param name="SymbolVertexIndices">SymbolVertexIndices</param>
    [PreserveSig]
    void GetFilledAreaFacetsInfo([In] [MarshalAs(UnmanagedType.Interface)] Camera Camera, [Out] out int TextVertexCount, [Out] out int TextFacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextVertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] TextVertexIndices, [Out] out int SymbolVertexCount, [Out] out int SymbolFacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] SymbolVertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] SymbolVertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="InternalName">InternalName</param>
    [PreserveSig]
    void GenerateInternalName([In] [MarshalAs(UnmanagedType.Struct)] object Context, [In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default);
}
