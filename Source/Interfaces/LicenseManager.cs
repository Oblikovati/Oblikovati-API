namespace Oblikovati.API;

/// <summary>
/// LicenseManager Object.
/// </summary>
public interface LicenseManager
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read-only property that returns the license model.
    /// </summary>
    string LicenseModel { get; }
    /// <summary>
    /// Read-only property that returns the license usage.
    /// </summary>
    string LicenseUsage { get; }
}
