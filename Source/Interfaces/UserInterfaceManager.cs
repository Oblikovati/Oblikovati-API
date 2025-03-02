namespace Oblikovati.API;

/// <summary>
/// The UserInterfaceManager object, through which all UI customization objects can be accessed. See Ribbon Customization for an overview.
/// </summary>
public interface UserInterfaceManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBars CommandBars { get; }
    /// <summary>
    /// Property that returns the Environment that is currently active.
    /// </summary>
    Environment ActiveEnvironment { get; }
    /// <summary>
    /// Property that returns the list of Environments valid for the edit target or the environment being switched to. Environments can be added to or removed from the list as seen appropriate by the client when an OnNewEditObject or an OnEnvironmentChange event is received. This list of environments will show in the Applications menu item. This list may only contain non-built-in environments.
    /// </summary>
    EnvironmentList ParallelEnvironments { get; }
    /// <summary>
    /// Property that returns the Environments collection object.
    /// </summary>
    Environments Environments { get; }
    /// <summary>
    /// Show/Hide Browser.
    /// </summary>
    bool ShowBrowser { get; set; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether the UI is in Expert mode.
    /// </summary>
    bool ExpertMode { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LargeIcons { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowPanelBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowToolBar { get; set; }
    /// <summary>
    /// Show/Hide StatusBar.
    /// </summary>
    bool ShowStatusBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ProgressBarEnabled { get; set; }
    /// <summary>
    /// Enable/Disable user interaction.
    /// </summary>
    bool UserInteractionDisabled { get; set; }
    /// <summary>
    /// Property returning the UserInterfaceEvents object.
    /// </summary>
    UserInterfaceEvents UserInterfaceEvents { get; }
    /// <summary>
    /// Gets and sets whether to enable the capacity meter display in Inventor's status bar.
    /// </summary>
    bool CapacityMeterEnabled { get; set; }
    /// <summary>
    /// Property that returns the Ribbons collection object.
    /// </summary>
    Ribbons Ribbons { get; }
    /// <summary>
    /// Property that returns a CommandControls collection containing the controls in the File Browser (a.k.a Application Menu).
    /// </summary>
    CommandControls FileBrowserControls { get; }
    /// <summary>
    /// Gets and sets the appearance of the ribbon.
    /// </summary>
    RibbonAppearanceEnum RibbonAppearance { get; set; }
    /// <summary>
    /// Gets and sets the docking state of the ribbon.
    /// </summary>
    RibbonDockingStateEnum RibbonDockingState { get; set; }
    /// <summary>
    /// Gets and sets the display state of the ribbon.&nbsp;Valid values are kFullRibbon, kMinimizeToTabs, kMinimizeToPanelTitles and kMinimizeToPanelButtons.
    /// </summary>
    RibbonStateEnum RibbonState { get; set; }
    /// <summary>
    /// Gets sets whether the viewed screen area is maximized.
    /// </summary>
    bool ShowCleanScreen { get; set; }
    /// <summary>
    /// Gets and sets whether document tabs are displayed.
    /// </summary>
    bool ShowDocumentTabs { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowPanelTitles { get; set; }
    /// <summary>
    /// Gets and sets whether the Quick Access Toolbar (QAT) is shown below or above the ribbon.
    /// </summary>
    bool ShowQuickAccessControlsBelowRibbon { get; set; }
    /// <summary>
    /// Property that returns a CommandControls collection containing the controls in the Help Menu.
    /// </summary>
    CommandControls HelpControls { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InterfaceStyleEnum InterfaceStyle { get; }
    /// <summary>
    /// Property that returns the DockableWindows collection object.
    /// </summary>
    DockableWindows DockableWindows { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the navigation bar is displayed.
    /// </summary>
    bool ShowNavigationBar { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the steering wheel control is displayed.
    /// </summary>
    bool ShowSteeringWheel { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the view cube is displayed.
    /// </summary>
    bool ShowViewCube { get; set; }
    /// <summary>
    /// Read-only property that returns the BalloonTips collection object.
    /// </summary>
    BalloonTips BalloonTips { get; }
    /// <summary>
    /// Property that gets and sets whether to use the marking menu.
    /// </summary>
    bool ShowMarkingMenu { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the behavior of the overflow menu.
    /// </summary>
    OverflowMenuBehaviorEnum OverflowMenuBehavior { get; set; }
    /// <summary>
    /// Read-only property that gets whether the MiniToolbar position is pinned or not.
    /// </summary>
    bool PinMiniToolbarPosition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SceneRedrawDisabled { get; set; }
    /// <summary>
    /// Allows Oblikovati to process all Windows messages currently in the message queue.
    /// </summary>
    [PreserveSig]
    void DoEvents();
    /// <summary>
    /// Method that returns all command controls in Oblikovati's ribbon interface that reference the input ControlDefinition. Controls from ribbons panels, Quick Access Toolbar and the File Browser (application menu) are returned.
    /// </summary>
    /// <param name="Definition">Input ControlDefinition object to find the controls for.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandControlsEnumerator AllReferencedControls([In] [MarshalAs(UnmanagedType.Interface)] ControlDefinition Definition);
    /// <summary>
    /// Method that removes all customizations from the ribbon user interface.
    /// </summary>
    [PreserveSig]
    void ResetRibbonInterface();
    /// <summary>
    /// Method that returns all the paths that the given command is found in, optionally filtered to an environment.
    /// </summary>
    /// <param name="CommandInternalName">Input String that specifies the internal name of a ControlDefinition.</param>
    /// <param name="Environment">Optional input Environment object that specifies which Environment to return the paths for. If not specified, paths from all environments are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetCommandPaths([In] [MarshalAs(UnmanagedType.BStr)] string CommandInternalName, [In] [MarshalAs(UnmanagedType.Struct)] object? Environment = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pValueMap">pValueMap</param>
    [PreserveSig]
    void RegisterFileExtension([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap pValueMap);
}
