namespace Oblikovati.API;

public interface ChangeProcessorObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ChangeDefinition Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DisplayMessages { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool GlobalChangeProcess { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool GlobalChangeProcessAborted { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Transact { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MergeWithPrevious { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandTypesEnum ChangeType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DeferDrawingCleanUp { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ButtonTypeEnum MessageDialogUserChoice { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    void Execute([In] [MarshalAs(UnmanagedType.Interface)] _Document Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentNames">FullDocumentNames</param>
    /// <param name="ReasonsForChange">ReasonsForChange</param>
    [PreserveSig]
    void SetAffectedDocuments([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] FullDocumentNames, [In] [MarshalAs(UnmanagedType.Struct)] object? ReasonsForChange = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AllowAccept">AllowAccept</param>
    /// <param name="AllowEdit">AllowEdit</param>
    [PreserveSig]
    void SetMessageDialogOptions([In] bool AllowAccept, [In] bool AllowEdit);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _TransactBRepHistory();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SuppressedEvents">SuppressedEvents</param>
    /// <param name="Suppressed">Suppressed</param>
    [PreserveSig]
    void SuppressChangeNotifications([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] SuppressedEvents, [In] bool Suppressed);
}
