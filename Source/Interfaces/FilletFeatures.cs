namespace Oblikovati.API;

/// <summary>
/// The FilletFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional FilletFeature objects.
/// </summary>
public interface FilletFeatures : IEnumerable
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
    /// Returns the specified FilletFeature object from the collection.
    /// </summary>
    FilletFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new constant radius fillet where all fillets have the same radius. For more complex fillet features, the Add method of the FilletFeatures collection can be used.
    /// </summary>
    /// <param name="Edges">Input object that contains the edges to be filleted.</param>
    /// <param name="Radius">Input Variant that defines the radius of the fillet. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="AllFillets">Optional input Boolean that specifies if all concave edges of the body are to be considered part of this edge set. True indicates all concave edges will be filleted. The default is False.</param>
    /// <param name="AllRounds">Optional input Boolean that specifies if all convex edges of the body are to be considered part of this edge set. True indicates all convex edges will be filleted. The default is False.</param>
    /// <param name="AutomaticEdgeChain">Optional input Boolean that defines if automatic edge chaining along tangentially connected edges should be performed. The default is True.</param>
    /// <param name="RollAlongSharpEdges">Optional input Boolean that sets the solution method for fillets when the specified radius would cause adjacent faces to be extended. When True, the radius will be varied when necessary to preserve the edges of adjacent faces. When False, a constant radius will be maintained and adjacent faces extended as needed. The default is False.</param>
    /// <param name="RollingBallWherePossible">Optional input Boolean that sets the corner style for the fillet. When True, the fillet will be defined as if a ball had been rolled along the edge and around the corners. When False, a continuous tangent transition between fillets in sharp corners is created. The default is True.</param>
    /// <param name="PreserveAllFeatures">Optional input Boolean that specifies if all features that intersect with the fillet are checked and their intersections calculated during the fillet operation. If False, only the edges that are part of the fillet operation are calculated during the operation. The default is False.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletFeature AddSimple([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] bool? AllFillets = false, [In] bool? AllRounds = false, [In] bool? AutomaticEdgeChain = true, [In] bool? RollAlongSharpEdges = false, [In] bool? RollingBallWherePossible = true, [In] bool? PreserveAllFeatures = false);
    /// <summary>
    /// Method that creates a new FilletFeature. This method may be used to create fillet features of constant radius, variable radius or a combination of constant and variable radius. Setbacks may also be specified. The new FilletFeature is returned.
    /// </summary>
    /// <param name="FilletDefinition">Input object that defines the input definition for the fillet feature. The object defines the edges, radii, and setbacks.</param>
    /// <param name="AutomaticEdgeChain">Optional input Boolean that defines if automatic edge chaining along tangentially connected edges should be performed. The default is True.</param>
    /// <param name="SmoothRadiusTransition">Optional input Boolean that applies only to variable radius fillets and defines whether the transition between different radii is to be smooth. For a smooth transition there is a gradual blending transition between the defined radius points and the transitions are tangent. Without a smooth transition, a linear transition is used between radius points. The default is True for a smooth transition.</param>
    /// <param name="RollAlongSharpEdges">Optional input Boolean that sets the solution method for fillets when the specified radius would cause adjacent faces to be extended. When True, the radius will be varied when necessary to preserve the edges of adjacent faces. When False, a constant radius will be maintained and adjacent faces extended as needed. The default is False.</param>
    /// <param name="RollingBallWherePossible">Optional input Boolean that sets the corner style for the fillet. When True, the fillet will be defined as if a ball had been rolled along the edge and around the corners. When False, a continuous tangent transition between fillets in sharp corners is created. The default is True.</param>
    /// <param name="PreserveAllFeatures">Optional input Boolean that specifies if all features that intersect with the fillet are checked and their intersections calculated during the fillet operation. If False, only the edges that are part of the fillet operation are calculated during the operation. The default is False.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FilletDefinition FilletDefinition, [In] bool? AutomaticEdgeChain = true, [In] bool? SmoothRadiusTransition = true, [In] bool? RollAlongSharpEdges = false, [In] bool? RollingBallWherePossible = true, [In] bool? PreserveAllFeatures = false);
    /// <summary>
    /// Method that creates a new FilletDefinition object. The object returned by this method is used to define the inputs for a fillet feature and is provided as the argument to the Add method of the FilletFeatures collection.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FilletDefinition CreateFilletDefinition();
}
