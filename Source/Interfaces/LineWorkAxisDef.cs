namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis along a line.
/// </summary>
public interface LineWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the line of a line defined work axis. This object can be a linear Edge, WorkAxis, or SketchLine object.
    /// </summary>
    object Line { get; }
}
