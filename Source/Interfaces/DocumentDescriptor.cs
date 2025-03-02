namespace Oblikovati.API;

/// <summary>
/// The DocumentDescriptor object represents a native document reference.
/// </summary>
public interface DocumentDescriptor
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
    /// Property that returns the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the display name of the referenced document as currently found (or the last known display name, if the reference is not found).
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the full path name of the referenced document as currently found (or the last known full document name, if the reference is not found).
    /// </summary>
    string FullDocumentName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LevelOfDetailEnum ReferencedLevelOfDetail { get; }
    /// <summary>
    /// Property that returns the Document object being referenced.
    /// </summary>
    object ReferencedDocument { get; }
    /// <summary>
    /// Property that returns type of the referenced document.
    /// </summary>
    DocumentTypeEnum ReferencedDocumentType { get; }
    /// <summary>
    /// Property that returns the descriptor object for the file object that contains the referenced document.
    /// </summary>
    FileDescriptor ReferencedFileDescriptor { get; }
    /// <summary>
    /// Property that returns whether the referenced document is missing (unresolved or suppressed).
    /// </summary>
    bool ReferenceMissing { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ReferenceReplaced { get; }
    /// <summary>
    /// Property that returns whether the reference is currently suppressed.
    /// </summary>
    bool ReferenceSuppressed { get; }
    /// <summary>
    /// Gets whether the link to this file is disabled.
    /// </summary>
    bool ReferenceDisabled { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileOwnershipEnum OwnershipType { get; set; }
    /// <summary>
    /// Gets whether the internal name of the referenced file is different from the last time the parent (referencing) file was saved. A value of True indicates that the currently referenced file has a different internal name than the originally referenced file.
    /// </summary>
    bool ReferenceInternalNameDifferent { get; }
    /// <summary>
    /// Gets whether the file path or the file name of the referenced document is different from the last time the parent (referencing) document was saved. A value of True indicates that the currently referenced document has a different file path or file name.
    /// </summary>
    bool ReferenceLocationDifferent { get; }
    /// <summary>
    /// Read-only property that returns the model state type of the referenced document.
    /// </summary>
    ModelStateTypeEnum ReferencedModelState { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsSubstituteOccurrence { get; }
}
