namespace Oblikovati.API;

/// <summary>
/// The CornerChamferDefinition object is a utility object used for creating, querying, and editing sheet metal corner chamfer features.
/// </summary>
public interface CornerChamferDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the ChamferDefinition object that defines how the chamfer is defined.
    /// </summary>
    ChamferDefinition ChamferDefinition { get; }
    /// <summary>
    /// Property that returns an enum indicating how the chamfer is defined.
    /// </summary>
    ChamferDefinitionTypeEnum ChamferDefinitionType { get; }
    /// <summary>
    /// Gets the edges used for this corner chamfer.
    /// </summary>
    EdgeCollection CornerEdges { get; set; }
    /// <summary>
    /// Property that returns the parent CornerChamferFeature object of this CornerChamferDefinition object.
    /// </summary>
    CornerChamferFeature Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Function that creates a copy of this CornerChamferDefinition object. The copy is independent of any other object and can be edited without affecting anything else. It can then be used as input to either modify an existing corner round or create a new corner round feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CornerChamferDefinition Copy();
    /// <summary>
    /// Method that changes the way this corner chamfer is defined so that it is defined using an equal distance from the corner.
    /// </summary>
    /// <param name="CornerEdges">Input EdgeCollection object that contains all of the corners to apply a fillet on. These must be corner edges.</param>
    /// <param name="Distance">Input Variant that defines the distance from the edge. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetDistance([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection CornerEdges, [In] [MarshalAs(UnmanagedType.Struct)] object Distance);
    /// <summary>
    /// Method that changes the CornerChamferDefinition object to define a chamfer that is measured by an offset from the corner along one face and then ang chamfer feature where the chamfer is defined by a distance from an edge and an angle from a face.
    /// </summary>
    /// <param name="CornerEdges">Input EdgeCollection object that contains all of the corners to apply a fillet on. These must be corner edges and must also be edges of the face specified through the Face argument.</param>
    /// <param name="Face">Input Face object that the chamfer angle is measured from.</param>
    /// <param name="Distance">Input Variant that defines the distance for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Angle">Input Variant that defines the angle for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetDistanceAndAngle([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection CornerEdges, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object Angle);
    /// <summary>
    /// Method that changes the CornerChamferDefinition object to define a chamfer that is measured by two offset distances.
    /// </summary>
    /// <param name="CornerEdge">Input Edge object that defines the corner to place the chamfer on..</param>
    /// <param name="Face">Input Face object that specifies which face the first distance applies to. The corner edges specified must lie on this face.</param>
    /// <param name="DistanceOne">Input Variant that defines the first distance for the chamfer.. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="DistanceTwo">Input Variant that defines the second distance for the chamfer.. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetTwoDistances([In] [MarshalAs(UnmanagedType.Interface)] Edge CornerEdge, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceOne, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceTwo);
}
