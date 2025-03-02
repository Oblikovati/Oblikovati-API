namespace Oblikovati.API;

/// <summary>
/// The AuxiliaryFeatureIndicator object.
/// </summary>
public interface AuxiliaryFeatureIndicator
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    FeatureControlFrame Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the formatted text for the first text field of auxiliary feature indicator.
    /// </summary>
    string FieldOneText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the formatted text for the second text field of auxiliary feature indicator.
    /// </summary>
    string FieldTwoText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the symbol for the auxiliary feature indicator.
    /// </summary>
    AuxiliaryFeatureIndicatorSymbolTypeEnum SymbolType { get; set; }
    /// <summary>
    /// Method that deletes the auxiliary feature indicator object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
