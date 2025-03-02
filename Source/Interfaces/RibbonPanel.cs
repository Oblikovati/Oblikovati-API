namespace Oblikovati.API;

/// <summary>
/// A RibbonPanel object represents a panel within a ribbon tab.
/// </summary>
public interface RibbonPanel
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent RibbonTab object.
    /// </summary>
    RibbonTab Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the display name of the ribbon panel.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the unique internal name of the ribbon panel.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the CommandControls collection object that provides access to all the visible controls within the panel.
    /// </summary>
    CommandControls CommandControls { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Gets and sets whether the ribbon panel is currently visible in the ribbon. Note that this property applies only when the parent ribbon tab and the ribbon within which the tab lives are currently active.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets sets whether the ribbon panel docked within the ribbon.
    /// </summary>
    bool Docked { get; set; }
    /// <summary>
    /// Property that returns the CommandControls collection object that provides access to all controls in the slideout section of the panel.
    /// </summary>
    CommandControls SlideoutControls { get; }
    /// <summary>
    /// Gets and sets the keyboard access key for the slideout controls within the panel.
    /// </summary>
    string SlideOutKeyTip { get; set; }
    /// <summary>
    /// Method that deletes the RibbonPanel.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that moves the RibbonPanel to a new location within the ribbon tab.
    /// </summary>
    /// <param name="TargetPanelInternalName">Input String that specifies the \internal name of an existing panel to reposition the panel next to. The InsertBeforeTargetPanel argument indicates whether to reposition the panel before or after the target panel.</param>
    /// <param name="InsertBeforeTargetPanel">Input Boolean that specifies whether to reposition the panel before or after the target ribbon panel.</param>
    [PreserveSig]
    void Reposition([In] [MarshalAs(UnmanagedType.BStr)] string TargetPanelInternalName, [In] bool InsertBeforeTargetPanel);
    /// <summary>
    /// Method that moves the ribbon panel. If the panel is docked, calling this method automatically undocks the panel and honors the input values.
    /// </summary>
    /// <param name="Top">Input Long that specifies the distance between the top of the screen and top of the panel.</param>
    /// <param name="Left">Input Long that specifies the distance between the left edge of the screen and left edge of the panel.</param>
    [PreserveSig]
    void Move([In] int Top, [In] int Left);
}
