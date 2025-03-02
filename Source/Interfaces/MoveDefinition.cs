namespace Oblikovati.API;

/// <summary>
/// The MoveDefinition object is used to define all of the input required for move body features.  It is also used to query and edit existing move body features.
/// </summary>
public interface MoveDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the specified MoveOperation object.&nbsp;They are returned in the same order that they were applied.&nbsp;The MoveOperationCount property can used to determine the number of operations avaialable.
    /// </summary>
    MoveOperation MoveOperation { get; }
    /// <summary>
    /// Property that returns the number of move operations associated with this definition.&nbsp;The MoveOperation property can be used to access a specific operation.
    /// </summary>
    int MoveOperationCount { get; }
    /// <summary>
    /// Read-only property that returns the parent MoveFeature of the definition.&nbsp;This can return Nothing in the case where this definition is transient and is not associated with any feature.
    /// </summary>
    MoveFeature Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the set of bodies that are affected by this feature.
    /// </summary>
    ObjectCollection SurfaceBodies { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a free drag operation on the associated move body feature.
    /// </summary>
    /// <param name="XOffset">Input Variant that defines the x offset of the move operation.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="YOffset">Input Variant that defines the y offset of the move operation.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ZOffset">Input Variant that defines the z offset of the move operation.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    FreeDragMoveOperation AddFreeDrag([In] [MarshalAs(UnmanagedType.Struct)] object XOffset, [In] [MarshalAs(UnmanagedType.Struct)] object YOffset, [In] [MarshalAs(UnmanagedType.Struct)] object ZOffset);
    /// <summary>
    /// Method that creates a move along ray operation on the associated move body feature.
    /// </summary>
    /// <param name="DirectionEntity">Input entity that specifies the direction of the move.  Valid input includes linear edges, planar faces, work axes, and work planes.</param>
    /// <param name="UseNaturalEntityDirection">Input Boolean that specifies if the movement direction of the bodies uses the natural direction of the direction entity. If True it uses the natural direction.  If False the direction is reversed.</param>
    /// <param name="Offset">Input Variant that defines the offset value of the move operation.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    MoveAlongRayMoveOperation AddMoveAlongRay([In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] bool UseNaturalEntityDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Offset);
    /// <summary>
    /// Method that creates a move rotate about azis operation on the associated move body feature.
    /// </summary>
    /// <param name="AxisEntity">Input entity that defines the axis of rotation  Valid input includes linear edges, cylindrical faces, torus faces, and work axes.  The rotation of the body(s) about this entity is defined using the right-hand rule, where the thumb is pointed along the entity in its natural direction and the fingers define the direction of rotation.  The UseEntityNaturalDirection property can be used to reverse the rotation direction.</param>
    /// <param name="UseNaturalAxisDirection">Input Boolean that specifies if the rotation direction of the bodies uses the natural direction of the direction entity. If True it uses the natural direction.  If False the direction is reversed.
    /// The rotation of the body(s) about the axis entity is defined using the right-hand rule, where the thumb is pointed along the entity in its natural direction and the fingers define the direction of rotation.  The UseEntityNaturalDirection property can be used to reverse the rotation direction.</param>
    /// <param name="Angle">Input Variant that defines the rotation angle of the rotate operation.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are radians.  If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    RotateAboutLineMoveOperation AddRotateAboutAxis([In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool UseNaturalAxisDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Angle);
    /// <summary>
    /// Method that returns a copy of the MoveDefinition object.&nbsp;The copy is independent of any feature and making edits to it will not change any feature.&nbsp;A common workflow if you need to makes several edits to a feature is to copy the definition, makes the changes and then assign the definition back to the feature so that all of the edits are made as part of a single update.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MoveDefinition Copy();
}
