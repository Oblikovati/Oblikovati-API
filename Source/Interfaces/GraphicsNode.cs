namespace Oblikovati.API;

/// <summary>
/// The GraphicsNode object provides a logical grouping of Client graphics. It is the lowest level of detail the user will see when selecting objects.
/// </summary>
public interface GraphicsNode : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the object this graphics node belongs to.
    /// </summary>
    ClientGraphics Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of graphic primitive objects associated with this GraphicsNode object.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified graphic entity from the collection.
    /// </summary>
    GraphicsPrimitive Item { get; }
    /// <summary>
    /// Returns the specified GraphicsPrimitive from the collection using its Id as index.
    /// </summary>
    GraphicsPrimitive ItemById { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that returns the Id of the GraphicsNode.
    /// </summary>
    int Id { get; set; }
    /// <summary>
    /// Property that gets and sets the transformation of the GraphicsNode.
    /// </summary>
    Matrix Transformation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle RenderStyle { get; set; }
    /// <summary>
    /// Property that specifies whether the GraphicsNode object can be selected when the Select command is running in Inventor.
    /// </summary>
    bool Selectable { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the GraphicsNode is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this graphics node is visible when the containing object is not the active edit object. A value of True indicates that this node is visible only when the containing object is activated. The value of this property is ignored if the Visible property on GraphicsNode is False.
    /// </summary>
    bool VisibleInActiveEditObject { get; set; }
    /// <summary>
    /// Property that returns a object containing the Views that this graphics node is visible in. If there are no views in the list, the node is visible in all views. Views may be added or removed from the list. This property is ignored if the Visible property on GraphicsNode is False.
    /// </summary>
    ViewList VisibleInViews { get; }
    /// <summary>
    /// Specifies that the node is not considered when doing a view all.
    /// </summary>
    bool ExcludedFromViewAll { get; set; }
    /// <summary>
    /// Specifies that the node participates in slicing of client graphics.
    /// </summary>
    bool AllowSlicing { get; set; }
    /// <summary>
    /// Read-write Property that gets and sets display name of this graphics node.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-write Property that gets and sets transparency behavior of this graphics node in inactive mode.
    /// </summary>
    bool IsTransparentInPlaceEdit { get; set; }
    /// <summary>
    /// Override Opacity that controls the transparencty of the node.
    /// </summary>
    double OverrideOpacity { get; set; }
    /// <summary>
    /// Specifies that whether this graphics node will display a cap or not when sliced.
    /// </summary>
    bool AllowSliceCapping { get; set; }
    /// <summary>
    /// Gets and sets the appearance asset associated with the graphics node.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Method that creates a new LineGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LineGraphics AddLineGraphics();
    /// <summary>
    /// Method that creates a new LineStripGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LineStripGraphics AddLineStripGraphics();
    /// <summary>
    /// Method that creates a new PointGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PointGraphics AddPointGraphics();
    /// <summary>
    /// Method that creates a new TextGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TextGraphics AddTextGraphics();
    /// <summary>
    /// Method that creates a new (scalable) TextGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TextGraphics AddScalableTextGraphics();
    /// <summary>
    /// Method that creates a new TriangleFanGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TriangleFanGraphics AddTriangleFanGraphics();
    /// <summary>
    /// Method that creates a new TriangleGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TriangleGraphics AddTriangleGraphics();
    /// <summary>
    /// Method that creates a new TriangleStripGraphics graphic primitive.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TriangleStripGraphics AddTriangleStripGraphics();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PartFeature">PartFeature</param>
    [PreserveSig]
    FeatureGraphics AddFeatureGraphics([In] [MarshalAs(UnmanagedType.Interface)] PartFeature PartFeature);
    /// <summary>
    /// Method that creates a new CurveGraphics graphic primitive.
    /// </summary>
    /// <param name="Curve">Input object that defines the curve. This can be one of the following: LineSegment, Circle, Arc3d, EllipseFull, EllipticalArc, BSplineCurve and Polyline3d.</param>
    /// <returns></returns>
    [PreserveSig]
    CurveGraphics AddCurveGraphics([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve);
    /// <summary>
    /// Method that deletes the GraphicsNode. This also deletes all associated graphic primitives.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a copy of this . The copy has the same property values as the original, a duplicate of all of the graphics primitives, and the CustomRenderStyle has the same values. A new ID is generated for the copy.
    /// </summary>
    /// <param name="Transformation">Input that defines the transform for the copy.</param>
    /// <param name="NodeId">Input Long that specifies the identifier for the newly created node. This id needs to be unique with respect to all other object in this ClientGraphics object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsNode Copy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Transformation, [In] int NodeId);
    /// <summary>
    /// Method that creates a new SurfaceGraphics object based on the input surface(s).
    /// </summary>
    /// <param name="Surfaces">Input object that defines the surfaces. This can be one of the following: SurfaceBody, Face, Faces or a FaceCollection object. If a FaceCollection is provided, all the Face objects in the collection must belong to the same SurfaceBody, else an error will occur. Use the various body primitive creation methods on the TransientBRep object to create bodies for input to this method.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceGraphics AddSurfaceGraphics([In] [MarshalAs(UnmanagedType.IDispatch)] object Surfaces);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ApplyCapping">ApplyCapping</param>
    /// <param name="SlicingPlanes">SlicingPlanes</param>
    /// <param name="ThreeQuarterSection">ThreeQuarterSection</param>
    /// <param name="RenderStyle">RenderStyle</param>
    [PreserveSig]
    void SliceGraphics([In] bool ApplyCapping, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SlicingPlanes, [In] bool? ThreeQuarterSection = false, [In] [MarshalAs(UnmanagedType.Struct)] object? RenderStyle = default);
    /// <summary>
    /// Method that clears all the slicing applied to the graphics node.
    /// </summary>
    [PreserveSig]
    void ClearSlice();
    /// <summary>
    /// Method that creates a new ComponentGraphics object based on the input ComponentDefinition.
    /// </summary>
    /// <param name="ComponentDefinition">Input ComponentDefinition object (either from a part or an assembly) to create the graphics from.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentGraphics AddComponentGraphics([In] [MarshalAs(UnmanagedType.Interface)] ComponentDefinition ComponentDefinition);
}
