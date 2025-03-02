namespace Oblikovati.API;

/// <summary>
/// The SketchedSymbol object represents the instance of a SketchedSymbolDefinition on a sheet. See the article in the overviews section.
/// </summary>
public interface SketchedSymbol
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
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property returning the sketched symbol definition object referenced by the sketched symbol.
    /// </summary>
    SketchedSymbolDefinition Definition { get; }
    /// <summary>
    /// Gets and sets the origin position of the symbol on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that provides the transform that is applied to display the associated sketched symbol definition in the correct location on the sheet. The matrix defines the sheet to sketched symbol transform.
    /// </summary>
    Matrix2d Transformation { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the layer associated with the sketched symbol.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the scale of the symbol.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Gets and sets the rotation angle of the symbol in radians.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Property that gets whether this sketched symbol is a callout symbol.
    /// </summary>
    bool Callout { get; }
    /// <summary>
    /// Property that returns the Leader object.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Gets and sets whether the leader of the SketchedSymbol is visible.
    /// </summary>
    bool LeaderVisible { get; set; }
    /// <summary>
    /// Gets and sets whether to show the scale and rotation grip points on the SketchedSymbol.
    /// </summary>
    bool Static { get; set; }
    /// <summary>
    /// Gets and sets whether to trim annotations applied to the SketchedSymbol.
    /// </summary>
    bool SymbolClipping { get; set; }
    /// <summary>
    /// Gets and sets the name of the sketched symbol instance.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets whether the symbol's leader should be clipped where it overlaps the symbol.
    /// </summary>
    bool LeaderClipping { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryIntent _AttachedEntity { get; set; }
    /// <summary>
    /// Gets and sets the color for the symbol.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets the line weight override for the symbol.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the line type override for the symbol.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Property that gets and sets the associated leader style.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Method that deletes the sketched symbol (e.g. the title block) from the sheet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns the text that is currently displayed for a specific text box. This is useful for text boxes that use input form other sources to define their content, i.e. properties and prompted text. The string displayed within this text box is returned.
    /// </summary>
    /// <param name="DefinitionText">Input TextBox object from the referenced TitleBlockDefinition object. This text box is used to specify which prompted text box to set the text for.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText);
    /// <summary>
    /// Method that sets the text that was supplied for a specified sketched symbol that contains prompted text. The string displayed within this symbol is changed.
    /// </summary>
    /// <param name="DefinitionText">Input TextBox object from the referenced sketched symbol object. This text box is used to specify which prompted text box to set the text for.</param>
    /// <param name="NewValue">Input String that defines the new text to use for the specified prompted text.</param>
    [PreserveSig]
    void SetPromptResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText, [In] [MarshalAs(UnmanagedType.BStr)] string NewValue);
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
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
