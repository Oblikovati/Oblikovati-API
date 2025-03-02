namespace Oblikovati.API;

/// <summary>
/// CustomDictionaries object.
/// </summary>
public interface CustomDictionaries : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    CustomDictionary this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new CustomDictionary. The new created CustomDictionary is returned.
    /// </summary>
    /// <param name="Name">Input String as the new CustomDictionary name.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomDictionary Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Method that adds an existing CustomDictionary to the list of available custom dictionaries. The newly added CustomDictionary is returned.
    /// </summary>
    /// <param name="FullFileName">Input String indicating the full filename of an existing CustomDictionary.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomDictionary AddExisting([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
