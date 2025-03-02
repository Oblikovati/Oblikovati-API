namespace Oblikovati.API;

/// <summary>
/// The AuxiliaryFeatureIndicators object allows to access the auxiliary feature indicators within a feature control frame symbol.
/// </summary>
public interface AuxiliaryFeatureIndicators : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    AuxiliaryFeatureIndicator this[int Index] { get; }
    /// <summary>
    /// Method that creates a new AuxiliaryFeatureIndicator. The newly created AuxiliaryFeatureIndicator object is returned.
    /// </summary>
    /// <param name="SymbolType">Input AuxiliaryFeatureIndicatorSymbolTypeEnum  value that specifies the symbol type of the auxiliary feature indicator.</param>
    /// <param name="FieldOneText">Input String value that specifies the formatted text for the first text field of auxiliary feature indicator.</param>
    /// <param name="FieldTwoText">Input String value that specifies the formatted text for the second  text field of auxiliary feature indicator.</param>
    /// <returns></returns>
    [PreserveSig]
    AuxiliaryFeatureIndicator Add([In] AuxiliaryFeatureIndicatorSymbolTypeEnum SymbolType, [In] [MarshalAs(UnmanagedType.BStr)] string? FieldOneText = "", [In] [MarshalAs(UnmanagedType.BStr)] string? FieldTwoText = "");
}
