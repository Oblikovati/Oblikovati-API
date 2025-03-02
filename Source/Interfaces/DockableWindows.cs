namespace Oblikovati.API;

/// <summary>
/// The DockableWindows collection object provides access to all existing dockable windows and provides methods to create additional ones.
/// </summary>
public interface DockableWindows : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DockableWindow object from the collection.
    /// </summary>
    DockableWindow this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the DockableWindowsEvents object that hosts events related to dockable windows.
    /// </summary>
    DockableWindowsEvents Events { get; }
    /// <summary>
    /// Method that creates a new DockableWindow.&nbsp;The newly created DockableWindow is returned.&nbsp;The window is created invisible and is undocked.&nbsp;The window remains invisible until explicitly made visible by the creator of the window.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DockableWindow Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string Caption);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="Title">Title</param>
    [PreserveSig]
    WebBrowserDockableWindow AddWithWebBrowser([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string Title);
}
