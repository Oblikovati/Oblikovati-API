namespace Oblikovati.API;

public interface IRxTranslatorAddInServer2 : IRxTranslatorAddInServer, IRxApplicationAddInServer
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceData">SourceData</param>
    object GetThumbnail([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData);
}
