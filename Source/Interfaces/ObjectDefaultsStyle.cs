namespace Oblikovati.API;

/// <summary>
/// The Object Defaults style is a sub-style of the active standard style. In a drawing document, after a standard is selected, the active Object Default style specifies which layer and object style provides the format definition for a particular object.
/// </summary>
public interface ObjectDefaultsStyle
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingStylesManager _Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the name of the Style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the internal name of the style. The name is the internal English name of the standard style. This name will remain constant and is not affected by locale. This name is never displayed to the user. Note that this name is not guaranteed to be unique.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the location of this style, i.e. local to the document, cached locally in the document, exists in the library. Styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the type of the style.
    /// </summary>
    StyleTypeEnum StyleType { get; }
    /// <summary>
    /// Gets and sets comments associated with the style.
    /// </summary>
    string Comments { get; set; }
    /// <summary>
    /// Property returning the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets and sets the default dimension style for angular dimensions.
    /// </summary>
    DimensionStyle AngularDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for linear dimensions.
    /// </summary>
    DimensionStyle LinearDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for diameter dimensions.
    /// </summary>
    DimensionStyle DiameterDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for radial dimensions.
    /// </summary>
    DimensionStyle RadialDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for baseline dimensions.
    /// </summary>
    DimensionStyle BaselineDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for ordinate dimensions.
    /// </summary>
    DimensionStyle OrdinateDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for ordinate set dimensions.
    /// </summary>
    DimensionStyle OrdinateSetDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default text style for sketches.
    /// </summary>
    TextStyle SketchTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default text style for leader text.
    /// </summary>
    DimensionStyle LeaderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for angular dimensions.
    /// </summary>
    Layer AngularDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for balloons.
    /// </summary>
    BalloonStyle BalloonStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for balloons.
    /// </summary>
    Layer BalloonLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for baseline dimensions.
    /// </summary>
    Layer BaselineDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for bend notes.
    /// </summary>
    DimensionStyle BendNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for bend notes.
    /// </summary>
    Layer BendNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for border geometries.
    /// </summary>
    Layer BorderGeometryLayer { get; set; }
    /// <summary>
    /// Gets and sets the default text style for border texts.
    /// </summary>
    TextStyle BorderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for border texts.
    /// </summary>
    Layer BorderTextLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for chamfer notes.
    /// </summary>
    DimensionStyle ChamferNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for chamfer notes.
    /// </summary>
    Layer ChamferNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for diameter dimensions.
    /// </summary>
    Layer DiameterDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for feature control frames.
    /// </summary>
    FeatureControlFrameStyle FeatureControlFrameStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for feature control frames.
    /// </summary>
    Layer FeatureControlFrameLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for hole notes.
    /// </summary>
    DimensionStyle HoleNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for hole notes.
    /// </summary>
    Layer HoleNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for hole tables.
    /// </summary>
    HoleTableStyle HoleTableStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for hole tables.
    /// </summary>
    Layer HoleTableLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for hole tags.
    /// </summary>
    DimensionStyle HoleTagStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for hole tags.
    /// </summary>
    Layer HoleTagLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for leader texts.
    /// </summary>
    Layer LeaderTextLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for linear dimensions.
    /// </summary>
    Layer LinearDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for ordinate dimensions.
    /// </summary>
    Layer OrdinateDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for ordinate dimension sets.
    /// </summary>
    Layer OrdinateDimensionSetLayer { get; set; }
    /// <summary>
    /// Gets and sets the default leader style for origin indicators.
    /// </summary>
    LeaderStyle OriginIndicatorStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for origin indicators.
    /// </summary>
    Layer OriginIndicatorLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for parts lists.
    /// </summary>
    Layer PartsListLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for punch notes.
    /// </summary>
    DimensionStyle PunchNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for punch notes.
    /// </summary>
    Layer PunchNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for radial dimensions.
    /// </summary>
    Layer RadialDimensionLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for sketch geometries.
    /// </summary>
    Layer SketchGeometryLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for 3D sketch geometries.
    /// </summary>
    Layer Sketch3DGeometryLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for sketch texts.
    /// </summary>
    Layer SketchTextLayer { get; set; }
    /// <summary>
    /// Gets and sets the default leader style for user defined symbols.
    /// </summary>
    LeaderStyle SketchedSymbolLeaderStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for user defined symbols.
    /// </summary>
    Layer SketchedSymbolLeaderLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for user defined symbol sketch geometries.
    /// </summary>
    Layer SketchedSymbolGeometryLayer { get; set; }
    /// <summary>
    /// Gets and sets the default text style for user defined symbol sketch texts.
    /// </summary>
    TextStyle SketchedSymbolTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for user defined symbol sketch texts.
    /// </summary>
    Layer SketchedSymbolTextLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for surface textures.
    /// </summary>
    SurfaceTextureStyle SurfaceTextureStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for surface textures.
    /// </summary>
    Layer SurfaceTextureLayer { get; set; }
    /// <summary>
    /// Gets and sets the default dimension style for thread notes.
    /// </summary>
    DimensionStyle ThreadNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for thread notes.
    /// </summary>
    Layer ThreadNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for title block geometries.
    /// </summary>
    Layer TitleBlockGeometryLayer { get; set; }
    /// <summary>
    /// Gets and sets the default text style for title block texts.
    /// </summary>
    TextStyle TitleBlockTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for title block texts.
    /// </summary>
    Layer TitleBlockTextLayer { get; set; }
    /// <summary>
    /// Gets and sets the default text style for general notes.
    /// </summary>
    TextStyle GeneralNoteStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for general notes.
    /// </summary>
    Layer GeneralNoteLayer { get; set; }
    /// <summary>
    /// Gets and sets the default text style for view labels.
    /// </summary>
    TextStyle ViewLabelStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for view labels.
    /// </summary>
    Layer ViewLabelLayer { get; set; }
    /// <summary>
    /// Gets and sets the default layer for center lines.
    /// </summary>
    Layer CenterlineLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for center lines.
    /// </summary>
    CentermarkStyle CenterlineStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for center marks.
    /// </summary>
    Layer CentermarkLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for center marks.
    /// </summary>
    CentermarkStyle CentermarkStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for center mark identifying the center of gravity.
    /// </summary>
    Layer CenterOfGravityLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for center mark identifying the center of gravity.
    /// </summary>
    CentermarkStyle CenterOfGravityStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for a center mark identifying a sheet metal punch origin.
    /// </summary>
    Layer SheetMetalPunchLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for a center mark identifying a sheet metal punch origin.
    /// </summary>
    CentermarkStyle SheetMetalPunchStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for a centerline or center mark identifying a work axis.
    /// </summary>
    Layer WorkAxisLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for a centerline or center mark identifying a work axis.
    /// </summary>
    CentermarkStyle WorkAxisStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for a centerline identifying a work plane.
    /// </summary>
    Layer WorkPlaneLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for a centerline identifying a work plane.
    /// </summary>
    CentermarkStyle WorkPlaneStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for a center mark identifying a work point.
    /// </summary>
    Layer WorkPointLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for a center mark identifying a work point.
    /// </summary>
    CentermarkStyle WorkPointStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    StyleLocationEnum _StyleLocation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _InUse { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpToDate { get; }
    /// <summary>
    /// Read-write property that gets and sets the default layer for chain dimension sets.
    /// </summary>
    Layer ChainDimensionLayer { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the default style for chain dimension sets.
    /// </summary>
    DimensionStyle ChainDimensionStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for bend tables.
    /// </summary>
    Layer BendTableLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for bend tables.
    /// </summary>
    TableStyle BendTableStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for bend tags.
    /// </summary>
    Layer BendTagLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for bend tags.
    /// </summary>
    DimensionStyle BendTagStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for configuration tables.
    /// </summary>
    Layer ConfigurationTableLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for configuration tables.
    /// </summary>
    TableStyle ConfigurationTableStyle { get; set; }
    /// <summary>
    /// Gets and sets the default style for parts lists.
    /// </summary>
    PartsListStyle PartsListStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for revision tables.
    /// </summary>
    Layer RevisionTableLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for revision tables.
    /// </summary>
    RevisionTableStyle RevisionTableStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for revision tags.
    /// </summary>
    Layer RevisionTagLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for revision tags.
    /// </summary>
    RevisionTableStyle RevisionTagStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for general (custom) tables.
    /// </summary>
    Layer TableLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for general (custom) tables.
    /// </summary>
    TableStyle TableStyle { get; set; }
    /// <summary>
    /// Gets and sets the default layer for weld symbols.
    /// </summary>
    Layer WeldSymbolLayer { get; set; }
    /// <summary>
    /// Gets and sets the default style for weld symbols.
    /// </summary>
    WeldSymbolStyle WeldSymbolStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the default layer for edge symbols.
    /// </summary>
    Layer EdgeSymbolLayer { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the default style for edge symbols.
    /// </summary>
    EdgeSymbolStyle EdgeSymbolStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    [PreserveSig]
    ObjectDefaultsStyle _Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    ObjectDefaultsStyle _ConvertToLocal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _SaveToGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _UpdateFromGlobal();
    /// <summary>
    /// Method that deletes the Style/Layer/UnfoldMethod.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Style ConvertToLocal();
    /// <summary>
    /// Method that creates a new local Style object. The newly created style is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a dimension style is being copied, the name must be unique with respect to all the other dimension styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Style Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
