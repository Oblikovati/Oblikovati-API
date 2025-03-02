namespace Oblikovati.API;

/// <summary>
/// This object provides methods and properties allowing the BOM row unit quantity to be computed.
/// </summary>
public interface BOMQuantity
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the true unit that the component is quantified in.&nbsp;This property only applies if the BaseQuantity is set to a parameter.
    /// </summary>
    string BaseUnits { get; set; }
    /// <summary>
    /// Property that returns the unit quantity derived from two other properties, the BaseQuantity and the BaseUnits.
    /// </summary>
    string UnitQuantity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="QuantityType">QuantityType</param>
    /// <param name="Quantity">Quantity</param>
    [PreserveSig]
    void GetBaseQuantity();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="QuantityType">QuantityType</param>
    /// <param name="Quantity">Quantity</param>
    [PreserveSig]
    void GetBaseQuantity([Out] out BOMQuantityTypeEnum QuantityType, [Out] [MarshalAs(UnmanagedType.Struct)] out object Quantity);
    /// <summary>
    /// Method that sets the base quantity for the component.
    /// </summary>
    /// <param name="QuantityType">Input BOMQuantityTypeEnum indicating the quantity type. If kParameterBOMQuantity is set, a Parameter needs to be specified as the second argument.</param>
    /// <param name="Quantity">Input Variant specifying the quantity. If QuantityType is kParameterBOMQuantity, this argument expects a Parameter input, else this argument can be left unspecified. Only such parameters whose units resolve to being a linear length, a volume, or a mass are valid.</param>
    [PreserveSig]
    void SetBaseQuantity([In] BOMQuantityTypeEnum QuantityType, [In] [MarshalAs(UnmanagedType.Struct)] object? Quantity = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="QuantityType">QuantityType</param>
    [PreserveSig]
    double GetEvaluatedBaseQuantity([Out] out BOMQuantityTypeEnum QuantityType);
}
