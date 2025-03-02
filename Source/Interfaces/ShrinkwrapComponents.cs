namespace Oblikovati.API;

/// <summary>
/// The ShrinkwrapComponents collection object provides access to all of the existing ShrinkwrapComponent objects in a part and provides methods to create additional shrinkwrap components.
/// </summary>
public interface ShrinkwrapComponents : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified ShrinkwrapComponent object from the collection.
    /// </summary>
    ShrinkwrapComponent Item { get; }
    /// <summary>
    /// Read-only property returning kShrinkwrapComponentsObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Creates a new ShrinkwrapComponent using the information supplied by the input ShrinkwrapDefinition object.
    /// </summary>
    /// <param name="Definition">Input ShrinkwrapDefinition object that defines the shrinkwrap component.</param>
    /// <returns></returns>
    [PreserveSig]
    ShrinkwrapComponent Add([In] [MarshalAs(UnmanagedType.Interface)] ShrinkwrapDefinition Definition);
    /// <summary>
    /// Creates a new ShrinkwrapDefinition object.
    /// </summary>
    /// <param name="FullDocumentName">Input string that specifies the name of the file to create the definition for.  The file must be an existing assembly document.  If an invalid file is specified an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    ShrinkwrapDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
}
