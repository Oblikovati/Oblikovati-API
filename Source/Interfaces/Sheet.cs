namespace Oblikovati.API;

/// <summary>
/// The Sheet object represents a sheet in a drawing document. See here for an overview on drawing views.
/// </summary>
public interface Sheet
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
    /// Property returning the parent document. When used within Autodesk Inventor the DrawingDocument object will be returned. When used within Apprentice the ApprenticeServerDrawingDocument object will be returned.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets or sets the user-friendly name of the Sheet.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets or sets the revision number of the sheet.
    /// </summary>
    string Revision { get; set; }
    /// <summary>
    /// Property that returns the collection object. This provides access to the existing drawing views on the sheet.
    /// </summary>
    DrawingViews DrawingViews { get; }
    /// <summary>
    /// Property that returns a DataIO object. The DataIO object can be used to write out the sheet data in various formats. The Sheet currently only supports
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Gets or sets the size of the Sheet as value in an enumeration of standard sheet sizes.
    /// </summary>
    DrawingSheetSizeEnum Size { get; set; }
    /// <summary>
    /// Gets or sets the orientation of the sheet as it is viewed or printed.
    /// </summary>
    PageOrientationTypeEnum Orientation { get; set; }
    /// <summary>
    /// Gets or sets the height of the sheet.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Gets or sets the width of the sheet.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Property that returns the current status of the sheet and its contents. If the value is equal to kUpToDateDrawingSheet then the drawing sheet is up to date. Any other value means some portion of the sheet is out of date. The returned value can contain status information about several things about the sheet. You can use bitwise operators to determine the status for a particular item. For example the following can be used to see if the precise display for views on sheet are up to date. If (oSheet.Status And kProcessingPreciseDisplayDrawingSheet) = kProcessingPreciseDisplayDrawingSheet Then MsgBox "Processing precise display." End If This is useful when an operation requires the sheet to be up to date. For example, when plotting the sheet.
    /// </summary>
    DrawingSheetStatusBits Status { get; }
    /// <summary>
    /// Property that returns the DrawingSketches collection object for the sheet. This object provides access to all of the sketches that have been created on the sheet and provides functionality to create new sketches.
    /// </summary>
    DrawingSketches Sketches { get; }
    /// <summary>
    /// Property that returns the PartsLists collection object associated with this sheet. This provides access to the existing parts lists on the sheet.
    /// </summary>
    PartsLists PartsLists { get; }
    /// <summary>
    /// Property that returns the collection of on this sheet.
    /// </summary>
    Balloons Balloons { get; }
    /// <summary>
    /// Gets or sets whether to exclude the sheet in the count of sheets in the drawing.
    /// </summary>
    bool ExcludeFromCount { get; set; }
    /// <summary>
    /// Gets or sets whether to exclude the sheet when printing the drawing.
    /// </summary>
    bool ExcludeFromPrinting { get; set; }
    /// <summary>
    /// Property that returns the TitleBlock object associated with the sheet. This property will return Nothing in the case where the sheet doesn't have a title block.
    /// </summary>
    TitleBlock TitleBlock { get; }
    /// <summary>
    /// Property that returns the Border or DefaultBorder object associated with the sheet. This property will return Nothing in the case where the sheet doesn't have a border.
    /// </summary>
    Border Border { get; }
    /// <summary>
    /// Property that returns the CustomTables collection object for this sheet.
    /// </summary>
    CustomTables CustomTables { get; }
    /// <summary>
    /// Property that returns the RevisionTables collection object.
    /// </summary>
    RevisionTables RevisionTables { get; }
    /// <summary>
    /// Property that returns the HoleTables collection object.
    /// </summary>
    HoleTables HoleTables { get; }
    /// <summary>
    /// Property that returns the DrawingNotes collection object consisting of all drawing notes.
    /// </summary>
    DrawingNotes DrawingNotes { get; }
    /// <summary>
    /// Property that returns the SketchedSymbols collection object. This object provides access to all sketched symbols on a sheet.
    /// </summary>
    SketchedSymbols SketchedSymbols { get; }
    /// <summary>
    /// Property that returns the AutoCADBlocks collection object. This object provides access to all instances of AutoCAD blocks on a sheet. This property returns Nothing for sheets on an Inventor IDW document.
    /// </summary>
    AutoCADBlocks AutoCADBlocks { get; }
    /// <summary>
    /// Property that returns the collection for the drawing sheet.
    /// </summary>
    ClientViews ClientViews { get; }
    /// <summary>
    /// Gets the ClientGraphicsCollection object.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Gets the GraphicsDataSetsCollection object.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Property that returns whether this is a model space sheet created automatically when opening (rather than importing) AutoCAD dwg files.
    /// </summary>
    bool IsModelSpaceSheet { get; }
    /// <summary>
    /// Property that returns the FeatureControlFrames collection object.
    /// </summary>
    FeatureControlFrames FeatureControlFrames { get; }
    /// <summary>
    /// Property that returns the SurfaceTextureSymbols collection object.
    /// </summary>
    SurfaceTextureSymbols SurfaceTextureSymbols { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the DrawingDimensions collection object. This object provides access to all of the dimensions on the sheet.
    /// </summary>
    DrawingDimensions DrawingDimensions { get; }
    /// <summary>
    /// Property that returns the Centermarks collection object.
    /// </summary>
    Centermarks Centermarks { get; }
    /// <summary>
    /// Property that returns the Centerlines collection object.
    /// </summary>
    Centerlines Centerlines { get; }
    /// <summary>
    /// Read-write property that gets and sets the text property source model. This is the name of a drawing view.
    /// </summary>
    string TextPropertySource { get; set; }
    /// <summary>
    /// Get the DrawingWeldingSymbols collection object.
    /// </summary>
    DrawingWeldingSymbols WeldingSymbols { get; }
    /// <summary>
    /// Get the RevisionClouds collection object.
    /// </summary>
    RevisionClouds RevisionClouds { get; }
    /// <summary>
    /// Read-only property that returns the collection of edge symbols on this sheet.
    /// </summary>
    EdgeSymbols EdgeSymbols { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _DisplayName { get; }
    /// <summary>
    /// Method that causes this sheet to become the active sheet.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that adds the specified title block definition to the sheet. Since a sheet can only have one title block at a time, calling this method will remove the existing title block.
    /// </summary>
    /// <param name="TitleBlockDefinition">Input Variant that specifies which TitleBlockDefinition to use. The input for the argument can be either a TitleBlockDefinition object or string containing the name of an existing TitleBlockDefinition object.</param>
    /// <param name="TitleBlockLocation">Optional input value from the TitleBlockLocationEnum enum that defines which corner of the sheet the title block is positioned in. If not supplied, it defaults to the position defined by the sheet.</param>
    /// <param name="PromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the title block definition. If prompted strings exist in the title block definition you must supply input strings through this argument or this method will fail. The prompt strings and their order are obtained by querying the TextBox objects in the TitleBlockDefinition. The order they're returned by the TextBoxes collection is the same order the input strings need to be supplied in the PromptStrings array.</param>
    /// <returns></returns>
    [PreserveSig]
    TitleBlock AddTitleBlock([In] [MarshalAs(UnmanagedType.Struct)] object TitleBlockDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object? TitleBlockLocation = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default);
    /// <summary>
    /// Method that adds the specified border definition to the sheet. This method will fail in the case where a border instance already exists on the sheet. In this case, use the Delete method of the Border object to remove the existing one first.
    /// </summary>
    /// <param name="BorderDefinition">Input Variant that specifies which BorderDefinition to use. The input for the argument can be either a BorderDefinition object or string containing the name of an existing BorderDefinition object.</param>
    /// <param name="PromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the border definition. If prompted strings exist in the border definition you must supply input strings through this argument or this method will fail. The prompt strings and their order are obtained by querying the TextBox objects in the BorderDefinition. The order they're returned by the TextBoxes collection is the same order the input strings need to be supplied in the PromptStrings array.</param>
    /// <returns></returns>
    [PreserveSig]
    Border AddBorder([In] [MarshalAs(UnmanagedType.Struct)] object BorderDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default);
    /// <summary>
    /// Method that adds an instance of the default border to the sheet. This method is the equivalent of inserting the 'Default Border' border. A border created using the default border is created 'on the fly' by  Oblikovati using the supplied input. It is not based on an existing border definition.
    /// </summary>
    /// <param name="HorizontalZoneCount">Optional value that specifies the number of horizontal zones to be created for the border. If not supplied it will default to a standard value, which varies depending on the width of the sheet.</param>
    /// <param name="HorizontalZoneLabelMode">Optional input BorderLabelModeEnum value that specifies label style for the horizontal labels. Valid values are kBorderLabelModeAlphabetical, kBorderLabelModeNumeric, and kBorderLabelModeNone. If not specified, it will default to kBorderLabelModeNumeric.</param>
    /// <param name="VerticalZoneCount">Optional value that specifies the number of vertical zones to be created for the border. If not supplied it will default to a standard value, which varies depending on the height of the sheet.</param>
    /// <param name="VerticalZoneLabelMode">Optional input BorderLabelModeEnum value that specifies label style for the vertical labels. Valid values are kBorderLabelModeAlphabetical, kBorderLabelModeNumeric, and kBorderLabelModeNone. If not specified, it will default to kBorderLabelModeAlphabetical.</param>
    /// <param name="LabelFromBottomRight">Optional input Variant that indicates whether the zone numbers should begin at the bottom\-right or top\-left corner. A value of True indicates the bottom\-right corner and False specifies the top\-left. If not specified, it will default to True.</param>
    /// <param name="DelimitByLines">Optional input Boolean input that indicates if delimit zones should be indicated by lines or arrowheads. A value of True indicates lines and False specifies arrowheads. If not specified, it will default to True.</param>
    /// <param name="Centermarks">Optional input Boolean that specifies whether to a incorporate center marks into the border. A value of True will add center marks. If not specified, it will default to True.</param>
    /// <param name="TopMargin">Optional Double input that specifies the space between the top edge of the sheet and the border line. The distance is specified in centimeters. If not specified, it defaults to a value appropriate for the current active standard.</param>
    /// <param name="BottomMargin">Optional Double input that specifies the space between the bottom edge of the sheet and the border line. The distance is specified in centimeters. If not specified, it defaults to a value appropriate for the current active standard.</param>
    /// <param name="LeftMargin">Optional Double input that specifies the space between the left edge of the sheet and the border line. The distance is specified in centimeters. If not specified, it defaults to a value appropriate for the current active standard.</param>
    /// <param name="RightMargin">Optional input Variant that specifies the space between the right edge of the sheet and the border line. The distance is specified in centimeters. If not specified, it defaults to a value appropriate for the current active standard.</param>
    /// <param name="TextStyle">Optional input TextStyle object that specifies the text style for the zone labels.</param>
    /// <param name="TextLayer">Optional input Layer object that specifies the layer for the zone labels.</param>
    /// <param name="LineLayer">Optional input Layer object that specifies the layer for the border geometry.</param>
    /// <returns></returns>
    [PreserveSig]
    DefaultBorder AddDefaultBorder([In] [MarshalAs(UnmanagedType.Struct)] object? HorizontalZoneCount = default, [In] [MarshalAs(UnmanagedType.Struct)] object? HorizontalZoneLabelMode = default, [In] [MarshalAs(UnmanagedType.Struct)] object? VerticalZoneCount = default, [In] [MarshalAs(UnmanagedType.Struct)] object? VerticalZoneLabelMode = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LabelFromBottomRight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DelimitByLines = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Centermarks = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TopMargin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomMargin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LeftMargin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RightMargin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TextStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TextLayer = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LineLayer = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetDocument">TargetDocument</param>
    [PreserveSig]
    Sheet CopyTo([In] [MarshalAs(UnmanagedType.Interface)] _DrawingDocument TargetDocument);
    /// <summary>
    /// Method that deletes this sheet.
    /// </summary>
    /// <param name="RetainDependentViews">Indicates whether to retain any views dependent on this sheet.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependentViews = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that creates a GeometryIntent object for use in various annotation and view creations.
    /// </summary>
    /// <param name="Geometry">Input object that specifies the geometry. Valid \input objects are DrawingCurve, sketch entities from a sheet sketch, DrawingDimension, Centerline, and Centermark objects. If a DrawingDimension object is input, a Point2d on the dimension must be provided in the Intent argument. A Point object can be provided for true dimensions in an iso\-view. Use the DimensionLine, ExtensionLineOne and ExtensionLineTwo properties on the dimension objects to get points on the dimension.</param>
    /// <param name="Intent">Input object that specifies the intent point on the input geometry. This can be a value from PointIntentEnum, a geometry if the intent is the intersection of two geometries, a Point2d object that specifies a sheet point on the geometry or a double value (0 to 1) indicating the parameter on the input curve geometry. The range of valid parameter values can be obtained using the GetParamExtents method on the curve's evaluator.</param>
    /// <returns></returns>
    [PreserveSig]
    GeometryIntent CreateGeometryIntent([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [In] [MarshalAs(UnmanagedType.Struct)] object? Intent = default);
    /// <summary>
    /// Method that finds drawing curve segments, entities on a sheet sketch, centerlines and centermarks that the given point lies on.
    /// </summary>
    /// <param name="PointOnSheet">Input Point2d object that specifies a sheet point.</param>
    /// <param name="ProximityTolerance">Input Double that specifies the tolerance value for the search. If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator FindUsingPoint([In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOnSheet, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default);
    /// <summary>
    /// Method that updates the sheet.
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that changes the associated layer for all the input objects.
    /// </summary>
    /// <param name="Objects">Input ObjectCollection containing the objects to change the layer of. All the objects should belong to the parent Sheet. The collection can contain any drawing object that has a layer associated with it.</param>
    /// <param name="Layer">Input Layer object that specifies the new layer to which the objects should be moved to.</param>
    [PreserveSig]
    void ChangeLayer([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects, [In] [MarshalAs(UnmanagedType.Interface)] Layer Layer);
    /// <summary>
    /// Retrieves sketch and/or model annotations into the drawing.
    /// </summary>
    /// <param name="ViewOrSketch">Input object that specifies the DrawingView or the DrawingSketch object to retrieve annotations from.</param>
    /// <param name="AnnotationsToRetrieve">Optional input ObjectCollection that specifies the annotations to retrieve.  If not specified, all annotations from the specified view or sketch are retrieved.  If specified, the collection can contain sketch constraint objects or their proxies that derive from DimensionConstraint, FeatureDimension objects or FeatureDimensionProxy objects, 3D annotation objects and their proxy objects.  The objects must belong to the view or sketch specified in the first argument, else an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator RetrieveAnnotations([In] [MarshalAs(UnmanagedType.IDispatch)] object ViewOrSketch, [In] [MarshalAs(UnmanagedType.Struct)] object? AnnotationsToRetrieve = default);
    /// <summary>
    /// Gets an array of strings containing names of the design views of model document that the 3D annotations can be retrieved from.
    /// </summary>
    /// <param name="View">Input DrawingView object from which to get the names of the model document’s design views that can be used to get the retrievable annotations.</param>
    /// <returns></returns>
    [PreserveSig]
    string[,] GetAvailableDesignViewsToRetrieve3DAnnotations([In] [MarshalAs(UnmanagedType.Interface)] DrawingView View);
    /// <summary>
    /// Returns a collection of objects that represent the valid set of model dimensions that can be retrieved into the input drawing view.
    /// </summary>
    /// <param name="View">Input DrawingView object to get the retrievable annotations from.</param>
    /// <param name="SketchAndFeatureDimensions">Optional input Boolean that specifies whether to get the retrievable sketch and feature dimensions. This defaults to True. If not specified or this is set to True, the retrievable sketch constraint objects or their proxies that derive from DimensionConstraint, FeatureDimension objects or FeatureDimensionProxy objects will be returned. If this is set to False, the retrievable 3D annotation objects and their proxy objects will be returned.</param>
    /// <param name="ModelObject">Optional input object from the model referenced by the drawing view that specifies a filter for this method.  If specified, only the annotations related to this object will be returned.  Valid inputs include PlanarSketch, any of the objects that derive from PartFeature, ComponentOccurrence and the proxies to all these objects.  If not specified, all the valid annotations for the input view are returned.</param>
    /// <param name="DesignView">Optional input String value that specifies a design view of the model document to get the retrievable 3D annotation objects. If SketchAndFeatureDimensions is set to True this will be ignored. If SketchAndFeatureDimensions  is set to False and ModelObject is provided then this is ignored also. If not provided the default design view will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection GetRetrievableAnnotations([In] [MarshalAs(UnmanagedType.Interface)] DrawingView View, [In] [MarshalAs(UnmanagedType.Struct)] object? SketchAndFeatureDimensions = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ModelObject = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DesignView = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ObjectNameKey">ObjectNameKey</param>
    [PreserveSig]
    void _SelectByONK([In] [MarshalAs(UnmanagedType.BStr)] string ObjectNameKey);
}
