namespace Oblikovati.API;

/// <summary>
/// The Tolerance object represents information about tolerance.
/// </summary>
public interface Tolerance
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns a constant specifying the tolerance type.
    /// </summary>
    ToleranceTypeEnum ToleranceType { get; }
    /// <summary>
    /// Property that returns a constant specifying the upper variation from the nominal value in database units.
    /// </summary>
    double Upper { get; }
    /// <summary>
    /// Property that returns the lower variation from the nominal value in database units.
    /// </summary>
    double Lower { get; }
    /// <summary>
    /// Property that returns a string specifying the hole tolerance.
    /// </summary>
    string HoleTolerance { get; }
    /// <summary>
    /// Property that returns the shaft tolerance.
    /// </summary>
    string ShaftTolerance { get; }
    /// <summary>
    /// Method that sets the tolerance to the default value.
    /// </summary>
    [PreserveSig]
    void SetToDefault();
    /// <summary>
    /// Method that sets the type of this tolerance to be a deviation tolerance.
    /// </summary>
    /// <param name="UpperTolerance">Input Variant that defines the upper limit of the deviation.</param>
    /// <param name="LowerTolerance">Input Variant that defines the lower limit of the deviation.</param>
    [PreserveSig]
    void SetToDeviation([In] [MarshalAs(UnmanagedType.Struct)] object UpperTolerance, [In] [MarshalAs(UnmanagedType.Struct)] object LowerTolerance);
    /// <summary>
    /// Method that sets the type of this tolerance to be a fits tolerance.
    /// </summary>
    /// <param name="FitsToleranceType">Input constant that specifies the type of tolerance.</param>
    /// <param name="HoleTolerance">Input String that specifies the tolerance for the hole feature.</param>
    /// <param name="ShaftTolerance">Input String that specifies the tolerance for the shaft.</param>
    [PreserveSig]
    void SetToFits([In] ToleranceTypeEnum FitsToleranceType, [In] [MarshalAs(UnmanagedType.BStr)] string HoleTolerance, [In] [MarshalAs(UnmanagedType.BStr)] string ShaftTolerance);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="UpperTolerance">UpperTolerance</param>
    /// <param name="LowerTolerance">LowerTolerance</param>
    [PreserveSig]
    void _SetToLimits([In] [MarshalAs(UnmanagedType.Struct)] object UpperTolerance, [In] [MarshalAs(UnmanagedType.Struct)] object LowerTolerance);
    /// <summary>
    /// Method that sets the type of this tolerance to be a limits tolerance.
    /// </summary>
    /// <param name="LimitsToleranceType">constant Indicates the type of limits tolerance.</param>
    /// <param name="UpperTolerance">Input Variant that defines the upper limit of the tolerance.</param>
    /// <param name="LowerTolerance">Input Variant that defines the lower limit of the tolerance.</param>
    [PreserveSig]
    void SetToLimits([In] ToleranceTypeEnum LimitsToleranceType, [In] [MarshalAs(UnmanagedType.Struct)] object UpperTolerance, [In] [MarshalAs(UnmanagedType.Struct)] object LowerTolerance);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MinMaxToleranceType">MinMaxToleranceType</param>
    /// <param name="DeviationValue">DeviationValue</param>
    [PreserveSig]
    void SetToMinMax([In] ToleranceTypeEnum MinMaxToleranceType, [In] [MarshalAs(UnmanagedType.Struct)] object? DeviationValue = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FitsToleranceType">FitsToleranceType</param>
    /// <param name="HoleOrShaftTolerance">HoleOrShaftTolerance</param>
    [PreserveSig]
    void SetToShowFits([In] ToleranceTypeEnum FitsToleranceType, [In] [MarshalAs(UnmanagedType.BStr)] string HoleOrShaftTolerance);
    /// <summary>
    /// Method that sets the type of this tolerance to be a symmetric tolerance.
    /// </summary>
    /// <param name="Tolerance">Input Variant that specifies the tolerance.</param>
    [PreserveSig]
    void SetToSymmetric([In] [MarshalAs(UnmanagedType.Struct)] object Tolerance);
    /// <summary>
    /// Sets the type of this tolerance to be a MIN type of tolerance.
    /// </summary>
    [PreserveSig]
    void SetToMin();
    /// <summary>
    /// Sets the type of this tolerance to be a MAX type of tolerance.
    /// </summary>
    [PreserveSig]
    void SetToMax();
    /// <summary>
    /// Sets the type of this tolerance to be a basic type of tolerance (only valid for drawing dimensions).
    /// </summary>
    [PreserveSig]
    void SetToBasic();
    /// <summary>
    /// Sets the type of this tolerance to be a reference type of tolerance (only valid for drawing dimensions).
    /// </summary>
    [PreserveSig]
    void SetToReference();
}
