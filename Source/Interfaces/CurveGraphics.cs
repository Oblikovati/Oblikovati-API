namespace Oblikovati.API;

/// <summary>
/// The CurveGraphics object defines a graphics object created using a transient curve.
/// </summary>
public interface CurveGraphics
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    GraphicsNode Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that indicates whether this graphics primitive is anchored in view space. This property can only be set to False. The Anchored property is automatically set to True by the SetViewSpaceAnchor method.
    /// </summary>
    bool Anchored { get; }
    /// <summary>
    /// Read-only property that returns the Id of the object.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Gets and sets curve associated with this primitive.
    /// </summary>
    object Curve { get; set; }
    /// <summary>
    /// Gets and sets color associated with this primitive.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify a display priority to the curve graphics.
    /// </summary>
    int DepthPriority { get; set; }
    /// <summary>
    /// Read-write property that specifies whether or not graphics are always visible even if they are blocked by other objects.
    /// </summary>
    bool BurnThrough { get; set; }
    /// <summary>
    /// Property that gets and sets the line type override. Setting the property to kDefaultLineType restores the default line type. If the property returns kCustomLineType, the GetCustomLineType method can be used to get further details about the line type.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the LineWeight applied to this curve graphics.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the LineScale applied to this curve graphics.
    /// </summary>
    double LineScale { get; set; }
    /// <summary>
    /// Gets and sets the LineDefinitionSpace applied to this curve graphics.
    /// </summary>
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    /// <summary>
    /// Property that returns the type of the underlying curve geometry that defines this curve.
    /// </summary>
    CurveTypeEnum CurveType { get; }
    /// <summary>
    /// Method that deletes the graphics primitive.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Origin">Origin</param>
    /// <param name="Anchor">Anchor</param>
    /// <param name="AnchorRelativeTo">AnchorRelativeTo</param>
    [PreserveSig]
    void GetViewSpaceAnchor([Out] [MarshalAs(UnmanagedType.Interface)] out Point Origin, [Out] [MarshalAs(UnmanagedType.Interface)] out Point2d Anchor, [Out] out ViewLayoutEnum AnchorRelativeTo);
    /// <summary>
    /// Method that anchors the graphics object at the specified point in view space. The Anchored property is set to True.
    /// </summary>
    /// <param name="Origin">Input that specifies the origin of the coordinate system.</param>
    /// <param name="Anchor">Input that indicates which point is unaffected by the transform behavior.</param>
    /// <param name="AnchorRelativeTo">Input constant indicating which corner of the view the anchor is relative to.</param>
    [PreserveSig]
    void SetViewSpaceAnchor([In] [MarshalAs(UnmanagedType.Interface)] Point Origin, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Anchor, [In] ViewLayoutEnum AnchorRelativeTo);
    /// <summary>
    /// The RemoveViewSpaceAnchor method removes the view space anchor from the object, and sets the Anchored property to false.
    /// </summary>
    [PreserveSig]
    void RemoveViewSpaceAnchor();
    /// <summary>
    /// Method that sets the transform behavior of the graphic object.
    /// </summary>
    /// <param name="Anchor">Input Point object that specifies the anchor point of the graphic object in model space. The coordinates of this point are always defined in model space. The value of this argument is ignored when setting the behavior type to kNoTransformBehaviors.</param>
    /// <param name="BehaviorType">Input value from DisplayTransformBehaviorEnum that specifies the type of transform behavior the text has. Valid values are kFrontFacing, kFrontFacingAndPixelScaling, kNoTransformBehaviors, and kPixelScaling. TextGraphics objects are always front facing regardless of the defined behavior type.</param>
    /// <param name="PixelScale">Input Double that defines the scale factor to apply to all coordinates associated with this graphics object. This scale factor is only used when the behavior type is kFrontFacingAndPixelScaling or kPixelScaling.</param>
    [PreserveSig]
    void SetTransformBehavior([In] [MarshalAs(UnmanagedType.Interface)] Point Anchor, [In] DisplayTransformBehaviorEnum BehaviorType, [In] double? PixelScale = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TextAnchor">TextAnchor</param>
    /// <param name="BehaviorType">BehaviorType</param>
    /// <param name="PixelScale">PixelScale</param>
    [PreserveSig]
    void GetTransformBehavior([Out] [MarshalAs(UnmanagedType.Interface)] out Point TextAnchor, [Out] out DisplayTransformBehaviorEnum BehaviorType, [Out] out double PixelScale);
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
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
