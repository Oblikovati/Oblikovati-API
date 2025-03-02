namespace Oblikovati.API;

/// <summary>
/// Object provides access to all rows of a feature control frame in a part or assembly.
/// </summary>
public interface ModelFeatureControlFrameRows : IEnumerable
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ModelFeatureControlFrameRow this[int Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a row to the feature control frame.
    /// </summary>
    /// <param name="GeometricCharacteristic">Input GeometricCharacteristicEnum that specifies the geometric characteristic symbol for the row.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance associated with this geometric characteristic.  For length values the units for the value is always centimeters and for angles the value is always radians.  The actual displayed value will use the units and precision specified by the style.</param>
    /// <param name="ToleranceModifierPrefix">Optional input GDTSymbolEnum that specifies a symbol to use as a prefix for the tolerance. For example, the n symbol is used when the tolerance zone is cylindrical.</param>
    /// <param name="ToleranceMaterialCondition">Optional input GDTSymbolEnum that specifies a symbol to use as material condition for the tolerance. For example, the m symbol is used to specify maximum material condition. Valid values for this argument are kGDTNoSymbol, kGDTMaximumMaterialCondition and kGDTLeastMaterialCondition.</param>
    /// <param name="PrimaryDatumIdentifier">Optional input ModelDatumIdentifier object that specifies the primary datum reference. If the geometric characteristic is kStraightness, kFlatness, kCircularity, or kCylindricity no datum identifiers are needed and the datum arguments will be ignored.</param>
    /// <param name="PrimaryDatumModifier">Optional input GDTSymbolEnum enum value that specifies the material condition symbol to append to the primary datum. For example, the m symbol is used to specify maximum material condition. The PrimaryDatumIdentifier argument must be specified for this argument to be used.</param>
    /// <param name="SecondaryDatumIdentifier">Optional input ModelDatumIdentifier object that specifies the secondary datum reference. The first datum identifier must be specified before the secondary will be used.</param>
    /// <param name="SecondaryDatumModifier">Optional input GDTSymbolEnum enum value that specifies the material condition symbol to append to the secondary datum. For example, the m symbol is used to specify maximum material condition. The SecondaryDatumIdentifier argument must be specified for this argument to be used.</param>
    /// <param name="TertiaryDatumIdentifier">Optional input ModelDatumIdentifier object that specifies the tertiary datum reference.  The first and second datum identifiers must be specified before the tertiary will be used.</param>
    /// <param name="TertiaryDatumModifier">Optional input GDTSymbolEnum enum value that specifies the material condition symbol to append to the tertiary datum. For example, the m symbol is used to specify maximum material condition. The TertiaryDatumIdentifier argument must be specified for this argument to be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelFeatureControlFrameRow Add([In] GeometricCharacteristicEnum GeometricCharacteristic, [In] double Tolerance, [In] GDTSymbolEnum? ToleranceModifierPrefix = GDTSymbolEnum.kGDTNoSymbol, [In] GDTSymbolEnum? ToleranceMaterialCondition = GDTSymbolEnum.kGDTNoSymbol, [In] [MarshalAs(UnmanagedType.Struct)] object? PrimaryDatumIdentifier = default, [In] GDTSymbolEnum? PrimaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol, [In] [MarshalAs(UnmanagedType.Struct)] object? SecondaryDatumIdentifier = default, [In] GDTSymbolEnum? SecondaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol, [In] [MarshalAs(UnmanagedType.Struct)] object? TertiaryDatumIdentifier = default, [In] GDTSymbolEnum? TertiaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="GeometricCharacteristic">GeometricCharacteristic</param>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="ToleranceModifierPrefix">ToleranceModifierPrefix</param>
    /// <param name="ToleranceMaterialCondition">ToleranceMaterialCondition</param>
    /// <param name="DatumReferenceFrame">DatumReferenceFrame</param>
    [PreserveSig]
    ModelFeatureControlFrameRow Add2([In] GeometricCharacteristicEnum GeometricCharacteristic, [In] double Tolerance, [In] GDTSymbolEnum? ToleranceModifierPrefix = GDTSymbolEnum.kGDTNoSymbol, [In] GDTSymbolEnum? ToleranceMaterialCondition = GDTSymbolEnum.kGDTNoSymbol, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumReferenceFrame = default);
}
