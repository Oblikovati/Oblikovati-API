namespace Oblikovati.API;

/// <summary>
/// Provides a means for an application to register an interest in a document. In order words, to flag the document as containing application-specific data, and to set the data version (for example, so Inventor can determine whether data migration is required and so fire the appropriate event).
/// </summary>
public interface DocumentInterest
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
    /// Property that returns the parent document object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the ClientId associated with the DocumentInterest indicating the owner of this object.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Property that returns the non-localized name associated with this interest.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets/Sets the type of interest that the client has in this document.
    /// </summary>
    DocumentInterestTypeEnum InterestType { get; set; }
    /// <summary>
    /// Gets/Sets the current data version of the document. If the property returns -1 or is set to -1, this is assumed to be a 'non-migrating' type of interest.
    /// </summary>
    int DataVersion { get; set; }
    /// <summary>
    /// Gets/Sets additional data that the client would like to store with the interest. This string is not interpreted by Inventor.
    /// </summary>
    string ClientData { get; set; }
    /// <summary>
    /// Method that deletes the DocumentInterest object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
