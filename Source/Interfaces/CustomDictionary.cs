namespace Oblikovati.API;

/// <summary>
/// CustomDictionary object.
/// </summary>
public interface CustomDictionary
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
    /// Read-only property that returns the name of the CustomDictionary.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the fully qualified file name of the CustomDictionary.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Method that imports words to this custom dictionary from an existing custom dictionary.
    /// </summary>
    /// <param name="FullFileName">Input String indicating the full filename of an existing CustomDictionary.</param>
    [PreserveSig]
    void ImportWordsFromExistingDictionary([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that adds a word to this custom dictionary.
    /// </summary>
    /// <param name="Word">Input String indicating a word.</param>
    [PreserveSig]
    void AddWord([In] [MarshalAs(UnmanagedType.BStr)] string Word);
    /// <summary>
    /// Method that deletes a word from this custom dictionary.
    /// </summary>
    /// <param name="Word">Input String indicating a word.</param>
    [PreserveSig]
    void DeleteWord([In] [MarshalAs(UnmanagedType.BStr)] string Word);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Words">Words</param>
    [PreserveSig]
    void GetWords([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Words);
    /// <summary>
    /// Method that removes the CustomDictionary from the custom dictionaries.
    /// </summary>
    [PreserveSig]
    void Remove();
}
