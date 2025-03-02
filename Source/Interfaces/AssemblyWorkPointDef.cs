namespace Oblikovati.API;

/// <summary>
/// The AssemblyWorkPointDef object allows you to get and set the information that specifies a fixed work point.
/// </summary>
public interface AssemblyWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the collection of constraints that are acting on the work point. This returns all of the constraints, including those returned by the DefinitionConstraints property.
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Specifies the origin point of the work point.
    /// </summary>
    Point Point { get; set; }
}
