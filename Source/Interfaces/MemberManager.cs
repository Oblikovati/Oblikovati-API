namespace Oblikovati.API;

/// <summary>
/// MemberManager Object.
/// </summary>
public interface MemberManager
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
    LinkStatusEnum InstanceStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    /// <param name="LibraryId">LibraryId</param>
    [PreserveSig]
    string GetMemberValues([In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Expression">Expression</param>
    /// <param name="ValueType">ValueType</param>
    /// <param name="DefaultUnitType">DefaultUnitType</param>
    /// <param name="AsValue">AsValue</param>
    /// <param name="Moniker">Moniker</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CustomParameters">CustomParameters</param>
    [PreserveSig]
    object EvaluateTableExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] GeneralDataTypeEnum ValueType, [In] [MarshalAs(UnmanagedType.BStr)] string DefaultUnitType, [In] bool AsValue, [In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomParameters = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    /// <param name="InstanceStatus">InstanceStatus</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CustomParameters">CustomParameters</param>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    string GetInstance([In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [Out] out ContentCenterInstanceStatusEnum InstanceStatus, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomParameters = default, [In] [MarshalAs(UnmanagedType.BStr)] string? FullFileName = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CustomParameters">CustomParameters</param>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    string GetRefreshedInstance([In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomParameters = default, [In] [MarshalAs(UnmanagedType.BStr)] string? FullFileName = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Error">Error</param>
    [PreserveSig]
    string GetLastError([Out] out MemberManagerErrorsEnum Error);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CustomParameters">CustomParameters</param>
    [PreserveSig]
    _Document GetNewInstance([In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomParameters = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="CustomParameters">CustomParameters</param>
    [PreserveSig]
    string GetBatchEditParameters([In] [MarshalAs(UnmanagedType.BStr)] string Moniker, [In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomParameters = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    [PreserveSig]
    string GetItem([In] [MarshalAs(UnmanagedType.BStr)] string Moniker);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RowId">RowId</param>
    /// <param name="Family">Family</param>
    [PreserveSig]
    string GetMoniker([In] [MarshalAs(UnmanagedType.BStr)] string RowId, [In] [MarshalAs(UnmanagedType.BStr)] string Family);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    [PreserveSig]
    string GetFamilyFromMoniker([In] [MarshalAs(UnmanagedType.BStr)] string Moniker);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Moniker">Moniker</param>
    [PreserveSig]
    string GetRowIdFromMoniker([In] [MarshalAs(UnmanagedType.BStr)] string Moniker);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Categories">Categories</param>
    /// <param name="FamilyParamMap">FamilyParamMap</param>
    /// <param name="Table">Table</param>
    /// <param name="TemplateParams">TemplateParams</param>
    [PreserveSig]
    string GetMemberCategorization([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Categories, [In] [MarshalAs(UnmanagedType.BStr)] string FamilyParamMap, [In] [MarshalAs(UnmanagedType.BStr)] string Table, [In] [MarshalAs(UnmanagedType.BStr)] string TemplateParams);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MemberCategorization">MemberCategorization</param>
    /// <param name="TemplateFile">TemplateFile</param>
    /// <param name="Categories">Categories</param>
    /// <param name="DefaultTable">DefaultTable</param>
    /// <param name="FamilyParamMap">FamilyParamMap</param>
    /// <param name="TemplateParams">TemplateParams</param>
    [PreserveSig]
    void GetDefaultTableWithMap([In] [MarshalAs(UnmanagedType.BStr)] string MemberCategorization, [In] [MarshalAs(UnmanagedType.BStr)] string TemplateFile, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Categories, [Out] [MarshalAs(UnmanagedType.BStr)] out string DefaultTable, [Out] [MarshalAs(UnmanagedType.BStr)] out string FamilyParamMap, [Out] [MarshalAs(UnmanagedType.BStr)] out string TemplateParams);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Instance">Instance</param>
    [PreserveSig]
    NameValueMap GetUserParametersFromInstance([In] [MarshalAs(UnmanagedType.Struct)] object Instance);
}
