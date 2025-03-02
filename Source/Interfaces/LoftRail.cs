namespace Oblikovati.API;

/// <summary>
/// The LoftRail object is used to define a rail in a loft feature.
/// </summary>
public interface LoftRail
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
    /// Property that specifies whether the rail has conditions associated with it.
    /// </summary>
    bool HasConditions { get; }
    /// <summary>
    /// Returns an enum indicating the condition of the loft at the rail if the rail has conditions associated with it.
    /// </summary>
    LoftConditionEnum Condition { get; set; }
    /// <summary>
    /// Property that returns the Parameter object that controls the amount of influence the rail has on the shape of the entire loft.
    /// </summary>
    Parameter Impact { get; }
    /// <summary>
    /// Property that gets the rail for the loft feature.
    /// </summary>
    object Rail { get; }
    /// <summary>
    /// Method that deletes this loft rail.
    /// </summary>
    [PreserveSig]
    void Delete();
}
