namespace Oblikovati.API;

/// <summary>
/// The SheetFormat object represents a sheet format in a drawing.
/// </summary>
public interface SheetFormat
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
    /// Property that returns the parent DrawingDocument object.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Gets and sets the name of the SheetFormat.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that gets the height of the sheet as defined in the format.
    /// </summary>
    double Height { get; }
    /// <summary>
    /// Property that gets the width of the sheet as defined in the format.
    /// </summary>
    double Width { get; }
    /// <summary>
    /// Property that gets the size of the sheet as defined in the format.
    /// </summary>
    DrawingSheetSizeEnum Size { get; }
    /// <summary>
    /// Property that gets whether the sheet is oriented using landscape or portrait orientation.
    /// </summary>
    PageOrientationTypeEnum Orientation { get; }
    /// <summary>
    /// Property that returns the position of the title block on the sheet as defined in the format.
    /// </summary>
    TitleBlockLocationEnum TitleBlockLocation { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the TitleBlockDefinition that this format references.
    /// </summary>
    TitleBlockDefinition ReferencedTitleBlockDefinition { get; }
    /// <summary>
    /// Property that returns the BorderDefinition that this format references.
    /// </summary>
    BorderDefinition ReferencedBorderDefinition { get; }
    /// <summary>
    /// Property that returns an enumerator of all the SketchedSymbolDefinition objects that this format references.
    /// </summary>
    ObjectsEnumerator ReferencedSymbolDefinitions { get; }
    /// <summary>
    /// Property that returns an enumerator of all the AutoCADBlockDefinition objects that this format references. The property returns Nothing if the sheet format does not reference any AutoCAD block definitions.
    /// </summary>
    AutoCADBlockDefinitionsEnumerator ReferencedAutoCADBlockDefinitions { get; }
    /// <summary>
    /// Property that returns whether this sheet format contains definitions for one or more drawing views.
    /// </summary>
    bool HasDrawingViews { get; }
    /// <summary>
    /// Returns whether to fit the drawing views to the sheet or no.
    /// </summary>
    bool FitViewsToSheet { get; }
    /// <summary>
    /// Method that deletes the sheet format.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetDocument">TargetDocument</param>
    [PreserveSig]
    SheetFormat CopyTo([In] [MarshalAs(UnmanagedType.Interface)] _DrawingDocument TargetDocument);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
