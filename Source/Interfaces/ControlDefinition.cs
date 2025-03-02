namespace Oblikovati.API;

/// <summary>
/// The ControlDefinition object is the base class for all other command definition types. This includes the following objects: ButtonDefinition, ComboBoxDefinition, and MacroControlDefinition.
/// </summary>
public interface ControlDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the internal name. This name is the internal unique identifier for the ControlDefinition.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the display name of the ControlDefinition.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that specifies if the control or definition is a standard Autodesk Inventor control or definition. Built-in ones have restrictions in the edits that can be performed.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that returns the command classification of the ControlDefinition. These classifications are bits and can be combined to designate that a command falls within more than one classification. Because they are bits, care needs to be taken when interpreting the returned values.
    /// </summary>
    CommandTypesEnum Classification { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    CommandManager Parent { get; }
    /// <summary>
    /// Property that returns the control definition type. The possible return values are kButtonDefinition, kComboBoxDefinition, and kMacroControlDefinition.
    /// </summary>
    ControlDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Gets/Sets Description Text.&nbsp;For MacroControlDefinition this property is read-only.
    /// </summary>
    string DescriptionText { get; set; }
    /// <summary>
    /// Enables/Disables the UIDefinition object.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Gets/Sets Tooltip. For MacroControlDefinition this property is read-only
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ControlDefinitionEvents ControlDefinitionEvents { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Gets/Sets the default (internal) shortcut assigned to the command. Setting this property fails for built-in ControlDefinitions.
    /// </summary>
    string DefaultShortcut { get; set; }
    /// <summary>
    /// Property that returns the type of shortcut assigned to this command.
    /// </summary>
    ShortcutTypeEnum DefaultShortcutType { get; }
    /// <summary>
    /// Property that returns whether the default (internal) shortcut has been overridden by the user or through the API.
    /// </summary>
    bool IsShortcutOverridden { get; }
    /// <summary>
    /// Gets/Sets the override shortcut assigned to the command. Setting this property to a null string clears the override.
    /// </summary>
    string OverrideShortcut { get; set; }
    /// <summary>
    /// Property that returns the type of override shortcut assigned to this command.
    /// </summary>
    ShortcutTypeEnum OverrideShortcutType { get; }
    /// <summary>
    /// Gets/Sets StandardIcon. For MacroControlDefinition this property is read-only.
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Gets/Sets LargeIcon. For MacroControlDefinition this property is read-only.
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Property that returns a ProgressiveToolTip object providing access to enhanced tooltip display for controls in the ribbon interface.
    /// </summary>
    ProgressiveToolTip ProgressiveToolTip { get; }
    /// <summary>
    /// Read-write property that gets and sets the introduced in version of the control definition. The values from AvailableComparisonVersions can be used to set this property. This is read only if the control definition is built-in or if it is MacroControlDefinition.
    /// </summary>
    string IntroducedInVersion { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the last updated version of the control definition. The values from AvailableComparisonVersions can be used to set this property. This is read only if the control definition is built-in or if it is MacroControlDefinition.
    /// </summary>
    string LastUpdatedVersion { get; set; }
    /// <summary>
    /// Method that deletes the control definition. This method fails for built-in definitions.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that automatically adds a control based on this definition to the General panel of the Add-Ins tab in the ribbon interface.
    /// </summary>
    [PreserveSig]
    void AutoAddToGUI();
    /// <summary>
    /// Method that runs the built-in command or sends the Click event to the Add-In. The end result of calling the Execute method is the same as if the user had clicked/pressed the relevant control - for example, by clicking on a button that references a ButtonDefinition object.
    /// </summary>
    [PreserveSig]
    void Execute();
    /// <summary>
    /// Method that executes the control definition synchronously or asynchronously.
    /// </summary>
    /// <param name="Synchronous">Input Boolean that specifies whether to execute the control definition synchronously ('Send Message') or asynchronously ('Post Message').</param>
    [PreserveSig]
    void Execute2([In] bool Synchronous);
}
