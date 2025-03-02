namespace Oblikovati.API;

/// <summary>
/// RigidBodyResults Object.
/// </summary>
public interface RigidBodyResults
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
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the RigidBodyGroups object that contains the set of rigid bodies for this specific rigid body analysis.
    /// </summary>
    RigidBodyGroups RigidBodyGroups { get; }
    /// <summary>
    /// Property that returns the RigidBodyGroups object that contains the set of joints for this specific rigid body analysis.
    /// </summary>
    RigidBodyJoints RigidBodyJoints { get; }
}
