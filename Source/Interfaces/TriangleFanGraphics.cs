namespace Oblikovati.API;

/// <summary>
/// The TriangleFanGraphics object defines a set of connected triangles. The first three coordinates define a triangle and the next coordinate defines another triangle using two previous coordinates.
/// </summary>
public interface TriangleFanGraphics
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
    /// Gets and sets the GraphicsCoordinateSet associated with the set.
    /// </summary>
    GraphicsCoordinateSet CoordinateSet { get; set; }
    /// <summary>
    /// Get and sets the GraphicsIndexSet that defines the indices within the coordinate set to use for the triangles of the set.
    /// </summary>
    GraphicsIndexSet CoordinateIndexSet { get; set; }
    /// <summary>
    /// Gets and sets the GraphicsNormalSet associated with the set.
    /// </summary>
    GraphicsNormalSet NormalSet { get; set; }
    /// <summary>
    /// Gets and sets the GraphicsIndexSet that defines the indices within the normal set to use for the triangles of the set.
    /// </summary>
    GraphicsIndexSet NormalIndexSet { get; set; }
    /// <summary>
    /// Gets and sets how the normals are defined for the triangles.
    /// </summary>
    NormalBindingEnum NormalBinding { get; set; }
    /// <summary>
    /// Gets and sets the GraphicsColorSet associated with the set.
    /// </summary>
    GraphicsColorSet ColorSet { get; set; }
    /// <summary>
    /// Gets and sets the GraphicsIndexSet that defines the indices within the GraphicsColorSet to use.
    /// </summary>
    GraphicsIndexSet ColorIndexSet { get; set; }
    /// <summary>
    /// Gets and sets how the colors are defined for the triangle.
    /// </summary>
    ColorBindingEnum ColorBinding { get; set; }
    /// <summary>
    /// Read-write property that allows you to specify a priority to a set.
    /// </summary>
    int DepthPriority { get; set; }
    /// <summary>
    /// Read-write property that specifies whether or not graphics are always visible even if they are blocked by other object.
    /// </summary>
    bool BurnThrough { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the GraphicsColorMapper object associated with the set.
    /// </summary>
    GraphicsColorMapper ColorMapper { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the GraphicsCoordinateIndexSet that defines the indices within the texture coordinate set to use for the triangles of the set.
    /// </summary>
    GraphicsIndexSet TextureCoordinateIndexSet { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the GraphicsCoordinateSet associated with the set.
    /// </summary>
    GraphicsTextureCoordinateSet TextureCoordinateSet { get; set; }
    /// <summary>
    /// Gets and sets how the back face culling are defined for the triangles.
    /// </summary>
    BackFaceCullingEnum BackFaceCulling { get; set; }
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
    /// <param name="StripLengths">StripLengths</param>
    [PreserveSig]
    void GetStripLengths([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] StripLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StripLengths">StripLengths</param>
    [PreserveSig]
    void PutStripLengths([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] StripLengths);
    /// <summary>
    /// Sets the view transformation settings (e.g. pixel scaling and front facing).
    /// </summary>
    /// <param name="Anchor">Input <link Inventor::Point, Point> that indicates which point is unaffected by the transform behavior.</param>
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
