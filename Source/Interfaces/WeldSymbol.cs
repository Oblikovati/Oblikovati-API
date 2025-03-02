namespace Oblikovati.API;

/// <summary>
/// WeldSymbol Object.
/// </summary>
public interface WeldSymbol
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
    object Parent { get; }
    /// <summary>
    /// Gets and sets the weld symbol type. This can be a value of WeldSymbolTypeEnum&nbsp;or BackingSymbolTypeEnum.
    /// </summary>
    int WeldSymbolType { get; set; }
    /// <summary>
    /// Gets and sets the prefix to precede the symbol.
    /// </summary>
    string Prefix { get; set; }
    /// <summary>
    /// Gets and sets the angle between weldments.
    /// </summary>
    string Angle { get; set; }
    /// <summary>
    /// Gets and sets the hole countersink angle of the plug weld.
    /// </summary>
    string CountersinkAngle { get; set; }
    /// <summary>
    /// Gets and sets the diameter of the weld.
    /// </summary>
    string Diameter { get; set; }
    /// <summary>
    /// Gets and sets the depth of the weld.
    /// </summary>
    string Depth { get; set; }
    /// <summary>
    /// Gets and sets the either side of the weld.
    /// </summary>
    string EitherSide { get; set; }
    /// <summary>
    /// Gets and sets the hole filling depth of the plug weld.
    /// </summary>
    string FillingDepth { get; set; }
    /// <summary>
    /// Gets and sets the space between weldments.
    /// </summary>
    string Gap { get; set; }
    /// <summary>
    /// Gets and sets the height of the weld.
    /// </summary>
    string Height { get; set; }
    /// <summary>
    /// Gets and sets the groove included angle of the butt weld.
    /// </summary>
    string IncludedAngle { get; set; }
    /// <summary>
    /// Gets and sets the text for leg1.
    /// </summary>
    string Leg1 { get; set; }
    /// <summary>
    /// Gets and sets the text for leg2.
    /// </summary>
    string Leg2 { get; set; }
    /// <summary>
    /// Gets and sets the length of the weld.
    /// </summary>
    string Length { get; set; }
    /// <summary>
    /// Gets and sets the number of welds.
    /// </summary>
    string Number { get; set; }
    /// <summary>
    /// Gets and sets the penetration depth of the weld.
    /// </summary>
    string PenetrationDepth { get; set; }
    /// <summary>
    /// Gets and sets the preparation depth of the butt weld.
    /// </summary>
    string PreparationDepth { get; set; }
    /// <summary>
    /// Gets and sets the distance between welds.
    /// </summary>
    string Pitch { get; set; }
    /// <summary>
    /// Gets and sets the root thickness of the weld.
    /// </summary>
    string Root { get; set; }
    /// <summary>
    /// Gets and sets the gap for the weld.
    /// </summary>
    string RootGap { get; set; }
    /// <summary>
    /// Gets and sets the size or strength of the weld.
    /// </summary>
    string SizeOrStrength { get; set; }
    /// <summary>
    /// Gets and sets the space between welds.
    /// </summary>
    string Spacing { get; set; }
    /// <summary>
    /// Gets and sets the test of the weld.
    /// </summary>
    string Test { get; set; }
    /// <summary>
    /// Gets and sets the thickness of the weld.
    /// </summary>
    string Thickness { get; set; }
    /// <summary>
    /// Gets and sets the width of the weld.
    /// </summary>
    string Width { get; set; }
    /// <summary>
    /// Gets and sets the contour finish type for the weld.
    /// </summary>
    ContourSymbolTypeEnum Contour { get; set; }
    /// <summary>
    /// Gets and sets the contour finish method for the weld.
    /// </summary>
    string Method { get; set; }
    /// <summary>
    /// Gets and sets whether the weld is brazed.
    /// </summary>
    bool Brazing { get; set; }
    /// <summary>
    /// Gets and sets the clearance for the braze.
    /// </summary>
    string Clearance { get; set; }
    /// <summary>
    /// Gets and sets whether to enable the secondary fillet weld or not.
    /// </summary>
    bool EnableSecondaryFilletWeld { get; set; }
    /// <summary>
    /// Returns the WeldSymbol object indicating the secondary fillet weld.
    /// </summary>
    WeldSymbol SecondaryWeldSymbol { get; }
}
