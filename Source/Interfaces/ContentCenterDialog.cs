namespace Oblikovati.API;

/// <summary>
/// ContentCenterDialog Object.
/// </summary>
public interface ContentCenterDialog
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DialogTitle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayFilter { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CurrentSelection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentItemTypeEnum SelectionType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MultiSelect { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ApplyButton { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CancelButton { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool OKButton { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ApplyButtonString { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CancelButtonString { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string OKButtonString { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayActiveLibrary { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DialogStyleEnum Style { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentCenterDialogEvents ContentCenterDialogEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ApplyButtonEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CancelButtonEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool OKButtonEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void SetCheckBoxOptions([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Modal">Modal</param>
    [PreserveSig]
    void Show([In] bool? Modal = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Terminate();
}
