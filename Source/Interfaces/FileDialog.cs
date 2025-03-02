namespace Oblikovati.API;

/// <summary>
/// The FileDialog object represents the Inventor dialogs that are displayed when the user invokes the Place Component or Save As command. In the API, the FileDialog object provides the ability to use these same dialogs when a filename is needed from the user. It is very similar in concept to the Microsoft common file control.
/// </summary>
public interface FileDialog
{
    /// <summary>
    /// Generate error when user cancels dialog if true.
    /// </summary>
    bool CancelError { get; set; }
    /// <summary>
    /// The string displayed in the dialog's title bar.
    /// </summary>
    string DialogTitle { get; set; }
    /// <summary>
    /// The selected filename.&nbsp;Can be pre-set to initialize the selected filename in the dialog.
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// The filter used to limit the types of files displayed in the dialog.
    /// </summary>
    string Filter { get; set; }
    /// <summary>
    /// The index of the default filter in the filter string (first index is 1).
    /// </summary>
    int FilterIndex { get; set; }
    /// <summary>
    /// The initial directory displayed in the file dialog.&nbsp;This can also be set with the filename property.
    /// </summary>
    string InitialDirectory { get; set; }
    /// <summary>
    /// Specifies whether or not to warn that a file is being saved outside of a project resolvable location.
    /// </summary>
    bool SuppressResolutionWarnings { get; set; }
    /// <summary>
    /// Gets and sets whether the 'Options' button on the dialog is enabled. If the button is enabled and the user clicks it, the OnOptions event is fired.
    /// </summary>
    bool OptionsEnabled { get; set; }
    /// <summary>
    /// Property that returns the FileDialogEvents object.
    /// </summary>
    FileDialogEvents FileDialogEvents { get; }
    /// <summary>
    /// Gets and sets whether the 'Open' dialog should allow the selection of multiple files.&nbsp;If multiple files are selected by the user, the FileName property returns a string containing all selected file names delimited by a vertical bar ('|').
    /// </summary>
    bool MultiSelectEnabled { get; set; }
    /// <summary>
    /// Gets and sets whether the FileDialog is being used for inserting a file (as opposed to opening one). If set to True, the OnFileInsertDialog event is fired by the ShowOpen method; if set to False, the OnFileOpenDialog event is fired. This defaults to True when a FileDialog is created.
    /// </summary>
    bool InsertMode { get; set; }
    /// <summary>
    /// Read-only property that returns the settings the user specified in the options dialog when a file type known to Inventor was selected. This includes the standard Inventor types (.ipt, .iam, .idw, etc.) and also any files types supported by any translator add-ins. In the case where it’s an unknown type (i.e. .txt, .xml), or if no options were specified this property will return Nothing.
    /// The NameValueMap that’s returned can be used directly as the NameValueMap for the corresponding translator add-in.
    /// </summary>
    NameValueMap OptionValues { get; }
    /// <summary>
    /// Gets and sets whether the quick launch controls on the dialog are visible or not. When the dialog is in insert mode the quick launch controls will be always hidden, so to show the quick launch controls the InsertMode should be set to False also.
    /// </summary>
    bool ShowQuickLaunch { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableSkipAllUnresolvedFilesOption { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableLODRepresentationOption { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DesignViewAssociative { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowExistingDesignViewsOnlyInDropdown { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowExistingLevelOfDetailsOnlyInDropdown { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Details { get; set; }
    /// <summary>
    /// Method that displays the Save As dialog. If the user selects an existing file a warning message is displayed notifying them that the file already exists and the file will be overwritten if they continue. The use of this method does not actually perform a save but only returns the filename the user has specified through the dialog.
    /// </summary>
    [PreserveSig]
    void ShowSave();
    /// <summary>
    /// Method that displays the open dialog. The existence of the specified file is checked for by the dialog, so only valid filenames will be returned. This does not actually open the file but only returns the filename the user has specified through the dialog.
    /// </summary>
    [PreserveSig]
    void ShowOpen();
    /// <summary>
    /// Method that sets the HTML Help Context to display when the help button is pressed in the FileDialog.
    /// </summary>
    /// <param name="FileName">Input string that specifies the path of the HTML(.chm) file or a website address.</param>
    /// <param name="Context">Input Long that specifies the HTML help context or -1 when the FileName is specified with a website address.</param>
    [PreserveSig]
    void SetHelpContext([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] int Context);
    /// <summary>
    /// Method that sets the HTML Help Topic to display when the help button is pressed in the FileDialog.
    /// </summary>
    /// <param name="FileName">Input string that specifies the name of the HTML file.</param>
    /// <param name="TopicName">Input string that specifies the HTML topic to display.</param>
    [PreserveSig]
    void SetHelpTopic([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] [MarshalAs(UnmanagedType.BStr)] string TopicName);
}
