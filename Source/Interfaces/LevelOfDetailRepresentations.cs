namespace Oblikovati.API;

/// <summary>
/// The LevelOfDetailRepresentations collection object provides access to all the LOD (Level Of Detail) representations in the assembly and provides methods to create new ones.
/// </summary>
public interface LevelOfDetailRepresentations : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified LevelOfDetailRepresentation object from the collection.
    /// </summary>
    LevelOfDetailRepresentation this[object Index] { get; }
    /// <summary>
    /// Method that creates a new LevelOfDetailRepresentation. The newly created LevelOfDetailRepresentation is returned.
    /// </summary>
    /// <param name="Name">Optional input string that specifies the name of the LOD representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <returns></returns>
    [PreserveSig]
    LevelOfDetailRepresentation Add([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a new substitute LevelOfDetailRepresentation based on the input file. The newly created LevelOfDetailRepresentation is returned.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full name of the file to create the substitute LOD with.</param>
    /// <param name="Name">Optional input string that specifies the name of the LOD representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <param name="SkipDocumentSave">Optional input Boolean that indicates whether to suppress the save dialogs that appear for dirty documents that are about to be closed as a result of this action. If set to True, any edits performed on the documents needing to be closed are lost. Also, any document never saved to disk and needing to be closed is lost. The default value is False indicating that the user will be prompted to save documents about to be closed.</param>
    /// <returns></returns>
    [PreserveSig]
    LevelOfDetailRepresentation AddSubstitute([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] bool? SkipDocumentSave = false);
}
