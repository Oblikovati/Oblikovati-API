namespace Oblikovati.API;

/// <summary>
/// The BrowserNode object represents a node in the browser.
/// </summary>
public interface BrowserNode
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the BrowserNode object. This may either be another BrowserNode or a BrowserPane.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns a object which defines the various inputs that were used to create the browser node.
    /// </summary>
    BrowserNodeDefinition BrowserNodeDefinition { get; }
    /// <summary>
    /// Property that returns a collection of the top level BrowserNode objects contained under this node.
    /// </summary>
    BrowserNodesEnumerator BrowserNodes { get; }
    /// <summary>
    /// Specifies the BrowserNode object is expanded.
    /// </summary>
    bool Expanded { get; set; }
    /// <summary>
    /// Property that returns whether the object is selected or not.
    /// </summary>
    bool Selected { get; }
    /// <summary>
    /// Gets and sets whether the browser node is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets the fully qualified label of the BrowserNode.
    /// </summary>
    string FullPath { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool OverrideNativeGraying { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    object NativeObject { get; }
    /// <summary>
    /// Property that returns a collection of all browser folders contained directly under this node in the browser.
    /// </summary>
    BrowserFoldersEnumerator BrowserFolders { get; }
    /// <summary>
    /// Method that creates a new as a nested child of this one. The new BrowserNode is returned.
    /// </summary>
    /// <param name="Definition">Input object that specifies the input definition for the browser node.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserNode AddChild([In] [MarshalAs(UnmanagedType.Interface)] BrowserNodeDefinition Definition);
    /// <summary>
    /// Method that ensures the BrowserNode object is visible.
    /// </summary>
    [PreserveSig]
    void EnsureVisible();
    /// <summary>
    /// This method will simulate a mouse hover on the browser node.
    /// </summary>
    [PreserveSig]
    void DoPreSelect();
    /// <summary>
    /// This method will simulate a mouse click on the browser node.
    /// </summary>
    [PreserveSig]
    void DoSelect();
    /// <summary>
    /// Method that deletes the browser node. All of its child browser nodes are deleted as well. None of the corresponding browser node definitions nor the client node resources are deleted, however. This method will fail for built-in browser nodes.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns all browser nodes referencing the specified BrowserNodeDefinition below this BrowserNode. For instance, in the case of a shared sketch, two browser nodes reference the same definition.
    /// </summary>
    /// <param name="Definition">Input BrowserNodeDefinition object to get the referenced nodes for.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserNodesEnumerator AllReferencedNodes([In] [MarshalAs(UnmanagedType.Interface)] BrowserNodeDefinition Definition);
    /// <summary>
    /// Method that creates a new BrowserNode at the specified location. The new BrowserNode is returned.
    /// </summary>
    /// <param name="Definition">Input object that defines the input definition for the browser node.</param>
    /// <param name="TargetNode">Input BrowserNode object that specifies the node adjacent to which the new node should be inserted.</param>
    /// <param name="InsertBefore">Input Boolean that specifies whether the new node should be inserted before or after the target node.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserNode InsertChild([In] [MarshalAs(UnmanagedType.Interface)] BrowserNodeDefinition Definition, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNode TargetNode, [In] bool InsertBefore);
}
