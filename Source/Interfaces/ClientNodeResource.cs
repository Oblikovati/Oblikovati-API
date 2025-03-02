namespace Oblikovati.API;

/// <summary>
/// This object is accessible through the BrowserPane. But it is in fact, just the one associated with the Document. In other words, all of the ClientNodeResource objects that are used inside the various BrowserPanes of this Document are to be found here.
/// </summary>
public interface ClientNodeResource
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of this object. Though this document is reachable from the BrowserPane out of convenience, it's true parent is the Document itself. That is, this object is not BrowserPane specific, rather, it has its scope or influence across all BrowserPanes (of the TreeBrowser kind).
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp Icon { get; set; }
    /// <summary>
    /// Property returning the integer identifier that was supplied during the creation of this resource.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Property returning the string identifier that stood for the client or AddIn that was supplied during the creation of this resource.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Gets and sets picture name associated with a ClientNodeResource object.
    /// </summary>
    string IconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes invisible.
    /// </summary>
    string InvisibleIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes suppressed.
    /// </summary>
    string SuppressedIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes disabled.
    /// </summary>
    string DisabledIconName { get; set; }
    /// <summary>
    /// Gets and sets the expanded icon name to be used when the associated data model object becomes invisible.
    /// </summary>
    string ExpandedInvisibleIconName { get; set; }
    /// <summary>
    /// Gets and sets the expanded icon name to be used when the associated data model object becomes suppressed.
    /// </summary>
    string ExpandedSuppressedIconName { get; set; }
    /// <summary>
    /// Gets and sets the expanded icon name to be used when the associated data model objects becomes disabled.
    /// </summary>
    string ExpandedDisabledIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes grounded.
    /// </summary>
    string GroundedIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes grounded and suppressed.
    /// </summary>
    string GroundedSuppressedIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes grounded and invisible.
    /// </summary>
    string GroundedInvisibleIconName { get; set; }
    /// <summary>
    /// Gets and sets the icon name to be used when the associated data model object becomes grounded and disabled.
    /// </summary>
    string GroundedDisabledIconName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp InvisibleIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp SuppressedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp DisabledIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp ExpandedInvisibleIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp ExpandedSuppressedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp ExpandedDisabledIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp GroundedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp GroundedSuppressedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp GroundedInvisibleIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp GroundedDisabledIcon { get; set; }
    /// <summary>
    /// Method that gets rid of this object. If it is being used currently by some node definition object, the method fails.
    /// </summary>
    [PreserveSig]
    void Delete();
}
