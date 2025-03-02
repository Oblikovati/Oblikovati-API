namespace Oblikovati.API;

/// <summary>
/// The RadiusModelDimensionDefinition provides access to all of the information that defines a radius model dimension.  It is derived from the ModelDimensionDefinition object.
/// </summary>
public interface RadiusModelDimensionDefinition
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
    /// Read-write property that gets and sets whether this is an inspection dimension.&nbsp;Inspection dimensions are used during the quality control process. They are formatted specifically to indicate which dimensions must be checked before accepting a part. The dimens.
    /// </summary>
    bool IsInspectionDimension { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the model value is overridden for the dimension.&nbsp;Setting the OverrideModelValue property automatically toggles this property to True.
    /// </summary>
    bool IsModelValueOverridden { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to display the dimension value.
    /// </summary>
    bool IsValueHidden { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane for the dimension.&nbsp;Will return nothing in the case where the ModelDimensionDefinition object is transient and not associated with a dimension.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the dimension.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the display value for the dimension.
    /// </summary>
    double OverrideModelValue { get; set; }
    /// <summary>
    /// Read-only property that returns the parent model annotation that the definition is associated with.&nbsp;This property will return Nothing in the case where the definition is not associated with any annotation.&nbsp;This is the case when it’s been created using one of the create definition methods and when it’s been copied from another definition object.
    /// </summary>
    ModelDimension Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the number of decimal places displayed for this dimension. Values are truncated and rounded to the specified precision.&nbsp;Valid range of values is 0 to 8.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of decimal places displayed for this dimension tolerance. Values are truncated and rounded to the specified precision.&nbsp;Valid range of values is 0 to 8.
    /// </summary>
    int TolerancePrecision { get; set; }
    /// <summary>
    /// Read-only property that gets the text of the dimension.&nbsp;Properties on the returned ModelAnnotationText object can be edited to change the displayed text.
    /// </summary>
    ModelAnnotationText Text { get; }
    /// <summary>
    /// Read-write property that controls the position of the dimension text.&nbsp;When being set, the input point will be projected onto the orientation plane.
    /// </summary>
    Point TextPosition { get; set; }
    /// <summary>
    /// Read-only property that returns the Tolerance object associated with this dimension. Methods and properties on the returned Tolerance object can be used to add/edit tolerance information for the dimension.
    /// </summary>
    Tolerance Tolerance { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter PromoteParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of the first arrowhead. This is a style override.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometric entity associated with the dimension.&nbsp;For a radius dimension this must be a circular edge, circular sketch entity, or a cylindrical face.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the&nbsp;arrowhead is inside or not.
    /// </summary>
    bool IsArrowheadInside { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the leader starts from the center of the arc or the circle.
    /// </summary>
    bool IsLeaderFromCenter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the dimension is jogged.
    /// </summary>
    bool IsJogged { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the landing position of the dimension. The point is projected onto the orientation plane.
    /// </summary>
    Point LandingPosition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Shape">Shape</param>
    /// <param name="Label">Label</param>
    /// <param name="Rate">Rate</param>
    [PreserveSig]
    void GetInspectionDimensionData([Out] out InspectionDimensionShapeEnum Shape, [Out] [MarshalAs(UnmanagedType.BStr)] out string Label, [Out] [MarshalAs(UnmanagedType.BStr)] out string Rate);
    /// <summary>
    /// Method that sets the data associated with an inspection dimension. This method automatically sets the IsInspectionDimension property to True, if it isn’t already.
    /// </summary>
    /// <param name="Shape">Optional input InspectionDimensionShapeEnum that specifies the border shape surrounding the inspection dimension text.  Valid values are kNoInspectionBorder, kAngularEndsInspectionBorder and kRoundedEndsInspectionBorder.  If not specified, kNoInspectionBorder is used.</param>
    /// <param name="Label">Optional input string that specifies the text placed left of the dimension value.  The string can contain symbols specified using the StyleOverride tag.  For instance, it can contain “&lt;StyleOverride Font='AIGDT'&gt;m&lt;/StyleOverride&gt;” to specify <img src="..\images\CircleM.png">.</param>
    /// <param name="Rate">Optional input string that specifies the text  (typically a percentage value) placed to the right of the dimension value.  The string can contain symbols specified using the StyleOverride tag.  For instance, it can contain “&lt;StyleOverride Font='AIGDT'&gt;m&lt;/StyleOverride&gt;” to specify <img src="..\images\CircleM.png">.</param>
    [PreserveSig]
    void SetInspectionDimensionData([In] InspectionDimensionShapeEnum? Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, [In] [MarshalAs(UnmanagedType.BStr)] string? Label = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Rate = "");
    /// <summary>
    /// Method that returns the wheather a planer object is valid to be used as an annotation plane for this model dimension.
    /// </summary>
    /// <param name="pPlane">Input planar object to check if it can be an annotation plane for the model dimension. This can be a Face or WorkPlane object.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsValidAnnotationPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object pPlane);
    /// <summary>
    /// Method that creates a copy of this RadiusModelDimensionDefinition object. The new RadiusModelDimensionDefinition object is independent of any dimension. It can edited and used as input to edit an existing dimension or to create a new dimension.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RadiusModelDimensionDefinition Copy();
}
