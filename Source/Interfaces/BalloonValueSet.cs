namespace Oblikovati.API;

/// <summary>
/// The BalloonValueSet object allows for setting and overriding of balloon content.
/// </summary>
public interface BalloonValueSet
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
    /// Gets and sets the value of the balloon.&nbsp;This value corresponds to the item number of a row in a parts list if any have been created.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Gets and sets the override value of the balloon.
    /// </summary>
    string OverrideValue { get; set; }
    /// <summary>
    /// Property returning the parent balloon.
    /// </summary>
    Balloon Parent { get; }
    /// <summary>
    /// Property that returns the referenced DrawingBOMRow object.
    /// </summary>
    DrawingBOMRow ReferencedRow { get; }
    /// <summary>
    /// Gets and sets whether the Value property has been overridden.
    /// </summary>
    bool Static { get; set; }
    /// <summary>
    /// Returns the associated item number.
    /// </summary>
    string ItemNumber { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptors ReferencedFiles { get; }
    /// <summary>
    /// Deletes this BalloonValueSet object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
