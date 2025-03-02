namespace Oblikovati.API;

/// <summary>
/// SketchedSymbolDefinitionLibraries Object.
/// </summary>
public interface SketchedSymbolDefinitionLibraries : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    SketchedSymbolDefinitionLibrary this[object Index] { get; }
    /// <summary>
    /// Creates a new sketch symbol library.
    /// </summary>
    /// <param name="Name">Input String that specifies the sketched symbol library name. The name should be unique in the libraries collection</param>
    /// <returns></returns>
    [PreserveSig]
    SketchedSymbolDefinitionLibrary Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
}
