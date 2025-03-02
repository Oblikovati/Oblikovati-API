namespace Oblikovati.API;

public interface ContentQueryObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentCenter Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="QueryXML">QueryXML</param>
    [PreserveSig]
    void StartActiveQuery([In] [MarshalAs(UnmanagedType.BStr)] string QueryXML);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="QueryXML">QueryXML</param>
    /// <param name="IncludingSubCategories">IncludingSubCategories</param>
    [PreserveSig]
    string StartWaitQuery([In] [MarshalAs(UnmanagedType.BStr)] string QueryXML, [In] bool? IncludingSubCategories = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Stop();
}
