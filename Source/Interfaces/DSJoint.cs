namespace Oblikovati.API;

/// <summary>
/// DSJoint object.
/// </summary>
public interface DSJoint
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
    /// Gets the parent DynamicSimulation object.
    /// </summary>
    DynamicSimulation Parent { get; }
    /// <summary>
    /// Gets the definition object associated with this joint.
    /// </summary>
    DSJointDefinition Definition { get; set; }
    /// <summary>
    /// Gets and sets the displayed name of the joint.&nbsp;This is the name that is visible in the browser and is editable by the end-user.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets whether the joint is suppressed or not.&nbsp;A value of True indicates the joint is suppressed.
    /// </summary>
    bool IsSuppressed { get; set; }
    /// <summary>
    /// Returns the type of simulation joint this object represents
    /// </summary>
    DSJointTypeEnum JointType { get; }
}
