namespace Oblikovati.API;

/// <summary>
/// The OrdinateDimension object represents an ordinate dimension placed on a sheet. The properties and methods listed below are in addition to those supported by the DrawingDimension object.
/// </summary>
public interface OrdinateDimension
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
    /// Property that returns the dimension type.
    /// </summary>
    DimensionTypeEnum DimensionType { get; }
    /// <summary>
    /// Read-write property that gets and sets the geometry associated with the dimension.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the first jog point for the ordinate dimension.
    /// </summary>
    Point2d JogPointOne { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the second jog point for the ordinate dimension.
    /// </summary>
    Point2d JogPointTwo { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the dimension style used for this dimension.
    /// </summary>
    DimensionStyle Style { get; set; }
    /// <summary>
    /// Property that returns the OrdinateDimensionSet that owns this dimension. This property returns nothing if this dimension is not an ordinate dimension set member. This can be checked using the IsOrdinateSetMember property.
    /// </summary>
    OrdinateDimensionSet OrdinateDimensionSet { get; }
    /// <summary>
    /// Property that returns whether this dimension is a member of an ordinate dimension set. If this property returns True, the OrdinateDimensionSet object is returned by the OrdinateDimensionSet property.
    /// </summary>
    bool IsOrdinateSetMember { get; }
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
}
