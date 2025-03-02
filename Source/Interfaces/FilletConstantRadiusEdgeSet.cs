namespace Oblikovati.API;

/// <summary>
/// The ConstantRadiusEdgeSet object provides access the edges and their associated radii for a constant radius fillet.
/// </summary>
public interface FilletConstantRadiusEdgeSet
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
    /// Property that returns the parameter that controls the radius of the fillet. This property will return Nothing if the fillet feature has not been created yet.
    /// </summary>
    Parameter Radius { get; }
    /// <summary>
    /// Property that returns if the edge set defines all concave edges.
    /// </summary>
    bool AllFillets { get; }
    /// <summary>
    /// Property that returns if the edge set defines all convex edges.
    /// </summary>
    bool AllRounds { get; }
    /// <summary>
    /// Read-write property that gets and sets the continuity type for the edge set. Valid values are kTangentContinuity and kCurvatureContinuity. This property can currently only be set in the forward create scenario (it fails if the FilletDefinition is obtained from an existing feature).
    /// </summary>
    ContinuityTypeEnum ContinuityType { get; set; }
    /// <summary>
    /// Gets and sets whether or not to use inverted fillet for the edge set.
    /// </summary>
    bool InvertedFillet { get; set; }
}
