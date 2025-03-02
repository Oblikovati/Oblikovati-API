namespace Oblikovati.API;

/// <summary>
/// The DerivedAssemblyDefinition object is used to describe which parts in an assembly will be used during the creation of the DerivedAssemblyComponent. It is also used when querying and editing an existing derived assembly.
/// </summary>
public interface DerivedAssemblyDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that gets the available in the selected assembly. This returns the top-level occurrences in the assembly. You can use the SubOccurrences of the DerivedAssemblyOccurrence object to traverse through the entire occurrence tree.
    /// </summary>
    DerivedAssemblyOccurrences Occurrences { get; }
    /// <summary>
    /// Property that defines the inclusion status for all of the occurrences in the assembly. Valid options are kDerivedIncludeAll, kDerivedSubtractAll, kDerivedExcludeAll, kDerivedBoundingBox, kDerivedIntersect and kDerivedIndividualDefined.
    /// </summary>
    DerivedComponentOptionEnum InclusionOption { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets and sets the name of the active Positional Representation for the derived assembly.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Design View Representation for the derived part.&nbsp;An empty string indicates the Master design view is used.&nbsp;The IsAssociativeDesignView property indicates if an associate link to the design view is created or not.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveLevelOfDetailRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if there is an associative link to the specified design view.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
    /// <summary>
    /// Gets or sets the scale factor for the derived Assembly.
    /// </summary>
    double ScaleFactor { get; set; }
    /// <summary>
    /// Gets and sets the plane about which the base assembly will be mirrored to create the derived assembly.
    /// </summary>
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    /// <summary>
    /// Gets and sets reduced memory mode for the derived Assembly.
    /// </summary>
    bool ReducedMemoryMode { get; set; }
    /// <summary>
    /// Gets and sets how bodies are derived. Valid options are kDeriveAsSingleBodyWithSeams, kDeriveAsSingleBodyNoSeams and kDeriveAsMultipleBodies.&nbsp;kDeriveAsWorkSurface is not a valid option for derived assemblies.
    /// </summary>
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool KeepSeams { get; set; }
    /// <summary>
    /// Read-write property that defines whether all top level iMates in the source assembly are included in the derived assembly.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllTopLeveliMateDefinitions { get; set; }
    /// <summary>
    /// Read-write property that defines whether all top level parameters in the source assembly are included in the derived assembly.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllTopLevelParameters { get; set; }
    /// <summary>
    /// Read-write property that defines whether all top level sketches in the source assembly are included in the derived assembly.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllTopLevelSketches { get; set; }
    /// <summary>
    /// Read-write property that defines whether all top level work features in the source assembly are included in the derived assembly.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllTopLevelWorkFeatures { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to create independent solids in the derived part when a Boolean operation fails.
    /// </summary>
    bool IndependentSolidsOnFailedBoolean { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether internal voids should be removed from the resulting derived part.
    /// </summary>
    bool RemoveInternalVoids { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UseColorOverridesFromSource { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the name of active model state for the derived assembly.
    /// </summary>
    string ActiveModelState { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether color override should be removed from the resulting derived part.
    /// </summary>
    bool LinkFaceColorFromSource { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether color override should be removed from the resulting derived part.
    /// </summary>
    bool LinkSketchFormattingFromSource { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to use the oriented minimum bounding box or orthogonal bounding box for the components that are included as bounding box.
    /// </summary>
    bool UseOrientedMinimumBoundingBox { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HolePatchType">HolePatchType</param>
    /// <param name="MinimumPerimeter">MinimumPerimeter</param>
    /// <param name="MaximumPerimeter">MaximumPerimeter</param>
    /// <param name="Reserved">Reserved</param>
    [PreserveSig]
    void GetHolePatchingOptions([Out] out DerivedHolePatchEnum HolePatchType, [Out] out double MinimumPerimeter, [Out] out double MaximumPerimeter, [Out] [MarshalAs(UnmanagedType.Interface)] out EdgeCollection Reserved);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Enable">Enable</param>
    /// <param name="SizeRatioPercentage">SizeRatioPercentage</param>
    [PreserveSig]
    void GetRemoveBySizeOptions([Out] out bool Enable, [Out] out int SizeRatioPercentage);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="GeometryToRemove">GeometryToRemove</param>
    /// <param name="VisibilityPercentage">VisibilityPercentage</param>
    /// <param name="IgnoreSurfaceFeatures">IgnoreSurfaceFeatures</param>
    [PreserveSig]
    void GetRemoveByVisibilityOptions([Out] out DerivedGeometryRemovalEnum GeometryToRemove, [Out] out int VisibilityPercentage, [Out] out bool IgnoreSurfaceFeatures);
    /// <summary>
    /// Method that sets the hole patching options for the derived assembly.
    /// </summary>
    /// <param name="HolePatchType">Input DerivedHolePatchEnum that specifies the holes to patch. Valid values are kDerivedPatchNone, kDerivedPatchAll and kDerivedPatchRange. If kDerivedPatchRange is provided, the MinimumPerimeter and MaximumPerimeter values define the range.</param>
    /// <param name="MinimumPerimeter">Optional input Double that specifies the minimum perimeter value if the HolePatchType is specified to be kDerivedPatchRange. If not provided, an internal default value is assumed.</param>
    /// <param name="MaximumPerimeter">Optional input Double that specifies the maximum perimeter value if the HolePatchType is specified to be kDerivedPatchRange. If not provided, an internal default value is assumed.</param>
    /// <param name="Reserved">Optional input Variant reserved for future use. Currently ignored.</param>
    [PreserveSig]
    void SetHolePatchingOptions([In] DerivedHolePatchEnum HolePatchType, [In] double? MinimumPerimeter = default, [In] double? MaximumPerimeter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default);
    /// <summary>
    /// Method that sets the simplification options specifying geometry to remove based on size.
    /// </summary>
    /// <param name="Enable">Input Boolean that specifies whether to enable or disable the 'remove by size' simplification option.</param>
    /// <param name="SizeRatioPercentage">Optional input Long that specifies the size ratio percentage value of parts/faces to be removed. Valid range is 0 to 100. The ratio indicates the difference between the part bounding box and the assembly bounding box. This input is required if the Enable argument is specified to be True.</param>
    [PreserveSig]
    void SetRemoveBySizeOptions([In] bool Enable, [In] int? SizeRatioPercentage = default);
    /// <summary>
    /// Method that sets the simplification options specifying geometry to remove based on visibility.
    /// </summary>
    /// <param name="GeometryToRemove">Input that specifies what geometry to remove. Valid values are kDerivedRemoveNone, kDerivedRemovePartsOnly and kDerivedRemovePartsAndFaces.</param>
    /// <param name="VisibilityPercentage">Optional input Long that specifies the visibility percentage value of parts/faces to be removed. For instance, a value of 0 indicates that parts/faces not visible in any view are to be removed. Valid range is 0 to 100. This input is required if GeometryToRemove is specified to be kDerivedRemovePartsOnly or kDerivedRemovePartsAndFaces.</param>
    /// <param name="IgnoreSurfaceFeatures">Optional input Boolean that specifies whether to ignore surfaces in visibility detection and removal. If not specified, a default of True is assumed indicating that surfaces will be ignored.</param>
    [PreserveSig]
    void SetRemoveByVisibilityOptions([In] DerivedGeometryRemovalEnum GeometryToRemove, [In] int? VisibilityPercentage = default, [In] bool? IgnoreSurfaceFeatures = true);
    /// <summary>
    /// Method that includes all sketches from the source assembly. This includes top level sketches in the source assembly as well as sketches in sub-assemblies and parts.
    /// </summary>
    [PreserveSig]
    void IncludeAllSketches();
    /// <summary>
    /// Method that includes all work features from the source assembly. This includes top level work features in the source assembly as well as work features in sub-assemblies and parts.
    /// </summary>
    [PreserveSig]
    void IncludeAllWorkFeatures();
    /// <summary>
    /// Method that includes all parameters from the source assembly.&nbsp;This includes top level parameters in the source assembly as well as parameters in sub-assemblies and parts.
    /// </summary>
    [PreserveSig]
    void IncludeAllParameters();
}
