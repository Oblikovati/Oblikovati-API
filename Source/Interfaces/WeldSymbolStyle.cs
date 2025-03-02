namespace Oblikovati.API;

/// <summary>
/// WeldSymbolStyle object.
/// </summary>
public interface WeldSymbolStyle
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
    /// Gets and sets the leader style used for the weld symbol style.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the weld symbol style.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Gets and sets the default identification line placement.
    /// </summary>
    IdentificationLinePlacementEnum IdentificationLinePlacement { get; set; }
    /// <summary>
    /// Gets and sets the distance between the identification line and weld symbol.
    /// </summary>
    double IdentificationLineOffset { get; set; }
    /// <summary>
    /// Gets and sets the default identification line type.
    /// </summary>
    LineTypeEnum IdentificationLineType { get; set; }
    /// <summary>
    /// Gets and sets whether the arrow side position if above or below the reference line.
    /// </summary>
    bool ArrowSidePositionAbove { get; set; }
    /// <summary>
    /// Gets and sets the field&nbsp;weld symbol flag direction.
    /// </summary>
    FieldFlagDirectionTypeEnum FieldFlagDirection { get; set; }
    /// <summary>
    /// Gets and sets whether justifies the text to leader or not.
    /// </summary>
    bool JustifyTextToLeader { get; set; }
    /// <summary>
    /// Gets and sets whether the symbol size is linked to text height or not.
    /// </summary>
    bool SymbolSizeLinkToTextHeight { get; set; }
    /// <summary>
    /// Gets and sets the symbol size scale factor. Scale factor must be between 0.5 and 2.00.
    /// </summary>
    double SymbolSizeScaleFactor { get; set; }
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
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    LineTypeEnum GetIdentificationLineCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Sets a custom line type to the identification line from the specified .lin file.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetIdentificationLineCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BackingSymbolFilter">BackingSymbolFilter</param>
    [PreserveSig]
    void GetBackingSymbolsFilter([Out] [MarshalAs(UnmanagedType.SafeArray)] out BackingSymbolTypeEnum[] BackingSymbolFilter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BackingSymbolFilter">BackingSymbolFilter</param>
    [PreserveSig]
    void SetBackingSymbolsFilter([In] [MarshalAs(UnmanagedType.SafeArray)] ref BackingSymbolTypeEnum[] BackingSymbolFilter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ContourSymbolFilter">ContourSymbolFilter</param>
    [PreserveSig]
    void GetContourSymbolsFilter([Out] [MarshalAs(UnmanagedType.SafeArray)] out ContourSymbolTypeEnum[] ContourSymbolFilter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ContourSymbolFilter">ContourSymbolFilter</param>
    [PreserveSig]
    void SetContourSymbolsFilter([In] [MarshalAs(UnmanagedType.SafeArray)] ref ContourSymbolTypeEnum[] ContourSymbolFilter);
    /// <summary>
    /// Gets the variation type of a contour symbol filter.
    /// </summary>
    /// <param name="ContourSymbolFilter">Input ContourSymbolTypeEnum to specify a contour symbol filter.</param>
    /// <returns></returns>
    [PreserveSig]
    ContourSymbolVariationTypeEnum GetContourSymbolFilterVariationType([In] ContourSymbolTypeEnum ContourSymbolFilter);
    /// <summary>
    /// Sets the variation type of a contour symbol filter.
    /// </summary>
    /// <param name="ContourSymbolFilter">Input ContourSymbolTypeEnum to specify a contour symbol filter.</param>
    /// <param name="ContourSymbolVariation">Intput ContourSymbolVariationTypeEnum value that indicates the included contour symbol filter variation type.</param>
    [PreserveSig]
    void SetContourSymbolFilterVariationType([In] ContourSymbolTypeEnum ContourSymbolFilter, [In] ContourSymbolVariationTypeEnum ContourSymbolVariation);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WeldingSymbolFilter">WeldingSymbolFilter</param>
    [PreserveSig]
    void GetWeldingSymbolsFilter([Out] [MarshalAs(UnmanagedType.SafeArray)] out WeldSymbolTypeEnum[] WeldingSymbolFilter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WeldingSymbolFilter">WeldingSymbolFilter</param>
    [PreserveSig]
    void SetWeldingSymbolsFilter([In] [MarshalAs(UnmanagedType.SafeArray)] ref WeldSymbolTypeEnum[] WeldingSymbolFilter);
    /// <summary>
    /// Gets the variation type of a welding symbol filter.
    /// </summary>
    /// <param name="WeldingSymbolFilter">Input WeldSymbolTypeEnum to specify a welding symbol filter.</param>
    /// <returns></returns>
    [PreserveSig]
    WeldSymbolVariationTypeEnum GetWeldingSymbolFilterVariationType([In] WeldSymbolTypeEnum WeldingSymbolFilter);
    /// <summary>
    /// Sets the variation type of a welding symbol filter.
    /// </summary>
    /// <param name="WeldingSymbolFilter">Input WeldSymbolTypeEnum to specify a welding symbol filter.</param>
    /// <param name="WeldingSymbolVariation">Intput WeldingSymbolVariationTypeEnum value that indicates the included welding symbol filter variation type.</param>
    [PreserveSig]
    void SetWeldingSymbolFilterVariationType([In] WeldSymbolTypeEnum WeldingSymbolFilter, [In] WeldSymbolVariationTypeEnum WeldingSymbolVariation);
}
