namespace Oblikovati.API;

/// <summary>
/// RevisionCloudDefinition Object.
/// </summary>
public interface RevisionCloudDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RevisionCloud Parent { get; }
    /// <summary>
    /// Returns the RevisionCloudControlPoints object that handles control points of the revision cloud.
    /// </summary>
    RevisionCloudControlPoints ControlPoints { get; }
    /// <summary>
    /// Gets and sets whether the revision cloud is inverted or not.
    /// </summary>
    bool Inverted { get; set; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the minimum arc radius.
    /// </summary>
    double MinimumArcRadius { get; set; }
    /// <summary>
    /// Gets and sets the maximum arc radius.
    /// </summary>
    double MaximumArcRadius { get; set; }
    /// <summary>
    /// Gets and sets whether to set the arc radius values as default for next time when create a new RevisionCloudDefinition.
    /// </summary>
    bool SetValuesAsDefault { get; set; }
    /// <summary>
    /// Method that creates a copy of this RevisionCloudDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RevisionCloudDefinition Copy();
}
