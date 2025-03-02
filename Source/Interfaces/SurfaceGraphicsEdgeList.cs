namespace Oblikovati.API;

/// <summary>
/// The SurfaceGraphicsEdgeList object contains a list of edges currently displayed by a SurfaceGraphics primitive and allows you to add edges to the list.
/// </summary>
public interface SurfaceGraphicsEdgeList : IEnumerable
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
    /// Property that returns the number of SurfaceGraphicsEdge objects in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns a SurfaeGraphicsEdge object.
    /// </summary>
    SurfaceGraphicsEdge Item { get; }
    /// <summary>
    /// Method that specifies additional edges to be displayed.
    /// </summary>
    /// <param name="Edges">Input object that defines the additional edges to display. This can be one of the following: Edge, Edge or a EdgeCollection object. The edges provided must belong to the SurfaceBody associated with the SurfaceGraphics, else an error will occur.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Edges);
    /// <summary>
    /// Method that removes a edge from the list. The edge will no longer be displayed.
    /// </summary>
    /// <param name="Index">Input Long that specifies the SurfaceGraphicsEdge to remove from the list.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that removes all the edges from the list. No edges will be displayed after the method is called.
    /// </summary>
    [PreserveSig]
    void Clear();
}
