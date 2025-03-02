namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point defined to be at the midpoint of an edge.
/// </summary>
public interface MidPointWorkPointDef
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
    /// Property that returns the object of a work point that is defined to be at the center of the edge. Any open edge is valid as input. Inputting a closed edge, (i.e. circle), will cause and error to occur.
    /// </summary>
    Edge Edge { get; }
}
