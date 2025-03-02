namespace Oblikovati.API;

/// <summary>
/// The PartsListCell object represents an individual cell in the parts list table.
/// </summary>
public interface PartsListCell
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
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    PartsList Parent { get; }
    /// <summary>
    /// Gets or sets the value of the cell in the parts list table.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Gets whether the value of the cell is static.
    /// </summary>
    bool Static { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    bool UpToDate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Update();
}
