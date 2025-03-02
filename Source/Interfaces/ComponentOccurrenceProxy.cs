namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface ComponentOccurrenceProxy
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns a Boolean specifying whether the occurrence path contains body-modifying assembly features.
    /// </summary>
    bool HasBodyOverride { get; }
    /// <summary>
    /// Property that returns the SurfaceBodies collection for the occurrence. This property applies to occurrences that represent a part and provides access to the B-Rep of that part. The B-Rep queries will return coordinate data in the context of the component definition that served as the starting point to access the occurrence, which can also be accessed through the ContextDefinition property.
    /// </summary>
    SurfaceBodies SurfaceBodies { get; }
    /// <summary>
    /// Gets/Sets the human-readable name of this Component Occurrence.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the object this occurrence is in the context of. For example, all coordinate data returned by the definition is in the space of this ComponentDefinition.
    /// </summary>
    ComponentDefinition ContextDefinition { get; }
    /// <summary>
    /// Property that returns the object this occurrence references.
    /// </summary>
    ComponentDefinition Definition { get; }
    /// <summary>
    /// Gets the type of the Document whose occurrence this is.
    /// </summary>
    DocumentTypeEnum DefinitionDocumentType { get; }
    /// <summary>
    /// Property that returns the parent of this occurrence. This property is only valid for the occurrences in a multi-level assembly that are not in the top level. The parent occurrence is the occurrence representing the subassembly this occurrence is contained within.
    /// </summary>
    ComponentOccurrence ParentOccurrence { get; }
    /// <summary>
    /// Gets the path of immediate (directly instanced) occurrences that make up this occurrence.
    /// </summary>
    ComponentOccurrencesEnumerator OccurrencePath { get; }
    /// <summary>
    /// Property that returns the collection of occurrences for an occurrence. This property applies to occurrences that represent a subassembly. The collection returned provides access to the occurrences contained within the subassembly. If this collection is obtained from an occurrence that represents a part, it will not contain any occurrences.
    /// </summary>
    ComponentOccurrencesEnumerator SubOccurrences { get; }
    /// <summary>
    /// Property that returns and sets the transformation for the occurrence. The transformation matrix defines the position and orientation of the component within the assembly. When setting the transform of an occurrence the actual change in position and orientation of the occurrence is limited by the constraints on the occurrence.
    /// </summary>
    Matrix Transformation { get; set; }
    /// <summary>
    /// Property returns the collection of constraints that are acting on the occurrence.
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// 'Put' is Inventor Only: Gets/Sets the Boolean flag that specifies whether this Occurrence is grounded or not.
    /// </summary>
    bool Grounded { get; set; }
    /// <summary>
    /// 'Put' is Inventor Only: Gets/Sets the Boolean flag that specifies whether this Occurrence is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// 'Put' is Inventor Only: Gets/Sets the Boolean flag that specifies whether this Occurrence is adaptive or not.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// 'Put' is Inventor Only: Gets/Sets the Boolean flag that specifies whether this Occurrence is enabled or not.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle RenderStyle { get; set; }
    /// <summary>
    /// Property that returns the MassProperties object. This supports performing mass properties calculations for this particular occurrence.
    /// </summary>
    MassProperties MassProperties { get; }
    /// <summary>
    /// Property that returns the pattern element this occurrence represents. In the case where this occurrence is not part of a pattern this property returns Nothing. The IsPatternElement property can be used to check if this occurrence is part of a pattern.
    /// </summary>
    OccurrencePatternElement PatternElement { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that specifies if the ComponentOccurence is an iPartMember. The property is True if the ComponentOccurence is an iPartMember.
    /// </summary>
    bool IsiPartMember { get; }
    /// <summary>
    /// Property that returns the iMateDefinitions that are available from this occurrence. The iMateDefinition objects returned are actually proxies for the various iMateDefinition objects. These can be used as input to the Add and ValidResult methods of the iMateResults object.
    /// </summary>
    iMateDefinitionsEnumerator iMateDefinitions { get; }
    /// <summary>
    /// Gets and sets the action types valid for this component occurrence.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that tightly encloses this object.
    /// </summary>
    Box PreciseRangeBox { get; }
    /// <summary>
    /// Read-only property that returns the oriented minimum range box for this object.
    /// </summary>
    OrientedBox OrientedMinimumRangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActivePositionalState { get; set; }
    /// <summary>
    /// Gets and sets the BOM structure override.
    /// </summary>
    BOMStructureEnum BOMStructure { get; set; }
    /// <summary>
    /// Only works for assembly occurrences.&nbsp;Gets and sets the Boolean flag that specifies whether the assembly is flexible.
    /// </summary>
    bool Flexible { get; set; }
    /// <summary>
    /// Property that returns an enumeration of descriptors that represent the native document references held by this document.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Gets and sets the active Positional Representation for this occurrence.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveLevelOfDetailRepresentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveDesignViewRepresentation { get; }
    /// <summary>
    /// Property that returns whether the ComponentOccurrence is an iAssemblyMember. The property returns True if the ComponentOccurrence is an iAssemblyMember. This property always returns False for occurrences of part documents.
    /// </summary>
    bool IsiAssemblyMember { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CustomAdaptive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object InterchangeableComponents { get; set; }
    /// <summary>
    /// Property that returns whether this occurrence is suppressed or not.
    /// </summary>
    bool Suppressed { get; }
    /// <summary>
    /// Gets and sets the opacity of an occurrence.
    /// </summary>
    double OverrideOpacity { get; set; }
    /// <summary>
    /// Gets and sets whether to display the degrees of freedom for the occurrence.
    /// </summary>
    bool ShowDegreesOfFreedom { get; set; }
    /// <summary>
    /// Property that returns whether this occurrence references a substitute part in the context of a substitute model state.
    /// </summary>
    bool IsSubstituteOccurrence { get; }
    /// <summary>
    /// Gets and sets whether the component belongs in the contact set.
    /// </summary>
    bool ContactSet { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the occurrence is excluded in the active row of the iAssembly factory.&nbsp;This property returns False and cannot be set to True if the parent document is not an iAssembly.
    /// </summary>
    bool Excluded { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptor ReferencedFileDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _DisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentDefinitionReference DefinitionReference { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Reference { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LocalAdaptive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Edited { get; }
    /// <summary>
    /// Property that indicates whether this occurrence represents a pattern element. In the case where this occurrence represents a pattern element, this property returns True. The PatternElement property can be used to get that pattern element.
    /// </summary>
    bool IsPatternElement { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsSimulationOccurrence { get; }
    /// <summary>
    /// Gets and sets whether this occurrence is associative to a design view representation.
    /// </summary>
    bool IsAssociativeToDesignViewRepresentation { get; set; }
    /// <summary>
    /// Gets and sets the current appearance of the component occurrence.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Gets and sets the source of the appearance for the component occurrence.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Inventor Only: Gets the enumerator that presents the joints applied on this Component Occurrence.
    /// </summary>
    AssemblyJointsEnumerator Joints { get; }
    /// <summary>
    /// Gets whether this occurrence is an associatively imported occurrence.
    /// </summary>
    bool IsAssociativelyImported { get; }
    /// <summary>
    /// Read-only property that returns whether the ComponentOccurrence has an associative imported component.
    /// </summary>
    bool HasAssociativeImportedComponent { get; }
    /// <summary>
    /// Read-only property that returns the associative ImportedComponent object if the HasAssociativeImportedComponent returns True.
    /// </summary>
    ImportedComponent ImportedComponent { get; }
    /// <summary>
    /// 'Put' is Inventor Only: Gets/Sets the Boolean flag that specifies whether this Occurrence is transparent or not.
    /// </summary>
    bool Transparent { get; set; }
    /// <summary>
    /// Read-only property that returns the full file name of the associative foreign file. This property returns empty string if the IsAssociativelyImported returns False.
    /// </summary>
    string AssociativeForeignFilename { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active model state for an assembly occurrence.
    /// </summary>
    string ActiveModelState { get; set; }
    /// <summary>
    /// Read-only property that returns a PropertySets object associated with the occurence.
    /// </summary>
    PropertySets OccurrencePropertySets { get; }
    /// <summary>
    /// Read-write property that gets and sets whether this occurrence has a PropertySets object.
    /// </summary>
    bool OccurrencePropertySetsEnabled { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    ComponentOccurrence NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that sets the position and orientation of the occurrence, ignoring any constraints on the occurrence. When the assembly is recomputed the occurrence will reposition to honor the constraints.
    /// </summary>
    /// <param name="Matrix">Input object that specifies the position and orientation of the occurrence.</param>
    [PreserveSig]
    void SetTransformWithoutConstraints([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Geometry">Geometry</param>
    /// <param name="Result">Result</param>
    [PreserveSig]
    void CreateGeometryProxy([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Result);
    /// <summary>
    /// Method that deletes the occurrence. This is the equivalent of the user deleting the occurrence interactively.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Deletes this component occurrence.
    /// </summary>
    /// <param name="SkipDocumentSave">Optional input Boolean value to specify if skip save the source document of the occurrence. This default to False if not specified.</param>
    [PreserveSig]
    void Delete2([In] bool? SkipDocumentSave = false);
    /// <summary>
    /// Method that replaces the occurrence or all instances of an occurrence with another file.
    /// </summary>
    /// <param name="FileName">Input filename of the new file to be used to replace the existing occurrence.</param>
    /// <param name="ReplaceAll">Input Boolean that indicates whether the current occurrence should be replaced for all instances of this occurrence.</param>
    [PreserveSig]
    void Replace([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool ReplaceAll);
    /// <summary>
    /// Replaces this component occurrence with another component. Can save replaced component and unset adaptivity.
    /// </summary>
    /// <param name="FileName">Input String value indicates the full document name of another document to be used to replace the existing occurrence.</param>
    /// <param name="ReplaceAll">Input Boolean that indicates whether the current occurrence should be replaced or all instances of this occurrence should be replaced.</param>
    /// <param name="SaveEdits">Optional input Boolean that specifies whether to save the edits in the component(s) that is being replaced. This defaults to False indicating the edits won’t be saved.</param>
    /// <param name="KeepAdaptivity">Optional input Boolean that specifies whether to keep the adaptivity after replacing the component(s). This defaults to False indicating the adaptivity is removed after replacement.</param>
    [PreserveSig]
    void Replace2([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool ReplaceAll, [In] [MarshalAs(UnmanagedType.Struct)] object? SaveEdits = default, [In] [MarshalAs(UnmanagedType.Struct)] object? KeepAdaptivity = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    [PreserveSig]
    RenderStyle GetRenderStyle([Out] out StyleSourceTypeEnum StyleSourceType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    /// <param name="RenderStyle">RenderStyle</param>
    [PreserveSig]
    void SetRenderStyle([In] StyleSourceTypeEnum StyleSourceType, [In] [MarshalAs(UnmanagedType.Struct)] object? RenderStyle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that changes the row in the iPartTable this iPartMember represents. This method can be used only if the iPartMember property is True.
    /// </summary>
    /// <param name="NewRow">Specifies the new row from the factory. The row index is specified either by a Long (row index), a String (MemberName of a member or DocumentName of a member), or an iPartTableRow object.</param>
    /// <param name="CustomInput">Optional input array of Strings that specifies the input to use for the custom input. If the factory is a custom factory and this is not supplied the default values for custom values are used. The custom input strings are supplied in a column order. If the factory is not a custom factory this argument is ignored.</param>
    [PreserveSig]
    void ChangeRowOfiPartMember([In] [MarshalAs(UnmanagedType.Struct)] object NewRow, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
    /// <summary>
    /// Activates this component occurrence for editing by the end user via the user interface.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DisplayModeSourceType">DisplayModeSourceType</param>
    [PreserveSig]
    DisplayModeEnum GetDisplayMode([Out] out DisplayModeSourceTypeEnum DisplayModeSourceType);
    /// <summary>
    /// Sets the display mode and type - default or override.
    /// </summary>
    /// <param name="DisplayModeSourceType">Enum indicating the display mode type.</param>
    /// <param name="DisplayMode">The display mode.</param>
    [PreserveSig]
    void SetDisplayMode([In] DisplayModeSourceTypeEnum DisplayModeSourceType, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayMode = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Representation">Representation</param>
    /// <param name="SkipDocumentSave">SkipDocumentSave</param>
    [PreserveSig]
    void SetLevelOfDetailRepresentation([In] [MarshalAs(UnmanagedType.BStr)] string Representation, [In] bool? SkipDocumentSave = false);
    /// <summary>
    /// Method that sets a design view representation for an assembly occurrence.
    /// </summary>
    /// <param name="Representation">String that specifies the Design View Representation to set on the occurrence. The method returns a failure if a representation with this name is not found in the referenced assembly or in the private representation file (if specified).</param>
    /// <param name="Associative">Optional input Boolean that indicates whether to associatively apply the design view. If set to True, any changes to the design view in the referenced assembly will show in this occurrence. If not specified, a value of False is used. This method fails if the input representation is a private design view representation and a value of True is specified for this argument (i.e. the associative option is invalid for private design views).</param>
    [PreserveSig]
    void SetDesignViewRepresentation([In] [MarshalAs(UnmanagedType.BStr)] string Representation, [In] [MarshalAs(UnmanagedType.BStr)] string? Reserved = "", [In] bool? Associative = false);
    /// <summary>
    /// Method that changes the row in the iAssemblyFactory this occurrence references. This method can be used only if the IsiAssemblyMember property returns True.
    /// </summary>
    /// <param name="NewRow">Specifies the new row from the factory. The row index is specified either by a Long (row index), a String (MemberName of a member or DocumentName of a member), or an iAssemblyTableRow object.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for modifying the occurrence. This argument is currently ignored.</param>
    [PreserveSig]
    void ChangeRowOfiAssemblyMember([In] [MarshalAs(UnmanagedType.Struct)] object NewRow, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Suppresses this occurrence.
    /// </summary>
    /// <param name="SkipDocumentSave">Optional input Boolean value to specify if skip save the source document of the occurrence. This default to False if not specified.</param>
    [PreserveSig]
    void Suppress([In] bool? SkipDocumentSave = false);
    /// <summary>
    /// Method that unsuppresses the occurrence.
    /// </summary>
    [PreserveSig]
    void Unsuppress();
    /// <summary>
    /// Method that causes the component occurrence to return from the edit mode and into the environment specified by the input argument. If the ComponentOccurrence is not currently active (i.e. this is not the same occurrence as returned by AssemblyComponentDefinition.ActiveOccurrence), then this method does nothing.
    /// </summary>
    /// <param name="ExitTo">Input ExitTypeEnum that specifies the environment to exit to. Possible values are kExitToPrevious, kExitToParent and kExitToTop.</param>
    [PreserveSig]
    void ExitEdit([In] ExitTypeEnum ExitTo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TranslationDegreesCount">TranslationDegreesCount</param>
    /// <param name="TranslationDegreesVectors">TranslationDegreesVectors</param>
    /// <param name="RotationDegreesCount">RotationDegreesCount</param>
    /// <param name="RotationDegreesVectors">RotationDegreesVectors</param>
    /// <param name="DOFCenter">DOFCenter</param>
    [PreserveSig]
    void GetDegreesOfFreedom([Out] out int TranslationDegreesCount, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator TranslationDegreesVectors, [Out] out int RotationDegreesCount, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator RotationDegreesVectors, [Out] [MarshalAs(UnmanagedType.Interface)] out Point DOFCenter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="ReplaceAll">ReplaceAll</param>
    [PreserveSig]
    void _Replace([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool ReplaceAll);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DisplayModeSourceType">DisplayModeSourceType</param>
    [PreserveSig]
    void _GetDisplayMode([Out] out DisplayModeSourceTypeEnum DisplayModeSourceType);
    /// <summary>
    /// Method that shows all of the assembly constraints, joints and iMate objects associated with this occurrence.
    /// </summary>
    [PreserveSig]
    void ShowRelationships();
}
