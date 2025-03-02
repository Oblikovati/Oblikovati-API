namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface SketchEquationCurveProxy
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
    /// Specifies whether curvature information is displayed for the spline.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Read-only property that returns the sketch point that defines the position of the end of the spline.
    /// </summary>
    SketchPoint EndSketchPoint { get; }
    /// <summary>
    /// Read-only property that retruns a BSplineCurve2d geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the spline.
    /// </summary>
    BSplineCurve2d Geometry { get; }
    /// <summary>
    /// Read-only property that returns b-spline geometry that represents this spline in model space.
    /// </summary>
    BSplineCurve Geometry3d { get; }
    /// <summary>
    /// Gets the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Gets and sets the LineDefinitionSpace applied to this sketch spline.
    /// </summary>
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    /// <summary>
    /// Gets and sets the LineScale applied to this sketch spline.
    /// </summary>
    double LineScale { get; set; }
    /// <summary>
    /// Gets and sets the LineType applied to this sketch spline.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the LineWeight applied to this sketch spline.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the color applied to this sketch spline.
    /// </summary>
    Color OverrideColor { get; set; }
    /// <summary>
    /// Gets the sketch point that defines the position of the start of the elliptical arc.
    /// </summary>
    SketchPoint StartSketchPoint { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SketchEquationCurve NativeObject { get; }
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EquationType">EquationType</param>
    /// <param name="CoordinateSystemType">CoordinateSystemType</param>
    /// <param name="XValueOrRadius">XValueOrRadius</param>
    /// <param name="YValueOrTheta">YValueOrTheta</param>
    /// <param name="MinValue">MinValue</param>
    /// <param name="MaxValue">MaxValue</param>
    [PreserveSig]
    void GetEquation([Out] out CurveEquationTypeEnum EquationType, [Out] out CoordinateSystemTypeEnum CoordinateSystemType, [Out] [MarshalAs(UnmanagedType.BStr)] out string XValueOrRadius, [Out] [MarshalAs(UnmanagedType.BStr)] out string YValueOrTheta, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter MinValue, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter MaxValue);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">OInput string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists.  If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Method that returns edits the information of the curve.&nbsp;You can use the GetEquation method to get the current equation values.
    /// </summary>
    /// <param name="EquationType">Enum value indicating if the equation is parametric or explicit.</param>
    /// <param name="CoordinateSystemType">Enum value indicating if the coordinate system being used is Cartesian or Polar.</param>
    /// <param name="XValueOrRadius">Expression that defines the equation for the X value when using a Cartesian coordinate system and the radius when using a Polar coordinate system.</param>
    /// <param name="YValueOrTheta">Expression that defines the equation for the Y value when using a Cartesian coordinate system and the theta value (or angle from the X axis) when using a Polar coordinate system.</param>
    /// <param name="MinValue">Input Variant that defines the the minimum value of “t”. This can be either a numeric value or a string and is assigned to the associated parameter. If a string is input, the resulting equation must be unitless.</param>
    /// <param name="MaxValue">Input Variant that defines the the maximum value of “t”. This can be either a numeric value or a string and is assigned to the associated parameter. If a string is input, the resulting equation must be unitless.</param>
    [PreserveSig]
    void SetEquation([In] CurveEquationTypeEnum EquationType, [In] CoordinateSystemTypeEnum CoordinateSystemType, [In] [MarshalAs(UnmanagedType.BStr)] string XValueOrRadius, [In] [MarshalAs(UnmanagedType.BStr)] string YValueOrTheta, [In] [MarshalAs(UnmanagedType.Struct)] object MinValue, [In] [MarshalAs(UnmanagedType.Struct)] object MaxValue);
}
