namespace Oblikovati.API;

/// <summary>
/// The RotateAboutLineMoveOperation object represents the definition of a rotation about a line within a move feature.
/// </summary>
public interface RotateAboutLineMoveOperation
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
    /// Read-write property that provides access to the angle of a rotate about line operation on a move body feature.
    /// </summary>
    object Angle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the entity used to define the axis or rotation.
    /// </summary>
    object AxisEntity { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies if the rotation direction of the bodies uses the natural direction of the direction entity.
    /// </summary>
    bool UseEntityNaturalDirection { get; set; }
    /// <summary>
    /// Method that deletes this operation from the feature.
    /// </summary>
    [PreserveSig]
    void Delete();
}
