namespace Oblikovati.API;

/// <summary>
/// The HoleThreadNote object represents either a hole note or a thread note on a sheet and derives from the DiameterGeneralDimension object.
/// </summary>
public interface HoleThreadNote
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
    /// Property that returns the parent sheet of the object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the HideValue setting.
    /// </summary>
    bool HideValue { get; set; }
    /// <summary>
    /// Property that gets the dimension value as defined in the model or as measured in the drawing.
    /// </summary>
    double ModelValue { get; }
    /// <summary>
    /// Gets and sets the NominalValue setting.
    /// </summary>
    double OverrideModelValue { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the model value is overridden for the dimension.
    /// </summary>
    bool ModelValueOverridden { get; set; }
    /// <summary>
    /// Gets and sets the Precision setting.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Gets and sets the DimensionText setting.
    /// </summary>
    DimensionText Text { get; set; }
    /// <summary>
    /// Property that returns the Tolerance object associated with this dimension.
    /// </summary>
    Tolerance Tolerance { get; }
    /// <summary>
    /// Gets and sets the layer applied to this dimension.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Indicates whether this dimension is attached to anything. If not, it is considered orphaned and can be removed.
    /// </summary>
    bool Attached { get; }
    /// <summary>
    /// Gets and sets the precision of the tolerance text for the dimension.
    /// </summary>
    int TolerancePrecision { get; set; }
    /// <summary>
    /// Property that returns the dimension line geometry of the dimension.
    /// </summary>
    object DimensionLine { get; }
    /// <summary>
    /// Gets and sets whether this is an inspection dimension.
    /// </summary>
    bool IsInspectionDimension { get; set; }
    /// <summary>
    /// Gets and sets the ArrowheadsInside setting.
    /// </summary>
    bool ArrowheadsInside { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the first arrowhead is inside or outside.
    /// </summary>
    bool FirstArrowheadInside { get; set; }
    /// <summary>
    /// Property that indicates whether the dimension was created as a result of retrieving it either from the model or a drawing view sketch. If True, the RetrievedFrom property returns the object that the dimension was retrieved from.
    /// </summary>
    bool Retrieved { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the second arrowhead is inside or outside.
    /// </summary>
    bool SecondArrowheadInside { get; set; }
    /// <summary>
    /// Gets and sets the DimensionStyle associated with the dimension.
    /// </summary>
    DimensionStyle Style { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ShowLeader { get; }
    /// <summary>
    /// Property that returns the object that this dimension was retrieved from. Possible return objects include all sketch constraint objects that derive from DimensionConstraint and their proxies, FeatureDimension and FeatureDimensionProxy. The property returns Nothing if the Retrieved property returns False.
    /// </summary>
    object RetrievedFrom { get; }
    /// <summary>
    /// Returns an enum indicating the type of general dimension.
    /// </summary>
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    /// <summary>
    /// Read-write property that gets and sets the type of the first arrowhead.
    /// </summary>
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of the second arrowhead.
    /// </summary>
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    /// <summary>
    /// Gets and sets the geometry associated with the dimension.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Gets and sets whether the leader starts from the center of the arc or the circle.
    /// </summary>
    bool LeaderFromCenter { get; set; }
    /// <summary>
    /// Gets and sets whether to use a single dimension line.
    /// </summary>
    bool SingleDimensionLine { get; set; }
    /// <summary>
    /// Property that returns the first extension line of the dimension.
    /// </summary>
    object ExtensionLineOne { get; }
    /// <summary>
    /// Property that returns the second extension line of the dimension.
    /// </summary>
    object ExtensionLineTwo { get; }
    /// <summary>
    /// Gets and sets the hole/thread edge associated with the note.
    /// </summary>
    object Edge { get; set; }
    /// <summary>
    /// Gets and sets the fully formatted string that defines the contents of the hole/thread note.
    /// </summary>
    string FormattedHoleThreadNote { get; set; }
    /// <summary>
    /// Gets and sets the fully formatted string that defines the quantity note.
    /// </summary>
    string FormattedQuantityNote { get; set; }
    /// <summary>
    /// Property that indicates if this note is for a hole or thread feature. Returns True if it is for a hole note. This is true even in the case where the hole is tapped and has threads. Returns False in the case where the note is for a thread feature. There is some difference in behavior between the two and this property provides a convenient way to determine the expected behavior.
    /// </summary>
    bool IsHoleNote { get; }
    /// <summary>
    /// Gets and sets how the quantity value is set for the note.
    /// </summary>
    HoleNoteQuantityEnum QuantityDefinition { get; set; }
    /// <summary>
    /// Gets and sets whether to set the hole note as tap drill type.
    /// </summary>
    bool TapDrill { get; set; }
    /// <summary>
    /// Gets and sets whether to use the custom thread designation, as defined in the Thread.xls spreadsheet for thread notes.
    /// </summary>
    bool UseCustomThreadDesignation { get; set; }
    /// <summary>
    /// Gets and sets whether to use the default format for hole notes.
    /// </summary>
    bool UseDefaultFormat { get; set; }
    /// <summary>
    /// Gets and sets whether to use model units or the units specified by dimension style.
    /// </summary>
    bool UsePartUnits { get; set; }
    /// <summary>
    /// Gets and sets whether to show RH for right handed thread.
    /// </summary>
    bool RightHandedThread { get; set; }
    /// <summary>
    /// Method that deletes the DrawingDimension.
    /// </summary>
    [PreserveSig]
    void Delete();
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
    /// <param name="Shape">Shape</param>
    /// <param name="Label">Label</param>
    /// <param name="Rate">Rate</param>
    [PreserveSig]
    void GetInspectionDimensionData([Out] out InspectionDimensionShapeEnum Shape, [Out] [MarshalAs(UnmanagedType.BStr)] out string Label, [Out] [MarshalAs(UnmanagedType.BStr)] out string Rate);
    /// <summary>
    /// Method that sets the data associated with an inspection dimension. This method automatically sets the IsInspectionDimension property to True, if it isn't already.
    /// </summary>
    /// <param name="Shape">Optional input InspectionDimensionShapeEnum that specifies the border shape surrounding the inspection dimension text. Valid values are kNoInspectionBorder, kAngularEndsInspectionBorder and kRoundedEndsInspectionBorder. If not specified, kNoInspectionBorder is used.</param>
    /// <param name="Label">Optional input string that specifies the text placed left of the dimension value. The string can contain symbols specified using the StyleOverride tag.</param>
    /// <param name="Rate">Optional input string that specifies the text (typically a percentage value) placed to the right of the dimension value. The string can contain symbols specified using the StyleOverride tag.</param>
    [PreserveSig]
    void SetInspectionDimensionData([In] InspectionDimensionShapeEnum? Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, [In] [MarshalAs(UnmanagedType.BStr)] string? Label = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Rate = "");
    /// <summary>
    /// Method that copies the dimension to the underlying sketch. This method only works for dimensions associated with a draft view.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DimensionConstraint PromoteToSketch();
    /// <summary>
    /// Method that un-hides all the extension lines associated with this dimension. If there are no hidden extension lines associated with this dimension, this method does nothing and returns a success.
    /// </summary>
    [PreserveSig]
    void ShowAllExtensionLines();
}
