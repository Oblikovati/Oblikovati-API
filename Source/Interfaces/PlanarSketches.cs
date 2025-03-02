namespace Oblikovati.API;

/// <summary>
/// The PlanarSketches collection object provides access to all of the objects and provides methods to create additional PlanarSketch objects. See the article in the overviews section.
/// </summary>
public interface PlanarSketches : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PlanarSketch Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new sketch based on the input planar entity.
    /// </summary>
    /// <param name="PlanarEntity">Input object that defines the planar object the sketch is to be built on. Valid input for this argument includes planar faces and work planes.</param>
    /// <param name="UseFaceEdges">Optional input Boolean that specifies if sketch geometry should automatically be created for all of the edges of the input face. This is the behavior when creating a sketch interactively in Autodesk Inventor. This argument is ignored in the case when PlanarEntity is a work plane. The default value of False specifies that no sketch geometry should automatically be created from the face edges.</param>
    /// <returns></returns>
    [PreserveSig]
    PlanarSketch Add([In] [MarshalAs(UnmanagedType.IDispatch)] object PlanarEntity, [In] bool? UseFaceEdges = false);
    /// <summary>
    /// Method that creates a new sketch based on the input planar entity and orientation information.
    /// </summary>
    /// <param name="PlanarEntity">Input object that defines the planar object the sketch is to be built on. Valid input for this argument includes planar faces and work planes.</param>
    /// <param name="AxisEntity">Input object that defines the X or Y axis of the sketch plane (the AxisIsX argument defines which). Valid input includes linear edges, sketch lines from another sketch, and work axes.</param>
    /// <param name="NaturalAxisDirection">Input Boolean that defines if the sketch plane X or Y axis is in the same direction as that defined by the input axis entity. True indicates the axis direction is in the same direction as that of the input entity.</param>
    /// <param name="AxisIsX">Input Boolean that specifies if the axis entity defines the X or Y axis. True indicates the axis defines the X-axis.</param>
    /// <param name="Origin">Input object that defines the origin of the sketch plane. Valid input is a vertex, work point, or a sketch point from another sketch.</param>
    /// <param name="UseFaceEdges">Optional input Boolean that specifies if sketch geometry should automatically be created for all of the edges of the input face. This is the behavior when creating a sketch interactively in Autodesk Inventor. This argument is ignored in the case when PlanarEntity is a work plane. The default value of False specifies that no sketch geometry should automatically be created from the face edges.</param>
    /// <returns></returns>
    [PreserveSig]
    PlanarSketch AddWithOrientation([In] [MarshalAs(UnmanagedType.IDispatch)] object PlanarEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool NaturalAxisDirection, [In] bool AxisIsX, [In] [MarshalAs(UnmanagedType.IDispatch)] object Origin, [In] bool? UseFaceEdges = false);
}
