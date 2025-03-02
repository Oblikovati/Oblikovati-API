namespace Oblikovati.API;

/// <summary>
/// The ApplicationAddInSite object is an object that is only available through the Activate method of the ApplicationAddInServer interface.
/// </summary>
public interface ApplicationAddInSite
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ApplicationAddIn object.
    /// </summary>
    ApplicationAddIn Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InventorServer InventorServer { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandName">CommandName</param>
    /// <param name="CommandID">CommandID</param>
    /// <param name="InstallInTools">InstallInTools</param>
    [PreserveSig]
    Command CreateCommand([In] [MarshalAs(UnmanagedType.BStr)] string CommandName, [In] int CommandID, [In] [MarshalAs(UnmanagedType.Struct)] object InstallInTools);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    [PreserveSig]
    void DeleteCommand([In] int CommandID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LicenseCode">LicenseCode</param>
    [PreserveSig]
    AddInLicenseStatusEnum License([In] [MarshalAs(UnmanagedType.BStr)] string LicenseCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    string LicenseChallenge();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Response">Response</param>
    [PreserveSig]
    AddInLicenseStatusEnum LicenseResponse([In] [MarshalAs(UnmanagedType.BStr)] string Response);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    /// <param name="Classification">Classification</param>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="DescriptionText">DescriptionText</param>
    /// <param name="ToolTipText">ToolTipText</param>
    /// <param name="StandardIcon">StandardIcon</param>
    /// <param name="LargeIcon">LargeIcon</param>
    [PreserveSig]
    ButtonDefinitionHandler CreateButtonDefinitionHandler([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] CommandTypesEnum Classification, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.Struct)] object? DescriptionText = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ToolTipText = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EnvironmentID">EnvironmentID</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="CopyFrom">CopyFrom</param>
    [PreserveSig]
    EnvironmentBaseHandler CreateEnvironmentBaseHandler([In] [MarshalAs(UnmanagedType.BStr)] string EnvironmentID, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.Interface)] EnvironmentBase CopyFrom);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentType">DocumentType</param>
    /// <param name="SubTypeID">SubTypeID</param>
    /// <param name="ApplicationName">ApplicationName</param>
    /// <param name="EnvironmentBase">EnvironmentBase</param>
    /// <param name="MissingBehavior">MissingBehavior</param>
    /// <param name="LargeIcon">LargeIcon</param>
    /// <param name="SmallIcon">SmallIcon</param>
    [PreserveSig]
    DocumentSubTypeHandler CreateDocumentSubTypeHandler([In] DocumentTypeEnum DocumentType, [In] [MarshalAs(UnmanagedType.BStr)] string SubTypeID, [In] [MarshalAs(UnmanagedType.BStr)] string ApplicationName, [In] [MarshalAs(UnmanagedType.Interface)] EnvironmentBase EnvironmentBase, [In] CommandTypesEnum MissingBehavior, [In] [MarshalAs(UnmanagedType.Interface)] IPictureDisp LargeIcon, [In] [MarshalAs(UnmanagedType.Interface)] IPictureDisp SmallIcon);
}
