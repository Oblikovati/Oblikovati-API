namespace Oblikovati.API;

/// <summary>
/// Plugin License Manager.
/// </summary>
public interface PluginLicenseManager
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets whether the license is authorized.
    /// </summary>
    bool IsAuthorized { get; }
    /// <summary>
    /// Gets the license expiration date.
    /// </summary>
    DateTime LicenseExpirationDate { get; }
    /// <summary>
    /// Gets the license behavior.
    /// </summary>
    string LicenseBehavior { get; }
    /// <summary>
    /// Gets license usage.
    /// </summary>
    string LicenseUsage { get; }
    /// <summary>
    /// Gets the license expiration state.
    /// </summary>
    string LicenseExpirationState { get; }
    /// <summary>
    /// Gets license serial number.
    /// </summary>
    string LicenseSerialNumber { get; }
    /// <summary>
    /// Gets the plugin license events.
    /// </summary>
    PluginLicenseManagerEvents PluginLicenseEvents { get; }
    /// <summary>
    /// Displays Authorization Information.
    /// </summary>
    [PreserveSig]
    void DisplayAuthorizationInfo();
    /// <summary>
    /// Method that sets plugin license mode.
    /// </summary>
    /// <param name="Value">Input PluginLicenseIdleModeEnum value that specifies the idle mode to set.</param>
    [PreserveSig]
    void SetLicenseIdleMode([In] PluginLicenseIdleModeEnum Value);
}
