namespace Oblikovati.API;

/// <summary>
/// The LeaderNode object represents a node in a leader.
/// </summary>
public interface LeaderNode
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
    /// Property that returns the parent of this leader node object. This could either be another LeaderNode object or the Leader object in case of a root node.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the leader node location on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets and sets the attached entity of the leaf leader node.
    /// </summary>
    GeometryIntent AttachedEntity { get; set; }
    /// <summary>
    /// Property that returns the children nodes under this node. The count will return 0 if the node is a leaf node.
    /// </summary>
    LeaderNodesEnumerator ChildNodes { get; }
    /// <summary>
    /// Method that deletes this leader node.
    /// </summary>
    /// <param name="RetainDependentNodes">Optional input Boolean that indicates whether to delete all the dependent nodes as well. If specified to be True, dependent nodes are not deleted. Instead, their ownership is transferred to the parent of this node. If not specified, the argument defaults to False, indicating that all dependent nodes will be deleted.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependentNodes = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a leader branch with the input points. This is the equivalent of the 'Add Leader' command in the user interface.
    /// </summary>
    /// <param name="Points">ObjectCollection containing a series of points representing a leader branch, that originates at the node that the branch is being attached to and terminates at the leaf of the branch. If the first point specified has the same position as the node that the branch is being attached to, then the first point is ignored. The last item in the collection can be a GeometryIntent object indicating a geometry to attach the leader branch to. The ObjectCollection must contain at least one item, else the method will fail.</param>
    [PreserveSig]
    void AddLeader([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Points);
    /// <summary>
    /// Method that adds a LeaderNode at the specified position between two existing leader nodes. This is the equivalent of the 'Add Vertex' command in the user interface. This method does not apply for leaf nodes.
    /// </summary>
    /// <param name="ChildNode">LeaderNode object that specifies a child node of this node. The new node will be inserted between these two nodes. If the input node is not an immediate child, an error will occur.</param>
    /// <param name="Position">Point2d object that specifies the position of the node to add. The method fails if the input position is not on the leader segment connecting the two leader nodes.</param>
    /// <returns></returns>
    [PreserveSig]
    LeaderNode InsertNode([In] [MarshalAs(UnmanagedType.Interface)] LeaderNode ChildNode, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position);
}
