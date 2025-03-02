namespace Oblikovati.API;

/// <summary>
/// WebView Object.
/// </summary>
public interface WebView
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read-write property that gets and set the caption of web view.
    /// </summary>
    string Caption { get; set; }
    /// <summary>
    /// Gets either control identifier or the internal identifier depending on whether this browser pane is a ActiveX control identifier or an Inventor tree browser.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that gets and sets the height of the web view.
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the width of the web view.
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Returns the HWND.
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Read-write property that gets and sets the left edge of the web view window.
    /// </summary>
    int Left { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the top of the web view window.
    /// </summary>
    int Top { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the web view window state.
    /// </summary>
    WindowsSizeEnum WindowState { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of this web view.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the icon of the web view.
    /// </summary>
    IPictureDisp Icon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ViewTab ViewTab { get; }
    /// <summary>
    /// Method that makes this web view the active one.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that close the web view.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that moves this web view window.
    /// </summary>
    [PreserveSig]
    void Move([In] int Top, [In] int Left, [In] int Height, [In] int Width);
    /// <summary>
    /// Method that start an action onto the web view.
    /// </summary>
    [PreserveSig]
    void StartAction([In] [MarshalAs(UnmanagedType.BStr)] string ActionType, [In] [MarshalAs(UnmanagedType.Struct)] object? ActionData = default);
    /// <summary>
    /// Method that navigates to the url in the web view.
    /// </summary>
    [PreserveSig]
    void Navigate([MarshalAs(UnmanagedType.BStr)] string Url);
}
