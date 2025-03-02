namespace Oblikovati.API;

/// <summary>
/// The NonParametricBaseFeatureDefinition is a utility object used for creating, querying, and editing non-parametric base features. A NonParametricBaseFeatureDefinition object can be created using the CreateDefinition method of the NonParametricBaseFeatures collection object. They can also be obtained from existing NonParametricBaseFeature objects.
/// </summary>
public interface NonParametricBaseFeatureDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that defines the geometry to be used for creating the non-parametric base feature.
    /// </summary>
    ObjectCollection BRepEntities { get; set; }
    /// <summary>
    /// Read-write property that defines if the original geometry in the construction environment is deleted.
    /// </summary>
    bool DeleteOriginal { get; set; }
    /// <summary>
    /// Read-write property that defines if the copied geometry should be associative to the original geometry.
    /// </summary>
    bool IsAssociative { get; set; }
    /// <summary>
    /// Read-write property that specifies the desired result type.
    /// </summary>
    BaseFeatureOutputTypeEnum OutputType { get; set; }
    /// <summary>
    /// Read-write property that specifies the desired target Occurrence.
    /// </summary>
    ComponentOccurrence TargetOccurrence { get; set; }
}
