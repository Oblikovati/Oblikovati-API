namespace Oblikovati.API;

/// <summary>
/// The ModelHoleThreadNoteDefinition provides access to all of the information that defines a hole or thread note.
/// </summary>
public interface ModelHoleThreadNoteDefinition
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
    /// Read-only property that returns the parent model annotation that the definition is associated with.&nbsp;This property will return Nothing in the case where the definition is not associated with any annotation.&nbsp;This is the case when it’s been created using one of the create definition methods and when it’s been copied from another definition object.
    /// </summary>
    ModelAnnotation Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the geometry associated with the hole or thread note.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fully formatted string that defines the contents of the hole or thread text.
    /// The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the defaults specified in the dimension style. You can use the XML tags to override the default style and apply style overrides for all or portions of the text.
    /// The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override.
    /// </summary>
    string FormattedHoleThreadNote { get; set; }
    /// <summary>
    /// Read-write property that indicates if this note is for a hole or thread feature. Returns True if it is for a hole note. This is true even in the case where the hole is tapped and has threads. Returns False in the case where the note is for a thread feature. Th.
    /// </summary>
    bool IsHoleNote { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to set the hole note as tap drill type. This property only applies to tapped hole features. In other cases the value of this property should be ignored and setting it will fail.
    /// </summary>
    bool IsTapDrill { get; set; }
    /// <summary>
    /// Gets and sets whether to use the custom thread designation, as defined in the Thread.xls spreadsheet for thread notes.
    /// </summary>
    bool UseCustomThreadDesignation { get; set; }
    /// <summary>
    /// Gets and sets whether to use the default format for hole notes.
    /// </summary>
    bool UseDefaultFormat { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane for the hole or thread note. Will return nothing in case where the ModelHoleThreadNodeDefinition object is transient and not associated with a hole or thread note.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the hole or thread note.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of the arrowhead. This is a style override.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Read-only property that gets the text of the dimension.&nbsp;Properties on the returned ModelAnnotationText object can be edited to change the displayed text.
    /// </summary>
    ModelAnnotationText Text { get; }
    /// <summary>
    /// Read-write property that controls the position of the hole or thread note text.&nbsp;When being set, the input point will be projected onto the orientation plane.
    /// </summary>
    Point TextPosition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the landing position of the dimension. The point is projected onto the orientation plane.
    /// </summary>
    Point LandingPosition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use the format and tolerance information from parameters for hole note.
    /// This is only valid for notes to hole features and not notes to thread features. This can easily be determined by checking the value of IsHoleNote property. In other cases the value of this property should be ignored and setting it will fail.
    /// </summary>
    bool UseParameterTolerance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use the model measurement units for hole note.
    /// This is only valid for notes to hole features and not notes to thread features. This can easily be determined by checking the value of IsHoleNote property. In other cases the value of this property should be ignored and setting it will fail.
    /// </summary>
    bool UseModelUnits { get; set; }
    /// <summary>
    /// Gets and sets whether to show RH for right handed thread.
    /// </summary>
    bool RightHandedThread { get; set; }
    /// <summary>
    /// Method that creates a copy of this ModelHoleThreadNoteDefinition object. The new ModelHoleThreadNoteDefinition object is independent of any note. It can be edited and used as input to edit an existing note or to create a new note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelHoleThreadNoteDefinition Copy();
    /// <summary>
    /// Method that gets the tolerance for the specified hole property.
    /// </summary>
    /// <param name="HolePropEnum">Input HolePropertyEnum value the specifies which tolerance to return.
    /// Valid values are: kHoleDiameterHoleProperty, kHoleDepthHoleProperty, kCBoreDepthHoleProperty, kCBoreDiameterHoleProperty, kCSinkAngleHoleProperty, kCSinkDepthHoleProperty, kCSinkDiameterHoleProperty, kThreadDepthHoleProperty or kTapDrillDiameterHoleProperty.</param>
    /// <returns></returns>
    [PreserveSig]
    Tolerance GetHolePropertyTolerance([In] HolePropertyEnum HolePropEnum);
    /// <summary>
    /// Method that gets the tolerance precision for the specified hole property.
    /// </summary>
    /// <param name="HolePropEnum">Input HolePropertyEnum value the specifies which tolerance precision to return.
    /// Valid values are: kHoleDiameterHoleProperty, kHoleDepthHoleProperty, kCBoreDepthHoleProperty, kCBoreDiameterHoleProperty, kCSinkAngleHoleProperty, kCSinkDepthHoleProperty, kCSinkDiameterHoleProperty, kThreadDepthHoleProperty or kTapDrillDiameterHoleProperty</param>
    /// <returns></returns>
    [PreserveSig]
    int GetHolePropertyTolerancePrecision([In] HolePropertyEnum HolePropEnum);
    /// <summary>
    /// Method that sets the tolerance precision for the specified hole property.
    /// </summary>
    /// <param name="HolePropEnum">Input HolePropertyEnum value the specifies which tolerance precision to return.
    /// Valid values are: kHoleDiameterHoleProperty, kHoleDepthHoleProperty, kCBoreDepthHoleProperty, kCBoreDiameterHoleProperty, kCSinkAngleHoleProperty, kCSinkDepthHoleProperty, kCSinkDiameterHoleProperty, kThreadDepthHoleProperty or kTapDrillDiameterHoleProperty.</param>
    /// <param name="Value">Input Long value the specifies the tolerance precision. Valid value range is from 0 to 8.</param>
    [PreserveSig]
    void SetHolePropertyTolerancePrecision([In] HolePropertyEnum HolePropEnum, [In] int Value);
    /// <summary>
    /// Method that returns the wheather a planer object is valid to be used as an annotation plane for this hole or thread note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool IsValidAnnotationPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object pPlane);
    /// <summary>
    /// Method that returns whether the tolerance for the specified hole property is enabled or not. This returns True if the hole property tolerance is enabled.
    /// </summary>
    /// <param name="HolePropEnum">Input HolePropertyEnum value the specifies the hole property type.
    /// Valid values are: kHoleDiameterHoleProperty, kHoleDepthHoleProperty, kCBoreDepthHoleProperty, kCBoreDiameterHoleProperty, kCSinkAngleHoleProperty, kCSinkDepthHoleProperty, kCSinkDiameterHoleProperty, kThreadDepthHoleProperty or kTapDrillDiameterHoleProperty</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetHolePropertyToleranceStatus([In] HolePropertyEnum HolePropEnum);
    /// <summary>
    /// Method that enables/disables the tolerance for the specified hole property.
    /// </summary>
    /// <param name="HolePropEnum">Input HolePropertyEnum value the specifies hole property type.
    /// Valid values are: kHoleDiameterHoleProperty, kHoleDepthHoleProperty, kCBoreDepthHoleProperty, kCBoreDiameterHoleProperty, kCSinkAngleHoleProperty, kCSinkDepthHoleProperty, kCSinkDiameterHoleProperty, kThreadDepthHoleProperty or kTapDrillDiameterHoleProperty.</param>
    /// <param name="Value">Input Boolean value the specifies the enabled  status of the hole property tolerance.</param>
    [PreserveSig]
    void SetHolePropertyToleranceStatus([In] HolePropertyEnum HolePropEnum, [In] bool Value);
}
