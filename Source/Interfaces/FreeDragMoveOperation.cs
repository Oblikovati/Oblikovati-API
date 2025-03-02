namespace Oblikovati.API;

/// <summary>
/// The FreeDragMoveOperation object represents the definition of a free drag within a move feature.
/// </summary>
public interface FreeDragMoveOperation
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
    /// Read-write property that provides access to the x offset of a free drag operation on a move body feature.
    /// </summary>
    object XOffset { get; set; }
    /// <summary>
    /// Read-write property that provides access to the y offset of a free drag operation on a move body feature.
    /// </summary>
    object YOffset { get; set; }
    /// <summary>
    /// Read-write property that provides access to the z offset of a free drag operation on a move body feature.
    /// </summary>
    object ZOffset { get; set; }
    /// <summary>
    /// Method that deletes this operation from the feature.
    /// </summary>
    [PreserveSig]
    void Delete();
}
