namespace Oblikovati.API;

/// <summary>
/// This object represents a list of commands that are disabled in the given context. For example, a DisabledCommandList collection in the document context lists all commands disabled at the document level, while a DisabledCommandList collection at the environment level list commands disabled in a given environment. This collection object compliments the Enabled property of the ControlDefinition object.
/// </summary>
public interface DisabledCommandList : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read only property that returns the number of commands in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ControlDefinition from the list.
    /// </summary>
    ControlDefinition this[int Index] { get; }
    /// <summary>
    /// Method that adds the specified command to the list.
    /// </summary>
    /// <param name="Command">Input ControlDefinition object that is to be added to the disabled command list.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] ControlDefinition Command);
    /// <summary>
    /// Method that removes the specified command from the list.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the ControlDefinition object to remove from the list. The first item in the list has an index of one.</param>
    [PreserveSig]
    void Remove([In] int Index);
}
