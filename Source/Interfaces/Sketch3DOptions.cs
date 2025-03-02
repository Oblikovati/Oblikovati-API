namespace Oblikovati.API;

/// <summary>
/// The Sketch3DOptions object provides access to properties that provide read and write access of the 3D sketch related application options. This is somewhat equivalent to the 3D Sketch portion on the Sketch tab of the Application Options dialog.
/// </summary>
public interface Sketch3DOptions
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
    /// Enables/disables automatically creating corner bends on 3D lines.
    /// </summary>
    bool AutoBendWithLineCreation { get; set; }
}
