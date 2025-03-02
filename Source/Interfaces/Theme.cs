namespace Oblikovati.API;

/// <summary>
/// Theme object.
/// </summary>
public interface Theme
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the name of this theme.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Method that activates current theme.
    /// </summary>
    [PreserveSig]
    void Activate();
}
