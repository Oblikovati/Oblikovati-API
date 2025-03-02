namespace Oblikovati.API;

/// <summary>
/// ThemeManager Object.
/// </summary>
public interface ThemeManager
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
    /// Read-only property that returns the active theme.
    /// </summary>
    Theme ActiveTheme { get; }
    /// <summary>
    /// Read-only property that returns the themes collection object.
    /// </summary>
    ThemesEnumerator Themes { get; }
    /// <summary>
    /// Method that gets the current theme color of the specified component.
    /// </summary>
    /// <param name="ComponentName">Input String value that indicates a component name. Valid values include:
    /// ApplicationFrame_BackgroundColor
    /// BrowserPane_BackgroundColor
    /// BrowserPane_TextColor</param>
    /// <returns></returns>
    [PreserveSig]
    Color GetComponentThemeColor([In] [MarshalAs(UnmanagedType.BStr)] string ComponentName);
}
