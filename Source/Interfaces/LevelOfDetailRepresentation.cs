namespace Oblikovati.API;

/// <summary>
/// The LevelOfDetailRepresentation object represents a positional representation in the assembly.
/// </summary>
public interface LevelOfDetailRepresentation
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
    /// Property that returns the parent RepresentationsManager object.
    /// </summary>
    RepresentationsManager Parent { get; }
    /// <summary>
    /// Gets and sets the name of the LevelOfDetailRepresentation.&nbsp;The name must be unique with respect to all other LevelOfDetailRepresentation objects in the document, or an error will occur.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the enum indicating the LOD type.
    /// </summary>
    LevelOfDetailEnum LevelOfDetail { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence object associated with this level of detail representation.
    /// </summary>
    ComponentOccurrence SubstituteOccurrence { get; }
    /// <summary>
    /// Property that returns the DocumentDescriptor of the document associated with the substitute occurrence.
    /// </summary>
    DocumentDescriptor SubstituteDocumentDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelState _MigrateToModelState { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentOccurrencesEnumerator _ComponentsForLegacySysLOD { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsRetiredLOD { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that activates the level of detail representation.
    /// </summary>
    /// <param name="SkipDocumentSave">Optional input Boolean that specifies whether ignore the document save when activate this LOD or not. This default to True if not specified.</param>
    [PreserveSig]
    void Activate([In] bool? SkipDocumentSave = false);
    /// <summary>
    /// Method that creates a copy of the LevelOfDetailRepresentation. The new created LevelOfDetailRepresentation is returned.
    /// </summary>
    /// <param name="NewName">Optional input string that specifies the name of the level of detail representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <returns></returns>
    [PreserveSig]
    LevelOfDetailRepresentation Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that deletes the LevelOfDetailRepresentation. The method returns an error if this is a built-in LOD representation.
    /// </summary>
    [PreserveSig]
    void Delete();
}
