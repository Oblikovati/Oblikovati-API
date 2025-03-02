namespace Oblikovati.API;

/// <summary>
/// The ErrorManager object contains methods and properties to get errors and warnings that occurred during an API call, add to Inventor's errors or to display them.
/// </summary>
public interface ErrorManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Application object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns an XML string containing all messages (errors and warnings).
    /// </summary>
    string AllMessages { get; }
    /// <summary>
    /// Property that returns whether there are any recorded errors.
    /// </summary>
    bool HasErrors { get; }
    /// <summary>
    /// Property that returns whether there are any recorded warnings.
    /// </summary>
    bool HasWarnings { get; }
    /// <summary>
    /// Property that returns whether there is any message section active.
    /// </summary>
    bool IsMessageSectionActive { get; }
    /// <summary>
    /// Property that returns the last recorded error/warning message. If there is a tree of errors/warnings, this property returns the most recent leaf error/warning.
    /// </summary>
    string LastMessage { get; }
    /// <summary>
    /// Method that adds a new message at the current level in the message tree.
    /// </summary>
    /// <param name="Message">Input String that specifies the error or warning message.</param>
    /// <param name="Error">Input Boolean that specifies whether this is an error or a warning. True indicates error.</param>
    /// <param name="Reserved">Optional input Variant reserved for future use. Currently unused.</param>
    [PreserveSig]
    void AddMessage([In] [MarshalAs(UnmanagedType.BStr)] string Message, [In] bool Error, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default);
    /// <summary>
    /// Method that clears all errors and warnings. This method returns a failure if there are any active message sections (indicated by the IsMessageSectionActive property).
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Method that displays the current error/warning or the stack of errors/warnings to the user.
    /// </summary>
    /// <param name="Title">Input string that specifies the title of the message dialog. The display name of the product (e.g. 'Autodesk Inventor 2010 ' ') is prefixed to the string automatically.</param>
    /// <param name="AllowAccept">Input Boolean that indicates whether the 'Accept' button should be available. This user choice implies that the user would like to continue despite any errors/warnings.</param>
    /// <param name="AllowEdit">Input Boolean that indicates whether the 'Edit' button should be available. This user choice implies that implies that the user would like to go back into the command to correct the situation.</param>
    /// <returns></returns>
    [PreserveSig]
    ButtonTypeEnum Show([In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] bool AllowAccept, [In] bool AllowEdit);
    /// <summary>
    /// Method that starts a message section and returns a MessageSection object which can be used to clear, adopt or retain error/warning messages created during the section.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MessageSection StartMessageSection();
}
