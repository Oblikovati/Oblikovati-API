namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point using a non-linear edge.
/// </summary>
public interface NonLinearEdgeWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Property that returns a non-linear Edge object.
    /// </summary>
    Edge Edge { get; }
}
