namespace Oblikovati.API;

/// <summary>
/// SpellCheckOptions object.
/// </summary>
public interface SpellCheckOptions
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to ignore the capitalized words (e.g. Autodesk).
    /// </summary>
    bool IgnoreCapitalizedWords { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to ignore the word with mixed case(e.g. TrueType).
    /// </summary>
    bool IgnoreWordWithMixedCase { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to ignore the uppercase words (e.g. DWG).
    /// </summary>
    bool IgnoreUppercaseWords { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to ignore the words with numbers (e.g. ISO9000).
    /// </summary>
    bool IgnoreWordsWithNumbers { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to ignore the words with punctuation (e.g. A/3).
    /// </summary>
    bool IgnoreWordsContainingPunctuation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets dictionary language.
    /// </summary>
    DictionaryLanguageTypeEnum DictionaryLanguage { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the active custom dictionary.
    /// </summary>
    CustomDictionary ActiveCustomDictionary { get; set; }
    /// <summary>
    /// Read-only property that returns the CustomDictionaries object containing all the custom dictionaries.
    /// </summary>
    CustomDictionaries CustomDictionaries { get; }
}
