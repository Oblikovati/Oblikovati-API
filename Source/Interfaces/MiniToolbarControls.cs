namespace Oblikovati.API;

/// <summary>
/// The MiniToolbarControls object contains the controls within a minitoolbar and methods to create new controls.
/// </summary>
public interface MiniToolbarControls : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    MiniToolbarControl this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new button control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="DisplayName">Input String that specifies a display name for the control.  If this is specified to be a null string, the control does not display any text.</param>
    /// <param name="ToolTipText">Input String that specifies the tooltip text for the control.</param>
    /// <param name="StandardIcon">Optional input IPictureDisp that specifies the icon to use for the control.  A standard size icon is 16 pixels wide and 16 pixels high.</param>
    /// <param name="LargeIcon">Optional input IPictureDisp that specifies the icon to use for the control.  A standard size icon is 24 pixels wide and 24 pixels high.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarButton AddButton([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Method that creates a new check box control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="DisplayName">Input String that specifies a display name for the control.  If this is specified to be a null string, the control does not display any text.</param>
    /// <param name="ToolTipText">Input String that specifies the tooltip text for the control.</param>
    /// <param name="Checked">Input Boolean that specifies whether to initially display the control as checked.</param>
    /// <param name="StandardIcon">Optional input IPictureDisp that specifies the icon to use for the control.  A standard size icon is 16 pixels wide and 16 pixels high.</param>
    /// <param name="LargeIcon">Optional input IPictureDisp that specifies the large icon to use for the control.  A large size icon is 24 pixels wide and 24 pixels high.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarCheckBox AddCheckBox([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] bool Checked, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Method that creates a new dropdown control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="ShowIcon">Optional input Boolean that specifies whether the icon associated with the currently selected item should be displayed on the face of the control.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether the display name associated with the currently selected item should be displayed on the face of the control.</param>
    /// <param name="HasMRUBehavior">Specifies if this button displays the most recently selected item from the list.  When True, the item displayed on the button is the item last selected from the list.  If False, the text of the button is independent of the list.</param>
    /// <param name="IsSplitButton">Optional input Boolean that specifies whether this is a split button dropdown control.  If set to True, a separator is added between the currently selected item and the dropdown arrow within the control, and the currently selected item is clickable by the user.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarDropdown AddDropdown([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] bool? ShowIcon = true, [In] bool? ShowText = false, [In] bool? HasMRUBehavior = true, [In] bool? IsSplitButton = false);
    /// <summary>
    /// Method that creates a new combobox control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="ShowIcon">Optional input Boolean that specifies whether the icon associated with the currently selected item should be displayed on the face of the control.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether the text associated with the currently selected item should be displayed on the face of the control.</param>
    /// <param name="Width">Optional input Boolean that specifies whether the text associated with the currently selected item should be displayed on the face of the control.
    /// Note: The width and height of the dropdown area of the control are automatically calculated based on the contents.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarComboBox AddComboBox([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] bool? ShowIcon = false, [In] bool? ShowText = true, [In] int? Width = default);
    /// <summary>
    /// Method that creates a new label control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="Text">Input String that specifies a display name for the control.  If this is specified to be a null string, the control does not display any text.</param>
    /// <param name="ToolTipText">Input String that specifies the tooltip text for the control.</param>
    /// <param name="StandardIcon">Optional input IPictureDisp that specifies the icon to use for the control.  A standard size icon is 16 pixels wide and 16 pixels high.</param>
    /// <param name="LargeIcon">Optional input IPictureDisp that specifies the large icon to use for the control.  A large size icon is 24 pixels wide and 24 pixels high.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarControl AddLabel([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string Text, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Method that creates a new line within the MiniToolbar.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarControl AddNewLine();
    /// <summary>
    /// Method that creates a new separator within the MiniToolbar.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarControl AddSeparator();
    /// <summary>
    /// Method that creates a new value edit control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="ToolTipText">Input String that specifies the tooltip text for the control.</param>
    /// <param name="UnitsType">Input enum that specifies the units type for the value editor.</param>
    /// <param name="Expression">Input String that specifies the initial value to display in the value editor.</param>
    /// <param name="DisplayName">Input String that specifies the label text to display next to the value field.</param>
    /// <param name="Width">Optional input Long that specifies the width of the value editor in pixels. If not specified (or specified to be 0), an internal default width value is used.</param>
    /// <param name="StandardIcon">Optional input IPictureDisp that specifies the icon to use for the control.  A standard size icon is 16 pixels wide and 16 pixels high.</param>
    /// <param name="LargeIcon">Optional input IPictureDisp that specifies the large icon to use for the control.  A large size icon is 24 pixels wide and 24 pixels high.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarValueEditor AddValueEditor([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] ValueUnitsTypeEnum UnitsType, [In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.BStr)] string? DisplayName = "", [In] int? Width = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Method that creates a new slider control within the MiniToolbar.
    /// </summary>
    /// <param name="InternalName">Input String that specifies an internal name for the control.</param>
    /// <param name="DisplayName">Input String that specifies a display name for the control.  If this is specified to be a null string, the control does not display any text.</param>
    /// <param name="ToolTipText">Input String that specifies the tooltip text for the control.</param>
    /// <param name="ValueType">Input enum that specifies if the slider will handle integer or decimal numbers.  Valid values are kDoubleType or kIntegerType.</param>
    /// <param name="Maximum">Input Double that specifies the maximum value of the slider.  If the ValueType argument is kIntegerType then this value will be rounded to the nearest integer.</param>
    /// <param name="Minimum">Input Double that specifies the minimum value of the slider.  If the ValueType argument is kIntegerType then this value will be rounded to the nearest integer.</param>
    /// <param name="NumberOfTicks">Input Long that sets the number of tick marks displayed.  This does not include the start and end marks.</param>
    /// <param name="StepsBetweenTicks">Input Long that sets the number of steps the slider will move to go from one tick to the next.  This controls the resolution and the corresponding values that can be returned by the slider.</param>
    /// <param name="Width">Input Long that sets the width of the slider in pixels.</param>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbarSlider AddSlider([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] ValueTypeEnum ValueType, [In] double Maximum, [In] double Minimum, [In] int NumberOfTicks, [In] int StepsBetweenTicks, [In] int Width);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    /// <param name="ToolTipText">ToolTipText</param>
    /// <param name="TextValue">TextValue</param>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="Width">Width</param>
    /// <param name="Height">Height</param>
    /// <param name="StandardIcon">StandardIcon</param>
    /// <param name="LargeIcon">LargeIcon</param>
    [PreserveSig]
    MiniToolbarTextEditor AddTextEditor([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] [MarshalAs(UnmanagedType.BStr)] string TextValue, [In] [MarshalAs(UnmanagedType.BStr)] string? DisplayName = "", [In] int? Width = default, [In] int? Height = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    /// <param name="TextValue">TextValue</param>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="ToolTipText">ToolTipText</param>
    [PreserveSig]
    MiniToolbarTextBox AddTextBox([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string TextValue, [In] [MarshalAs(UnmanagedType.BStr)] string? DisplayName = "", [In] [MarshalAs(UnmanagedType.BStr)] string? ToolTipText = "");
}
