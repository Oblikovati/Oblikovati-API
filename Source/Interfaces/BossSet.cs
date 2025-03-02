namespace Oblikovati.API;

/// <summary>
/// Object containing boss definition of the rib.
/// </summary>
public interface BossSet
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RibDefinition Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of SketchPoint objects which specify the boss centers.
    /// </summary>
    ObjectCollection Centers { get; set; }
    /// <summary>
    /// Read-write property that returns the boss diameter value.
    /// </summary>
    object Diameter { get; set; }
    /// <summary>
    /// Read-write property that returns the value of boss offset from the sketch plane.
    /// </summary>
    object Offset { get; set; }
    /// <summary>
    /// Read-write property that returns the boss taper angle value.
    /// </summary>
    object TaperAngle { get; set; }
    /// <summary>
    /// Method that deletes the boss set from the collection.
    /// </summary>
    [PreserveSig]
    void Delete();
}
