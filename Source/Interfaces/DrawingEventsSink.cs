namespace Oblikovati.API;

public interface DrawingEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SketchDimensions">SketchDimensions</param>
    /// <param name="DrawingDimensions">DrawingDimensions</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnRetrieveDimensions([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SketchDimensions, [In] [MarshalAs(UnmanagedType.Interface)] GeneralDimensionsEnumerator DrawingDimensions, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
