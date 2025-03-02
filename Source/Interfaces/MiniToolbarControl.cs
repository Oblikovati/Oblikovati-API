namespace Oblikovati.API;

/// <summary>
/// The MiniToolbarControl object is the base class for all controls within a MiniToolbar.
/// </summary>
public interface MiniToolbarControl
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    MiniToolbar Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the control should be automatically hidden when the user moves the cursor away from the MiniToolbar.
    /// </summary>
    bool AutoHide { get; set; }
    /// <summary>
    /// Read-only property that returns the control type.
    /// </summary>
    MiniToolbarControlTypeEnum ControlType { get; }
    /// <summary>
    /// Read-write property that gets and sets the display name for the control.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the control is enabled.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Read-only property that returns a string uniquely identifying this control within the toolbar.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that gets and sets the large icon for the control.
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the standard (small) icon for the control.
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the tooltip text for the control.
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the control is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns the index this control is currently positioned at within the mini toolbar.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Method that deletes the control.
    /// </summary>
    [PreserveSig]
    void Delete();
}
