namespace Oblikovati.API;

/// <summary>
/// The ModelLeaderNode represents the node in the leader of a model leader note.
/// </summary>
public interface ModelLeaderNode
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the parent of the leader.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the leader node location on the sheet.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Gets and sets the attached entity of the leaf leader node.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-only that returns the child nodes under this node. The count will return 0 if the node is a leaf node.
    /// </summary>
    ModelLeaderNodesEnumerator ChildNodes { get; }
    /// <summary>
    /// Method that deletes this leader node, optionally retaining any dependent nodes.
    /// </summary>
    /// <param name="RetainDependentNodes">Input optional value that specifies if the any dependent nodes should also be deleted.  Defaults to deleting all dependent nodes.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependentNodes = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a leader branch with the input points. This is the equivalent of the 'Add Leader' command in the user interface. This method will succeed only if the HasRootNode property returns False (i.e. there are no existing leader segments). If there are existing leader segments, you should use the ModelLeaderNode.AddLeader method instead.
    /// </summary>
    /// <param name="Points">ObjectCollection containing a series of Point objects representing a leader branch originating at the drawing annotation or symbol. The first point indicates the position of the root node. The last item in the collection can be a GeometryIntent object indicating a geometry to attach the leader branch to. The ObjectCollection must contain at least two items, else the method will fail.  The points are projected onto the orientation plane.</param>
    [PreserveSig]
    void AddLeader([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Points);
    /// <summary>
    /// Method that adds a leader node at the specified position between two existing leader nodes. This is the equivalent of the 'Add Vertex' command in the user interface. This method does not apply for leaf nodes.
    /// </summary>
    /// <param name="ChildNode">LeaderNode object that specifies a child node of this node. The new node will be inserted between these two nodes. If the input node is not an immediate child, an error will occur.</param>
    /// <param name="Position">Point object that specifies the position of the node to add. The method fails if the input position is not on the leader segment connecting the two leader nodes.  The point is projected onto the orientation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelLeaderNode InsertNode([In] [MarshalAs(UnmanagedType.Interface)] ModelLeaderNode ChildNode, [In] [MarshalAs(UnmanagedType.Interface)] Point Position);
}
