namespace Oblikovati.API;

/// <summary>
/// The FilletVariableRadiusEdgeSet object provides methods to specify the radius for variable radius fillet features.
/// </summary>
public interface FilletVariableRadiusEdgeSet : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that provides access to the in the edge set. This property is only available when a FilletDefinition object is being defined to use as input for creating a fillet. When the parent FilletDefinition object is obtained from an existing Fillet, the end-of-part marker should be placed above this fillet feature to allow access this property.
    /// </summary>
    EdgeCollection Edges { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the specified FilletIntermediateRadius object.
    /// </summary>
    FilletIntermediateRadius IntermediateRadiusItem { get; }
    /// <summary>
    /// Property that returns the number of intermediate points defined in the edge set.
    /// </summary>
    int IntermediateRadiusCount { get; }
    /// <summary>
    /// Property that returns the parameter that controls the start radius of the fillet.
    /// </summary>
    Parameter StartRadius { get; }
    /// <summary>
    /// Property that returns the parameter that controls the end radius of the fillet.
    /// </summary>
    Parameter EndRadius { get; }
    /// <summary>
    /// Read-write property that gets and sets the continuity type for the edge set. Valid values are kTangentContinuity and kCurvatureContinuity. This property can currently only be set in the forward create scenario (it fails if the FilletDefinition is obtained from an existing feature).
    /// </summary>
    ContinuityTypeEnum ContinuityType { get; set; }
    /// <summary>
    /// Method that creates a new FilletIntermediateRadius. The new FilletIntermediateRadius is returned. This method is used to define radii at intermediate points along an edge.
    /// </summary>
    /// <param name="Edge">Input object that the intermediate radius lies on.</param>
    /// <param name="Radius">Input Variant that defines the radius at the specified point. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="PercentLength">Input Variant that defines the position of the point along the edge as a percentage of the length of the edge. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. The units for input value need to be unitless and the value should be between 0 and 1.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletIntermediateRadius AddIntermediateRadius([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] [MarshalAs(UnmanagedType.Struct)] object PercentLength);
}
