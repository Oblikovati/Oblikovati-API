namespace Oblikovati.API;

/// <summary>
/// ModelWeldingSymbolDefinition Object.
/// </summary>
public interface ModelWeldingSymbolDefinition
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
    ModelWeldingSymbol Parent { get; }
    /// <summary>
    /// Gets and sets whether to add the all-around indicator to the symbol.
    /// </summary>
    bool AllAroundSymbol { get; set; }
    /// <summary>
    /// Gets and sets the placement of the identification line against the reference line. Available for ISO and DIN only.
    /// </summary>
    IdentificationLinePlacementEnum IdentificationLinePlacement { get; set; }
    /// <summary>
    /// Gets and sets whether to switch the arrow and symbols above or below the reference line.
    /// </summary>
    bool SwapArrowAndSymbols { get; set; }
    /// <summary>
    /// Gets and sets the stagger type of the welding symbols for fillets. This is applicable only if fillet welding symbols are set on both sides of the reference line.
    /// </summary>
    StaggerTypeEnum StaggerType { get; set; }
    /// <summary>
    /// Gets and sets the description to the reference line.
    /// </summary>
    string TailNote { get; set; }
    /// <summary>
    /// Gets and sets whether to enclose the note text in a box or not.
    /// </summary>
    bool ClosedNoteTail { get; set; }
    /// <summary>
    /// Gets and sets whether to add a flag indicating a field or site weld to the selected reference line or not.
    /// </summary>
    bool FieldWeldingSymbol { get; set; }
    /// <summary>
    /// Gets and sets whether to use spacer or not.
    /// </summary>
    bool UseSpacer { get; set; }
    /// <summary>
    /// Returns the WeldSymbol object that is above the reference line.
    /// </summary>
    WeldSymbol WeldSymbolOne { get; }
    /// <summary>
    /// Returns the WeldSymbol object that is below the reference line.
    /// </summary>
    WeldSymbol WeldSymbolTwo { get; }
}
