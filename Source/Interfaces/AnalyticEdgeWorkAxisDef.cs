namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis using an analytic edge.
/// </summary>
public interface AnalyticEdgeWorkAxisDef
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
    /// Property that returns the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Property that returns an Edge object that can be a circle, arc, or an ellipse.
    /// </summary>
    Edge Edge { get; }
}
