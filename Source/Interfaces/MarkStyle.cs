namespace Oblikovati.API;

/// <summary>
/// MarkStyle object.
/// </summary>
public interface MarkStyle
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets and sets the name of the style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the unique name of the style.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns whether this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Read-only property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the location status of the mark style.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets and sets the layer name for front face.
    /// </summary>
    string FrontLayerName { get; set; }
    /// <summary>
    /// Property that gets and sets the color for front Layer.
    /// </summary>
    Color FrontLayerColor { get; set; }
    /// <summary>
    /// Property that gets and sets the layer name for back layer.
    /// </summary>
    string BackLayerName { get; set; }
    /// <summary>
    /// Property that gets and sets the color for back Layer.
    /// </summary>
    Color BackLayerColor { get; set; }
    /// <summary>
    /// Property that gets and sets the line weight for front Layer.
    /// </summary>
    double FrontLayerLineWeight { get; set; }
    /// <summary>
    /// Property that gets and sets the line weight for back Layer.
    /// </summary>
    double BackLayerLineWeight { get; set; }
    /// <summary>
    /// Property that gets and sets the line type for front Layer.
    /// </summary>
    LineTypeEnum FrontLayerLineType { get; set; }
    /// <summary>
    /// Property that gets and sets the line type for back Layer.
    /// </summary>
    LineTypeEnum BackLayerLineType { get; set; }
    /// <summary>
    /// Property that gets and sets the mark text type.
    /// </summary>
    MarkTextTypeEnum MarkTextType { get; set; }
    /// <summary>
    /// Property that gets and sets the mark depth type.
    /// </summary>
    MarkTypeEnum MarkDepthType { get; set; }
    /// <summary>
    /// Property that gets and sets the mark text strokes font name.
    /// </summary>
    string StrokesFontName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that saves this style to the global repository.
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
    MarkStyle ConvertToLocal();
    /// <summary>
    /// Method that creates a new local style object.
    /// </summary>
    /// <param name="NewName">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a mark style is being copied, the name must be unique with respect to all the other mark styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    MarkStyle Copy([In] [MarshalAs(UnmanagedType.BStr)] string NewName);
    /// <summary>
    /// Method that deletes this style object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetFrontCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a the style to use custom line type from the specified .lin file.
    /// </summary>
    /// <param name="FullFileName">The full path and file name of the .lin file.</param>
    /// <param name="LineTypeName">The linetype name specified in the .lin file.</param>
    /// <param name="ReplaceExisting">Indicates whether to override an existing line type of the same name.</param>
    [PreserveSig]
    void SetFrontCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetBackCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a the style to use custom line type from the specified .lin file.
    /// </summary>
    /// <param name="FullFileName">The full path and file name of the .lin file.</param>
    /// <param name="LineTypeName">The linetype name specified in the .lin file.</param>
    /// <param name="ReplaceExisting">Indicates whether to override an existing line type of the same name.</param>
    [PreserveSig]
    void SetBackCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Method that gets the array of strings containing the stroke font list.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    string[] GetStrokeFontList();
}
