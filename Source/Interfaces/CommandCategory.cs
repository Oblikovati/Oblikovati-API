namespace Oblikovati.API;

/// <summary>
/// The CommandCategory object represents the list of commands that are displayed in the Customize dialog. Command categories serve as a logical grouping of commands to allow the user to more easily find a specific command. See the article in the overviews section.
/// </summary>
public interface CommandCategory : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    CommandManager Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that specifies if the control or definition is a standard Autodesk Inventor control or definition. Built-in ones have restrictions in the edits that can be performed.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that returns the number of commands in this category.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the display name of the command category. This is the name displayed to the user and can vary between locales.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the name of the command category. The name is the internal English name of the command category. This name will remain constant and is not affected by locale. The name is never displayed to the user. The display name is what's shown to the user.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Returns the specified object in the collection.
    /// </summary>
    object this[int Index] { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Returns the specified ControlDefinition or CommandBar object.
    /// </summary>
    object ItemByName { get; }
    /// <summary>
    /// Method that adds a control definition or a command bar to the command category.
    /// </summary>
    /// <param name="Command">Input object to be added to this command category. This object can either be a ControlDefinition or a CommandBar. An error will occur if a built-in ControlDefinition or CommandBar is supplied.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Command);
    /// <summary>
    /// Method that deletes the command category. If this category contains commands, these are moved to the default command category. This method fails for built-in categories.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that removes a control definition or a command bar from the command category.
    /// </summary>
    /// <param name="Index">Input Long that specifies the index within the collection of the item to return.</param>
    [PreserveSig]
    void Remove([In] int Index);
}
