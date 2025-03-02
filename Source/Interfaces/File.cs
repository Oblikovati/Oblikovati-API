namespace Oblikovati.API;

/// <summary>
/// The File object represents an Inventor file on disk.
/// </summary>
public interface File
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
    /// Property that returns an enumeration of all the documents within this file that are currently available (i.e. have been initialized). The returned documents may or may not be open. The property returns a DocumentsEnumerator object in Inventor and a ApprenticeServerDocuments in Apprentice.
    /// </summary>
    object AvailableDocuments { get; }
    /// <summary>
    /// Gets and sets the fully qualified name of this file. This property can only be set if this file has never been saved.
    /// </summary>
    string FullFileName { get; set; }
    /// <summary>
    /// Property that returns an enumeration of descriptors that represent the direct file references held by this file.
    /// </summary>
    FileDescriptorsEnumerator ReferencedFileDescriptors { get; }
    /// <summary>
    /// Property that returns all the files directly referenced by this file.
    /// </summary>
    FilesEnumerator ReferencedFiles { get; }
    /// <summary>
    /// Property that returns all the files in memory that reference this file.
    /// </summary>
    FilesEnumerator ReferencingFiles { get; }
    /// <summary>
    /// Property that returns all the file references of this File along with all of the recursively nested references.
    /// </summary>
    FilesEnumerator AllReferencedFiles { get; }
    /// <summary>
    /// Property that gets the Internal Name (a GUID) for this File.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Returns the number that is indicative of the number of times the file has been saved.
    /// </summary>
    int FileSaveCounter { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileOwnershipEnum OwnershipType { get; }
    /// <summary>
    /// Gets the GUID that represents the last saved revision of this file. Works as a stamp of the contents of this file.
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Gets the GUID that represents the last saved revision of database contained in this file. This revision id tracks modifications to the database (such as reference changes, geometry changes, etc.) but does not track file property changes.
    /// </summary>
    string DatabaseRevisionId { get; }
    /// <summary>
    /// Read-only property that returns whether any documents within this file is loaded or not.
    /// </summary>
    bool HasLoadedDocuments { get; }
    /// <summary>
    /// Read-only property that returns whether this file is referenced by any other files in memory or not.
    /// </summary>
    bool HasReferencingFiles { get; }
    /// <summary>
    /// Read-only property that returns object that encapsulates version of the software with which this file was created.
    /// </summary>
    SoftwareVersion SoftwareVersionCreated { get; }
    /// <summary>
    /// Read-only property that returns object that encapsulates version of the software with which this file was last saved.
    /// </summary>
    SoftwareVersion SoftwareVersionSaved { get; }
}
