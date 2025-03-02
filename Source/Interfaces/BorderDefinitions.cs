namespace Oblikovati.API;

/// <summary>
/// The BorderDefinitions collection object provides access to all the existing objects in a drawing document and provides methods to create additional border definitions.
/// </summary>
public interface BorderDefinitions : IEnumerable
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
    /// Returns the specified BorderDefinition object from the collection.
    /// </summary>
    BorderDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new border definition. The new BorderDefinition object is returned. This method will fail in the case where a sketch is currently active. You can check for this case using the ActiveEditObject property of the Application object to see if a sketch is active.
    /// </summary>
    /// <param name="Name">Input String that defines the name of the new border definition. The name specified must be unique with respect to the other border definitions in the document. If a unique name is not specified, an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    BorderDefinition Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
}
