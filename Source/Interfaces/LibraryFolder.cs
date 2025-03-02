namespace Oblikovati.API;

/// <summary>
/// LibraryFolder Object.
/// </summary>
public interface LibraryFolder
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SketchedSymbolDefinitionLibrary Parent { get; }
    /// <summary>
    /// Read-only property that returns the parent LibraryFolder for this library folder object.
    /// </summary>
    LibraryFolder ParentFolder { get; }
    /// <summary>
    /// Read-only property that returns a collection of all library folders contained directly under this folder in the library.
    /// </summary>
    LibraryFolders ChildFolders { get; }
    /// <summary>
    /// Read-only property that returns the name of the library folder object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the collection of library sketched symbol definitions under this library folder object.
    /// </summary>
    LibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}
