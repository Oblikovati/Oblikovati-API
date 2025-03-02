namespace Oblikovati.API;

/// <summary>
/// SolidSweepDefinition Object.
/// </summary>
public interface SolidSweepDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SweepFeature Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to keep the toolbody.
    /// </summary>
    bool KeepToolbody { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the orientation of sweep.
    /// </summary>
    SweepProfileOrientationEnum Orientation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the entity that defines the path of the sweep.
    /// </summary>
    Path Path { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the SurfaceBody object used to define the toolbody of the sweep.
    /// </summary>
    SurfaceBody ToolBody { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the twist angle of sweep.
    /// </summary>
    object TwistAngle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the twist axis.
    /// </summary>
    object TwistAxis { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the object to define the align to vector.
    /// </summary>
    object AlignToVector { get; set; }
    /// <summary>
    /// Method that creates a copy of this SolidSweepDefinition object.&nbsp;The new SolidSweepDefinition object is independent of any feature.&nbsp;It can be edited and used as input to edit an existing feature or to create a new Sweep feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SolidSweepDefinition Copy();
    /// <summary>
    /// Method that sets the twist angle info.
    /// </summary>
    /// <param name="TwistAngle">Input numeric or string value to set the twist angle, a parameter will be created for the twist angle when the sweep is created. If a numeric value is supplied, the value is in radian. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.</param>
    /// <param name="TwistAxis">Optional input object to specify the twist axis. This is required if the TwistAngle is specified with non-zero value. This can be a linear Edge, WorkAxis or Face which can infer an axis. When a Face object is specified it should be a cylindrical, conical, elliptical or toroidal surface where its axis is used.</param>
    [PreserveSig]
    void SetTwistInfo([In] [MarshalAs(UnmanagedType.Struct)] object TwistAngle, [In] [MarshalAs(UnmanagedType.Struct)] object? TwistAxis = default);
    /// <summary>
    /// Method that sets the orientation info.
    /// </summary>
    /// <param name="Orientation">Input SweepProfileOrientationEnum  to set the orientation of the sweep.</param>
    /// <param name="AlignToVector">Optional input object to specify the align to vector. This is required if the Orientation is specified to kAlignToVector. This can be a linear Edge, WorkAxis, WorkPlane or Face which can infer an axis. When a WorkPlane or planar Face object is specified, its normal is used, when a cylindrical, conical, elliptical or toroidal Face is specified its axis is used.</param>
    [PreserveSig]
    void SetOrientationInfo([In] SweepProfileOrientationEnum Orientation, [In] [MarshalAs(UnmanagedType.Struct)] object? AlignToVector = default);
}
