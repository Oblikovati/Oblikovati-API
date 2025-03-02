namespace Oblikovati.API;

public interface FileUIEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileMetadataObjects">FileMetadataObjects</param>
    /// <param name="Formulae">Formulae</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void PopulateFileMetadata([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection FileMetadataObjects, [In] [MarshalAs(UnmanagedType.BStr)] string Formulae, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
