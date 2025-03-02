namespace Oblikovati.API;

/// <summary>
/// The LeaderStyle object represents a leader style in a drawing. The properties and methods listed below are in addition to those supported by the Style object.
/// </summary>
public interface LeaderStyle
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
    /// Property that gets and sets the arrowhead style to use.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Property that gets and sets the size of the arrowhead (i.e. the terminator). The value is that of width of the arrow if the terminator is an arrowhead or for diameter if the terminator is a circle.
    /// </summary>
    double ArrowheadSize { get; set; }
    /// <summary>
    /// Property that gets and sets the height of the arrowhead relative to the associated line.
    /// </summary>
    double ArrowheadHeight { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Color OverrideColor { get; set; }
    /// <summary>
    /// Property that gets and sets the color for the style. Setting the property to Nothing restores the style to the color defined by the layer.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Property that gets and sets the thickness of this primitive/object. If LineDefinitionSpace is set to kScreenSpace, this value is defined in pixels. If LineDefinitionSpace is set to kModelSpace, this value is defined in model units (centimeters).
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Property that gets and sets the line type override. Setting the property to kDefaultLineType restores the default line type. If the property returns kCustomLineType, the GetCustomLineType method can be used to get further details about the line type.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Property that gets and sets the space from the end of the edge to which the leader attaches to the beginning of the leader extension line.
    /// </summary>
    double ExtensionLineOffset { get; set; }
    /// <summary>
    /// Property that gets and sets the length of the leader extension line past the end of the terminator.
    /// </summary>
    double ExtensionLineOvershoot { get; set; }
    /// <summary>
    /// Property that gets and sets whether to define the all-around symbol size by the height of text from the symbol's text style. This specifies the size of the all-around symbol for Feature Control Frames, Surface symbols, and Weld symbols (circular only).
    /// </summary>
    bool ScaleToTextHeight { get; set; }
    /// <summary>
    /// Property that gets and sets the size of the all-around symbol for Feature Control Frames, Surface symbols, and Weld symbols (circular only). This value is used only if the ScaleToTextHeight property is set to False.
    /// </summary>
    double AllAroundSymbolDiameter { get; set; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the style from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
