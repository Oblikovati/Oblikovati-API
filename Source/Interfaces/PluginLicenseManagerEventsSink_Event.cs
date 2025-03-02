namespace Oblikovati.API;

public interface PluginLicenseManagerEventsSink_Event
{
    event PluginLicenseManagerEventsSink_OnLoseLicenseEventHandler OnLoseLicense;
    event PluginLicenseManagerEventsSink_OnChangeLicenseEventHandler OnChangeLicense;
}
