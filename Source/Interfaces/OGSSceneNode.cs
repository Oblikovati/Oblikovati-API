namespace Oblikovati.API;

/// <summary>
/// OGSSceneNode object.
/// </summary>
public interface OGSSceneNode
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// OGS scene node name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Get the render items.
    /// </summary>
    OGSRenderItemsEnumerator RenderItems { get; }
    /// <summary>
    /// Get the type of this scene node.
    /// </summary>
    OGSSceneNodeTypeEnum SceneNodeType { get; }
    /// <summary>
    /// Gets the transformation of this scene node.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Gets if the node is visible.
    /// </summary>
    bool Visible { get; }
    /// <summary>
    /// Gets the sub scene node if this node is an assembly node.
    /// </summary>
    OGSSceneNodesEnumerator SubSceneNodes { get; }
    /// <summary>
    /// Gets the document corresponding to this node.
    /// </summary>
    _Document Document { get; }
}
