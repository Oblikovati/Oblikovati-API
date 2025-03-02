namespace Oblikovati.API;

/// <summary>
/// UnitsFormatting Object.
/// </summary>
public interface UnitsFormatting
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
    /// Gets and sets the decimal marker type.
    /// </summary>
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets the display format.
    /// </summary>
    DisplayFormatEnum DisplayFormat { get; set; }
    /// <summary>
    /// Gets and sets the display format.
    /// </summary>
    double FractionalTextScale { get; set; }
    /// <summary>
    /// Gets and sets the precision.
    /// </summary>
    CustomPropertyPrecisionEnum Precision { get; set; }
    /// <summary>
    /// Gets and sets whether to show the unit string or not.
    /// </summary>
    bool ShowUnitString { get; set; }
    /// <summary>
    /// Gets and sets the units.
    /// </summary>
    UnitsTypeEnum Units { get; set; }
    /// <summary>
    /// Gets and sets the value units type.
    /// </summary>
    ValueUnitsTypeEnum UnitType { get; set; }
}
