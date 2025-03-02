namespace Oblikovati.API;

/// <summary>
/// SketchedSymbolDefinitionLibrary Object.
/// </summary>
public interface SketchedSymbolDefinitionLibrary
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
    /// Read-only property that returns whether this sketched symbol definition library is read only.
    /// </summary>
    bool IsReadOnly { get; }
    /// <summary>
    /// Read-only property that returns the LibraryFolders collection object.
    /// </summary>
    LibraryFolders Folders { get; }
    /// <summary>
    /// Read-only property that returns the name of the sketched symbol definition library.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the LibrarySketchedSymbolDefinitions collection object.
    /// </summary>
    LibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}
