namespace Oblikovati.API;

/// <summary>
/// The FilletRadiusEdgeSet object is the base class for FilletConstantRadiusEdgeSet and FilletVariableRadiusEdgeSet objects.
/// </summary>
public interface FilletRadiusEdgeSet
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
}
