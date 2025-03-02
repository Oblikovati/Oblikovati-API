namespace Oblikovati.API;

/// <summary>
/// WebBrowserDialog Object.
/// </summary>
public interface WebBrowserDialog
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read-write property that gets and sets a bit-mask defining the disabled window states of this web browser dialog.
    /// </summary>
    WindowsSizeEnum DisabledWindowState { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the height of this web browser dialog.
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// Read-only property that returns the HWND of this web browser dialog.
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Read-only property that returns the internal name of the web browser dialog.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that gets and sets the left edge of this web browser dialog.
    /// </summary>
    int Left { get; set; }
    /// <summary>
    /// Read-only property that returns whether this dialog is modal dialog or not.
    /// </summary>
    bool Modal { get; }
    /// <summary>
    /// Read-write property that gets and sets the title of this web browser dialog.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the top edge of this web browser dialog.
    /// </summary>
    int Top { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of this web browser dialog.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that gets the WebBrowserDialogEvents object.
    /// </summary>
    WebBrowserDialogEvents WebBrowserDialogEvents { get; }
    /// <summary>
    /// Read-write property that gets and sets the width of this web browser dialog.
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the window state of this web browser dialog.
    /// </summary>
    WindowsSizeEnum WindowState { get; set; }
    /// <summary>
    /// Method that deletes this web browser dialog.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that moves this web browser dialog.
    /// </summary>
    /// <param name="Top">Input Long that specifies the distance between the top of the screen and top of the dialog.</param>
    /// <param name="Left">Input Long that specifies the distance between the left edge of the screen and left edge of the window.</param>
    /// <param name="Height">Input Long value that specifies the height of the dialog.</param>
    /// <param name="Width">Input Long value that specifies the width of the dialog.</param>
    [PreserveSig]
    void Move([In] int Top, [In] int Left, [In] int Height, [In] int Width);
    /// <summary>
    /// Method that navigates to a url in this web browser dialog.
    /// </summary>
    /// <param name="Url">Input String value that specifies the url to navigate to.</param>
    [PreserveSig]
    void Navigate([MarshalAs(UnmanagedType.BStr)] string Url);
    /// <summary>
    /// Method that refreshes the content in this web browser dialog.
    /// </summary>
    [PreserveSig]
    void Refresh();
}
