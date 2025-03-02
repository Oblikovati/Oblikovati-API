namespace Oblikovati.API;

/// <summary>
/// WebBrowserDockableWindow Object.
/// </summary>
public interface WebBrowserDockableWindow
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. '{C9A6C580-3817-11D0-BE4E-080036E87B02}'.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Property that returns the control associated with the pane. This property returns Nothing if the pane contains a dialog and not a control.
    /// </summary>
    object Control { get; }
    /// <summary>
    /// Read-write property that gets and sets the bit-mask that specifies the docking positions to disallow.
    /// </summary>
    DockingStateEnum DisabledDockingStates { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DockingStateEnum DockingState { get; set; }
    /// <summary>
    /// Gets and sets the current height of the window.
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// Property that returns the handle of the dockable window.
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Property that returns the unique internal name of the window.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the distance between the left edge of the screen and left edge of the window.
    /// </summary>
    int Left { get; }
    /// <summary>
    /// Property that returns the parent UserInterfaceManager object.
    /// </summary>
    UserInterfaceManager Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets the caption of the window.
    /// </summary>
    string Caption { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowTitleBar { get; set; }
    /// <summary>
    /// Property that returns the distance between the top of the screen and top of the window.
    /// </summary>
    int Top { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the window is currently visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UserClosed { get; }
    /// <summary>
    /// Gets and sets the current width of the window.
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Property that returns whether size, position and docking states of this window have previously been customized and remembered by Inventor. If this property returns True, the size, position and docking states should not be initialized by the creating application so that the last known values are re-applied.
    /// </summary>
    bool IsCustomized { get; }
    /// <summary>
    /// Property that returns the button control automatically created by Inventor to control the visibility of the dockable window.
    /// </summary>
    ControlDefinition VisibilityControl { get; }
    /// <summary>
    /// Gets and sets whether to display the visibility check box in the User Interface dropdown in the View tab | Windows panel.
    /// </summary>
    bool ShowVisibilityCheckBox { get; set; }
    /// <summary>
    /// Gets and sets whether to disable close button.
    /// </summary>
    bool DisableCloseButton { get; set; }
    /// <summary>
    /// Method that adds a dialog or a control to the dockable window. Currently, you can only add a single child to a dockable window. So this method returns a failure if the dockable window already has a child. It is the responsibility of the client to destroy the dialog/control as and when appropriate.
    /// </summary>
    /// <param name="Identifier">Input Variant that specifies the dialog or control. This can either be the HWND of a dialog/window, or the ProgID of a control or the GUID of the control as a string (including the braces "{ }"). The ProgID/GUID can be that of an ActiveX or a .NET user control.</param>
    [PreserveSig]
    void AddChild([In] [MarshalAs(UnmanagedType.Struct)] object Identifier);
    /// <summary>
    /// Method that empties the contents of the dockable window (i.e. removes any children of the window). This does not destroy the child dialog/controls; it is the responsibility of the client to destroy them.
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Method that deletes the DockableWindow. This does not destroy the child dialog/controls; it is the responsibility of the client to destroy them.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SaveCurrentStates">SaveCurrentStates</param>
    [PreserveSig]
    void Delete2([In] bool? SaveCurrentStates = false);
    /// <summary>
    /// Method that repositions and resizes the window. If the window is docked, calling this method automatically undocks the window and honors the input values.
    /// </summary>
    /// <param name="Top">Input Long that specifies the distance between the top of the screen and top of the window.</param>
    /// <param name="Left">Input Long that specifies the distance between the left edge of the screen and left edge of the window.</param>
    /// <param name="Height">Input Long that specifies the height of the window.</param>
    /// <param name="Width">Input Long that specifies the width of the window.</param>
    [PreserveSig]
    void Move([In] int Top, [In] int Left, [In] int Height, [In] int Width);
    /// <summary>
    /// Method that sets the minimum size that the user can resize the window to.
    /// </summary>
    /// <param name="Height">Input Long that specifies the minimum height for the window.</param>
    /// <param name="Width">Input Long that specifies the minimum width for the window.</param>
    [PreserveSig]
    void SetMinimumSize([In] int Height, [In] int Width);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DockingState">DockingState</param>
    /// <param name="DockToObject">DockToObject</param>
    [PreserveSig]
    void GetDockingState([Out] out DockingStateEnum DockingState, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object DockToObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DockingState">DockingState</param>
    /// <param name="DockToObject">DockToObject</param>
    [PreserveSig]
    void SetDockingState([In] DockingStateEnum DockingState, [In] [MarshalAs(UnmanagedType.Struct)] object? DockToObject = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Url">Url</param>
    [PreserveSig]
    void Navigate([MarshalAs(UnmanagedType.BStr)] string Url);
}
