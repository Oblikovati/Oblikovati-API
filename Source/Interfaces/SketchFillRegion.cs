namespace Oblikovati.API;

/// <summary>
/// An object representing a color-filled region in a drawing sketch.
/// </summary>
public interface SketchFillRegion
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
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property to gets the profile object associated with this sketch fill region.
    /// </summary>
    Profile Profile { get; }
    /// <summary>
    /// Gets and sets the color of the sketch fill region.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method to delete this SketchFillRegion object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
