namespace Oblikovati.API;

public interface ControlDefinitionEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ControlDefinition Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="Inputs">Inputs</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void FireOnCommandInputs([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap Inputs, [Out] out HandlingCodeEnum HandlingCode);
}
