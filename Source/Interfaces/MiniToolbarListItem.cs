namespace Oblikovati.API;

/// <summary>
/// The MiniToolbarListItem object represents an item in either a MiniToolBarComboBox or a MiniToolBarDropdown object.
/// </summary>
public interface MiniToolbarListItem
{
    /// <summary>
    /// Read-write property that specifies if this item can be deleted.&nbsp;This will always be false for a separator.
    /// </summary>
    bool AllowDelete { get; set; }
    /// <summary>
    /// Read-only property that specifies the position of this item within the list.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Read-only property that gets the internal name of this item.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that specifies if the check box beside this item is checked or not.
    /// </summary>
    bool IsChecked { get; set; }
    /// <summary>
    /// Read-only property that indicates if this control is a separator or not.
    /// </summary>
    bool IsSeperator { get; }
    /// <summary>
    /// Read-write property that gets and sets the visible text for this item.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the standard size icon for this item.
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the a check box is displayed beside this item.
    /// </summary>
    bool ShowCheckBox { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the standard size icon for this item.
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the tool tip text for this item.
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the control is enabled.&nbsp;This property defaults to True when the control is created.
    /// </summary>
    bool Enabled { get; set; }
}
