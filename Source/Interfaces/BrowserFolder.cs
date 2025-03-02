namespace Oblikovati.API;

/// <summary>
/// The BrowserFolder object represents a folder in the browser.
/// </summary>
public interface BrowserFolder
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
    /// Property that returns the parent browser node for the folder.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the corresponding browser node for the folder. The contents of the folder (including sub-folders) can be accessed via the browser node.
    /// </summary>
    BrowserNode BrowserNode { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the folder.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether items can be added to and removed from the folder by the user. If set to False, the add/remove restriction applies to the user interface only - the contents of folder can still be modified via the API.
    /// </summary>
    bool AllowAddRemove { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the folder can be deleted by the user. If set to False, the delete restriction applies to the user interface only - the folder can still be deleted via the API.
    /// </summary>
    bool AllowDelete { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the folder can be renamed by the user. If set to False, the rename restriction applies to the user interface only - the folder can still be renamed via the API.
    /// </summary>
    bool AllowRename { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the folder can be reordered in the browser by the user. If set to False, the reorder restriction applies to the user interface only - the folder can still be reordered via the API.
    /// </summary>
    bool AllowReorder { get; set; }
    /// <summary>
    /// Read-only property that returns the unique internal name of the folder.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    BrowserFolderDisplayTypeEnum DisplayType { get; set; }
    /// <summary>
    /// Method that adds a node to the folder. The node is automatically reordered in the browser if required. If the node cannot be reordered as needed, the method returns an error.
    /// </summary>
    /// <param name="BrowserNode">Input BrowserNode object that specifies the object to be moved into the folder.</param>
    /// <param name="TargetNode">Optional input BrowserNode object that specifies the object within the folder adjacent to which the input node should be positioned. This node should be found directly under the folder, else the method returns an error. If not specified, the node is added to the top of the list in the folder.</param>
    /// <param name="Before">Optional input Boolean that specifies whether the input node should be moved before or after the target node. If not specified, the node is positioned after the target node. This argument is ignored if the TargetNode argument is not specified.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] BrowserNode BrowserNode, [In] [MarshalAs(UnmanagedType.Struct)] object? TargetNode = default, [In] bool? Before = false);
    /// <summary>
    /// Method that deletes the browser folder. The contents of the folder are retained and moved up one level in the browser.
    /// </summary>
    /// <param name="Reserved">Optional input Boolean reserved for future use. The value is currently ignored.</param>
    [PreserveSig]
    void Delete([In] bool? Reserved = true);
    /// <summary>
    /// Method that removes a node from the folder. The node is automatically reordered in the browser if required. If the node cannot be reordered as needed, the method returns an error.
    /// </summary>
    /// <param name="BrowserNode">Input BrowserNode object that specifies the object to be removed from the folder.</param>
    /// <param name="TargetNode">Optional input BrowserNode object that specifies the object outside the folder adjacent to which the input node should be positioned. If not specified, the node is positioned adjacent to the folder (either before or after).</param>
    /// <param name="Before">Optional input Boolean that specifies whether the input node should be moved before or after the target node. If not specified, the node is positioned after the target node.</param>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Interface)] BrowserNode BrowserNode, [In] [MarshalAs(UnmanagedType.Struct)] object? TargetNode = default, [In] bool? Before = false);
    /// <summary>
    /// Method that moves the end of part before or after the folder. The method only applies for first level folders in part documents and first level folders in the features portion of the browser in assembly documents. The method returns an error for all other folders.
    /// </summary>
    /// <param name="Before">Input Boolean that specifies whether to move the end of part before or after the folder. True for before.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
