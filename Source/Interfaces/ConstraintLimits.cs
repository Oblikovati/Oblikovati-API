namespace Oblikovati.API;

/// <summary>
/// The ConstraintLimits object provides access to various limits related settings for assembly constraints and iMate definitions.
/// </summary>
public interface ConstraintLimits
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the Parameter object that controls the maximum limit value. This property returns Nothing if the maximum limit has never been enabled for this constraint or the parameter associated with the maximum value was deleted. Set the MaximumEnabled property to True to make this parameter available.
    /// </summary>
    Parameter Maximum { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the maximum limit value should be enabled.&nbsp;Once enabled, the parameter returned in the Maximum property can be used to control the value of this limit.
    /// </summary>
    bool MaximumEnabled { get; set; }
    /// <summary>
    /// Property that returns the Parameter object that controls the minimum limit value. This property returns Nothing if the minimum limit has never been enabled for this constraint or the parameter associated with the minimum value was deleted. Set the MinimumEnabled property to True to make this parameter available.
    /// </summary>
    Parameter Minimum { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the minimum limit value should be enabled.&nbsp;Once enabled, the parameter returned in the Minimum property can be used to control the value of this limit.
    /// </summary>
    bool MinimumEnabled { get; set; }
    /// <summary>
    /// Property that returns the parent object. This can be one of the strongly typed assembly constraint objects (such as MateConstraint) or one of the strongly typed iMate definition objects (such as MateiMateDefinition).
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the resting position value should be enabled.&nbsp;If enabled, the constraint snaps back to the nominal value after a drag or a solve.
    /// </summary>
    bool RestingPositionEnabled { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
