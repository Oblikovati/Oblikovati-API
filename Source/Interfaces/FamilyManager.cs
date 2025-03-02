namespace Oblikovati.API;

/// <summary>
/// FamilyManager Object.
/// </summary>
public interface FamilyManager
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
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string GetFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyXml">FamilyXml</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string PublishFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyXml, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    void DeleteFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="FromLibraryId">FromLibraryId</param>
    /// <param name="ToLibraryId">ToLibraryId</param>
    /// <param name="Associative">Associative</param>
    [PreserveSig]
    string CopyFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string FromLibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string ToLibraryId, [In] bool? Associative = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    void UpdateFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string GetFamilyProperties([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyProps">FamilyProps</param>
    [PreserveSig]
    void EditFamilyProperties([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyProps);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="TemplateName">TemplateName</param>
    /// <param name="NoTemplateFile">NoTemplateFile</param>
    [PreserveSig]
    string GetFamilyTemplates([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.BStr)] string? TemplateName = "", [In] bool? NoTemplateFile = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyTemplate">FamilyTemplate</param>
    [PreserveSig]
    void EditFamilyTemplate([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyTemplate);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyTemplate">FamilyTemplate</param>
    [PreserveSig]
    void DeleteFamilyTemplate([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyTemplate);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FullyPopulated">FullyPopulated</param>
    [PreserveSig]
    string GetFamilyTable([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] bool? FullyPopulated = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="RowIds">RowIds</param>
    /// <param name="ColumnsIds">ColumnsIds</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string[,] GetEvaluatedRows([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.Struct)] object RowIds, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] ColumnsIds, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="ColumnIds">ColumnIds</param>
    /// <param name="RowIds">RowIds</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string[,] GetEvaluatedColumns([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.Struct)] object ColumnIds, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] RowIds, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyTable">FamilyTable</param>
    [PreserveSig]
    void EditFamilyTable([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyTable);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string GetFamilyParameterMap([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyParameterMap">FamilyParameterMap</param>
    [PreserveSig]
    void EditFamilyParameterMap([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyParameterMap);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="Language">Language</param>
    /// <param name="EnumerationOnly">EnumerationOnly</param>
    [PreserveSig]
    string GetFamilyStrings([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Language = "", [In] bool? EnumerationOnly = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyStrings">FamilyStrings</param>
    [PreserveSig]
    void EditFamilyStrings([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyStrings);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyIds">FamilyIds</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CachedOnly">CachedOnly</param>
    [PreserveSig]
    string[,] GetFamilyThumbnails([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] FamilyIds, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] bool? CachedOnly = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="ThumbnailFile">ThumbnailFile</param>
    [PreserveSig]
    void EditFamilyThumbnail([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string ThumbnailFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    [PreserveSig]
    string GetItem([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ExcelFile">ExcelFile</param>
    /// <param name="WorkSheet">WorkSheet</param>
    [PreserveSig]
    string GetTableFromExcel([In] [MarshalAs(UnmanagedType.BStr)] string ExcelFile, [In] [MarshalAs(UnmanagedType.BStr)] string? WorkSheet = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Table">Table</param>
    /// <param name="ExcelFile">ExcelFile</param>
    /// <param name="WorkSheet">WorkSheet</param>
    [PreserveSig]
    void GetExcelFromTable([In] [MarshalAs(UnmanagedType.BStr)] string Table, [In] [MarshalAs(UnmanagedType.BStr)] string ExcelFile, [In] [MarshalAs(UnmanagedType.BStr)] string WorkSheet);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="iPartFile">iPartFile</param>
    [PreserveSig]
    string GetTableFromiPart([In] [MarshalAs(UnmanagedType.BStr)] string iPartFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FamilyXml">FamilyXml</param>
    [PreserveSig]
    void EditFamily([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyXml);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="FullyPopulated">FullyPopulated</param>
    /// <param name="decimalMarker">decimalMarker</param>
    [PreserveSig]
    string GetFamilyTable2([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] bool? FullyPopulated = false, [In] ContentCenterDecimalMarkerOptionEnum? decimalMarker = ContentCenterDecimalMarkerOptionEnum.kCCDecimalMarkerOptionDefault);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FamilyId">FamilyId</param>
    /// <param name="RowId">RowId</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="ColumnIds">ColumnIds</param>
    /// <param name="ParameterValueOverrides">ParameterValueOverrides</param>
    /// <param name="decimalMarker">decimalMarker</param>
    [PreserveSig]
    NameValueMap GetEvaluatedRow([In] [MarshalAs(UnmanagedType.BStr)] string FamilyId, [In] [MarshalAs(UnmanagedType.BStr)] string RowId, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? ColumnIds = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ParameterValueOverrides = default, [In] ContentCenterDecimalMarkerOptionEnum? decimalMarker = ContentCenterDecimalMarkerOptionEnum.kCCDecimalMarkerOptionDefault);
}
