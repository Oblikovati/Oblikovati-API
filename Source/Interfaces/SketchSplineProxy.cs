namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface SketchSplineProxy
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
    /// Property that returns the parent sketch of the entity.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the object this entity is dependent on. When sketch entities are created by projecting model edges or intersecting the model, the resulting entities are driven by the original model entities and cannot be modified.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Property that returns a collection of sketch constraints that are tied directly to this entity. This collection consists of both geometric and dimension constraints.
    /// </summary>
    SketchConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Gets and sets whether this entity is a reference entity or not. It is only valid to set this property to False.
    /// </summary>
    bool Reference { get; set; }
    /// <summary>
    /// Gets and sets whether the entity behaves as a construction entity or not.
    /// </summary>
    bool Construction { get; set; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets and sets whether specific user actions are blocked on this sketch geometry.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Read-only property that returns the constraint status of the sketch.&nbsp;Possible return values are kFullyConstrainedConstraintStatus, kOverConstrainedConstraintStatus, kUnderConstrainedConstraintStatus, and kUnknownConstraintStatus.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Gets and sets the layer applied to this sketch entity.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    /// <summary>
    /// Indicates entity or entities that own this object.
    /// </summary>
    SketchEntitiesEnumerator OwnedBy { get; }
    /// <summary>
    /// Gets and sets whether this entity is visible only when editing the sketch.
    /// </summary>
    bool SketchOnly { get; set; }
    /// <summary>
    /// Property that returns the sketch block that contains this object. This is the same SketchBlock returned as the last item in the SketchBlockPath property. This property returns Nothing if this object does not belong to a sketch block and lives directly under a sketch.
    /// </summary>
    SketchBlock ContainingSketchBlock { get; }
    /// <summary>
    /// Property that returns the path of sketch blocks at the leaf of which this sketch object is found. The enumerator returns a count of 0 if the object lives directly under a sketch.
    /// </summary>
    SketchBlocksEnumerator SketchBlockPath { get; }
    /// <summary>
    /// Property that returns a geometry object. The object returned represents a snapshot view of the current state of the sketch spline.
    /// </summary>
    BSplineCurve2d Geometry { get; }
    /// <summary>
    /// Double property that returns the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Property that returns the number of fit points for the spline.
    /// </summary>
    int FitPointCount { get; }
    /// <summary>
    /// Property that returns the SketchPoint at the specified index. The indices correspond to the fit points in order from the start to the end of the spline. An Index of 1 returns the first SketchPoint. The FitPointCount property returns the total number of fits points for the spline.
    /// </summary>
    SketchPoint FitPoint { get; }
    /// <summary>
    /// Specifies whether the curve is closed.&nbsp;Setting a curve to be closed will cause it to close and be periodic.
    /// </summary>
    bool Closed { get; set; }
    /// <summary>
    /// Specifies whether curvature information is displayed for the spline.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Specifies the fit method for the spline.
    /// </summary>
    SplineFitMethodEnum FitMethod { get; set; }
    /// <summary>
    /// Property that gets the that defines the position of the end of the spline.
    /// </summary>
    SketchPoint EndSketchPoint { get; }
    /// <summary>
    /// Property that returns the that defines the position of the start of the line.
    /// </summary>
    SketchPoint StartSketchPoint { get; }
    /// <summary>
    /// Gets and sets the tension for the spline.
    /// </summary>
    int Tension { get; set; }
    /// <summary>
    /// Gets and sets the color applied to this sketch spline.
    /// </summary>
    Color OverrideColor { get; set; }
    /// <summary>
    /// Gets and sets the LineType applied to this sketch spline.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the LineWeight applied to this sketch spline.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the LineScale applied to this sketch spline.
    /// </summary>
    double LineScale { get; set; }
    /// <summary>
    /// Gets and sets the LineDefinitionSpace applied to this sketch spline.
    /// </summary>
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    /// <summary>
    /// Read-only property that returns the BSplineCurve geometry that represents this sketch spline in model space.
    /// </summary>
    BSplineCurve Geometry3d { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SketchSpline NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the sketch entity. This method will fail in the case where this object was created as a result of a derived part. The HasReferenceComponent property can be used to determine when this is the case.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that inserts a new fit point into the spline.
    /// </summary>
    /// <param name="FitPoint">Input object that specifies the position of the new fit point. This can be either a SketchPoint or Point2d object. In the case where a Point2d object is input, a SketchPoint will be created at that location.</param>
    /// <param name="TargetIndex">Input Long that specifies the existing fit point to insert the new fit point next to.</param>
    /// <param name="InsertBefore">Input Boolean indicating if the fit point should be inserted before or after the target index.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchPoint InsertFitPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object FitPoint, [In] int? TargetIndex = default, [In] bool? InsertBefore = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">OInput string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists.  If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Method that returns whether the handle at a given fit point is enabled or disabled.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint object that specifies the fit point at which to get the handle status.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetHandleStatus([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint FitPoint);
    /// <summary>
    /// Method that sets whether the handle at a given fit point is enabled or disabled.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint object that specifies the fit point at which to set the handle status.</param>
    /// <param name="Value">Input Boolean that specifies whether the handle at the input fit point is enabled or disabled.</param>
    [PreserveSig]
    void SetHandleStatus([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint FitPoint, [In] bool Value);
    /// <summary>
    /// Method that returns the fit point handle at the given fit point. The method returns Nothing if the handle is not enabled at the input fit point.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint object that specifies the fit point at which to obtain the handle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchSplineHandle GetHandle([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint FitPoint);
}
