namespace Oblikovati.API;

/// <summary>
/// The ModelLeader represents the leader of a model leader note.
/// </summary>
public interface ModelLeader
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
    /// Read-only property that returns if a root node exists for this leader. If False, there are no leader segments associated with this leader and the RootNode property will return Nothing.
    /// </summary>
    bool HasRootNode { get; }
    /// <summary>
    /// Read-only property that returns the root node of this leader. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNode RootNode { get; }
    /// <summary>
    /// Read-only propertythat returns a flat collection of all the leaf nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNodesEnumerator AllLeafNodes { get; }
    /// <summary>
    /// Read-only that returns a flat collection of all the nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNodesEnumerator AllNodes { get; }
    /// <summary>
    /// Gets and sets the arrowhead type of the leader.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a leader branch with the input points. This is the equivalent of the 'Add Leader' command in the user interface. This method will succeed only if the HasRootNode property returns False (i.e. there are no existing leader segments). If there are existing leader segments, you should use the ModelLeaderNode.AddLeader method instead.
    /// </summary>
    /// <param name="Points">ObjectCollection containing a series of Point objects representing a leader branch originating at the drawing annotation or symbol. The first point indicates the position of the root node. The last item in the collection can be a GeometryIntent object indicating a geometry to attach the leader branch to. The ObjectCollection must contain at least two items, else the method will fail.  The points are projected onto the orientation plane.</param>
    [PreserveSig]
    void AddLeader([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Points);
}
