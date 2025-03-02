namespace Oblikovati.API;

/// <summary>
/// The TextGraphics object defines a set of text strings that are displayed within the model. Each coordinate provided defines a new TextGraphics object. For each coordinate you must also provide a text string.
/// </summary>
public interface TextGraphics
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
    /// Gets and sets the text displayed for the TextGraphics object.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify a priority for a set.
    /// </summary>
    int DepthPriority { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify the horizontal justification of the text with respect to the coordinate point for the text.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalAlignment { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify the vertical justification of the text with respect to the coordinate point for the text.
    /// </summary>
    VerticalTextAlignmentEnum VerticalAlignment { get; set; }
    /// <summary>
    /// Gets and sets the position of the text.
    /// </summary>
    Point Anchor { get; set; }
    /// <summary>
    /// Gets and sets whether the text has bold formatting or not.
    /// </summary>
    bool Bold { get; set; }
    /// <summary>
    /// Gets and sets whether the text has italic formatting or not.
    /// </summary>
    bool Italic { get; set; }
    /// <summary>
    /// Gets and sets the font used for the text.
    /// </summary>
    string Font { get; set; }
    /// <summary>
    /// Gets/sets the font size. The font size is defined in pixels for non-scalable text graphics objects. It is defined in model space units for scalable text graphics objects.
    /// </summary>
    double FontSize { get; set; }
    /// <summary>
    /// Property that returns whether the TextGraphics object is scalable. If True, the FontSize property can be set a double value indicating its size in model space units.
    /// </summary>
    bool Scalable { get; }
    /// <summary>
    /// Read-write property that specifies whether or not graphics are always visible even if they are blocked by other objects.
    /// </summary>
    bool BurnThrough { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _FontSize { get; set; }
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
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetTextColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the color of the text.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">The blue component of the color. A Byte value between 0 and 255.</param>
    [PreserveSig]
    void PutTextColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Sets the view transformation settings (e.g. pixel scaling and front facing).
    /// </summary>
    /// <param name="Anchor">Input that indicates which point is unaffected by the transform behavior.</param>
    /// <param name="BehaviorType">Input DisplayTransformBehaviorEnum that specifies which transform behaviors are to be used.</param>
    /// <param name="PixelScale">Input Double that indicates how many pixels should be used to draw one model unit when pixel scaling is used.</param>
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
}
