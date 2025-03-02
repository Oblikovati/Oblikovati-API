namespace Oblikovati.API;

/// <summary>
/// The MoveOperation object is the base class for the various type of move operations that can be defined for a move body feature.
/// </summary>
public interface MoveOperation
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
    /// Method that deletes this operation from the feature.
    /// </summary>
    [PreserveSig]
    void Delete();
}
