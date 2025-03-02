namespace Oblikovati.API;

/// <summary>
/// The EdgeDefinitions collection provides access to existing EdgeDefinition objects and allows creation of new EdgeDefinition objects.
/// </summary>
public interface EdgeDefinitions : IEnumerable
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
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    EdgeDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new EdgeDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <param name="StartVertex">Optional input VertexDefinition object that defines the start of the edge.</param>
    /// <param name="EndVertex">Optional input VertexDefinition object that defines the end of the edge.</param>
    /// <param name="ModelSpaceCurve">Optional input transient geometry curve object that defines the shape of this edge using 3d geometry in model space. Valid input is Arc3d, BsplineCurve, Circle, EllipseFull, EllipticalArc, LineSegment and Polyline3D.</param>
    /// <param name="ParameterSpaceCurveOne">Optional input transient geometry curve object that defines the shape of this edge using 2d geometry in the parametric space of the surface defined by the FaceOne argument. Valid input is Arc2d, BsplineCurve2d, Circle2d, EllipseFull2d, EllipticalArc2d, LineSegment2d and Polyline2D.</param>
    /// <param name="FaceOne">Optional input FaceDefinition object that either defines the parametric space that the curve provided in ParameterSpaceCurveOne argument is defined within or it defines the first of two faces to be intersected to calculate the edge.</param>
    /// <param name="ParameterSpaceCurveTwo">Optional input transient geometry curve object that defines the shape of this edge using 2d geometry in the parametric space of the surface defined by the FaceOne argument. Valid input is Arc2d, BsplineCurve2d, Circle2d, EllipseFull2d, EllipticalArc2d, LineSegment2d and Polyline2D.</param>
    /// <param name="FaceTwo">Optional input FaceDefinition object that either defines the parametric space that the curve provided in ParameterSpaceCurveTwo argument is defined within or it defines the second of two faces to be intersected to calculate the edge.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeDefinition Add([In] [MarshalAs(UnmanagedType.Interface)] VertexDefinition StartVertex, [In] [MarshalAs(UnmanagedType.Interface)] VertexDefinition EndVertex, [In] [MarshalAs(UnmanagedType.Struct)] object? ModelSpaceCurve = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ParameterSpaceCurveOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? FaceOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ParameterSpaceCurveTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? FaceTwo = default);
}
