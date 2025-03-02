namespace Oblikovati.API;

/// <summary>
/// The SurfaceTextureStyle object represents a surface texture style in a drawing.
/// </summary>
public interface SurfaceTextureStyle
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
    /// Gets and sets a bit mask defining the machining lay symbols to be made available for surface texture symbol creation.
    /// </summary>
    LayDirectionTypeEnum AvailableLaySymbols { get; set; }
    /// <summary>
    /// Gets and sets the majority type of this style.
    /// </summary>
    MajorityTypeEnum MajorityType { get; set; }
    /// <summary>
    /// Gets and sets the leader style used for a surface texture symbol.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used to format the text in a surface texture symbol.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Gets and sets whether to use a large or small maching-prohibited symbol. If the property is set to True, the symbol with the smaller diameter is used.
    /// </summary>
    bool MachiningProhibitedSymbolSizeSmall { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DraftingStandardEnum StandardReference { get; set; }
    /// <summary>
    /// Gets and sets a bit mask defining the profile direction symbols to be made available for surface texture symbol creation.
    /// </summary>
    ProfileDirectionTypeEnum AvailableProfileDirectionSymbols { get; set; }
    /// <summary>
    /// Gets and sets whether to enable the all-around indicator to the symbol.
    /// </summary>
    bool EnableAllAroundSymbol { get; set; }
    /// <summary>
    /// Gets and sets the drafting standard that controls surface texture symbol format.
    /// </summary>
    SurfaceTextureStandardReferenceTypeEnum StandardReferenceType { get; set; }
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
}
