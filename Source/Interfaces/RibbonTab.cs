namespace Oblikovati.API;

/// <summary>
/// A RibbonTab object represents a tab within a ribbon.
/// </summary>
public interface RibbonTab
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Ribbon object.
    /// </summary>
    Ribbon Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the display name of the ribbon tab.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the unique internal name of the ribbon tab.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the RibbonPanels collection object.
    /// </summary>
    RibbonPanels RibbonPanels { get; }
    /// <summary>
    /// Gets and sets whether this tab is currently active. Setting this property returns an error if the parent ribbon is not active.
    /// </summary>
    bool Active { get; set; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Gets and sets whether the ribbon tab is currently visible in the ribbon. Note that this property applies only when the parent ribbon is active.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets and sets whether this tab is contextual.
    /// </summary>
    bool Contextual { get; set; }
    /// <summary>
    /// Gets and sets the keyboard access key for the tab.
    /// </summary>
    string KeyTip { get; set; }
    /// <summary>
    /// Method that deletes the RibbonTab.
    /// </summary>
    [PreserveSig]
    void Delete();
}
