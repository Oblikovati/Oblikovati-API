namespace Oblikovati.API;

/// <summary>
/// GeneralNoteSymbolDefinition Object.
/// </summary>
public interface GeneralNoteSymbolDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelGeneralNoteDefinition Parent { get; }
    /// <summary>
    /// Get the height of the text within the GeneralNote.
    /// </summary>
    object SymbolDefinition { get; set; }
    /// <summary>
    /// Get whether the GeneralNote is tightly fitted to the text box.
    /// </summary>
    [PreserveSig]
    void Delete();
}
