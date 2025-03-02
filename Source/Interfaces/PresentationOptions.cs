namespace Oblikovati.API;

/// <summary>
/// The PresentationOptions object provides access to properties that provide read and write access of the presentation related application options.
/// </summary>
public interface PresentationOptions
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Enables/disables skip all unresolved files during openning.
    /// </summary>
    bool SkipAllUnresolvedFiles { get; set; }
}
