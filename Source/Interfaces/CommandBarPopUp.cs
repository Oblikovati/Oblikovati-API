namespace Oblikovati.API;

/// <summary>
/// Use F1 key to display help topic.
/// </summary>
public interface CommandBarPopUp
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    CommandBar Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that specifies if the control or definition is a standard Autodesk Inventor control or definition. Built-in ones have restrictions in the edits that can be performed.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that specifies if the control has a dividing bar immediately to its left or has a dividing bar immediately above. If True, a dividing bar will be displayed. Setting this property to True for the first control in a command bar will not have any effect.
    /// </summary>
    bool GroupBegins { get; set; }
    /// <summary>
    /// Property that returns the display name. This is the name that is displayed to the user. For kButtonPopupControl, kSplitButtonMRUControl and kSplitButtonControl control types, this returns the display name of the currently displayed control.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that gets and sets the current ControlDefinition object for kButtonPopupControl, kSplitButtonMRUControl and kSplitButtonControl control types. For other types, this property returns Nothing.
    /// </summary>
    ControlDefinition DisplayedControl { get; set; }
    /// <summary>
    /// Property that returns the ControlDefinition object associated with this control. The ControlDefinition object is the public view of the command the ControlDefinitionHandler represents. The ControlDefinition is required as input when creating new command bar controls.
    /// </summary>
    ControlDefinition ControlDefinition { get; }
    /// <summary>
    /// Property that returns the object associated with this control. If the ControlType of this control is kButtonControl, kMacroControl or kComboBoxControl this property will return Nothing.
    /// </summary>
    CommandBar CommandBar { get; }
    /// <summary>
    /// Property that returns the style of the control. Valid types for a control are kButtonControl, kComboBoxControl, kMacroControl, kPopupControl, kButtonPopupControl, kSplitButtonMRUControl, kSplitButtonControl and kUnknownControl. An instance where kUnknownControl is returned is when an AddIn that created this control has been unloaded.
    /// </summary>
    ControlTypeEnum ControlType { get; }
    /// <summary>
    /// Property that returns the internal unique identifier of the control. This is the name that can be used to retrieve a control from a collection.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the index of this control within the parent command bar.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Get/Put to get/set caption of popup control.
    /// </summary>
    string Caption { get; set; }
    /// <summary>
    /// Method that deletes this command bar control.
    /// </summary>
    [PreserveSig]
    void Delete();
}
