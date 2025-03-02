namespace Oblikovati.API;

/// <summary>
/// A MessageSection object can be used to clear, adopt or retain error/warning messages created during the section.
/// </summary>
public interface MessageSection
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
    /// Property that returns the parent ErrorManager object.
    /// </summary>
    ErrorManager Parent { get; }
    /// <summary>
    /// Property that returns whether this message section has any errors reported in it.
    /// </summary>
    bool HasErrors { get; }
    /// <summary>
    /// Property that returns whether this message section has any warnings reported in it.
    /// </summary>
    bool HasWarnings { get; }
    /// <summary>
    /// Method that adopts all messages within this section under the specified message and terminates the section.
    /// </summary>
    /// <param name="Message">Input String that specifies the error or warning message to be used as the parent of existing messages.</param>
    /// <param name="Error">Input Boolean that specifies whether this is an error or a warning. True indicates error.</param>
    /// <param name="Reserved">Optional input Variant reserved for future use. Currently unused.</param>
    [PreserveSig]
    void AdoptMessages([In] [MarshalAs(UnmanagedType.BStr)] string Message, [In] bool Error, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default);
    /// <summary>
    /// Method that clears all messages within this section and terminates the section.
    /// </summary>
    [PreserveSig]
    void ClearMessages();
    /// <summary>
    /// Method that retains all the messages within this section as is and terminates the section. Calling this method is not required if either the ClearMessages or the AdoptMessages method has been called.
    /// </summary>
    [PreserveSig]
    void End();
}
