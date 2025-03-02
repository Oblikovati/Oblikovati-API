namespace Oblikovati.API;

/// <summary>
/// LibrarySketchedSymbolDefinition Object.
/// </summary>
public interface LibrarySketchedSymbolDefinition
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
    /// Read-only property that returns the name of the library sketched symbol definition.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the parent LibraryFolder for this library sketched symbol definition object.
    /// </summary>
    LibraryFolder ParentFolder { get; }
}
