namespace Oblikovati.API;

/// <summary>
/// The Balloon object provides the ability to access existing balloons.
/// </summary>
public interface Balloon
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
    /// Property returning the parent sheet (the sheet object this balloon is associated with).
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// This property gets the collection of objects. See the BalloonValueSets and BalloonValueSet objects for more information.
    /// </summary>
    BalloonValueSets BalloonValueSets { get; }
    /// <summary>
    /// Property that returns the parent DrawingView object. In other words, the sheet contains a view with which this balloon is associated.
    /// </summary>
    DrawingView ParentView { get; }
    /// <summary>
    /// Gets and sets the position of the balloon on the Sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets and sets the direction in which to place attached balloons.
    /// </summary>
    BalloonDirectionEnum PlacementDirection { get; set; }
    /// <summary>
    /// Gets and sets the layer applied to this balloons.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the associated BalloonStyle object.
    /// </summary>
    BalloonStyle Style { get; set; }
    /// <summary>
    /// Property that returns whether the balloon is attached to a component.
    /// </summary>
    bool Attached { get; }
    /// <summary>
    /// Property that returns the leader associated with the balloon.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method to delete this Balloon.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BalloonType">BalloonType</param>
    /// <param name="BalloonTypeData">BalloonTypeData</param>
    [PreserveSig]
    void GetBalloonType([Out] out BalloonTypeEnum BalloonType, [Out] [MarshalAs(UnmanagedType.Struct)] out object BalloonTypeData);
    /// <summary>
    /// Method that sets the balloon type.
    /// </summary>
    /// <param name="BalloonType">Constant that indicates the balloon type. Valid types are kCircularWithOneEntryBalloonType, kCircularWithTwoEntriesBalloonType, kHexagonBalloonType, kLinearBalloonType, kNoneBalloonType and kSketchedSymbolBalloonType. Setting the type to kNoneBalloonType specifies that all the properties chosen in the style will be displayed.</param>
    /// <param name="BalloonTypeData">Optional input data associated with certain balloon types. If the balloon type is kSketchedSymbolBalloonType, this argument requires a SketchedSymbolDefinition object. Else, this argument is ignored.</param>
    [PreserveSig]
    void SetBalloonType([In] BalloonTypeEnum BalloonType, [In] [MarshalAs(UnmanagedType.Struct)] object? BalloonTypeData = default);
    /// <summary>
    /// Method that saves any overrides to the item values in the balloon to the model BOM. Only the overrides applies to the BallonValueSet.Value property are saved. The value of the OverrideValue property is ignored.
    /// </summary>
    [PreserveSig]
    void SaveItemOverridesToBOM();
    /// <summary>
    /// Method that sorts the balloon value sets.
    /// </summary>
    [PreserveSig]
    void SortValueSets();
}
