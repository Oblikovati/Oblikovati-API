namespace Oblikovati.API;

/// <summary>
/// The CornerRoundEdgeSet object represents a set of edges and an associated fillet radius.
/// </summary>
public interface CornerRoundEdgeSet
{
    /// <summary>
    /// Gets and sets the edges in this edge set.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Property that returns the parent CornerRoundDefinition of this CornerRoundEdgeSet object.
    /// </summary>
    CornerRoundDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the radius of a sheet metal corner round feature.
    /// </summary>
    object Radius { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
