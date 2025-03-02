namespace Oblikovati.API;

/// <summary>
/// The PointGraphics object defines a set of points. Each coordinate provided defines a point.
/// </summary>
public interface PointGraphics
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
    /// Gets and sets the GraphicsCoordinateSet associate with set.
    /// </summary>
    GraphicsCoordinateSet CoordinateSet { get; set; }
    /// <summary>
    /// Gets and sets the GraphicsIndexSet that defines indices within the coordinate set to use for the point of the set.
    /// </summary>
    GraphicsIndexSet CoordinateIndexSet { get; set; }
    /// <summary>
    /// Gets and sets the point style associated with the PointGraphics object.
    /// </summary>
    PointRenderStyleEnum PointRenderStyle { get; set; }
    /// <summary>
    /// Read-write property that allows you specify a priority to a set.
    /// </summary>
    int DepthPriority { get; set; }
    /// <summary>
    /// Read-write property that specifies whether or not graphics are always visible even if they are blocked by other objects.
    /// </summary>
    bool BurnThrough { get; set; }
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
    /// <param name="GraphicsImageSet">GraphicsImageSet</param>
    /// <param name="GraphicsImageIndex">GraphicsImageIndex</param>
    [PreserveSig]
    void GetCustomImage([Out] [MarshalAs(UnmanagedType.Interface)] out GraphicsImageSet GraphicsImageSet, [Out] out int GraphicsImageIndex);
    /// <summary>
    /// Method that sets the custom image to use for this PointGraphics object. This is cause the PointerRenderStyleProperty to return kCustomImagePointStyle. You can remove the custom image by setting the PointRenderStyle to one of the predefined point types.
    /// </summary>
    /// <param name="GraphicsImageSet">Input GraphicsImageSet to assign to this PointGraphics object.</param>
    /// <param name="GraphicsImageIndex">Input Long that indicates which image in the GraphicsImageSet to use for this PointGraphics object.</param>
    [PreserveSig]
    void SetCustomImage([In] [MarshalAs(UnmanagedType.Interface)] GraphicsImageSet GraphicsImageSet, [In] int GraphicsImageIndex);
}
