namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a fixed work point.
/// </summary>
public interface FixedWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Specifies the origin point of the work point.
    /// </summary>
    Point Point { get; set; }
}
