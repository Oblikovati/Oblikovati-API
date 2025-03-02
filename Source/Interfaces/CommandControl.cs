namespace Oblikovati.API;

/// <summary>
/// A CommandControl object represents a user interface control (button, combobox, split button, etc.).
/// </summary>
public interface CommandControl
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the parent object. This can either be a RibbonPanel object if the control resides within a panel, or the UserInterfaceManager object if the control resides elsewhere (Quick Access Toolbar, etc.).
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the display name of the control.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the unique internal name of the control.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns a CommandControls collection object that provides access to the child controls of this control.
    /// </summary>
    CommandControls ChildControls { get; }
    /// <summary>
    /// Property that returns the ControlDefinition associated with this control.
    /// </summary>
    ControlDefinition ControlDefinition { get; }
    /// <summary>
    /// Property that returns the control type.
    /// </summary>
    ControlTypeEnum ControlType { get; }
    /// <summary>
    /// Gets and sets the current ControlDefinition object for kButtonPopupControl, kPopupControl, kSplitButtonMRUControl and kSplitButtonControl control types. For other control types, this property returns Nothing.
    /// </summary>
    ControlDefinition DisplayedControl { get; set; }
    /// <summary>
    /// Gets and sets whether to display the text (display name) associated with the control.&nbsp;The 'Ribbon Appearance' user choice overrides this setting.
    /// </summary>
    bool ShowText { get; set; }
    /// <summary>
    /// Gets and sets whether to display the control in the larger size. The 'Ribbon Appearance' user choice overrides this setting.
    /// </summary>
    bool UseLargeIcon { get; set; }
    /// <summary>
    /// Gets and sets whether this control is currently visible in the ribbon.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets and sets the keyboard access key for the control.
    /// </summary>
    string KeyTip { get; set; }
    /// <summary>
    /// Method that deletes the CommandControl. This simply removes the control from the panel, but does not delete the underlying ControlDefinition(s).
    /// </summary>
    [PreserveSig]
    void Delete();
}
