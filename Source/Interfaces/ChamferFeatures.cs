namespace Oblikovati.API;

/// <summary>
/// The ChamferFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional ChamferFeature objects.
/// </summary>
public interface ChamferFeatures : IEnumerable
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
    /// Method that returns the specified ChamferFeature object from the collection
    /// </summary>
    ChamferFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ChamferFeature defined by a specified distance. The new ChamferFeature is returned.
    /// </summary>
    /// <param name="Edges">Input object that contains the edges to be chamfered.</param>
    /// <param name="Distance">Input Variant that defines the distance for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="AutomaticEdgeChain">Optional input Boolean that defines if automatic edge chaining along tangentially connected edges should be performed. The default is True.</param>
    /// <param name="CornerSetback">Optional Boolean that defines how any corners will be treated. If True, the corner is joined by a flat intersection. If False, the corner is defined by the intersection of the chamfers. The default is True.</param>
    /// <param name="PreserveAllFeatures">Optional Boolean that defines the behavior when the chamfer intersects the body other than at adjacent faces. The default is False.</param>
    /// <returns></returns>
    [PreserveSig]
    ChamferFeature AddUsingDistance([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] bool? AutomaticEdgeChain = true, [In] bool? CornerSetback = true, [In] bool? PreserveAllFeatures = false);
    /// <summary>
    /// Method that creates a new ChamferFeature that is defined by a distance and at a specified angle to an input face. The new ChamferFeature is returned.
    /// </summary>
    /// <param name="Edges">Input object that contains the edges to be chamfered.</param>
    /// <param name="Face">Input object that is chamfer angle is measured from.</param>
    /// <param name="Distance">Input Variant that defines the distance for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="Angle">Input Variant that defines the angle for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="AutomaticEdgeChain">Optional input Boolean that defines if automatic edge chaining along tangentially connected edges should be performed. The default is True.</param>
    /// <param name="PreserveAllFeatures">Optional Boolean that defines the behavior when the chamfer intersects the body other than at adjacent faces. The default is False.</param>
    /// <returns></returns>
    [PreserveSig]
    ChamferFeature AddUsingDistanceAndAngle([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] bool? AutomaticEdgeChain = true, [In] bool? PreserveAllFeatures = false);
    /// <summary>
    /// Method that creates a new ChamferFeature that is defined by two distances. The new ChamferFeature is returned.
    /// </summary>
    /// <param name="Edges">Input edges that define the chamfer. This must be either a single edge or a set of tangent continuous edges.</param>
    /// <param name="Face">Input object that specifies which face distance one applies to. The first edge in the list of edges must lie on this face.</param>
    /// <param name="DistanceOne">Input Variant that defines the first distance for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="DistanceTwo">Input Variant that defines the second distance for the chamfer. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="AutomaticEdgeChain">Optional input Boolean that defines if automatic edge chaining along tangentially connected edges should be performed. The default is True.</param>
    /// <param name="PreserveAllFeatures">Optional Boolean that defines the behavior when the chamfer intersects the body other than at adjacent faces. The default is False.</param>
    /// <returns></returns>
    [PreserveSig]
    ChamferFeature AddUsingTwoDistances([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceOne, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceTwo, [In] bool? AutomaticEdgeChain = true, [In] bool? PreserveAllFeatures = false);
}
