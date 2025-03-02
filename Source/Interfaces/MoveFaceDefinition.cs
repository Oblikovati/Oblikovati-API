namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface MoveFaceDefinition
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
    /// Property that returns the parent MoveFaceFeature of this MoveFaceDefinition object.
    /// </summary>
    MoveFaceFeature Parent { get; }
    /// <summary>
    /// Gets and sets the FaceCollection object that contains the faces that are used to define the Move Face feature.
    /// </summary>
    FaceCollection Faces { get; set; }
    /// <summary>
    /// Property that returns the method used to define the type of the move face operation. The valid values for this property are kDirectionAndDistanceMoveType, kPlanarMoveType, and kFreeMoveType. This property is initialized to kFreeMoveType when the definition is created. Use the MoveFaceTypeDefinition property to get the corresponding definition object.
    /// </summary>
    MoveFaceTypeEnum MoveFaceType { get; }
    /// <summary>
    /// Property that returns the definition object that defines the type of move.
    /// </summary>
    object MoveFaceTypeDefinition { get; }
    /// <summary>
    /// Gets and sets whether the move operation should propagate to adjacent tangent faces.
    /// </summary>
    bool AutomaticBlending { get; set; }
    /// <summary>
    /// Method that creates a copy of this MoveFaceDefinition object. The new MoveFaceDefinition object is independent of any feature. It can edited and used as input to edit an existing feature or to create a new Move Face feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MoveFaceDefinition Copy();
    /// <summary>
    /// Method that sets the move face type to kDirectionAndDistanceMoveType. The move is defined using a direction and a distance along the direction.
    /// </summary>
    /// <param name="Distance">Defines the distance to move along the specified direction. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Direction">Specifies the entity defining the direction for the move. This can either be a WorkAxis, a linear Edge, or a planar Face object.</param>
    /// <param name="DirectionReversed">Specifies whether the direction defined by the entity in the Direction argument should be reversed. Defaults to False indicating that the direction is not reversed.</param>
    [PreserveSig]
    void SetDirectionAndDistanceMoveType([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.IDispatch)] object Direction, [In] bool? DirectionReversed = false);
    /// <summary>
    /// Method that sets the move face type to kFreeMoveType. The move is defined using a matrix that defines the transform to be applies to the face(s).
    /// </summary>
    /// <param name="Transformation">Matrix that defines the free move transform of the faces.</param>
    [PreserveSig]
    void SetFreeMoveType([In] [MarshalAs(UnmanagedType.Interface)] Matrix Transformation);
    /// <summary>
    /// Method that sets the move face type to kPlanarMoveType. The move is defined using two points, and optionally, a plane for the move.
    /// </summary>
    /// <param name="PointOne">Specifies the first point for the planar move. This can either be a WorkPoint or a Vertex object.</param>
    /// <param name="PointTwo">Specifies the second point for the planar move. This can either be a WorkPoint or a Vertex object.</param>
    /// <param name="Plane">Specifies the plane for the planar move. This can either be a WorkPlane or a planar Face object. If not specified, the move is based on the input points.</param>
    [PreserveSig]
    void SetPlanarMoveType([In] [MarshalAs(UnmanagedType.IDispatch)] object PointOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object PointTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? Plane = default);
}
