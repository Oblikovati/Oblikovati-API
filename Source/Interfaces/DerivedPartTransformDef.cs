namespace Oblikovati.API;

/// <summary>
/// The DerivedPartCoordinateSystemDef object allows you to define the transformation for a derived part, as well as to include and exclude elements from the base part to the part to be derived.
/// </summary>
public interface DerivedPartTransformDef
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
    /// Property that defines whether all surfaces are included in the derived part. Valid input for this property is kDerivedIncludeAll, kDerivedExcludeAll, and kDerivedIndividualDefined.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    /// <summary>
    /// Property that defines whether exported parameters are included in the derived part. This property is initialized to True when the DerivedPartDefinition object is created.
    /// </summary>
    bool IncludeAllParameters { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IncludeBody { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BodyAsSolidBody { get; set; }
    /// <summary>
    /// Property that gets the collection of surfaces available in the selected part along with the inclusion option for each surface.
    /// </summary>
    DerivedPartEntities Surfaces { get; }
    /// <summary>
    /// Property that gets the collection of iMates available in the selected part along with the inclusion option for each iMate.
    /// </summary>
    DerivedPartEntities iMateDefinitions { get; }
    /// <summary>
    /// Property that gets the collection of parameters available in the selected part along with the inclusion option for each parameter.
    /// </summary>
    DerivedPartEntities Parameters { get; }
    /// <summary>
    /// Gets and sets how bodies are derived. Valid options are kDeriveAsSingleBodyWithSeams, kDeriveAsSingleBodyNoSeams, kDeriveAsMultipleBodies and kDeriveAsWorkSurface.
    /// </summary>
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    /// <summary>
    /// Gets and sets whether all solids are included in the derived part.&nbsp;Valid input for this property is kDerivedIncludeAll, kDerivedExcludeAll, and kDerivedIndividualDefined.
    /// </summary>
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    /// <summary>
    /// Property that gets the collection of solids available in the selected part along with the inclusion option for each solid.
    /// </summary>
    DerivedPartEntities Solids { get; }
    /// <summary>
    /// Gets and sets whether all iMates are included in the derived part.
    /// </summary>
    DerivedComponentOptionEnum IncludeAlliMateDefinitions { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Design View Representation for the derived part. An empty string indicates the Master design view is used.&nbsp;The IsAssociativeDesignView property indicates if an associate link to the design view is created or not.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if there is an associative link to the specified design view.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the Reduced Memory Mode.
    /// </summary>
    bool ReducedMemoryMode { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UseColorOverridesFromSource { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the name of active model state for the derived part.
    /// </summary>
    string ActiveModelState { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to link face color from source component or not.
    /// </summary>
    bool LinkFaceColorFromSource { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to link sketch formatting from source component or not.
    /// </summary>
    bool LinkSketchFormattingFromSource { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to use the oriented minimum bounding box or orthogonal bounding box for the components that are included as bounding box.
    /// </summary>
    bool UseOrientedMinimumBoundingBox { get; set; }
    /// <summary>
    /// Gets the collection of FinishFeatures available in the selected part along with the inclusion option for each FinishFeature.
    /// </summary>
    DerivedPartEntities Finishes { get; }
    /// <summary>
    /// Method that causes all entities within the derived part component to be set to kDerivedIncludeAll.
    /// </summary>
    [PreserveSig]
    void IncludeAll();
    /// <summary>
    /// Method that causes all entities within the derived part component to be set to kDerivedExcludeAll. Description This method should exclude all solids, surfaces, sketches, 3d sketches, sketch blocks, sketch block definitions, workfeatures, parameters and iMate definitions.
    /// </summary>
    [PreserveSig]
    void ExcludeAll();
    /// <summary>
    /// Method that sets the matrix describing the transform that should be applied to the entities being derived. Operations allowed in the transform are: translation, rotation, non-uniform scale and mirror.
    /// </summary>
    /// <param name="Transform">Input object that specifies the transform for the derived part.</param>
    /// <param name="Mirror">Optional input Boolean that specifies whether the derived part should be mirrored.</param>
    [PreserveSig]
    void SetTransformation([In] [MarshalAs(UnmanagedType.Interface)] Matrix Transform, [In] bool? Mirror = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Transform">Transform</param>
    /// <param name="Mirror">Mirror</param>
    [PreserveSig]
    void GetTransformation([Out] [MarshalAs(UnmanagedType.Interface)] out Matrix Transform, [Out] out bool Mirror);
}
