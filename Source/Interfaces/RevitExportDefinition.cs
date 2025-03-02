namespace Oblikovati.API;

/// <summary>
/// RevitExportDefinition Object.
/// </summary>
public interface RevitExportDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RevitExport Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active model state for the RevitExport.
    /// </summary>
    string ActiveModelState { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Design View Representation for the RevitExport. The IsAssociativeDesignView property indicates if an associate link to the design view is created or not.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if there is an associative link to the specified design view. When creating a new RevitExport, setting this property to True will create a derivation that is associative to the design view.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Positional Representation for the RevitExport.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets envelopes replace style. When a new definition is created, this defaults to kNoneReplaceStyle.
    /// </summary>
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether remove parts by size or not.
    /// </summary>
    bool RemovePartsBySize { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the bounding box diagonal length in centimeters of the parts being removed.
    /// </summary>
    double RemovePartsSize { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the occurrences being included for the RevitExport.
    /// </summary>
    ObjectCollection AdditionalIncludedOccurrences { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the occurrences being excluded for the RevitExport.
    /// </summary>
    ObjectCollection AdditionalExcludedOccurrences { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the style to remove holes for the RevitExport.
    /// </summary>
    SimplificationRemoveStyleEnum RemoveHolesStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the diameter of holes in centimeters to remove for the RevitExport. This is only applicable when the RemoveHolesStyle is set to kRevitExportRemoveByRange.
    /// </summary>
    double RemoveHolesDiameterRange { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the style to remove fillets for the RevitExport.
    /// </summary>
    SimplificationRemoveStyleEnum RemoveFilletsStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the radius of fillets in centimeters to remove for the RevitExport. This is only applicable when the RemoveFilletsStyle is set to kRevitExportRemoveByRange.
    /// </summary>
    double RemoveFilletsRadiusRange { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the style to remove chamfers for the RevitExport.
    /// </summary>
    SimplificationRemoveStyleEnum RemoveChamfersStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the distance of chamfers in centimeters to remove for the RevitExport. This is only applicable when the RemoveChamfersStyle is set to kRevitExportRemoveByRange.
    /// </summary>
    double RemoveChamfersDistanceRange { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the style to remove pockets for the RevitExport.
    /// </summary>
    SimplificationRemoveStyleEnum RemovePocketsStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the max depth of pockets in centimeters to remove for the RevitExport. This is only applicable when the RemovePocketsStyle is set to kRevitExportRemoveByRange.
    /// </summary>
    double RemovePocketsMaxDepthRange { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SimplificationRemoveStyleEnum RemoveEmbossStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SimplificationRemoveStyleEnum RemoveEmbossesStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the max height of embosses in centimeters to remove for the RevitExport. This is only applicable when the RemoveEmbossesStyle is set to kRevitExportRemoveByRange.
    /// </summary>
    double RemoveEmbossMaxHeightRange { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the style to remove tunnels for the RevitExport. Valid values for this property are kSimplificationRemoveNone and kSimplificationRemoveAll.
    /// </summary>
    SimplificationRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the features to preserve from remove. For each preserved feature a Face from the feature is required to indicate it.
    /// </summary>
    ObjectCollection PreservedFeatures { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the filename of the RevitExport. This cannot be modified after the Revit model has been created.
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the location of the RevitExport. This cannot be modified after the Revit model has been created.
    /// </summary>
    string Location { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the structure.
    /// </summary>
    RevitExportStructureTypeEnum Structure { get; set; }
    /// <summary>
    /// Read-write property that controls whether or not a RevitExport object is created. If set to True, then an updateable RevitExport object is created. If set to False, then no RevitExport object is created, and no subsequent updates can be done.
    /// </summary>
    bool EnableUpdating { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the Revit version. Use the FileManager.GetRevitEngineInstallationStatus to get the Revit versions that can be used to create RevitExport objects.
    /// </summary>
    string RevitVersion { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether remove all the internal voids or not. Set this to True will fill all the internal void shells in the RevitExport solid.
    /// </summary>
    bool RemoveAllInternalVoids { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to remove internal parts or not.
    /// </summary>
    bool RemoveInternalParts { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether use the color override from source component.
    /// </summary>
    bool UseColorOverrideFromSourceComponent { get; set; }
    /// <summary>
    /// Method that creates a copy of this RevitExportDefinition object. The new RevitExportDefinition is independent of any RevitExport. It can be edited and used as input to edit an existing RevitExport or to create a new RevitExport.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RevitExportDefinition Copy();
}
