namespace Oblikovati.API;

/// <summary>
/// surface graphics vertex object.
/// </summary>
public interface SurfaceGraphicsVertex
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the Vertex object associated with the SurfaceGraphicsVertex.
    /// </summary>
    Vertex Vertex { get; }
    /// <summary>
    /// Gets the index of the SurfaceGraphicsVertex object within the SurfaceGraphicsVertexList.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Read-only property that returns the parent SurfaceGraphics object.
    /// </summary>
    SurfaceGraphics Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that specifies whether the surface graphics vertex can be selected or not.
    /// </summary>
    bool Selectable { get; set; }
}
