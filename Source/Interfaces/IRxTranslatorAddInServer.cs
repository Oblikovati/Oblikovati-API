namespace Oblikovati.API;

public interface IRxTranslatorAddInServer : IRxApplicationAddInServer
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte HasOpenOptions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte HasSaveCopyAsOptions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceData">SourceData</param>
    /// <param name="Context">Context</param>
    /// <param name="ChosenOptions">ChosenOptions</param>
    void ShowOpenOptions([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap ChosenOptions);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceData">SourceData</param>
    /// <param name="Context">Context</param>
    /// <param name="Options">Options</param>
    /// <param name="TargetObject">TargetObject</param>
    void Open([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] [MarshalAs(UnmanagedType.IUnknown)] out object TargetObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceObject">SourceObject</param>
    /// <param name="Context">Context</param>
    /// <param name="ChosenOptions">ChosenOptions</param>
    void ShowSaveCopyAsOptions([In] [MarshalAs(UnmanagedType.IUnknown)] object SourceObject, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap ChosenOptions);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceObject">SourceObject</param>
    /// <param name="Context">Context</param>
    /// <param name="Options">Options</param>
    /// <param name="TargetData">TargetData</param>
    void SaveCopyAs([In] [MarshalAs(UnmanagedType.IUnknown)] object SourceObject, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [MarshalAs(UnmanagedType.Interface)] DataMedium TargetData);
}
