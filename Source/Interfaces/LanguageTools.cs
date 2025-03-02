namespace Oblikovati.API;

/// <summary>
/// The LanguageTools object provides a means of determining the logical boolean value of iPart/iComponent table strings.
/// </summary>
public interface LanguageTools
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Application object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _CurrentMasterModelStateString { get; }
    /// <summary>
    /// Read-only property that returns the primary ModelState string in current language.
    /// </summary>
    string CurrentPrimaryModelStateString { get; }
    /// <summary>
    /// Method that returns the logical value of the input iComponent string. For instance, if the input string is 'Include', a value of True is returned. The input string can be in any of the supported localized languages.
    /// </summary>
    /// <param name="iComponentString">Return the logical value of this string.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetiComponentStringValue([In] [MarshalAs(UnmanagedType.BStr)] string iComponentString);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MasterName">MasterName</param>
    [PreserveSig]
    bool _IsValidMasterModelState([In] [MarshalAs(UnmanagedType.BStr)] string MasterName);
    /// <summary>
    /// Method that returns whether the input primary model state string is valid or not. The input primary model state string can be in any language that Oblikovati supports.
    /// </summary>
    /// <param name="PrimaryName">Input String value that specifies the primary model state string. This string can be in any language that Inventor supports. Below are the valid localized string for primary model state string in different languages:
    /// {"en-US", "[Primary]"},
    /// {"ja-JP", "[プライマリ]"},
    /// {"de-DE", "[Primär]"},
    /// {"cs-CZ", "[Primární]"},
    /// {"pl-PL", "[Główny]"},
    /// {"ru-RU", "[Oсновной]"},
    /// {"it-IT", "[Primario]"},
    /// {"fr-FR", "[Principale]"},
    /// {"es-ES", "[Principal]"},
    /// {"pt-BR", "[Principal]"},
    /// {"ko-KR", "[1차]"},
    /// {"zh-CN", "[主要]"},
    /// {"zh-TW", "[主要]"}.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsValidPrimaryModelState([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryName);
}
