namespace Oblikovati.API;

/// <summary>
/// The AutomatedCenterlineSettings object provides access to all of the settings that are used when automatically generating centerlines and center marks.
/// </summary>
public interface AutomatedCenterlineSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on sheet metal Bend features.
    /// </summary>
    bool ApplyToBends { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on circular pattern features.
    /// </summary>
    bool ApplyToCircularPatterns { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on cylindrical faces.
    /// </summary>
    bool ApplyToCylinders { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on Fillet features.
    /// </summary>
    bool ApplyToFillets { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on Hole features.
    /// </summary>
    bool ApplyToHoles { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on sheet metal Punch features.
    /// </summary>
    bool ApplyToPunches { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on rectangular pattern features.
    /// </summary>
    bool ApplyToRectangularPatterns { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on Revolved features.
    /// </summary>
    bool ApplyToRevolutions { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on circular and elliptical geometry within sketches.
    /// </summary>
    bool ApplyToSketches { get; set; }
    /// <summary>
    /// Gets and sets if centerlines and center marks should be placed on visible work features.
    /// </summary>
    bool ApplyToWorkFeatures { get; set; }
    /// <summary>
    /// Gets and sets the minimum angle for creating a center mark or centerline on circles, arcs, or ellipses.
    /// </summary>
    double ArcAngleThreshold { get; set; }
    /// <summary>
    /// Gets and sets the maximum radius of a circular edge that centerlines and center marks should be placed on.
    /// </summary>
    double CircularEdgeMaximumThreshold { get; set; }
    /// <summary>
    /// Gets and sets the minimum radius of a circular edge that centerlines and center marks should be placed on.
    /// </summary>
    double CircularEdgeMinimumThreshold { get; set; }
    /// <summary>
    /// Gets and sets the maximum radius of a fillet that centerlines and center marks should be placed on.
    /// </summary>
    double FilletRadiusMaximumThreshold { get; set; }
    /// <summary>
    /// Gets and sets the minimum radius of a fillet that centerlines and center marks should be placed on.
    /// </summary>
    double FilletRadiusMinimumThreshold { get; set; }
    /// <summary>
    /// Gets and sets if centerlines should be created where the entity axis is normal to the drawing view plane.
    /// </summary>
    bool ProjectionNormalAxis { get; set; }
    /// <summary>
    /// Gets and sets if centerlines should be created where the entity axis is parallel to the drawing view plane.
    /// </summary>
    bool ProjectionParallelAxis { get; set; }
    /// <summary>
    /// Gets and sets the number of decimal accuracy to use for comparing the size of fillets, arcs and circular features to the threshold.
    /// </summary>
    int RadiusThresholdPrecision { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
