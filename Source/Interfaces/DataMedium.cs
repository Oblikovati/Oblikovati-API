namespace Oblikovati.API;

/// <summary>
/// The DataMedium object is used when exporting/importing to various formats using the TranslatorAddIn APIs. See the 'export' samples under TranslatorAddin for examples of its use.
/// </summary>
public interface DataMedium
{
    /// <summary>
    /// Specifies the name of a data file.
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// Specifies an IStream containing the data.
    /// </summary>
    object Stream { get; set; }
    /// <summary>
    /// Specifies a IDataObject containing the data.
    /// </summary>
    object IDataObject { get; set; }
    /// <summary>
    /// Specifies a String containing the data.
    /// </summary>
    string String { get; set; }
    /// <summary>
    /// Specifies the type of the data.
    /// </summary>
    MediumTypeEnum MediumType { get; set; }
}
