namespace Oblikovati.API;

/// <summary>
/// FactoryTable Dialog Object.
/// </summary>
public interface FactoryTableDialog
{
    /// <summary>
    /// FactoryTable Dialog Title.
    /// </summary>
    string DialogTitle { get; set; }
    /// <summary>
    /// FactoryTable Dialog Full File Name.
    /// </summary>
    string FullFileName { get; set; }
    /// <summary>
    /// FactoryTable Dialog Destination Name.
    /// </summary>
    string DestinationFileName { get; set; }
    /// <summary>
    /// FactoryTable Dialog Active Tab Index.
    /// </summary>
    int ActiveTabIndex { get; set; }
    /// <summary>
    /// FactoryTable Dialog Custom Factory Property.
    /// </summary>
    bool IsCustomFactory { get; }
    /// <summary>
    /// FactoryTable Dialog Selected Table Row Index.
    /// </summary>
    int SelectedTableRow { get; }
    /// <summary>
    /// FactoryTable Dialog Custom Input Data.
    /// </summary>
    string[] CustomInput { get; }
    /// <summary>
    /// FactoryTable Dialog Show Method.
    /// </summary>
    [PreserveSig]
    void Show();
}
