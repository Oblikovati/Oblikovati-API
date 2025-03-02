namespace Oblikovati.API;

/// <summary>
/// The DSDegreeOfFreedom object represents a degree of freedom associated with a joint.
/// </summary>
public interface DSDegreeOfFreedom
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
    /// Returns the DSJointDefinition object this degree of freedom is associated with.
    /// </summary>
    DSJointDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the initial position. This property is writable when the DSDegreeOfFreedom object is transient and not associated with an existing joint.
    /// </summary>
    double InitialPosition { get; set; }
    /// <summary>
    /// Gets and sets the initial position. This property is writable when the DSDegreeOfFreedom object is transient and not associated with an existing joint.
    /// </summary>
    double InitialVelocity { get; set; }
    /// <summary>
    /// Gets and sets if the maximum bounds of the joint are defined.
    /// </summary>
    bool IsMaxBoundsEnabled { get; set; }
    /// <summary>
    /// Gets and sets if the minimum bounds of the joint are defined.
    /// </summary>
    bool IsMinBoundsEnabled { get; set; }
    /// <summary>
    /// Gets and sets if the position of this joint is locked.
    /// </summary>
    bool IsPositionLocked { get; set; }
    /// <summary>
    /// Gets and sets if the load settings for this joint are enabled.
    /// </summary>
    bool IsLoadEnabled { get; set; }
    /// <summary>
    /// Gets and sets if the velocity is computed.
    /// </summary>
    bool IsVelocityComputed { get; set; }
    /// <summary>
    /// Gets the maximum damping value. The value is in database units, where lengths are is always expressed in centimeters, angles in radians, and time in seconds.
    /// </summary>
    DSValue MaxBoundsDamping { get; }
    /// <summary>
    /// Gets the maximum stiffness value. The value is in database units, where lengths are is always expressed in centimeters, angles in radians, and time in seconds.
    /// </summary>
    DSValue MaxBoundsStiffness { get; }
    /// <summary>
    /// Gets the maximum value of the joint. The value is in database units, which for linear bounds is centimeters and radial bounds is radians.
    /// </summary>
    DSValue MaxBoundsValue { get; }
    /// <summary>
    /// Gets the minimuim damping value. The value is in database units, which for linear bounds is centimeters and radial bounds is radians.
    /// </summary>
    DSValue MinBoundsDamping { get; }
    /// <summary>
    /// Gets the minimum stiffness value.
    /// </summary>
    DSValue MinBoundsStiffness { get; }
    /// <summary>
    /// Gets the minimum value of the joint.
    /// </summary>
    DSValue MinBoundsValue { get; }
    /// <summary>
    /// Gets the DSResults object that provides access to the simulation results associated with this degree of freedom.
    /// </summary>
    DSResults Results { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load force. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadForce { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load damping. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadDamping { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load spring free position. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadSpringFreePosition { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load spring free position. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadSpringElasticStiffness { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load dry friction coefficient. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadDryFrictionCoefficient { get; }
    /// <summary>
    /// Gets a DSValue object that you can use to get and set the load dry friction radius. This property returns Nothing in the case where IsLoadEnabled is False.
    /// </summary>
    DSValue LoadDryFrictionRadius { get; }
    /// <summary>
    /// Gets and sets the type of imposed motion defined on a degree of freedom.
    /// </summary>
    DSDOFImposedMotionTypeEnum ImposedMotionType { get; set; }
    /// <summary>
    /// Read-only property returning a DSValue object that you can use to get and set the imposed motion.&nbsp;This property returns nothing in the case where the ImposedMotionType property is set to kNoImposedMotion.
    /// </summary>
    DSValue ImposedMotionValue { get; }
    /// <summary>
    /// Read-only property that indicates if this degree of freedom is for a rotation or translation.
    /// </summary>
    DSDegreeOfFreedomTypeEnum DegreeOfFreedomType { get; }
}
