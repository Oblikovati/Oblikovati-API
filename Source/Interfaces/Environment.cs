namespace Oblikovati.API;

/// <summary>
/// The Environment object represents any Autodesk Inventor environment. Example environments are Part, Assembly, Sketch, etc. The Environment represents the current state of an environment. See the UI customization and Environments overviews for more information.
/// </summary>
public interface Environment
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent of the environment.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that indicates the name of the environment.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Display Name of the Environment.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBar DefaultMenuBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBar DefaultToolBar { get; set; }
    /// <summary>
    /// Property that specifies if the Environment a standard Autodesk Inventor Environment or if it has been added by a client. Built-in environments have restrictions in the edits that can be performed. For example, build-in environments cannot be deleted. For more information, see the Environments overview.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Gets and sets the StandardIcon for the Environment.
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Gets and sets the LargeIcon for the Environment.
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Property that returns the DisabledCommandList object. This object allows the environment to disable commands when this environment is active. This list contains commands that are disabled in addition to those specified by the DisabledCommandTypes property.
    /// </summary>
    DisabledCommandList DisabledCommandList { get; }
    /// <summary>
    /// Gets list of disabled command types for the Environment.
    /// </summary>
    CommandTypesEnum DisabledCommandTypes { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarList ContextMenuList { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PanelBar PanelBar { get; }
    /// <summary>
    /// Gets and sets an array of strings containing the internal names of ribbon tabs that should be displayed in this environment. These are in addition to the tabs displayed as a result of setting the InheritAllRibbonTabs property to True.
    /// </summary>
    object AdditionalVisibleRibbonTabs { get; set; }
    /// <summary>
    /// Gets and sets the internal name of the ribbon tab that should be displayed when this environment is activated.
    /// </summary>
    string DefaultRibbonTab { get; set; }
    /// <summary>
    /// Gets and sets whether this environment should inherit all ribbon tabs from the 'base' environment. This property applies only to custom environments. If set to True, all visible tabs in the base environment are displayed in this environment.
    /// </summary>
    bool InheritAllRibbonTabs { get; set; }
    /// <summary>
    /// Property that returns the Ribbon object associated with this environment. This property returns Nothing when the environment is initially created and not yet applied as an override or a parallel environment.
    /// </summary>
    Ribbon Ribbon { get; }
    /// <summary>
    /// Returns the RadialMarkingMenus object that can be used to query and set the selection based radial menu.
    /// </summary>
    RadialMarkingMenus RadialMarkingMenus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object EnabledCommandList { get; set; }
    /// <summary>
    /// Gets and sets the exit display name of the environment, to be used on the Finish button. As default this will be the same as the DisplayName. This is the name displayed to the user and should be localized for the current locale.
    /// </summary>
    string ExitDisplayName { get; set; }
    /// <summary>
    /// Gets and sets whether the environment status would be preserved when switch model state in an assembly. This would make sure the environment to be preserved when switch between substitute model state and other model state in an assembly.For built-in environmen.
    /// </summary>
    bool PreserveWhenSwitchModelState { get; set; }
    /// <summary>
    /// Method that deletes the environment. This method will fail for built-in environments.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Returns the RadialMarkingMenu object that can be used to query and set the commands available in the radial menu for the input object type.
    /// </summary>
    /// <param name="ObjectType">Optional input ObjectTypeEnum that specifies the object type to retrieve the marking menu for.  If not provided, the marking menu for the default environment state (no selections) is returned.</param>
    /// <returns></returns>
    [PreserveSig]
    RadialMarkingMenu GetRadialMarkingMenu([In] [MarshalAs(UnmanagedType.Struct)] object? ObjectType = default);
}
