namespace Oblikovati.API;

/// <summary>
/// The AutoCADBlockDefinitions collection object provides access to all the existing AutoCADBlockDefinition objects in a (DWG) drawing document and provides methods to import additional definitions.
/// </summary>
public interface AutoCADBlockDefinitions : IEnumerable
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
    /// Returns the specified AutoCADBlockDefinition object from the collection.
    /// </summary>
    AutoCADBlockDefinition this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that imports AutoCAD block definitions from an AutoCAD or an Oblikovati DWG file.
    /// </summary>
    /// <param name="DWGFullFileName">Input String that specifies the full file name of the AutoCAD or Inventor DWG file from which to import the definitions.</param>
    /// <param name="DefinitionNames">Optional input array of strings that specifies the names of the definitions to import from the source file. If not specified, all AutoCAD block definitions are imported.</param>
    /// <param name="ReplaceExisting">Optional input Boolean that specifies whether to replace or create a new definition with a different name if a definition of the same name exists in the target document. If not specified, the argument defaults to False indicating that a new definition will be created.</param>
    /// <returns></returns>
    [PreserveSig]
    AutoCADBlockDefinitionsEnumerator AddFromFile([In] [MarshalAs(UnmanagedType.BStr)] string DWGFullFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? DefinitionNames = default, [In] bool? ReplaceExisting = false);
}
