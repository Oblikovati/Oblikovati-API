namespace Oblikovati.API;

/// <summary>
/// The CommandBarList object defines a list of objects that are displayed to the users in various contexts.
/// </summary>
public interface CommandBarList : IEnumerable
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
    /// Property that returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    CommandBar this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of command bars currently in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that specifies if this list is to inherit all of the command bars from the parent environment.
    /// </summary>
    bool InheritAll { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandBar">CommandBar</param>
    [PreserveSig]
    void _Add([In] [MarshalAs(UnmanagedType.IDispatch)] object CommandBar);
    /// <summary>
    /// Method that adds a new CommandBar object to the list.
    /// </summary>
    /// <param name="CommandBar">Input object to add to the list.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar);
    /// <summary>
    /// Method that removes the specified CommandBar from the list.
    /// </summary>
    /// <param name="Index">Input Long that specifies the index within the collection of the item to return.</param>
    [PreserveSig]
    void Remove([In] int Index);
}
