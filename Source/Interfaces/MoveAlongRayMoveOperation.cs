namespace Oblikovati.API;

/// <summary>
/// The MoveAlongRayMoveOperation object represents the definition of a move along a specified direction within a move feature.
/// </summary>
public interface MoveAlongRayMoveOperation
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property returning the associated MoveDefinition object.
    /// </summary>
    MoveDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the entity used to define the direction of the move.
    /// </summary>
    object DirectionEntity { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies if the movement direction of the bodies is in the natural direction of the direction entity.
    /// </summary>
    bool EntityNaturalDirection { get; set; }
    /// <summary>
    /// Read-write property that provides access to the offset of a move along ray operation on a move body feature.
    /// </summary>
    object Offset { get; set; }
    /// <summary>
    /// Method that deletes this operation from the feature.
    /// </summary>
    [PreserveSig]
    void Delete();
}
