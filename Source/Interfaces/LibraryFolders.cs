namespace Oblikovati.API;

/// <summary>
/// LibraryFolders Object.
/// </summary>
public interface LibraryFolders : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    LibraryFolder Item { get; }
    /// <summary>
    /// creates a new library folder.
    /// </summary>
    /// <param name="Name">Optional input String value to specify the name of the library folder.</param>
    /// <returns></returns>
    [PreserveSig]
    LibraryFolder Add([In] [MarshalAs(UnmanagedType.Struct)] object? Name = default);
}
