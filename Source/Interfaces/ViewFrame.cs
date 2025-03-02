namespace Oblikovati.API;

/// <summary>
/// ViewFrame Object.
/// </summary>
public interface ViewFrame
{
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Read-only property returning kViewFrameObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the view tabs that are located in this view frame.
    /// </summary>
    ViewTabsEnumerator ViewTabs { get; }
    /// <summary>
    /// Read-only property that returns the ViewTabGroupsEnumerator collection object.
    /// </summary>
    ViewTabGroupsEnumerator ViewTabGroups { get; }
    /// <summary>
    /// Read-only property that returns whether this view frame is the default one.
    /// </summary>
    bool IsDefault { get; }
    /// <summary>
    /// Read-only property that returns the caption of this view frame.
    /// </summary>
    string Caption { get; }
    /// <summary>
    /// Read-only property that returns the distance between the top edge of the screen and top edge of the view frame.
    /// </summary>
    int Top { get; }
    /// <summary>
    /// Read-only property that returns the distance between the left edge of the screen and left edge of the view frame.
    /// </summary>
    int Left { get; }
    /// <summary>
    /// Read-write property that gets and sets the height of the view frame.
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the width of the view frame.
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the window state of this view frame.
    /// </summary>
    WindowsSizeEnum WindowState { get; set; }
    /// <summary>
    /// Method that tiles the views in the view frame window.
    /// </summary>
    [PreserveSig]
    void Arrange([In] ViewTileTypeEnum? Value = ViewTileTypeEnum.kArrangeViewTileType);
    /// <summary>
    /// Method that restores the previous layout for this view frame window.
    /// </summary>
    [PreserveSig]
    void RestorePreviousLayout();
    /// <summary>
    /// Method that closes this view frame.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that closes this view frame. Close a ViewFrame may cause documents to close, use the argument to specify the documents to save if necessary. This does nothing if try to close the default ViewFrame.
    /// </summary>
    /// <param name="SaveDocuments">Optional input Boolean value to specify whether to save the documents.</param>
    /// <param name="DocumentsToSave">Optional input ObjectCollection including the documents to save.  This is ignored if the SaveDocuments is specified as False. If the SaveDocuments is set to True and this is not specified then all the documents being closed in this ViewFrame will be saved.</param>
    [PreserveSig]
    void Close2([In] bool? SaveDocuments = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DocumentsToSave = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Top">Top</param>
    /// <param name="Left">Left</param>
    /// <param name="Height">Height</param>
    /// <param name="Width">Width</param>
    [PreserveSig]
    void Move([In] ref int Top, [In] ref int Left, [In] ref int Height, [In] ref int Width);
}
