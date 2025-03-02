namespace Oblikovati.API;

/// <summary>
/// The SurfaceGraphicsVertexList object contains a list of vertices currently displayed by a SurfaceGraphics primitive and allows you to add vertices to the list.
/// </summary>
public interface SurfaceGraphicsVertexList : IEnumerable
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
    /// Read-only property that returns the number of SurfaceGraphicsVertex objects in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns a SurfaeGraphicsVertex object.
    /// </summary>
    SurfaceGraphicsVertex Item { get; }
    /// <summary>
    /// Method that specifies additional vertices to be displayed.
    /// </summary>
    /// <param name="Vertex">Input object that defines the additional vertices to display. This can be one of the following: Vertex or ObjectCollection object.  The vertices provided must belong to the SurfaceBody associated with the SurfaceGraphics, else an error will occur.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Vertex);
    /// <summary>
    /// Method that remove a vertex from the Vertexlist. The vertex will no longer be displayed.
    /// </summary>
    /// <param name="Index">Input Long that specifies the SurfaceGraphicsVertex to remove from the list.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that removes all the vertices from the list. No vertices will be displayed after the method is called.
    /// </summary>
    [PreserveSig]
    void Clear();
}
