namespace Oblikovati.API;

/// <summary>
/// UnitAttributes Object.
/// </summary>
public interface UnitAttributes
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the alternate units of length measurement.
    /// </summary>
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    /// <summary>
    /// Gets and sets the character to be used as decimal marker for alternate values.
    /// </summary>
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets whether display the alternate unit type.
    /// </summary>
    bool AlternateUnitTypeDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether display the leading zeros for alternate values.
    /// </summary>
    bool AlternateLeadingZerosDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether display the trailing zeros for alternate values.
    /// </summary>
    bool AlternateTrailingZerosDisplay { get; set; }
    /// <summary>
    /// Gets and sets the linear precision for alternate units.
    /// </summary>
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    /// <summary>
    /// Gets and sets whether use the standards notation.
    /// </summary>
    bool UseStandardsNotation { get; set; }
    /// <summary>
    /// Gets and sets the primary units of length measurement.
    /// </summary>
    UnitsTypeEnum PrimaryLinearUnits { get; set; }
    /// <summary>
    /// Gets and sets the character to be used as decimal marker for primary values.
    /// </summary>
    DecimalMarkerTypeEnum PrimaryDecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets whether display the primary unit type.
    /// </summary>
    bool PrimaryUnitTypeDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether display the leading zeros for primary values.
    /// </summary>
    bool PrimaryLeadingZerosDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether display the trailing zeros for primary values.
    /// </summary>
    bool PrimaryTrailingZerosDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the alternate units.
    /// </summary>
    bool AlternateUnitsDisplay { get; set; }
    /// <summary>
    /// Gets and sets the display style for alternate units.
    /// </summary>
    DimensionStyleFormatEnum DisplayStyleProp { get; set; }
}
