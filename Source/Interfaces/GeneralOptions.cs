namespace Oblikovati.API;

/// <summary>
/// The GeneralOptions object provides access to properties that provide read and write access of the general application options. This is somewhat equivalent to the General tab of the Application Options dialog.
/// </summary>
public interface GeneralOptions
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets Text Appearance.
    /// </summary>
    string TextAppearance { get; set; }
    /// <summary>
    /// Gets/Sets Text Size.
    /// </summary>
    int TextSize { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowStartupDialog { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Show3DIndicator { get; set; }
    /// <summary>
    /// Gets/Sets user name.
    /// </summary>
    string UserName { get; set; }
    /// <summary>
    /// Gets/Sets the size of the temporary file.
    /// </summary>
    int UndoFileSize { get; set; }
    /// <summary>
    /// Gets/Sets the distance (in pixels) where a selection of an object can occur.
    /// </summary>
    int ToleranceValue { get; set; }
    /// <summary>
    /// Gets/Sets the length of the delay time.
    /// </summary>
    double SelectOtherDelay { get; set; }
    /// <summary>
    /// Gets/Sets the size of non-model elements in the graphics window.
    /// </summary>
    double AnnotationScale { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the ThreadTableQuery object. This object has methods to query the thread table data contained in the Thread.xls spreadsheet.
    /// </summary>
    ThreadTableQuery ThreadTableQuery { get; }
    /// <summary>
    /// Gets/Sets whether the inertial properties should be calculated using the negative integral.
    /// </summary>
    bool UseNegativeIntegralForInertialProperties { get; set; }
    /// <summary>
    /// Gets and sets the Visibility of the iMate Glyph.
    /// </summary>
    bool iMateVisibility { get; set; }
    /// <summary>
    /// Gets and sets whether the autocomplete dropdown box should be displayed for command aliases.
    /// </summary>
    bool ShowAutocompleteForCommandAlias { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ShowHelpDialogOnStartup { get; set; }
    /// <summary>
    /// Gets and sets whether tooltips should be displayed to prompt for command inputs.
    /// </summary>
    bool ShowCommandPromptTooltips { get; set; }
    /// <summary>
    /// Gets and sets the type of startup action to perform each time Autodesk Inventor is opened.
    /// </summary>
    StartupActionTypeEnum StartupActionType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    StartupHelpFocusTopicEnum StartupHelpFocusTopic { get; set; }
    /// <summary>
    /// Gets and sets the name of the template for the new file that will be automatically created each time Autodesk Inventor is opened.
    /// </summary>
    string StartupNewFileTemplateName { get; set; }
    /// <summary>
    /// Gets and sets the name of the project file that will be used each time Autodesk Inventor is opened.
    /// </summary>
    string StartupProjectFileName { get; set; }
    /// <summary>
    /// Gets and sets whether enables or disables optimized selection.
    /// </summary>
    bool EnableOptimizedSelection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnablePrehighlight { get; set; }
    /// <summary>
    /// Gets and sets whether properties should be updated when part or assembly files are saved.
    /// </summary>
    UpdatePropertiesOnSaveForFileTypeEnum UpdatePropertiesOnSaveForFileType { get; set; }
    /// <summary>
    /// Gets/Sets the creation of shared and semi-isolated legacy projects.
    /// </summary>
    bool EnableLegacyProjectCreation { get; set; }
    /// <summary>
    /// Gets and sets whether the input dialog should be displayed for command aliases.
    /// </summary>
    bool ShowCommandAliasInputDialog { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableEnhancedHighlighting { get; set; }
    /// <summary>
    /// Property that returns the GripSnapOptions object. The GripSnapOptions object provides access to various grip snap related application level options.
    /// </summary>
    GripSnapOptions GripSnapOptions { get; }
    /// <summary>
    /// Gets and sets the length of the delay time (in seconds), before the second tooltip is displayed.
    /// </summary>
    double SecondLevelTooltipDelay { get; set; }
    /// <summary>
    /// Gets and sets whether to show tooltips when hovering over document tabs.
    /// </summary>
    bool ShowDocumentTabTooltips { get; set; }
    /// <summary>
    /// Gets and sets whether to show second level tooltips when hovering over a command in the ribbon.
    /// </summary>
    bool ShowSecondLevelTooltips { get; set; }
    /// <summary>
    /// Gets and sets whether to show tooltips when hovering over a command in the ribbon.
    /// </summary>
    bool ShowTooltips { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowXYZAxisLabels { get; set; }
    /// <summary>
    /// Gets and sets the length of the delay time (in seconds), while the cursor is hovering over a command in the ribbon, before the tooltip is displayed.
    /// </summary>
    double TooltipDelay { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowVideoToolClips { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LoadVBAOnStartup { get; set; }
    /// <summary>
    /// Gets and sets whether to use the Autodesk online help or not. This property defaults to True to indicate the online help will be used. If local help is installed set this property to False to use the local help.
    /// </summary>
    bool UseAutodeskOnlineHelp { get; set; }
    /// <summary>
    /// Gets and sets whether to enable the spell check or not. This property defaults to True to indicate the specll check is enabled.
    /// </summary>
    bool EnableSpellCheck { get; set; }
    /// <summary>
    /// Read-only property that returns the SpellCheckOptions object. The SpellCheckOptions object provides access to various spell check related application level options.
    /// </summary>
    SpellCheckOptions SpellCheckOptions { get; }
    /// <summary>
    /// Gets and sets whether to use the MyHome Screen.
    /// </summary>
    bool ShowHomeBaseOnStartup { get; set; }
}
