namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface VertexDefinition
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
    /// Gets and sets the associate ID of this vertex.&nbsp;This ID will be transferred to the corresponding vertex when this SurfaceBodyDefinition is used to create a SurfaceBody.&nbsp;It is used by Inventor as the identifier for the vertex and is used for tracking this geom.
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Gets and sets the defined location of the vertex.
    /// </summary>
    Point Position { get; set; }
}
