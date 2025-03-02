namespace Oblikovati.API;

public interface IRxReferencedOLEFileDescriptor
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    OLEDocumentTypeEnum OLEDocumentType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string LogicalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Verb">Verb</param>
    /// <param name="ppOLEDocumentObject">ppOLEDocumentObject</param>
    void Activate([In] OLEVerbEnum Verb, [Out] [MarshalAs(UnmanagedType.IUnknown)] out object ppOLEDocumentObject);
}
