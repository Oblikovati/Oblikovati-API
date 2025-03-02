namespace Oblikovati.API;

/// <summary>
/// The CommandControls collection object provides access to a collection of user interface controls and provides methods to create additional controls.
/// </summary>
public interface CommandControls : IEnumerable
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
    /// Returns the specified CommandControl object from the collection.
    /// </summary>
    CommandControl Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new button CommandControl object. An example of this type of control is the 'Extrude' feature command button.
    /// </summary>
    /// <param name="ButtonDefinition">Input ButtonDefinition object that specifies the object to associate with this control.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddButton([In] [MarshalAs(UnmanagedType.Interface)] ButtonDefinition ButtonDefinition, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new popup CommandControl object. An example of this type of control is the 'Display Mode' drop down (Shaded, Hidden Edge, Wireframe) available on the 'View' tab of the ribbon in parts and assemblies.
    /// </summary>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control. The first ButtonDefinition is used as the displayed control. Also, the internal and display names of the first definition are used for the control. The internal name of the control remains unchanged regardless of the currently displayed control.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddButtonPopup([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new combo-box CommandControl object.
    /// </summary>
    /// <param name="ComboBoxDefinition">Input ComboBoxDefinition object that specifies the object to associate with this control.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddComboBox([In] [MarshalAs(UnmanagedType.Interface)] ComboBoxDefinition ComboBoxDefinition, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new macro CommandControl object.
    /// </summary>
    /// <param name="MacroControlDefinition">Input MacroControlDefinition object that specifies the object to associate with this control.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddMacro([In] [MarshalAs(UnmanagedType.Interface)] MacroControlDefinition MacroControlDefinition, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new popup CommandControl object. An example of this type of control is the 'Switch' control available in the Windows panel of the View tab.
    /// </summary>
    /// <param name="DisplayedControl">Input ButtonDefinition object that specifies the displayed control for the control. This ButtonDefinition is only used to extract the icons and the display name for the control.</param>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddPopup([In] [MarshalAs(UnmanagedType.Interface)] ButtonDefinition DisplayedControl, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new separator CommandControl object.
    /// </summary>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddSeparator([In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new split button CommandControl object. An example of this type of control is the 'New File' split button drop down available in the Quick Access Toolbar.
    /// </summary>
    /// <param name="DisplayedControl">Input ButtonDefinition object that specifies the default control for the control. This is the control that is always displayed to the user.</param>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control. This collection may include the displayed control, but doesn't have to.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddSplitButton([In] [MarshalAs(UnmanagedType.Interface)] ButtonDefinition DisplayedControl, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new split button MRU (Most Recently Used) CommandControl object. An example of this type of control is the 'Circle' drop down in the Sketch tab of the ribbon.
    /// </summary>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control. The first ButtonDefinition is used as the displayed control. Also, the internal and display names of the first definition are used for the control. The internal name of the control remains unchanged regardless of the currently displayed control.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddSplitButtonMRU([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new gallery CommandControl object. An example of this type of control is the gallery control available in the Symbols panel of the Annotate tab in drawings.
    /// </summary>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control. The internal and display names of the first definition are used for the control.</param>
    /// <param name="DisplayAsComboBox">Optional input Boolean that specifies whether to display the controls as a window (see Symbols panel in Annotate tab of drawings) or a combobox (see Insert panel of Manage tab in parts).  If not specified, a default of False is assumed and the control is displayed as a window.</param>
    /// <param name="Width">Optional input Long that specifies the width for the control.  If not specified, a default value of 200 is used.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddGallery([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? DisplayAsComboBox = false, [In] int? Width = default, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a new toggle popup CommandControl object. An example of this type of control is the 'Object Visibility' control available in the Visibility panel of the Views tab.
    /// </summary>
    /// <param name="DisplayedControl">Input ButtonDefinition object that specifies the displayed control for the control. This ButtonDefinition is only used to extract the icons and the display name for the control.</param>
    /// <param name="ButtonDefinitions">Input ObjectCollection containing the ButtonDefinition objects hosted by this control. Use the ButtonDefinition.Pressed property to query whether the toggle is checked or unchecked.</param>
    /// <param name="UseLargeIcon">Optional input Boolean that specifies whether to use large icon or small icon for the control. If not specified, the small icon is used by default.</param>
    /// <param name="ShowText">Optional input Boolean that specifies whether to display text (display name) for the control. If not specified, text is displayed by default.</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddTogglePopup([In] [MarshalAs(UnmanagedType.Interface)] ButtonDefinition DisplayedControl, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ButtonDefinitions, [In] bool? UseLargeIcon = false, [In] bool? ShowText = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
    /// <summary>
    /// Method that creates a copy of an existing CommandControl object as a child control of the current CommandControl. This can be used to copy controls between ribbon panels.
    /// </summary>
    /// <param name="CommandControl">CommandControl to copy</param>
    /// <param name="TargetControlInternalName">Optional input String that specifies the internal name of an existing control to position the new control next to. If specified, the InsertBeforeTargetControl argument indicates whether to place the new control before or after the target control. If not specified, the new control is positioned at the end.</param>
    /// <param name="InsertBeforeTargetControl">Optional input Boolean that specifies whether to position the new control before or after the target control. The argument defaults to False and is not used if the TargetControlInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControl AddCopy([In] [MarshalAs(UnmanagedType.Interface)] CommandControl CommandControl, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetControlInternalName = "", [In] bool? InsertBeforeTargetControl = false);
}
