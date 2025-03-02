namespace Oblikovati.API;

/// <summary>
/// The SheetMetalStyle object contains all of the information about a particular sheet metal style (these are also referred to as sheet metal rules).
/// </summary>
public interface SheetMetalStyle
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
    /// Gets and sets the expression that defines the value of the bend radius depth.
    /// </summary>
    string BendRadius { get; set; }
    /// <summary>
    /// Gets/Sets BendReliefShape.
    /// </summary>
    BendReliefShapeEnum BendReliefShape { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the corner relief size radius.
    /// </summary>
    string MinimumRemnant { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the bend relief width.
    /// </summary>
    string BendReliefWidth { get; set; }
    /// <summary>
    /// Gets/Sets BendTransition.
    /// </summary>
    BendTransitionEnum BendTransition { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the bend relief depth.
    /// </summary>
    string BendReliefDepth { get; set; }
    /// <summary>
    /// Gets CornerReliefSize.
    /// </summary>
    string CornerReliefSize { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the corner relief size radius.
    /// </summary>
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    /// <summary>
    /// Gets and sets the default punch representation type.
    /// </summary>
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the bend relief arc radius.
    /// </summary>
    string BendTransitionArcRadius { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the corner relief size radius.
    /// </summary>
    CornerReliefShapeEnum ThreeBendCornerReliefShape { get; set; }
    /// <summary>
    /// Get the parameter that defines the three bend corner relief size for this style.
    /// </summary>
    string ThreeBendCornerReliefSize { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Material Material { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the expression that defines the value of the thickness.
    /// </summary>
    string Thickness { get; set; }
    /// <summary>
    /// Read-write property that gets and set the unfold method associated with the style.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Gets and sets which angle is to be reported in the flat pattern.
    /// </summary>
    BendAngleTypeEnum BendAngleReportType { get; set; }
    /// <summary>
    /// Gets and sets the expression that defines the value of the gap size for miters, seams, and rips.
    /// </summary>
    string GapSize { get; set; }
    /// <summary>
    /// Gets and sets corner relief placement (valid only for square and round corners).
    /// </summary>
    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
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
    /// Method that causes this sheet metal style to become the active sheet metal style for this document.
    /// </summary>
    [PreserveSig]
    void Activate();
}
