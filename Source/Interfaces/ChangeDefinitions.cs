namespace Oblikovati.API;

/// <summary>
/// The ChangeDefinitions collection object provides access to all the objects created by a particular client and provides a method to create additional ChangeDefinitions. See the topic in the overview section.
/// </summary>
public interface ChangeDefinitions : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property indicating the Client Id string that uniquely identifies this definitions collection.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Returns the specified ChangeDefinition object from the collection.
    /// </summary>
    ChangeDefinition this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ChangeDefinition. The newly created ChangeDefinition is returned.
    /// </summary>
    /// <param name="InternalName">Input String that defines the name of the new ChangeDefinition. The name specified must be unique with respect to the other change definitions in the collection. If a unique name is not specified, an error will occur.</param>
    /// <param name="CommandName">Input String that defines the localized command name that will show up in the undo list.</param>
    /// <returns></returns>
    [PreserveSig]
    ChangeDefinition Add([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string CommandName);
    /// <summary>
    /// Method to delete this collection and all objects contained within it.
    /// </summary>
    [PreserveSig]
    void Delete();
}
