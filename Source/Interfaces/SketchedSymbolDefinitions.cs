namespace Oblikovati.API;

/// <summary>
/// The SketchedSymbolDefinitions collection object provides access to all the existing objects in a drawing document and provides methods to create additional sketched symbol definitions. See the article in the overviews section.
/// </summary>
public interface SketchedSymbolDefinitions : IEnumerable
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
    /// Method that returns the specified SketchedSymbolDefinition object from the collection.
    /// </summary>
    SketchedSymbolDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the SketchedSymbolDefinitionLibraries collection object.
    /// </summary>
    SketchedSymbolDefinitionLibraries SketchedSymbolDefinitionLibraries { get; }
    /// <summary>
    /// Method that creates a new sketched symbol definition. This method will fail in the case where a sketch is currently active. You can check for this case using the ActiveEditObject property of the Application object to see if a sketch is active.
    /// </summary>
    /// <param name="Name">Input String that defines name of the sketched symbol definition. The name specified must be unique with respect to the other sketched symbol definitions in the document. If a unique name is not specified, an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchedSymbolDefinition Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Imports a new sketched symbol definition from library.
    /// </summary>
    /// <param name="SketchedSymbolDefinitionLibrary">Input SketchedSymbolDefinitionLibrary object or String that specifies the sketched symbol library name.</param>
    /// <param name="SketchedSymbolDefinitionName">Input String that specifies the name of the sketched symbol definition in the library.</param>
    /// <param name="ReplaceExisting">Optional input Boolean that specifies whether replace the existing sketched symbol definition in the document if one with the same name is found in the document.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchedSymbolDefinition AddFromLibrary([In] [MarshalAs(UnmanagedType.Struct)] object SketchedSymbolDefinitionLibrary, [In] [MarshalAs(UnmanagedType.BStr)] string SketchedSymbolDefinitionName, [In] [MarshalAs(UnmanagedType.Struct)] object? ReplaceExisting = default);
    /// <summary>
    /// Saves all the sketched symbol definitions in current document to the specified library.
    /// </summary>
    /// <param name="TargetSketchedSymbolDefinitionLibrary">Input SketchedSymbolDefinitionLibrary  object or String that specifies the sketched symbol library name.</param>
    /// <param name="RetainResourceFolderStructure">Optional input Boolean that specifies whether retain resource folder structure when save sketched symbol definitions to the library.  This defaults to True indicating the resource folder structure will be retained.</param>
    /// <param name="DestinationFolder">Optional input LibraryFolder that specifies destination folder to save the sketched symbol definition to.</param>
    /// <param name="ReplaceExisting">Optional input Boolean that specifies whether replace the existing sketched symbol definitions in the library if they have same names with the definitions that are being saved to the library.</param>
    [PreserveSig]
    void SaveAllToLibrary([In] [MarshalAs(UnmanagedType.Struct)] object TargetSketchedSymbolDefinitionLibrary, [In] [MarshalAs(UnmanagedType.Struct)] object? RetainResourceFolderStructure = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DestinationFolder = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ReplaceExisting = default);
}
