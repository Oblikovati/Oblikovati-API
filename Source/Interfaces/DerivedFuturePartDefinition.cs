namespace Oblikovati.API;

/// <summary>
/// The DerivedFuturePartDefinition object is used to describe which entities within a future part will be used during the creation of the DerivedFuturePartComponent.  It is also used when querying and editing an existing derived future part.  When a DerivedFuturePartDefinition is initially created it is set so all available entities will be included in the derived part. Note: DerivedFuturePartDefinition object will become invalid after it has been set in the DerivedFuturePartComponent object i.e; all the properties will return failure.
/// </summary>
public interface DerivedFuturePartDefinition
{
    /// <summary>
    /// Read-only property returning kDerivedFuturePartDefinitionObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Design View Representation for the derived part.&nbsp;An empty string indicates the Master design view is used.&nbsp;The IsAssociativeDesignView property indicates if an associate link to the design view is created or not.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Read-only property that gets the full filename of the derived document.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Read-write property that defines whether all solids are included in the derived part.&nbsp;Valid input for this property is kDerivedIncludeAll, kDerivedExcludeAll, and kDerivedIndividualDefined.&nbsp;If set to kDerivedIncludeAll, all solids will be included.&nbsp;If set to kDerivedExcludeAll, no solids will be included.&nbsp;If set to kDerivedIndividualDefined, then the inclusion state of each solid is defined by the solid itself.&nbsp;The available solids are accessed using the Solids property of the DerivedPartDefinition object.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    /// <summary>
    /// Read-write property that defines whether all surfaces are included in the derived part.&nbsp;Valid input for this property is kDerivedIncludeAll, kDerivedExcludeAll, and kDerivedIndividualDefined.&nbsp;If set to kDerivedIncludeAll, all surfaces will be included.&nbsp;If set to kDerivedExcludeAll, no surfaces will be imported.&nbsp;If set to kDerivedIndividualDefined, then the inclusion state of each surface is defined by the surface itself.&nbsp;The available surfaces are accessed using the Surfaces property of the DerivedPartDefinition object.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if there is an associative link to the specified design view.&nbsp;When creating a new derived part, setting this property to True (which is the default) will create a derivation that is associative to the design view.&nbsp;This can only be set to True when a design view other than the master design view is specified.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
    /// <summary>
    /// Read-only property that gets the collection of solids available in the selected part along with the inclusion option for each solid.
    /// </summary>
    DerivedPartEntities Solids { get; }
    /// <summary>
    /// Read-only property that gets the collection of surfaces available in the selected part along with the inclusion option for each surface.
    /// </summary>
    DerivedPartEntities Surfaces { get; }
    /// <summary>
    /// Method that causes all entities within the derived part descriptor to be set to kDerivedExcludeAll.
    /// This method excludes all solids, surfaces, sketches, 3d sketches, sketch blocks, sketch block definitions, workfeatures, parameters and iMate definitions.
    /// </summary>
    [PreserveSig]
    void ExcludeAll();
    /// <summary>
    /// Method that causes all entities within the derived part descriptor to be set to kDerivedIncludeAll.
    /// This method includes all solids, surfaces, sketches, 3d sketches, sketch blocks, sketch block definitions, workfeatures, parameters and iMate definitions.
    /// </summary>
    [PreserveSig]
    void IncludeAll();
}
