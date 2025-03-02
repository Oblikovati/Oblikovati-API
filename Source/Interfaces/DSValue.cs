namespace Oblikovati.API;

/// <summary>
/// The DSValue object represents a value where the value can be either a constant value or be a variable value defined by a graph.
/// </summary>
public interface DSValue
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
    /// Get and set the value. This property is writable when the DSValue object is associated with a transient object.
    /// </summary>
    double ConstantValue { get; set; }
    /// <summary>
    /// Gets the graph that controls this value.&nbsp;You can access and edit the graph using the properties on the returned DSValueGraph object.&nbsp;This property returns Nothing in the case where the value is defined by a constant value .&nbsp;You can determine this using the IsConstantValue property.
    /// </summary>
    DSValueGraph Graph { get; }
    /// <summary>
    /// Indicates if this value is defined by a constant value or a graph.
    /// </summary>
    bool IsConstantValue { get; set; }
}
