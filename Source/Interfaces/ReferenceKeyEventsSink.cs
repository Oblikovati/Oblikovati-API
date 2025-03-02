namespace Oblikovati.API;

public interface ReferenceKeyEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="Document">Document</param>
    /// <param name="Object">Object</param>
    /// <param name="MatchType">MatchType</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBindKeyToObject([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] [MarshalAs(UnmanagedType.IDispatch)] object Document, [In] [Out] [MarshalAs(UnmanagedType.IDispatch)] ref object Object, [Out] out SolutionNatureEnum MatchType, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] [Out] ref HandlingCodeEnum HandlingCode);
}
