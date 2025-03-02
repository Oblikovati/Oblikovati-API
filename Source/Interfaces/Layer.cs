namespace Oblikovati.API;

/// <summary>
/// The Layer object represents a layer in a drawing document.
/// </summary>
public interface Layer
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
    /// Property that gets and sets whether the layer is turned on or off.
    /// </summary>
    bool Visible { get; set; }
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
    StyleLocationEnum _StyleLocation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _InUse { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpToDate { get; }
    /// <summary>
    /// Property that gets and sets the color used for the layer.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Property that gets and sets the line type override. Setting the property to kDefaultLineType restores the default line type. If the property returns kCustomLineType, the GetCustomLineType method can be used to get further details about the line type.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Property that gets and sets the thickness of this primitive/object. If LineDefinitionSpace is set to kScreenSpace, this value is defined in pixels. If LineDefinitionSpace is set to kModelSpace, this value is defined in model units (centimeters).
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Property that gets and sets whether to scale the line type based on the line weight value.
    /// </summary>
    bool ScaleByLineWeight { get; set; }
    /// <summary>
    /// Property that gets and sets whether to use the default color for the layer. This property can only be set to True. Setting the Color property automatically sets this property to False.
    /// </summary>
    bool AutomaticColor { get; set; }
    /// <summary>
    /// Property that gets and sets whether this layer is plotted. If set to False, the layer continues to display in the drawing but will neither get printed nor published.
    /// </summary>
    bool Plot { get; set; }
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
    /// Method that sets a custom line type to the entity from the specified .lin file. The method automatically changes the value of the LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">The full path and file name of the .lin file.</param>
    /// <param name="LineTypeName">The linetype name specified in the .lin file.</param>
    /// <param name="ReplaceExisting">Indicates whether to override an existing line type of the same name.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NewName">NewName</param>
    [PreserveSig]
    Layer _Copy([In] [MarshalAs(UnmanagedType.BStr)] string NewName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    Layer _ConvertToLocal();
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
}
