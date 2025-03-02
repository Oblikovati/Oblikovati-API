namespace Oblikovati.API;

/// <summary>
/// The BalloonStyle object represents a balloon style in a drawing. The properties and methods listed below are in addition to those supported by the Style object.
/// </summary>
public interface BalloonStyle
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
    /// Property that gets and sets the leader style used for a balloon.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Property that gets and sets the alternate leader style used for the balloon style. Alternate leader style is used when a balloon termination is dragged away from its associative edge.
    /// </summary>
    LeaderStyle AlternateLeaderStyle { get; set; }
    /// <summary>
    /// Property that gets and sets the text style used to format the text in a balloon.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Property that gets and sets the default distance between balloons when they are aligned. Changing this value has no effect on previously created balloons.
    /// </summary>
    double DefaultOffset { get; set; }
    /// <summary>
    /// Property that gets and sets the shape of the balloon. Valid types are kCircularWithOneEntryBalloonType, kCircularWithTwoEntriesBalloonType, kHexagonBalloonType, kLinearBalloonType and kNoneBalloonType.
    /// </summary>
    BalloonTypeEnum BalloonType { get; set; }
    /// <summary>
    /// Property that gets and sets the properties to display in the balloon. The number of properties displayed depends on the balloon shape.
    /// </summary>
    string Properties { get; set; }
    /// <summary>
    /// Property that gets and sets whether to define the balloon size by text height. This property is not applicable if the balloon type is kNoneBalloonType or kLinearBalloonType.
    /// </summary>
    bool ScaleToTextHeight { get; set; }
    /// <summary>
    /// Property that gets and sets the balloon diameter. This value is used only if the ScaleToTextHeight property is set to False. This property is not applicable if the balloon type is kNoneBalloonType or kLinearBalloonType.
    /// </summary>
    double BalloonDiameter { get; set; }
    /// <summary>
    /// Property that gets and sets whether to size the balloon horizontally to accommodate long text strings. If set to False, the balloon is restricted to the defined size. This property is not applicable if the balloon type is kNoneBalloonType or kLinearBalloonType.
    /// </summary>
    bool StretchBalloonToText { get; set; }
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
