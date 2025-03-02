namespace Oblikovati.API;

/// <summary>
/// The Leader object represents a leader associated with a drawing annotation.
/// </summary>
public interface Leader
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
    /// Property that returns the parent of this leader object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns if a root node exists for this leader. If False, there are no leader segments associated with this leader and the RootNode property will return Nothing.
    /// </summary>
    bool HasRootNode { get; }
    /// <summary>
    /// Property that returns the root node of this leader. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    LeaderNode RootNode { get; }
    /// <summary>
    /// Property that returns a flat collection of all the leaf nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    LeaderNodesEnumerator AllLeafNodes { get; }
    /// <summary>
    /// Property that returns a flat collection of all the nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    LeaderNodesEnumerator AllNodes { get; }
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a leader branch with the input points. This is the equivalent of the 'Add Leader' command in the user interface. This method will succeed only if the HasRootNode property returns False (i.e. there are no existing leader segments). If there are existing leader segments, this method will fail you should use the LeaderNode.AddLeader method instead.
    /// </summary>
    /// <param name="Points">ObjectCollection containing a series of Point2d objects representing a leader branch originating at the drawing annotation or symbol. The first point indicates the position of the root node. The last item in the collection can be a GeometryIntent object indicating a geometry to attach the leader branch to. The ObjectCollection must contain at least two items, else the method will fail.</param>
    [PreserveSig]
    void AddLeader([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Points);
}
