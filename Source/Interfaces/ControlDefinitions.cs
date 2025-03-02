namespace Oblikovati.API;

/// <summary>
/// The ControlDefinitions collection object provides access to existing objects.
/// </summary>
public interface ControlDefinitions : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns the specified ControlDefinitionobject from the collection.
    /// </summary>
    ControlDefinition this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets/Sets whether the multi-character Command Aliases delivered with Inventor should be used.&nbsp;The equivalent UI option is found under the 'Keyboard' tab of the Customize dialog.
    /// </summary>
    bool UseDefaultMultiCharAliases { get; set; }
    /// <summary>
    /// Method that adds a newButtonDefinition object.
    /// </summary>
    /// <param name="DisplayName">Input String that specifies the display name associated with this definition. The display name is the text that is displayed to the user. Because this string is displayed to the user, you should consider localizing it for different languages.</param>
    /// <param name="InternalName">Input String value that defines the unique name of the definition. This name is never displayed to the user. The name must be unique with respect to all other control definitions and command bars in Inventor. Because of the uniqueness requirement, it is recommended that you add your application name to the name to help eliminate naming conflicts. For example instead of the name "Analyze" it might be "ACMEAnalyze".</param>
    /// <param name="Classification">Input that sets the classification for this ControlDefinition. These classifications are bits and can be combined to designate that a command falls within more than one classification.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <param name="DescriptionText">Optional input String that specifies the description text for this definition. The description text is displayed in the status bar when the mouse is moved over a control associated with the definition. If not supplied the display name will be used for the description text.</param>
    /// <param name="ToolTipText">Optional input String that specifies the tool tip text for this definition. If not supplied the display name will be used for the tool tip text.</param>
    /// <param name="StandardIcon">Optional input Picture (IPictureDisp) object that specifies the standard size icon to use for the controls using this definition. A standard size icon is 16 pixels wide and 16 pixels high. If not supplied the button will be created as a text only button and the LargeIcon argument is ignored.</param>
    /// <param name="LargeIcon">Optional input Picture (IPictureDisp) object that specifies the large size icon to use for the controls using this definition. A large size icon is 32 wide by 32 high. If not supplied and a standard size icon is supplied a large icon will be automatically created by scaling the standard size icon. Because scaling a bitmap does not necessarily create a good image, it is recommended that you create and supply a large bitmap.</param>
    /// <param name="ButtonDisplay">constant indicating whether to display text and icons on a button. The default value is kDisplayTextInLearningMode.</param>
    /// <returns></returns>
    [PreserveSig]
    ButtonDefinition AddButtonDefinition([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] CommandTypesEnum Classification, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default, [In] [MarshalAs(UnmanagedType.BStr)] string? DescriptionText = "", [In] [MarshalAs(UnmanagedType.BStr)] string? ToolTipText = "", [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default, [In] ButtonDisplayEnum? ButtonDisplay = ButtonDisplayEnum.kDisplayTextInLearningMode);
    /// <summary>
    /// Method that creates a new ComboBoxDefinition object.
    /// </summary>
    /// <param name="DisplayName">Input String that specifies the display name associated with this definition. The display name is the text that is displayed to the user. Because this string is displayed to the user, you should consider localizing it for different languages.</param>
    /// <param name="InternalName">Input String value that defines the unique name of the definition. This name is never displayed to the user. The name must be unique with respect to all other control definitions and command bars in Inventor. Because of the uniqueness requirement, it is recommended that you add your application name to the name to help eliminate naming conflicts. For example instead of the name 'Analyze' it might be 'ACMEAnalyze'.</param>
    /// <param name="Classification">Input that sets the classification for this ControlDefinition. These classifications are bits and can be combined to designate that a command falls within more than one classification.</param>
    /// <param name="DropDownWidth">Input Long that specifies the width (in pixels) of the drop-down portion of a combo box.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <param name="DescriptionText">Optional input String that specifies the description text for this definition. The description text is displayed in the status bar when the mouse is moved over a control associated with the definition. If not supplied the display name will be used for the description text.</param>
    /// <param name="ToolTipText">Optional input String that specifies the tool tip text for this definition. If not supplied the display name will be used for the tool tip text.</param>
    /// <param name="StandardIcon">Optional input Picture (IPictureDisp) object that specifies the standard size icon to use for the controls using this definition. A standard size icon is 16 pixels wide and 16 pixels high. All icons use 16 colors. If not supplied the button will be created as a text only button and the LargeIcon argument is ignored.</param>
    /// <param name="LargeIcon">Optional input Picture (IPictureDisp) object that specifies the large size icon to use for the controls using this definition. A large size icon is 24 pixels wide and 24 pixels high. All icons use 16 colors. If not supplied and a standard size icon is supplied a large icon will be automatically created by scaling the standard size icon. Because scaling a bitmap does not necessarily create a good image, it is recommended that you create and supply a large bitmap.</param>
    /// <param name="ButtonDisplay">constant indicating whether to display text and icons on a button.</param>
    /// <returns></returns>
    [PreserveSig]
    ComboBoxDefinition AddComboBoxDefinition([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] CommandTypesEnum Classification, [In] int DropDownWidth, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default, [In] [MarshalAs(UnmanagedType.BStr)] string? DescriptionText = "", [In] [MarshalAs(UnmanagedType.BStr)] string? ToolTipText = "", [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default, [In] ButtonDisplayEnum? ButtonDisplay = ButtonDisplayEnum.kDisplayTextInLearningMode);
    /// <summary>
    /// Method that creates a new MacroControlDefinition object. The MacroControlDefinition object is used to define the information associated with a button that can be used to execute an Oblikovati VBA macro, insert an iPart, insert an iFeature or execute an EXE.
    /// </summary>
    /// <param name="MacroOrProgram">Input String that defines the VBA macro to run, the external file to insert or EXE program to run. A VBA macro must be a Public Sub defined in a standard code module of the Application VBA project. The Sub cannot have any input arguments. The Sub is specified using 'Module.SubName' format. For example the Sub MovePart in a module named AsmTools would be specified by 'AsmTools.MovePart'. If a filename with a .ipt extension is supplied it is assumed to be an iPart. The filename must be a full filename. If an external EXE is specified, this argument must be the full path to the EXE.</param>
    /// <returns></returns>
    [PreserveSig]
    MacroControlDefinition AddMacroControlDefinition([In] [MarshalAs(UnmanagedType.BStr)] string MacroOrProgram);
}
