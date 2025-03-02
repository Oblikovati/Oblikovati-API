namespace Oblikovati.API;

/// <summary>
/// The iFeatureDefinition object represents the positional and parameter information of an iFeature.
/// </summary>
public interface iFeatureDefinition
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
    /// Property that indicates the input information of the iFeature.
    /// </summary>
    iFeatureInputs iFeatureInputs { get; }
    /// <summary>
    /// Property that returns the table information associated with this iFeature.
    /// </summary>
    iFeatureTable iFeatureTable { get; }
    /// <summary>
    /// Property that specifies if this iFeature is driven by a table.
    /// </summary>
    bool IsTableDriven { get; }
    /// <summary>
    /// Property that specifies if this iFeature has been defined to be used as a punch tool.
    /// </summary>
    bool IsPunchTool { get; }
    /// <summary>
    /// Property that returns the PunchID associated with this iFeature.
    /// </summary>
    string PunchId { get; }
    /// <summary>
    /// Gets and sets the row from the table that should be used to specify the sizes for the iFeature instances.
    /// </summary>
    iFeatureTableRow ActiveTableRow { get; set; }
}
