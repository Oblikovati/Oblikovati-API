namespace Oblikovati.API;

/// <summary>
/// The DirectionAndDistanceMoveDefinition object defines all of the inputs that are unique to a move face feature defined using a direction vector and a distance.
/// </summary>
public interface DirectionAndDistanceMoveDefinition
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
    /// Property that returns the parent MoveFaceDefinition object.
    /// </summary>
    MoveFaceDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the entity defining the direction for the move.
    /// </summary>
    object Direction { get; set; }
    /// <summary>
    /// Gets and sets whether the direction defined by the entity in the Direction property should be reversed.
    /// </summary>
    bool DirectionReversed { get; set; }
    /// <summary>
    /// Property that returns the distance Parameter object associated with the move.
    /// </summary>
    Parameter Distance { get; }
}
