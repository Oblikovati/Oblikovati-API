namespace Oblikovati.API;

public interface MeasureEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Parameter">Parameter</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnSelectParameter([In] [MarshalAs(UnmanagedType.Interface)] Parameter Parameter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MeasureType">MeasureType</param>
    /// <param name="MeasuredValue">MeasuredValue</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnMeasure([In] MeasureTypeEnum MeasureType, [In] double MeasuredValue, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}
