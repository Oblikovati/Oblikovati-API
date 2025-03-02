namespace Oblikovati.API;

/// <summary>
/// SimulationManager Object.
/// </summary>
public interface SimulationManager
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
    /// Gets the DynamicSimulations object.&nbsp;This object provides access to the existing dynamic simulations in this document and provides the ability to create new simulations.
    /// </summary>
    DynamicSimulations DynamicSimulations { get; }
    /// <summary>
    /// Gets the parent assembly or part component definition object.
    /// </summary>
    ComponentDefinition Parent { get; }
}
