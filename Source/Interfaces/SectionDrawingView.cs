namespace Oblikovati.API;

/// <summary>
/// The SectionDrawingView object represents a section view within a drawing. See the article in the overviews section.
/// </summary>
public interface SectionDrawingView
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returning the parent Sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property returning an DrawingViewTypeEnum constant indicating the type of view.
    /// </summary>
    DrawingViewTypeEnum ViewType { get; }
    /// <summary>
    /// Gets or sets the name of this View.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets the drawing view style.
    /// </summary>
    DrawingViewStyleEnum ViewStyle { get; set; }
    /// <summary>
    /// Gets or sets the Model-to-PaperSpace scale of this particular Drawing View.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Gets and sets the display center point of the drawing view on the owning sheet.
    /// </summary>
    Point2d Center { get; set; }
    /// <summary>
    /// Gets and sets the point used to position the drawing view on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that specifies the position of the top edge of the drawing view.
    /// </summary>
    double Top { get; }
    /// <summary>
    /// Property that returns the position of the left edge of the drawing view.
    /// </summary>
    double Left { get; }
    /// <summary>
    /// Property that specifies the height of the drawing view. The view height cannot be set but is defined by the contents of the view
    /// </summary>
    double Height { get; }
    /// <summary>
    /// Property that specifies the width of the drawing view. The view width cannot be set but is defined by the contents of the view.
    /// </summary>
    double Width { get; }
    /// <summary>
    /// Property that returns the associated DataIO object. This can be used in Apprentice to obtain an associated bitmap, if it exists.
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Property that returns if this view's graphics are also available as a bitmap as well. If a bitmap exists it can be retrieved using the DataIO object. This is only applicable within Apprentice.
    /// </summary>
    bool BitmapAvailable { get; }
    /// <summary>
    /// Property that returns a Camera object that defines the orientation of the model within the view.
    /// </summary>
    Camera Camera { get; }
    /// <summary>
    /// Property that returns the DrawingSketches collection object for the sheet. This object provides access to all of the sketches that have been created on the sheet and provides functionality to create new sketches.
    /// </summary>
    DrawingSketches Sketches { get; }
    /// <summary>
    /// Property that returns the model document referenced by this view.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Property that returns the transformation from drawing view coordinate space to the model space.
    /// </summary>
    Matrix DrawingViewToModelTransform { get; }
    /// <summary>
    /// Property that returns the transformation from drawing view coordinate space to the sheet space.
    /// </summary>
    Matrix DrawingViewToSheetTransform { get; }
    /// <summary>
    /// Property that returns the transformation from model space to the drawing view coordinate space.
    /// </summary>
    Matrix ModelToDrawingViewTransform { get; }
    /// <summary>
    /// Property that returns the transformation from model space to the sheet coordinate space.
    /// </summary>
    Matrix ModelToSheetTransform { get; }
    /// <summary>
    /// Property that returns the parent . This property returns Nothing in the case where no parent view exists.
    /// </summary>
    DrawingView ParentView { get; }
    /// <summary>
    /// Property that returns the transformation from sheet coordinate space to the model space.
    /// </summary>
    Matrix SheetToModelTransform { get; }
    /// <summary>
    /// Property that returns the transformation from sheet space to the drawing view coordinate space.
    /// </summary>
    Matrix SheetToDrawingViewTransform { get; }
    /// <summary>
    /// Property that returns the ClientGraphicsCollection object.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Property that returns the object for the drawing view.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Gets and sets whether the scale of the view derives from the parent view or not.
    /// </summary>
    bool ScaleFromBase { get; set; }
    /// <summary>
    /// Property that returns all the drawing curves within the drawing view optionally filtered to the input model object. This property returns Nothing for draft views.iew object represents a drawing view on a sheet.
    /// </summary>
    DrawingCurvesEnumerator DrawingCurves { get; }
    /// <summary>
    /// Gets and sets the name of the active Positional Representation for a drawing view of an assembly.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveDesignViewRepresentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveLevelOfDetailRepresentation { get; set; }
    /// <summary>
    /// Gets and sets the name of the active member for a drawing view of an iPart or an iAssembly.
    /// </summary>
    string ActiveMemberName { get; set; }
    /// <summary>
    /// Property that returns the object, which provides event notifcation. For example, view updates.
    /// </summary>
    DrawingViewEvents DrawingViewEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowScale { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowName { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to display the tangent edges on the drawing view.
    /// </summary>
    bool DisplayTangentEdges { get; set; }
    /// <summary>
    /// Property that returns whether the drawing view is up to date with respect to the model.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets or sets the Model-to-PaperSpace scale in string format of this particular Drawing View.
    /// </summary>
    string ScaleString { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the absolute rotation angle of the drawing view in radians. The value can either be positive (counter-clockwise rotation) or negative (clockwise rotation).
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Gets whether the drawing view is of a sheet metal flat pattern.
    /// </summary>
    bool IsFlatPatternView { get; }
    /// <summary>
    /// Read-write property that indicates the type of dimension.
    /// </summary>
    GeneralDimensionTypeEnum GeneralDimensionType { get; set; }
    /// <summary>
    /// Gets and sets whether this drawing view is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the DrawingViewLabel object.
    /// </summary>
    DrawingViewLabel Label { get; }
    /// <summary>
    /// Property that specifies whether the origin indicator for ordinate dimensions and hole tables has been created.
    /// </summary>
    bool HasOriginIndicator { get; }
    /// <summary>
    /// Property that gets the origin indicator for ordinate dimensions and hole tables.
    /// </summary>
    OriginIndicator OriginIndicator { get; }
    /// <summary>
    /// Gets and sets whether to show the label of the drawing view on the sheet.
    /// </summary>
    bool ShowLabel { get; set; }
    /// <summary>
    /// Property that returns the name of the active Presentation (Exploded) View for a drawing view of a presentation.
    /// </summary>
    string ActivePresentationView { get; }
    /// <summary>
    /// Gets and sets whether the view is aligned with another view.
    /// </summary>
    bool Aligned { get; set; }
    /// <summary>
    /// Property that returns drawing curve that the auxiliary view is aligned to. This property returns Nothing if this is not an auxiliary view or if the orientation edge (drawing curve) has been removed from the parent view during a subsequent update.
    /// </summary>
    DrawingCurve AuxiliaryOrientationEdge { get; }
    /// <summary>
    /// Gets and sets whether to display sheet metal bend extents on the drawing view.
    /// </summary>
    bool DisplayBendExtents { get; set; }
    /// <summary>
    /// Gets and sets whether to display detail circles, section lines and the associated text in the base view.
    /// </summary>
    bool DisplayDefinitionInBase { get; set; }
    /// <summary>
    /// Gets and sets whether to display hatches for section and slice views.
    /// </summary>
    bool DisplayHatching { get; set; }
    /// <summary>
    /// Gets and sets whether to display both hidden edges that are excluded due to an interference condition (press, or interference fit conditions, threaded fasteners in tapped holes where the hole feature is modeled with the minor diameter).
    /// </summary>
    bool DisplayInterferenceEdges { get; set; }
    /// <summary>
    /// Gets and sets whether to display shortened tangent edges in order to distinguish them from visible edges.
    /// </summary>
    bool DisplayForeshortenedTangentEdges { get; set; }
    /// <summary>
    /// Gets and sets whether to display thread features on the drawing view.
    /// </summary>
    bool DisplayThreadFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether to display trails.
    /// </summary>
    bool DisplayTrails { get; set; }
    /// <summary>
    /// Gets and sets whether the view should inherit the corresponding break from the parent view.
    /// </summary>
    bool InheritBreak { get; set; }
    /// <summary>
    /// Gets and sets whether the view should inherit the corresponding break out from the parent view.
    /// </summary>
    bool InheritBreakOut { get; set; }
    /// <summary>
    /// Gets and sets whether the view should inherit the corresponding section cut from the parent view.
    /// </summary>
    bool InheritSection { get; set; }
    /// <summary>
    /// Gets and sets whether the view should inherit the corresponding slice cut from the parent view.
    /// </summary>
    bool InheritSlice { get; set; }
    /// <summary>
    /// Gets and sets whether to associate the drawing view to the referenced presentation view.
    /// </summary>
    bool PresentationViewAssociative { get; set; }
    /// <summary>
    /// Gets and sets the sectioning behavior for standard parts in drawing views of assemblies.
    /// </summary>
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    /// <summary>
    /// Gets and sets the view justification.
    /// </summary>
    ViewJustificationEnum ViewJustification { get; set; }
    /// <summary>
    /// Property that returns the BreakOperations object containing information about all the break operations applied to this view as well as methods to add breaks. Both local as well as inherited break operations are returned in the collection.
    /// </summary>
    BreakOperations BreakOperations { get; }
    /// <summary>
    /// Property that returns the BreakOutOperations object containing information about all the break out operations applied to this view as well as methods to add break outs. Only local break out operations are returned.
    /// </summary>
    BreakOutOperations BreakOutOperations { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptor ReferencedFile { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Point2d _Center { get; set; }
    /// <summary>
    /// Gets and sets whether the view should inherit the orientation from the base view.
    /// </summary>
    bool ViewOrientationFromBase { get; set; }
    /// <summary>
    /// Indicates if the view has finished updating.
    /// </summary>
    bool IsUpdateComplete { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the drawing view is raster view or not.
    /// </summary>
    bool IsRasterView { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to include the mesh bodies.
    /// </summary>
    bool IncludeMeshBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to include the work surfaces.
    /// </summary>
    bool IncludeSurfaceBodies { get; set; }
    /// <summary>
    /// Read-only property that gets whether the DesignViewRepresentation for a drawing view of a model is associative or not.
    /// </summary>
    bool DesignViewAssociative { get; }
    /// <summary>
    /// Read-only property that returns the name of the Design View Representation for a drawing view of a model.
    /// </summary>
    string DesignViewRepresentation { get; }
    /// <summary>
    /// Read-only property that returns the DrawingViewHatchRegions collection object.
    /// </summary>
    DrawingViewHatchRegions HatchRegions { get; }
    /// <summary>
    /// Read-only property that gets the name of the active model state for a drawing view. This property returns a null string for drawing views of presentations and in the case where the model is unresolved.
    /// </summary>
    string ActiveModelState { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to include the 3D annotations.
    /// </summary>
    bool Include3DAnnotations { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the drawing view is specified as the text property source.This is applicable only when the drawing view is a base view.
    /// </summary>
    bool IsTextPropertySource { get; set; }
    /// <summary>
    /// Returns the collection of revision clouds on this drawing view.
    /// </summary>
    RevisionClouds RevisionClouds { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the hidden line are calculated for all bodies or reference data separately.
    /// </summary>
    bool HiddenLineCalculationForAllBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the reference data display style.
    /// </summary>
    ReferenceDataDisplayStyleEnum ReferenceDataDisplayStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the amount of area outside the normal view boundary that the view boundary extends.
    /// </summary>
    double Margin { get; set; }
    /// <summary>
    /// Property that indicates whether to show the entire section line or hide parts of it.
    /// </summary>
    bool ShowEntireLine { get; set; }
    /// <summary>
    /// Gets the object that contains the profile used to define the section line of the view.
    /// </summary>
    DrawingSketch SectionLineSketch { get; }
    /// <summary>
    /// Property that gets and sets whether to section all geometry beyond the cutting line. If set to False, the SectionDepth property specifies a distance of viewing beginning from the cutting line. Setting the SectionDepth property automatically toggles this property to False. This property does not apply (and setting it returns an error) if the SliceAllParts property is set to True.
    /// </summary>
    bool FullSectionDepth { get; set; }
    /// <summary>
    /// Property that gets and sets the section depth in centimeters. Setting this property automatically toggles the FullSectionDepth property to False. Setting the property to a value between 0 and 0.00003 sets the depth to the smallest available section depth value of 0.00003. This property does not apply (and setting it returns an error) if the SliceAllParts property is set to True.
    /// </summary>
    double SectionDepth { get; set; }
    /// <summary>
    /// Property that gets and sets whether some components are sliced and some components are sectioned, depending on their individual settings.
    /// </summary>
    bool IncludeSlice { get; set; }
    /// <summary>
    /// Property that gets and sets whether to override all individual settings and slice all components in the view according to the Section Line geometry. Components that are not crossed by the Section Line will not participate in the resulting view. Setting this property to True automatically toggles the IncludeSlice property to True. This property does not apply (and setting it returns an error) for drawing views of a part.
    /// </summary>
    bool SliceAllParts { get; set; }
    /// <summary>
    /// Property that gets and sets whether to use the projected or the aligned method.
    /// </summary>
    bool UseAlignedMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the cut edges are smooth or jogged.
    /// </summary>
    bool IsBreakLineSmooth { get; set; }
    /// <summary>
    /// Method that gets the hidden lines status of a component in the drawing view.
    /// </summary>
    /// <param name="Component">Input Document, ComponentOccurrence, ComponentOccurrenceProxy, SurfaceBody, SurfaceBodyProxy, MeshFeature or MeshFeatureProxy object to indicate a component in the drawing view.</param>
    /// <returns></returns>
    [PreserveSig]
    HiddenLinesStatusEnum GetHiddenLinesStatus([In] [MarshalAs(UnmanagedType.IDispatch)] object Component);
    /// <summary>
    /// Method that sets the hidden lines status of a component in the drawing view.
    /// </summary>
    /// <param name="Component">Input Document, ComponentOccurrence, ComponentOccurrenceProxy, SurfaceBody, SurfaceBodyProxy, MeshFeature or MeshFeatureProxy object to indicate a component in the drawing view.</param>
    /// <param name="visibleStatus">Input HiddenLinesStatusEnum value to specify the hidden line status for the component. Valid values are kAllHiddenLinesVisible and kAllHiddenLinesInvisible.</param>
    [PreserveSig]
    void SetHiddenLinesStatus([In] [MarshalAs(UnmanagedType.IDispatch)] object Component, [In] HiddenLinesStatusEnum visibleStatus);
    /// <summary>
    /// Method that sets the active model state for a drawing view. In this method users can also decide to update the PartsList objects which use the same model state as the drawing view. This method fails for drawing views where the model is unresolved.
    /// </summary>
    /// <param name="ModelState">Input String value that specifies the name of active model state to set for the drawing view.</param>
    /// <param name="UpdatePartsList">Optional input Boolean that specifies whether the PartsList objects in the document with the same model state as the drawing view should be updated or not.</param>
    /// <param name="KeepOverrides">Optional input Boolean that specifies whether to keep the overrides in the PartsList objects. This is ignored if the UpdatePartsLists is set to False.</param>
    [PreserveSig]
    void SetActiveModelState([In] [MarshalAs(UnmanagedType.BStr)] string ModelState, [In] bool? UpdatePartsList = true, [In] bool? KeepOverrides = true);
    /// <summary>
    /// Method that reverses the section line direction.
    /// </summary>
    [PreserveSig]
    void ReverseDirection();
    /// <summary>
    /// Method that deletes the DrawingView.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that moves this drawing view into the specified sheet. The moved object is returned.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet that this drawing view is to be moved into. An error occurs if the input sheet is the parent sheet object.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView MoveTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet);
    /// <summary>
    /// Method that copies this drawing view into the specified sheet. The new object is returned.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet that this drawing view is to be copied into. An error occurs if the input sheet is the parent sheet object.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet);
    /// <summary>
    /// Method that takes a 2d coordinate in drawing view space, and returns a Line in model space. Since this method transforms from 2D space to 3D space, there is insufficient information to obtain a 3D model point. Hence, this method returns a Line in the view direction on which the point lies. You may then use the FindUsingRay method to find the point(s) of interest.
    /// </summary>
    /// <param name="ViewCoordinate">Input Point2d object of a point within drawing view space.</param>
    /// <returns></returns>
    [PreserveSig]
    Line DrawingViewToModelSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewCoordinate);
    /// <summary>
    /// Method that takes a 2d coordinate in drawing view space, and returns a Point2d containing the coordinates of the point in sheet space.
    /// </summary>
    /// <param name="ViewCoordinate">Input Point2d object of a point within drawing view space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d DrawingViewToSheetSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewCoordinate);
    /// <summary>
    /// Method that takes a 3d coordinate in model space, and returns a Point2d object containing the coordinate point in drawing view space.
    /// </summary>
    /// <param name="ModelCoordinate">Input Point object of a point within model space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d ModelToDrawingViewSpace([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
    /// <summary>
    /// Method that takes a 3d coordinate in model space, and returns a Point2d object containing the coordinate point in sheet space.
    /// </summary>
    /// <param name="ModelCoordinate">Point object of a point within model space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d ModelToSheetSpace([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
    /// <summary>
    /// Method that takes a 2d coordinate in sheet space, and returns a Line in model space. Since this method transforms from 2D space to 3D space, there is insufficient information to obtain a 3D model point. Hence, this method returns a Line in the view direction on which the point lies. You may then use the FindUsingRay method to find the point(s) of interest.
    /// </summary>
    /// <param name="SheetCoordinate">Input Point2d object of a point within sheet space.</param>
    /// <returns></returns>
    [PreserveSig]
    Line SheetToModelSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d SheetCoordinate);
    /// <summary>
    /// Method that takes a 2d coordinate in sheet space, and returns a Point2d object containing the coordinate point in drawing view space.
    /// </summary>
    /// <param name="SheetCoordinate">Input Point2d object of a point within sheet space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d SheetToDrawingViewSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d SheetCoordinate);
    /// <summary>
    /// Method that rotates the drawing view by the specified angle.
    /// </summary>
    /// <param name="Angle">Input double that specifies the angle by which to rotate the view.</param>
    /// <param name="Clockwise">Optional input Boolean that specifies whether to rotate the view clockwise or counter-clockwise. The default value is True indicating that the view will be rotated clockwise.</param>
    [PreserveSig]
    void RotateByAngle([In] double Angle, [In] bool? Clockwise = true);
    /// <summary>
    /// Method that gets the visibility of the input object in the drawing view.
    /// </summary>
    /// <param name="Object">Input object to get the visibility state of. Valid objects are 2d and 3d sketches, work features, surface features, occurrences and proxies for all of these. The object needs to be supplied in the context of the document referenced by the drawing view. For instance, to set the visibility state of a 3D sketch within a part instanced in an assembly (and the drawing view is of the assembly), the input should be a Sketch3DProxy object created in context of the assembly. An error will occur if no corresponding object exists in the drawing view.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetVisibility([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Method that sets the visibility of the input object in the drawing view.
    /// </summary>
    /// <param name="Object">Input object to set the visibility state of. Valid objects are 2d and 3d sketches, work features, surface features, occurrences and proxies for all of these. The object needs to be supplied in the context of the document referenced by the drawing view. For instance, to set the visibility state of a 3D sketch within a part instanced in an assembly (and the drawing view is of the assembly), the input should be a Sketch3DProxy object created in context of the assembly. An error will occur if no corresponding object exists in the drawing view.</param>
    /// <param name="Visible">Input Boolean that specifies whether the input object is visible in the drawing view.</param>
    [PreserveSig]
    void SetVisibility([In] [MarshalAs(UnmanagedType.IDispatch)] object Object, [In] bool Visible);
    /// <summary>
    /// Method that gets the include status of the input object in the drawing view.
    /// </summary>
    /// <param name="Object">Input object to get the include status of. Valid objects are 2d and 3d sketches, work features, surface features, and proxies for all of these. The object needs to be supplied in the context of the document referenced by the drawing view. For instance, to set the include status of a 3D sketch within a part instanced in an assembly (and the drawing view is of the assembly), the input should be a Sketch3DProxy object created in context of the assembly. An error will occur if no corresponding object exists in the drawing view.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetIncludeStatus([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Method that sets the include status of the input object in the drawing view. This method automatically makes the object visible as well. After an object has been included, its visibility can be controlled using the GetVisibility and SetVisibility methods.
    /// </summary>
    /// <param name="Object">Input object to set the include status of. Valid objects are 2d and 3d sketches, work features, surface features, and proxies for all of these. The object needs to be supplied in the context of the document referenced by the drawing view. For instance, to set the include status of a 3D sketch within a part instanced in an assembly (and the drawing view is of the assembly), the input should be a Sketch3DProxy object created in context of the assembly. An error will occur if no corresponding object exists in the drawing view.</param>
    /// <param name="Include">Input Boolean that specifies whether the input object is included in the drawing view.</param>
    [PreserveSig]
    void SetIncludeStatus([In] [MarshalAs(UnmanagedType.IDispatch)] object Object, [In] bool Include);
    /// <summary>
    /// Method that displays all the curves explicitly hidden by the user.
    /// </summary>
    [PreserveSig]
    void ShowHiddenCurves();
    /// <summary>
    /// Method that displays all the annotations hidden by the user.
    /// </summary>
    [PreserveSig]
    void ShowHiddenAnnotations();
    /// <summary>
    /// Method that sets a design view representation for a drawing view of an assembly. This method fails for drawing views of parts and presentations and in the case where the model (assembly) is unresolved.
    /// </summary>
    /// <param name="Representation">String that specifies the Design View Representation to set on the drawing view. The method returns a failure if a representation with this name is not found in the referenced assembly.</param>
    /// <param name="Associative">Optional input Boolean that indicates whether to associatively apply the design view. If set to True, any changes to the design view in the referenced assembly will show in this view. If not specified, a value of False is used.</param>
    [PreserveSig]
    void SetDesignViewRepresentation([In] [MarshalAs(UnmanagedType.BStr)] string Representation, [In] bool? Associative = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that creates the origin indicator for ordinate dimensions and hole tables. The specified input GeometryIntent object must be associated with this drawing view, otherwise this method will fail.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that specifies the origin point with which the origin indicator is associated. The GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. Valid intent values are points. If an invalid intent value is specified, this method will fail.</param>
    [PreserveSig]
    void CreateOriginIndicator([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent);
    /// <summary>
    /// Method that aligns this view with the input drawing view. The method returns a failure if the view is already aligned. Use the Aligned property to check for this condition and to break existing alignment.
    /// </summary>
    /// <param name="DrawingView">Input DrawingView object that specifies the view with which to align this view.</param>
    /// <param name="AlignmentType">Input DrawingViewAlignmentEnum that specifies the alignment type. Valid values are kHorizontalViewAlignment, kVerticalViewAlignment and kInPositionViewAlignment.</param>
    [PreserveSig]
    void Align([In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] DrawingViewAlignmentEnum AlignmentType);
    /// <summary>
    /// Method that re-aligns an auxiliary view. The method fails if the view is not an auxiliary view.
    /// </summary>
    /// <param name="DrawingCurve">Input DrawingCurve object that specifies the orientation edge for the auxiliary view. This must be from the parent view, else the method returns an error.</param>
    /// <param name="Position">Input Point2d object that specifies the new placement point for the auxiliary view on the sheet.</param>
    [PreserveSig]
    void AlignAuxiliary([In] [MarshalAs(UnmanagedType.Interface)] DrawingCurve DrawingCurve, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WeldmentState">WeldmentState</param>
    /// <param name="Component">Component</param>
    [PreserveSig]
    void GetWeldmentState([Out] out WeldmentStateEnum WeldmentState, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Component);
    /// <summary>
    /// Method that sets the weldment option for the drawing view. The method returns a failure if the referenced model does not contain weldments.
    /// </summary>
    /// <param name="WeldmentState">Input WeldmentStateEnum that specifies the weldment state of the drawing view. Valid options are kAssemblyWeldmentState, kMachiningWeldmentState, kWeldsWeldmentState and kPreparationsWeldmentState. If kPreparationsWeldmentState is specified, the Component argument must also be specified, else the top level weldment document is assumed as the component.</param>
    /// <param name="Component">Optional input object that specifies the component to use for the Preparations weldment state. Valid input objects include an AssemblyDocument that represents the top level weldment document or a ComponentOccurrence that represents a first level occurrence in the weldment document.</param>
    [PreserveSig]
    void SetWeldmentState([In] WeldmentStateEnum WeldmentState, [In] [MarshalAs(UnmanagedType.Struct)] object? Component = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AutomatedCenterlineSettings">AutomatedCenterlineSettings</param>
    [PreserveSig]
    void GetAutomatedCenterlineSettings([Out] [MarshalAs(UnmanagedType.Interface)] out AutomatedCenterlineSettings AutomatedCenterlineSettings);
    /// <summary>
    /// Method that sets the automatic centerline and center mark settings for this view and creates the centerlines and center marks defined by the settings. The centerlines and center marks that were created are returned.
    /// </summary>
    /// <param name="AutomatedCenterlineSettings">Optional input AutomatedCenterlineSettings object that defines the automatic center line and center mark creation settings for this drawing view.
    /// If this argument is omitted the following rules apply. If automated centerlines and center marks have not been created for this view then this argument will default to the settings defined by the drawing settings. If this view has had automatic centerlines and center marks created, then the values used for the previous created are used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator SetAutomatedCenterlineSettings([In] [MarshalAs(UnmanagedType.Struct)] object? AutomatedCenterlineSettings = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Update();
    /// <summary>
    /// Inserts the view geometry into model space only if the drawing lives in an Oblikovati DWG file.
    /// </summary>
    [PreserveSig]
    void InsertInModelSpace();
}
