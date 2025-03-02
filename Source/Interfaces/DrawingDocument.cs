namespace Oblikovati.API;

/// <summary>
/// The DrawingDocument object provides methods and properties to create, activate, save, and query many properties of individual drawing documents.
/// </summary>
public interface DrawingDocument : Document
{
    /// <summary>
    /// Property that returns the currently active sheet.
    /// </summary>
    Sheet ActiveSheet { get; }
    /// <summary>
    /// Property that returns the Sheets collection object. This object provides access to all of the sheets in the document.
    /// </summary>
    Sheets Sheets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TextStyles _TextStyles { get; }
    /// <summary>
    /// Property that returns the BorderDefinitions collection object. This object provides access to all of the border definitions in the document and provides functionality to create new border definitions.
    /// </summary>
    BorderDefinitions BorderDefinitions { get; }
    /// <summary>
    /// Property that returns the TitleBlockDefinitions collection object. This object provides access to all of the title block definition in the document and provides functionality to create new title block definitions.
    /// </summary>
    TitleBlockDefinitions TitleBlockDefinitions { get; }
    /// <summary>
    /// Property that returns the SketchedSymbolDefinitions collection object. This object provides access to all of the sketched symbol definitions available for placement in the document and provides functionality to create new sketched symbol definitions.
    /// </summary>
    SketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
    /// <summary>
    /// The DrawingSettings object provides access to various drawing related document settings. This is somewhat equivalent to the Drawing tab of the Document Settings dialog.
    /// </summary>
    DrawingSettings DrawingSettings { get; }
    /// <summary>
    /// Property that returns the SketchSettings object. The SketchSettings object provides access to various sketch related document options. This is somewhat equivalent to the Sketch tab of the Document Settings dialog.
    /// </summary>
    SketchSettings SketchSettings { get; }
    /// <summary>
    /// Property that returns the DrawingStylesManager object.
    /// </summary>
    DrawingStylesManager StylesManager { get; }
    /// <summary>
    /// Property that gets the DrawingEvents object. This provides drawing event notification such as onRetrieveDimensions.
    /// </summary>
    DrawingEvents DrawingEvents { get; }
    /// <summary>
    /// Property that returns the DisabledCommandList object. This object allows the document to disable specific commands. This list contains commands that are disabled in addition to those specified by the DisabledCommandTypes property.
    /// </summary>
    DisabledCommandList DisabledCommandList { get; }
    /// <summary>
    /// Property that returns the EnvironmentManager object.
    /// </summary>
    EnvironmentManager EnvironmentManager { get; }
    /// <summary>
    /// Property that returns the SheetSettings object. The SheetSettings object provides access to various sheet related document options. This is somewhat equivalent to the Sheet tab of the Document Settings dialog.
    /// </summary>
    SheetSettings SheetSettings { get; }
    /// <summary>
    /// Gets the reference to the containing DWG document when this document is stored in a DWG.
    /// </summary>
    object ContainingDWGDocument { get; }
    /// <summary>
    /// Property that returns whether this is an Inventor DWG document.
    /// </summary>
    bool IsInventorDWG { get; }
    /// <summary>
    /// Property that returns the SheetFormats collection object.
    /// </summary>
    SheetFormats SheetFormats { get; }
    /// <summary>
    /// Property that returns the collection of locally stored BOMs in this drawing document.
    /// </summary>
    DrawingBOMs DrawingBOMs { get; }
    /// <summary>
    /// Property that returns the AutoCADBlockDefinitions collection object.
    /// </summary>
    AutoCADBlockDefinitions AutoCADBlockDefinitions { get; }
    /// <summary>
    /// Property that returns the set of parameters stored in this drawing document.
    /// </summary>
    Parameters Parameters { get; }
    /// <summary>
    /// Read-only property that returns the DrawingHatchPatternsManager object.
    /// </summary>
    DrawingHatchPatternsManager DrawingHatchPatternsManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Selection">Selection</param>
    /// <param name="ContainingView">ContainingView</param>
    /// <param name="SelectedObject">SelectedObject</param>
    [PreserveSig]
    void ProcessViewSelection([In] [MarshalAs(UnmanagedType.Interface)] GenericObject Selection, [Out] [MarshalAs(UnmanagedType.Interface)] out DrawingView ContainingView, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object SelectedObject);
    /// <summary>
    /// Method that saves the document as an Oblikovati DWG with the specified name.
    /// </summary>
    /// <param name="FullFileName">Input string to specify the full file name of the new dwg.</param>
    /// <param name="SaveCopyAs">Input Boolean that indicates whether the file to be saved is new or is a copy of a previously existing file.</param>
    [PreserveSig]
    void SaveAsInventorDWG([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] bool SaveCopyAs);
    /// <summary>
    /// Set all drawing views in the document to be raster views.
    /// </summary>
    [PreserveSig]
    void MakeAllViewsRaster();
    /// <summary>
    /// Set all drawing views in the document to be precise views.
    /// </summary>
    [PreserveSig]
    void MakeAllViewsPrecise();
}
