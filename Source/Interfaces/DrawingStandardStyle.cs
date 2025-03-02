namespace Oblikovati.API;

/// <summary>
/// The DrawingStandardStyle object represents a drawing standard.
/// </summary>
public interface DrawingStandardStyle
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingStylesManager _Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the name of the Style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the internal name of the style. The name is the internal English name of the standard style. This name will remain constant and is not affected by locale. This name is never displayed to the user. Note that this name is not guaranteed to be unique.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the location of this style, i.e. local to the document, cached locally in the document, exists in the library. Styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the type of the style.
    /// </summary>
    StyleTypeEnum StyleType { get; }
    /// <summary>
    /// Gets and sets comments associated with the style.
    /// </summary>
    string Comments { get; set; }
    /// <summary>
    /// Property returning the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the active ObjectDefaultsStyle object.
    /// </summary>
    ObjectDefaultsStyle ActiveObjectDefaults { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _InUse { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    StyleLocationEnum _StyleLocation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpToDate { get; }
    /// <summary>
    /// Gets and sets whether to exclude characters specified in the ExcludeCharacters property from bend tables and its associated tags.
    /// </summary>
    bool ApplyExcludeCharactersToBendTables { get; set; }
    /// <summary>
    /// Gets and sets whether to exclude characters specified in the ExcludeCharacters property from hole tables and its associated tags.
    /// </summary>
    bool ApplyExcludeCharactersToHoleTables { get; set; }
    /// <summary>
    /// Gets and sets whether to exclude characters specified in the ExcludeCharacters property from revision tables and its associated tags.
    /// </summary>
    bool ApplyExcludeCharactersToRevisionTables { get; set; }
    /// <summary>
    /// Gets and sets whether to exclude characters specified in the ExcludeCharacters property from view names.
    /// </summary>
    bool ApplyExcludeCharactersToViewNames { get; set; }
    /// <summary>
    /// Gets and sets the character to use as a decimal marker.
    /// </summary>
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets comma separated list of characters to be excluded from automatic alphabetical indexing.
    /// </summary>
    string ExcludeCharacters { get; set; }
    /// <summary>
    /// Gets and sets whether the projection type is first angle or third angle projection.
    /// </summary>
    bool FirstAngleProjection { get; set; }
    /// <summary>
    /// Gets and sets the viewing plane to use as front view when creating a drawing view.
    /// </summary>
    FrontViewPlaneEnum FrontViewPlane { get; set; }
    /// <summary>
    /// Gets and sets the line scale for all line styles in the drawing.
    /// </summary>
    double GlobalLineScale { get; set; }
    /// <summary>
    /// Property that returns the International Standard on which this standard style is based.
    /// </summary>
    DraftingStandardEnum InternationalStandardReference { get; }
    /// <summary>
    /// Gets and sets the units of length measure.
    /// </summary>
    UnitsTypeEnum LinearUnits { get; set; }
    /// <summary>
    /// Gets and sets thread edge display type for sectional views.
    /// </summary>
    bool PartialSectionThreadEnd { get; set; }
    /// <summary>
    /// Gets and sets thread edge display type for top views.
    /// </summary>
    bool PartialCircularThreadEdge { get; set; }
    /// <summary>
    /// Gets and sets an array of Doubles that specify the set of default values for line weights.
    /// </summary>
    object PresetLineWeights { get; set; }
    /// <summary>
    /// Gets and sets an array of Strings that specify the set of default values for drawing view scales.
    /// </summary>
    object PresetScales { get; set; }
    /// <summary>
    /// Gets and sets an array of Doubles that specify the set of default values for text heights.
    /// </summary>
    object PresetTextHeights { get; set; }
    /// <summary>
    /// Gets and sets an array of Doubles that specify the set of default values for section view hatch angles.
    /// </summary>
    object PresetSectionHatchAngles { get; set; }
    /// <summary>
    /// Method that deletes the Style/Layer/UnfoldMethod.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Style ConvertToLocal();
    /// <summary>
    /// Method that creates a new local Style object. The newly created style is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a dimension style is being copied, the name must be unique with respect to all the other dimension styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Style Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    [PreserveSig]
    DrawingStandardStyle _Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    DrawingStandardStyle _ConvertToLocal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _SaveToGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _UpdateFromGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewType">ViewType</param>
    /// <param name="Prefix">Prefix</param>
    /// <param name="Visible">Visible</param>
    /// <param name="FormattedText">FormattedText</param>
    /// <param name="ConstrainToBorder">ConstrainToBorder</param>
    /// <param name="PlaceBelowView">PlaceBelowView</param>
    [PreserveSig]
    void GetViewLabelDefaults([In] DrawingViewTypeEnum ViewType, [Out] [MarshalAs(UnmanagedType.BStr)] out string Prefix, [Out] out bool Visible, [Out] [MarshalAs(UnmanagedType.BStr)] out string FormattedText, [Out] out bool ConstrainToBorder, [Out] out bool PlaceBelowView);
    /// <summary>
    /// Method that sets the drawing view label defaults for the specified view type.
    /// </summary>
    /// <param name="ViewType">Input DrawingViewTypeEnum value that specifies the drawing view type for which to set the label defaults.</param>
    /// <param name="Prefix">Input String that specifies the default view label prefix.</param>
    /// <param name="Visible">Input Boolean that specifies whether the label should be displayed by default.</param>
    /// <param name="FormattedText">Input String that sets the content of the view label. See the documentation of the DrawingViewLabel.FormattedText property for details, or see the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="ConstrainToBorder">Input Boolean that specifies whether the view label is constrained to the view. If set to True, the view label maintains its relative position to the view boundary as the boundary changes in size or position due to a modeling change, changing a view's assembly representation, or changing the view scale.</param>
    /// <param name="PlaceBelowView">Input Boolean that specifies whether to place the label below or above the drawing view.</param>
    [PreserveSig]
    void SetViewLabelDefaults([In] DrawingViewTypeEnum ViewType, [In] [MarshalAs(UnmanagedType.BStr)] string Prefix, [In] bool Visible, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] bool ConstrainToBorder, [In] bool PlaceBelowView);
}
