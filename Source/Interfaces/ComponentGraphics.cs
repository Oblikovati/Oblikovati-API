namespace Oblikovati.API;

/// <summary>
/// ComponentGraphics Object.
/// </summary>
public interface ComponentGraphics
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
    /// Read-only property that returns the SurfaceBody object associated with the SurfaceGraphics.
    /// </summary>
    SurfaceBody Body { get; }
    /// <summary>
    /// Read-write property that specifies whether or not graphics are always visible even if they are blocked by other objects.
    /// </summary>
    bool BurnThrough { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color associated with the primitive.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify a display priority to the graphics.&nbsp;This is used in the cases where entities are coincident.&nbsp;The entities with the higher priority will render on top of lower priority entities.
    /// </summary>
    int DepthPriority { get; set; }
    /// <summary>
    /// Read-write property that specifies whether or not to display the silhouette edges of bodies.&nbsp;The property defaults to True when the ComponentGraphics object is created.
    /// </summary>
    bool DisplaySilhouettes { get; set; }
    /// <summary>
    /// Read-only property that returns a SurfaceGraphicsEdgeList object. This list provides access to all edges that are currently displayed.
    /// </summary>
    SurfaceGraphicsEdgeList DisplayedEdges { get; }
    /// <summary>
    /// Read-only property that returns a SurfaceGraphicsFaceList object. This list provides access to all faces that are currently displayed.
    /// </summary>
    SurfaceGraphicsFaceList DisplayedFaces { get; }
    /// <summary>
    /// Read-write property that gets and sets the line type associated with the primitive.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the line scale applied to this primitive.
    /// </summary>
    double LineScale { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the line definition space for this primitive. This affects how the line weight and line scale are applied to the primitive. This defaults to kScreenSpace.
    /// </summary>
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the thickness of this primitive. If LineDefinitionSpace is set to kScreenSpace, this value is defined in pixels. If LineDefinitionSpace is set to kModelSpace, this value is defined in model units (centimeters).
    /// </summary>
    double LineWeight { get; set; }
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TextAnchor">TextAnchor</param>
    /// <param name="BehaviorType">BehaviorType</param>
    /// <param name="PixelScale">PixelScale</param>
    [PreserveSig]
    void GetTransformBehavior([Out] [MarshalAs(UnmanagedType.Interface)] out Point TextAnchor, [Out] out DisplayTransformBehaviorEnum BehaviorType, [Out] out double PixelScale);
    /// <summary>
    /// Method that sets the transform behavior of the graphic object. Graphic objects have two special transform behaviors: front facing and pixel scaling. A front facing object does not rotate as the view is rotated but maintains the same orientation on the screen. It is positioned at a specified location within model and its position on the screen will change as the view is zoomed in and out and scrolled, but its orientation will not change.
    /// 
    /// A graphic object that has pixel scaling behavior maintains the same size relative to the screen. As the user zooms in and out the graphic objects visible size on the screen will remain the same.
    /// Any graphic object can have no transform behavior which means it’s size, position, and orientation are relative to model space, front facing behavior, pixel scaling behavior, or front facing and pixel scaling behavior. By default an object has not transform behavior, with the exception of text. Text always has front facing behavior regardless of the behavior type set through this method.
    /// </summary>
    /// <param name="Anchor">Input Point object that specifies the anchor point of the graphic object in model space.  The coordinates of this point are always defined in model space.  The value of this argument is ignored when setting the behavior type to kNoTransformBehaviors.</param>
    /// <param name="BehaviorType">Input value from DisplayTransformBehaviorEnum that specifies the type of transform behavior the text has.  Valid values are kFrontFacing, kFrontFacingAndPixelScaling, kNoTransformBehaviors, and kPixelScaling.  TextGraphics objects are always front facing regardless of the defined behavior type.</param>
    /// <param name="PixelScale">Input Double that defines the scale factor to apply to all coordinates associated with this graphics object.  This scale factor is only used when the behavior type is kFrontFacingAndPixelScaling or kPixelScaling.</param>
    [PreserveSig]
    void SetTransformBehavior([In] [MarshalAs(UnmanagedType.Interface)] Point Anchor, [In] DisplayTransformBehaviorEnum BehaviorType, [In] double? PixelScale = default);
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
}
