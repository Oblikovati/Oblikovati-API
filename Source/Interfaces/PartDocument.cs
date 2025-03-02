namespace Oblikovati.API;

/// <summary>
/// The PartDocument object is derived from the Document object.
/// </summary>
public interface PartDocument : Document
{
    /// <summary>
    /// Gets a Boolean flag indicating whether sketching is currently active.
    /// </summary>
    bool SketchActive { get; }
    /// <summary>
    /// Gets the primary ComponentDefinition that resides in this file (housing the BRep and its geometric Feature Constraints).
    /// </summary>
    PartComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Materials Materials { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle ActiveRenderStyle { get; set; }
    /// <summary>
    /// Property that returns the ModelingSettings object. The ModelingSettings object provides access to various modeling related document options. This is somewhat equivalent to the Modeling tab of the Document Settings dialog.
    /// </summary>
    ModelingSettings ModelingSettings { get; }
    /// <summary>
    /// Property that returns the SketchSettings object. The SketchSettings object provides access to various sketch related document options. This is somewhat equivalent to the Sketch tab of the Document Settings dialog.
    /// </summary>
    SketchSettings SketchSettings { get; }
    /// <summary>
    /// Property that returns the Sketch3DSettings object. The Sketch3DSettings object provides access to various 3D sketch related document options. This is somewhat equivalent to the 3D sketch related properties on Sketch tab of the Document Settings dialog.
    /// </summary>
    Sketch3DSettings Sketch3DSettings { get; }
    /// <summary>
    /// Property that returns the DisabledCommandList object. This object allows the document to disable specific commands. This list contains commands that are disabled in addition to those specified by the DisabledCommandTypes property.
    /// </summary>
    DisabledCommandList DisabledCommandList { get; }
    /// <summary>
    /// Property that returns the EnvironmentManager object.
    /// </summary>
    EnvironmentManager EnvironmentManager { get; }
    /// <summary>
    /// Gets the active lighting style object.
    /// </summary>
    LightingStyle ActiveLightingStyle { get; set; }
    /// <summary>
    /// Property that returns the LightingStyles collection object.
    /// </summary>
    LightingStyles LightingStyles { get; }
    /// <summary>
    /// Read-write property that gets and sets whether this part is intended to be used as a substitute part.
    /// </summary>
    bool IsSubstitutePart { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceStatusEnum SubstitutePartStatus { get; }
    /// <summary>
    /// Property that returns the ObjectVisibility object providing override visibility controls for objects in the document. Changes are not saved with the document.
    /// </summary>
    ObjectVisibility ObjectVisibility { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PartComponentDefinitions ComponentDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ExcludeFromBOM { get; set; }
    /// <summary>
    /// Property that returns the DisplaySettings object. The DisplaySettings object provides access to various display appearance related document settings.
    /// </summary>
    DisplaySettings DisplaySettings { get; }
    /// <summary>
    /// Read-only property that returns an Assets collection object that contains all of the assets, regardless of their type, that are associated with the document.
    /// </summary>
    Assets Assets { get; }
    /// <summary>
    /// Returns Assets collection object that contains the appearances associated with the document.
    /// </summary>
    AssetsEnumerator AppearanceAssets { get; }
    /// <summary>
    /// Gets Assets collection object that contains the materials associated with the document.
    /// </summary>
    AssetsEnumerator MaterialAssets { get; }
    /// <summary>
    /// Get AssetsEnumerator object that contains the physical properties associated with the document.
    /// </summary>
    AssetsEnumerator PhysicalAssets { get; }
    /// <summary>
    /// Gets and sets the default appearance for the part.
    /// </summary>
    Asset ActiveAppearance { get; set; }
    /// <summary>
    /// Gets and sets the default material for the part.
    /// </summary>
    Asset ActiveMaterial { get; set; }
    /// <summary>
    /// Gets and sets the source of the appearance for the part. Setting to kMaterialAppearance will clear appearance override so the document uses the appearance associated with active material.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Printer3DName { get; set; }
    /// <summary>
    /// Read-only property that returns whether this document is embedded into another document.
    /// </summary>
    bool IsEmbeddedDocument { get; }
    /// <summary>
    /// Read-only property that returns the document in which this document is embedded in. This returns Nothing if the IsEmbeddedDocument is False.
    /// </summary>
    _Document EmbeddingDocument { get; }
    /// <summary>
    /// Gets the FlatPatternSettings object.
    /// </summary>
    FlatPatternSettings FlatPatternSettings { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveAnnotationsStandard { get; set; }
    /// <summary>
    /// Gets the TextStylesEnumerator object.
    /// </summary>
    TextStylesEnumerator TextStyles { get; }
    /// <summary>
    /// Read-only property that returns the full file name of the associative foreign file. This property returns empty string if the IsEmbeddedDocument returns False.
    /// </summary>
    string AssociativeForeignFilename { get; }
    /// <summary>
    /// Property to get or set the active mark style object.
    /// </summary>
    MarkStyle ActiveMarkStyle { get; set; }
    /// <summary>
    /// Get the document's mark styles.
    /// </summary>
    MarkStylesEnumerator MarkStyles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BatchEditParams">BatchEditParams</param>
    /// <param name="Error">Error</param>
    [PreserveSig]
    void BatchEdit([In] [MarshalAs(UnmanagedType.BStr)] string BatchEditParams, [Out] out MemberManagerErrorsEnum Error);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="IgnoreErrors">IgnoreErrors</param>
    [PreserveSig]
    bool UpdateSubstitutePart([In] bool? IgnoreErrors = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Selection">Selection</param>
    /// <param name="ObjectType">ObjectType</param>
    /// <param name="AdditionalData">AdditionalData</param>
    /// <param name="ContainingOccurrence">ContainingOccurrence</param>
    /// <param name="SelectedObject">SelectedObject</param>
    [PreserveSig]
    void GetSelectedObject([In] [MarshalAs(UnmanagedType.Interface)] GenericObject Selection, [Out] out ObjectTypeEnum ObjectType, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap AdditionalData);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Selection">Selection</param>
    /// <param name="ObjectType">ObjectType</param>
    /// <param name="AdditionalData">AdditionalData</param>
    /// <param name="ContainingOccurrence">ContainingOccurrence</param>
    /// <param name="SelectedObject">SelectedObject</param>
    [PreserveSig]
    void GetSelectedObject([In] [MarshalAs(UnmanagedType.Interface)] GenericObject Selection, [Out] out ObjectTypeEnum ObjectType, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap AdditionalData, [Out] [MarshalAs(UnmanagedType.Interface)] out ComponentOccurrence ContainingOccurrence, [In] [Out] [MarshalAs(UnmanagedType.Struct)] ref object SelectedObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ExecutePromptToChoose3daStyle();
    /// <summary>
    /// Sets the graphics facet groups that must be saved with this file. Each bit indicating a level of detail. Up to 6 permitted. File size affected adversely when more. Recommend pick from GraphicsLevelsOfDetailEnum.
    /// </summary>
    /// <param name="LevelsOfDetail">Input Long that specifies the level of detail.</param>
    [PreserveSig]
    void PutGraphicsLevelsOfDetail([In] int LevelsOfDetail);
}
