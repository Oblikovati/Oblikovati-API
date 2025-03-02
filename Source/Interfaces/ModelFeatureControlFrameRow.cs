namespace Oblikovati.API;

/// <summary>
/// Object represents a row within a feature control frame symbol.
/// </summary>
public interface ModelFeatureControlFrameRow
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelFeatureControlFrameDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the geometric characteristic symbol for the row.
    /// </summary>
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    /// <summary>
    /// Gets and sets the tolerance associated with this geometric characteristic. The value can be either in centimeters or radians depending on if the geometric characteristic defines a length or angle.
    /// </summary>
    double Tolerance { get; set; }
    /// <summary>
    /// Gets and sets the primary datum.
    /// </summary>
    ModelDatumIdentifier PrimaryDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the the material condition symbol to append to the primary datum.
    /// </summary>
    GDTSymbolEnum PrimaryDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the secondary datum.
    /// </summary>
    ModelDatumIdentifier SecondaryDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the material condition symbol to append to the secondary datum.
    /// </summary>
    GDTSymbolEnum SecondaryDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the tertiary datum.
    /// </summary>
    ModelDatumIdentifier TertiaryDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the material condition symbol to append to the tertiary datum.
    /// </summary>
    GDTSymbolEnum TertiaryDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the symbol to use as a prefix for the tolerance.
    /// </summary>
    GDTSymbolEnum ToleranceModifierPrefix { get; set; }
    /// <summary>
    /// Gets and sets the symbol to use as tolerance material condition. Valid values are kGDTNoSymbol, kGDTMaximumMaterialCondition and kGDTLeastMaterialCondition.
    /// </summary>
    GDTSymbolEnum ToleranceMaterialCondition { get; set; }
    /// <summary>
    /// Gets and sets whether to display the tangent plane modifier or not.
    /// </summary>
    bool DisplayTangentPlaneModifier { get; set; }
    /// <summary>
    /// Gets and sets whether to display the free state modifier or not.
    /// </summary>
    bool DisplayFreeStateModifier { get; set; }
    /// <summary>
    /// Gets and sets whether to display the statistical modifier or not.
    /// </summary>
    bool DisplayStatisticalModifier { get; set; }
    /// <summary>
    /// Gets and sets whether to display the projected tolerance zone modifier or not.
    /// </summary>
    bool DisplayProjectedToleranceZoneModifier { get; set; }
    /// <summary>
    /// Gets and sets whether to display the unequally disposed modifier or not.
    /// </summary>
    bool DisplayUnequallyDisposedModifier { get; set; }
    /// <summary>
    /// Gets and sets the value for the projected tolerance zone modifier.
    /// </summary>
    double ProjectedToleranceZoneValue { get; set; }
    /// <summary>
    /// Gets and sets the value for the unequally disposed modifier.
    /// </summary>
    double UnequallyDisposedValue { get; set; }
    /// <summary>
    /// Gets and sets the primary comopund datum.
    /// </summary>
    ModelDatumIdentifier PrimaryCompoundDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the primary compound datum modifier.
    /// </summary>
    GDTSymbolEnum PrimaryCompoundDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the secondary compound datum.
    /// </summary>
    ModelDatumIdentifier SecondaryCompoundDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the secondary compound datum modifier.
    /// </summary>
    GDTSymbolEnum SecondaryCompoundDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the tertiary compound datum.
    /// </summary>
    ModelDatumIdentifier TertiaryCompoundDatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets the tertiary compound datum modifier.
    /// </summary>
    GDTSymbolEnum TertiaryCompoundDatumModifier { get; set; }
    /// <summary>
    /// Gets and sets the flag whether this FCF represents general surface profile tolerance.
    /// </summary>
    bool GeneralProfileOfSurfaceModifier { get; set; }
    /// <summary>
    /// Gets and sets the tolerance precision associated with this geometric characteristic. The value is a short integer.
    /// </summary>
    short TolerancePrecision { get; set; }
    /// <summary>
    /// Gets and sets the Projected Tolerance Zone precision associated with this geometric characteristic. The value is a short integer.
    /// </summary>
    short ProjectedToleranceZonePrecision { get; set; }
    /// <summary>
    /// Gets and sets the Unequally Disposed precision associated with this geometric characteristic. The value is a short integer.
    /// </summary>
    short UnequallyDisposedPrecision { get; set; }
    /// <summary>
    /// Gets the internal name (GUID) of the model feature control frame row.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumReferenceFrame DatumReferenceFrame { get; set; }
    /// <summary>
    /// Gets and sets whether to display the common zone modifier or not.
    /// </summary>
    bool DisplayCommonZoneModifier { get; set; }
    /// <summary>
    /// Method that deletes the row of the feature control frame, If this is not the last row of the feature control frame, all the rows below this row are also deleted.&nbsp;The first row of the symbol cannot be deleted, so this method will return an error.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="InternalName">InternalName</param>
    [PreserveSig]
    void GenerateInternalName([In] [MarshalAs(UnmanagedType.Struct)] object Context, [In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default);
}
