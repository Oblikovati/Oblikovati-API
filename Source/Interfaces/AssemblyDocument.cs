namespace Oblikovati.API;

/// <summary>
/// The AssemblyDocument object represents an in-memory Inventor assembly document.
/// </summary>
public interface AssemblyDocument : Document
{
    /// <summary>
    /// Property that returns the object associated with this assembly. For a standard assembly document, an AssemblyComponentDefinition object will be returned. For a weldment assembly, a Weldment object.
    /// </summary>
    AssemblyComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Property that returns the ModelingSettings object. The ModelingSettings object provides access to various modeling related document options. This is somewhat equivalent to the Modeling tab of the Document Settings dialog.
    /// </summary>
    ModelingSettings ModelingSettings { get; }
    /// <summary>
    /// Property that returns the SketchSettings object. The SketchSettings object provides access to various sketch related document options. This is somewhat equivalent to the Sketch tab of the Document Settings dialog.
    /// </summary>
    SketchSettings SketchSettings { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Materials Materials { get; }
    /// <summary>
    /// Gets the design view information for the document as a String containing XML formatted data. For more information on this XML format see More XML Design View Info...
    /// </summary>
    string DesignViewInfo { get; }
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string LevelOfDetailName { get; }
    /// <summary>
    /// Property that returns the ObjectVisibility object providing override visibility controls for objects in the document. Changes are not saved with the document.
    /// </summary>
    ObjectVisibility ObjectVisibility { get; }
    /// <summary>
    /// Read-write property that gets and sets a Boolean flag indicating whether this assembly is currently open in Express mode. When set this property it can only be set from True to False to load the document into full mode. To switch the document from full mode to express mode users should close it and re-open it in express mode using OpenWithOptions method.
    /// </summary>
    bool IsOpenExpress { get; set; }
    /// <summary>
    /// Gets the TextStylesEnumerator object.
    /// </summary>
    TextStylesEnumerator TextStyles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsOpenLightweight { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AssemblyComponentDefinitions ComponentDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ExcludeFromBOM { get; set; }
    /// <summary>
    /// Property that returns the DisplaySettings object. The DisplaySettings object provides access to various display appearance related document settings.
    /// </summary>
    DisplaySettings DisplaySettings { get; }
    /// <summary>
    /// Get Assets collection object that contains all of the assets, regardless of type, that are associated with the document.
    /// </summary>
    Assets Assets { get; }
    /// <summary>
    /// Read-only property that returns an AssetsEnumerator collection object that contains the appearances associated with the document.
    /// </summary>
    AssetsEnumerator AppearanceAssets { get; }
    /// <summary>
    /// Get AssetsEnumerator object that contains the materials associated with the document.
    /// </summary>
    AssetsEnumerator MaterialAssets { get; }
    /// <summary>
    /// Get AssetsEnumerator object that contains the physical properties associated with the document.
    /// </summary>
    AssetsEnumerator PhysicalAssets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    OGSSceneNode TopOGSSceneNode { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CachedGraphicsStatusEnum CachedGraphicsStatus { get; }
    /// <summary>
    /// Read-only property that returns whether this document is embedded into another document.
    /// </summary>
    bool IsEmbeddedDocument { get; }
    /// <summary>
    /// Read-only property that returns the document in which this document is embedded in. This returns Nothing if the IsEmbeddedDocument is False.
    /// </summary>
    _Document EmbeddingDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveAnnotationsStandard { get; set; }
    /// <summary>
    /// Read-only property that returns the full file name of the associative foreign file. This property returns empty string if the IsEmbeddedDocument returns False.
    /// </summary>
    string AssociativeForeignFilename { get; }
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Result">Result</param>
    [PreserveSig]
    void CheckAssemblyAndPromptOnError([Out] out bool Result);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _CleanMaterialProperty();
}
