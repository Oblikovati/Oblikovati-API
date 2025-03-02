namespace Oblikovati.API;

/// <summary>
/// The CommandBarControls collection object provides access to all of the source objects in Autodesk Inventor, along with the ability to add new CommandBarControl objects. The command bars represent all of the menus and toolbars.
/// </summary>
public interface CommandBarControls : IEnumerable
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
    /// Property that returns the specified object from the collection.
    /// </summary>
    CommandBarControl Item { get; }
    /// <summary>
    /// Property that returns the number of CommandBarControls in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Type">Type</param>
    /// <param name="Command">Command</param>
    /// <param name="Before">Before</param>
    /// <param name="Temporary">Temporary</param>
    [PreserveSig]
    CommandBarControl _Add([In] BarControlTypeEnum Type, [In] [MarshalAs(UnmanagedType.Struct)] object? Command = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Before = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Temporary = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Type">Type</param>
    /// <param name="ControlDefinition">ControlDefinition</param>
    /// <param name="Before">Before</param>
    [PreserveSig]
    CommandBarControl Add([In] BarControlTypeEnum Type, [In] [MarshalAs(UnmanagedType.Struct)] object? ControlDefinition = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Before = default);
    /// <summary>
    /// Method that creates a new button CommandBarControl object.
    /// </summary>
    /// <param name="ButtonDefinition">Input ButtonDefinition object that specifies the object to associate with this control.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddButton([In] [MarshalAs(UnmanagedType.Interface)] ButtonDefinition ButtonDefinition, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new macro CommandBarControl object.
    /// </summary>
    /// <param name="MacroControlDefinition">Input MacroControlDefinition object that specifies the object to associate with this control.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddMacro([In] [MarshalAs(UnmanagedType.Interface)] MacroControlDefinition MacroControlDefinition, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new combo-box CommandBarControl object.
    /// </summary>
    /// <param name="ComboBoxDefinition">Input ComboBoxDefinition object that specifies the object to associate with this control.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddComboBox([In] [MarshalAs(UnmanagedType.Interface)] ComboBoxDefinition ComboBoxDefinition, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new popup CommandBarControl object. An example of this type of control is the 'Display Mode' drop down (Shaded, Hidden Edge, Wireframe) available on the standard toolbar in part and assembly environments.
    /// </summary>
    /// <param name="CommandBar">Input CommandBar object that specifies the CommandBar to associate with this control. The CommandBarType of the command bar must be kButtonPopupCommandBar, else an error will occur.</param>
    /// <param name="DisplayedControl">Optional Input ControlDefinition object that specifies the default control for the control. This is the control that shows on the top of the control when the control is first displayed. If not specified, the first ControlDefinition on the input command bar is used.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddButtonPopup([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayedControl = default, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new split button CommandBarControl object. An example of this type of control is the 'New File' split button drop down available on all standard toolbars.
    /// </summary>
    /// <param name="CommandBar">Input CommandBar object that specifies the CommandBar to associate with this control. The CommandBarType of the command bar must be kSplitButtonCommandBar, else an error will occur.</param>
    /// <param name="DisplayedControl">Optional Input ControlDefinition object that specifies the default control for the control. This is the control that shows on the top of the control when the control is first displayed. This ControlDefinition must be present in the input CommandBar. If not specified, the first ControlDefinition on the input command bar is used.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddSplitButton([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayedControl = default, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new split button MRU (Most Recently Used) CommandBarControl object. An example of this type of control is the 'Sketch Constraints' drop down in the Sketch toolbar/panel bar.
    /// </summary>
    /// <param name="CommandBar">Input CommandBar object that specifies the CommandBar to associate with this control. The CommandBarType of the command bar must be kSplitButtonMRUCommandBar, else an error will occur.</param>
    /// <param name="DisplayedControl">Optional Input ControlDefinition object that specifies the default control for the control. This is the control that shows on the top of the control when the control is first displayed. This ControlDefinition must be present in the input CommandBar. If not specified, the first ControlDefinition on the input command bar is used.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddSplitButtonMRU([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayedControl = default, [In] int? Before = default);
    /// <summary>
    /// Method that creates a new popup CommandBarControl object. An example of this type of control is the 'Help' control on the menu bar.
    /// </summary>
    /// <param name="CommandBar">Input CommandBar object that specifies the CommandBar to associate with this control. The CommandBarType of the command bar must be kPopupCommandBar, else an error will occur.</param>
    /// <param name="Before">Optional input Long that defines the position of the new control on the command bar. The new control will be inserted before the control at this position. If this argument is omitted, the control is added at the end of the specified command bar.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBarControl AddPopup([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar, [In] int? Before = default);
}
