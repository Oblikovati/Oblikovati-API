namespace Oblikovati.API;

/// <summary>
/// The CommandManager object provides functionality that interacts with the various user interaction events. See here for an overview.
/// </summary>
public interface CommandManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent document of the object.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CommandEnabled { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandIDEnum _ActiveCommand { get; }
    /// <summary>
    /// Gets the active command (one that is currently running).
    /// </summary>
    string ActiveCommand { get; }
    /// <summary>
    /// Property that informs the client if Autodesk Inventor is currently in selection mode or not. This may be used, for example, by clients to test if calling the DoSelect (and related) methods will have any effect or not.
    /// </summary>
    bool SelectionActive { get; }
    /// <summary>
    /// Property that returns the object that fires events on all user input (commands, keyboard, mouse, etc.).
    /// </summary>
    UserInputEvents UserInputEvents { get; }
    /// <summary>
    /// Property that returns the collection.
    /// </summary>
    CommandCategories CommandCategories { get; }
    /// <summary>
    /// Property that returns the ControlDefinitions collection.
    /// </summary>
    ControlDefinitions ControlDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BuiltInCommandId">BuiltInCommandId</param>
    [PreserveSig]
    void StartCommand([In] CommandIDEnum BuiltInCommandId);
    /// <summary>
    /// Method that causes the currently running command to be terminated.
    /// </summary>
    [PreserveSig]
    void StopActiveCommand();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void StopAllActiveCommands();
    /// <summary>
    /// Method that causes the specified executable to be run. Using the Parameters argument you can also pass arguments to the executable.
    /// </summary>
    /// <param name="ExecutableName">Input String that contains the full path of the executable.</param>
    /// <param name="Parameters">Input string that contains the parameters. An empty string is valid in the case where the executable doesn't have any input arguments.</param>
    [PreserveSig]
    void StartExecutable([In] [MarshalAs(UnmanagedType.BStr)] string ExecutableName, [In] [MarshalAs(UnmanagedType.BStr)] string Parameters);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DataType">DataType</param>
    /// <param name="Data">Data</param>
    [PreserveSig]
    void PeekPrivateEvent([Out] out PrivateEventTypeEnum DataType, [Out] [MarshalAs(UnmanagedType.Struct)] out object Data);
    /// <summary>
    /// Method that posts data onto  Oblikovati's internal clipboard. Certain commands that usually obtain information using a dialog, i.e. Open, Save, etc., look first to see if data is on the clipboard before displaying the dialog. If valid information is on the clipboard the command will use it instead of displaying the dialog and asking the user to specify the filename.
    /// </summary>
    /// <param name="DataType">Input constant that specifies the type of value being pushed onto Autodesk Inventor's clipboard. Most often this will be kFileNameEvent.</param>
    /// <param name="Data">Input Variant that contains the actual data to push onto Autodesk Inventor's clipboard. When set the DateType as kBooleanEvent, then a NameValueMap object including the data name and value should be provided.</param>
    [PreserveSig]
    void PostPrivateEvent([In] PrivateEventTypeEnum DataType, [In] [MarshalAs(UnmanagedType.Struct)] object Data);
    /// <summary>
    /// Clears the contents of  Oblikovati's internal clipboard.
    /// </summary>
    [PreserveSig]
    void ClearPrivateEvents();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tag">Tag</param>
    /// <param name="Data">Data</param>
    [PreserveSig]
    void _PostPrivateEvent([In] [MarshalAs(UnmanagedType.BStr)] string Tag, [In] [MarshalAs(UnmanagedType.Struct)] object Data);
    /// <summary>
    /// Method that creates and returns a new InteractionEvents object. The InteractionEvents object is created for document that is currently active.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    InteractionEvents CreateInteractionEvents();
    /// <summary>
    /// Method that causes  Oblikovati to go through the pre-selection protocol, including firing of corresponding event out the active InteractionEvents object if one is active. If a native  Oblikovati command is active and is in a selection mode, it gets the pre-select notification just like a native pre-selection happened. This method is useful when you want to perform picking outside of the graphic window. For example if you have a browser that has icons that represent selectable objects you can cause the selection behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object, including custom graphics object, that needs to be understood as a candidate for selection by the active selection process in progress. This entity may have been picked by a means not known to native Autodesk Inventor (say a foreign browser).</param>
    [PreserveSig]
    void DoPreSelect([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Method that causes  Oblikovati to go through the stop pre-selection protocol, including firing of corresponding event out the active InteractionEvents object if one is active. If a native  Oblikovati command is active and is in a selection mode, it gets the stop pre-select notification just like a native stop pre-selection happened. This method is useful when you want to perform picking outside of the graphic window. For example if you have a browser that has icons that represent selectable objects you can cause the selection behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object, including custom graphics object, that needs to be understood as a candidate for selection by the active selection process in progress. This entity may have been picked by a means not known to native Autodesk Inventor (say a foreign browser).</param>
    [PreserveSig]
    void DoStopPreSelect([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Method that causes  Oblikovati to go through the selection protocol, including firing of corresponding event out the active InteractionEvents object if one is active. If a native  Oblikovati command is active and is in a selection mode, it gets the select notification just like a native selection happened. This method is useful when you want to perform picking outside of the graphic window. For example if you have a browser that has icons that represent selectable objects you can cause the selection behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object, including custom graphics object, that needs to be understood as a selection by the active selection process in progress. This entity may have been picked by a means not known to native Autodesk Inventor (say a foreign browser).</param>
    [PreserveSig]
    void DoSelect([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Method that causes  Oblikovati to go through the de-selection protocol, including firing of corresponding event out the active InteractionEvents object if one is active. If a native  Oblikovati command is active and is in a selection mode, it gets the de-select notification just like a native de-selection happened. This method is useful when you want to perform picking outside of the graphic window. For example if you have a browser that has icons that represent selectable objects you can cause the selection behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object, including custom graphics object, that needs to be understood as being de-selected by the active selection process in progress. This entity may have been picked by a means not known to native Autodesk Inventor (say a foreign browser).</param>
    [PreserveSig]
    void DoUnSelect([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// This method allows the developer to put up prompt messages (unless the user has suppressed this prompt) much like the Visual Basic MsgBox functionality.
    /// </summary>
    /// <param name="Prompt">The string that will appear in the dialog. The string can include "%s"  to indicate a string placeholder, while you can specify the string value using the PromptStrings argument.  The string can also specify the hyperlink with XML tags.</param>
    /// <param name="Buttons">Describes which buttons will be used, and which is the default answer. For example "vbOKCancel + vbDefaultButton1", or "vbYesNo".</param>
    /// <param name="Title">Each time you call the function, you can give it a new dialog title/caption. If not supplied, the title will default to "Inventor x", where x is the release number.</param>
    /// <param name="DefaultAnswer">The default response for the dialog. (vbOK, vbYes, etc.)</param>
    /// <param name="Restrictions">The client can specify which of the "don't ask me" options to allow (these options are grayed on the dialog). Also, in Inventor there is an option for which window should get focus when you exit the dialog (default is the mainframe window of Inventor). Zero or more of the following, in combination (can be added together with +): General options
    /// * kNoRestrictions (Allow all of the radio button options in the dialog "Don't ask ever again", "Don't ask again this session", for all buttons)
    /// * kDontAllowNeverAgain (Disable the "Don't ever as again" option)
    /// * kDontAllowNoMoreThisSession (Disable the "Don't ask again this session" option) Button 1 options (i.e. what is allowed/not allowed if button 1 is picked)
    /// * kDontAllowButton1NeverAgain (Disable the "Don't ever ask again" option if button 1 is selected)
    /// * kDontAllowButton1NoMoreThisSession (Disable the "No more this session") Button 2 options (i.e. what is allowed/not allowed if button 2 is picked)
    /// * kDontAllowButton2NeverAgain (Disable the "Don't ever ask again" option if button 1 is selected)
    /// * kDontAllowButton2NoMoreThisSession Button 3 options (i.e. what is allowed/not allowed if button 3 is picked)
    /// * kDontAllowButton3NeverAgain (Disable the "Don't ever ask again" option if button 1 is selected)
    /// * kDontAllowButton3NoMoreThisSession</param>
    /// <param name="PromptStrings">Optional input String or String array or Long value. If this input is Long it can indicate the parent window handler(HWND) for this prompt. If this argument is String or String array, and the input Prompt value includes "%s" then the "%s" will be replaced by this String value or String array sequentially.</param>
    /// <returns></returns>
    [PreserveSig]
    int PromptMessage([In] [MarshalAs(UnmanagedType.BStr)] string Prompt, [In] int Buttons, [In] [MarshalAs(UnmanagedType.Struct)] object? Title = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DefaultAnswer = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Restrictions = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default);
    /// <summary>
    /// Method that allows the user to pick a single entity.
    /// </summary>
    /// <param name="Filter">SelectionFilterEnum Entity filter</param>
    /// <param name="PromptText">Text to display as prompt.</param>
    /// <returns></returns>
    [PreserveSig]
    object Pick([In] SelectionFilterEnum Filter, [In] [MarshalAs(UnmanagedType.BStr)] string PromptText);
    /// <summary>
    /// Method that creates a new DragContext object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DragContext CreateDragContext();
    /// <summary>
    /// Method that creates a MiniToolbar object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MiniToolbar CreateMiniToolbar();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MessageID">MessageID</param>
    [PreserveSig]
    int _PromptMessage([In] [MarshalAs(UnmanagedType.BStr)] string MessageID);
}
