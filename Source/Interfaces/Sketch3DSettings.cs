namespace Oblikovati.API;

/// <summary>
/// The Sketch3DSettings object provides access to properties that provide read and write access of the various 3D sketch related document specific settings. This is somewhat equivalent to the 3D sketch related properties on Sketch tab of the Document Settings dialog.
/// </summary>
public interface Sketch3DSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Document object.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the default radius used for corner bends.
    /// </summary>
    string AutoBendRadius { get; set; }
}
