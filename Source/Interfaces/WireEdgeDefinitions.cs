namespace Oblikovati.API;

/// <summary>
/// Utility object used to create new WireEdgeDefinition objects.
/// </summary>
public interface WireEdgeDefinitions : IEnumerable
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
    /// Returns the specified WireEdgeDefinition object from the collection.
    /// </summary>
    WireEdgeDefinition this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Creates a new WireEdgeDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <param name="StartVertex">Input VertexDefinition object that defines the start of the edge.</param>
    /// <param name="EndVertex">Input VertexDefinition object that defines the end of the edge.</param>
    /// <param name="ModelSpaceCurve">Input transient geometry curve object that defines the shape of this edge using 3d geometry in model space.  Valid input is Arc3d, BsplineCurve, Circle, EllipseFull, EllipticalArc, LineSegment and Polyline3D.</param>
    /// <returns></returns>
    [PreserveSig]
    WireEdgeDefinition Add([In] [MarshalAs(UnmanagedType.Interface)] VertexDefinition StartVertex, [In] [MarshalAs(UnmanagedType.Interface)] VertexDefinition EndVertex, [In] [MarshalAs(UnmanagedType.IDispatch)] object ModelSpaceCurve);
}
