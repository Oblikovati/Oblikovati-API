namespace Oblikovati.API;

/// <summary>
/// Object that holds a collection of Opaquely-Referenced File Descriptor objects.
/// </summary>
public interface ReferencedOpaqueFileDescriptors : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ReferencedOpaqueFileDescriptor Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows string-indexed access to items in the collection. Usually found when this ability has been added to an pre-existing collection.
    /// </summary>
    ReferencedOpaqueFileDescriptor ItemByName { get; }
    /// <summary>
    /// Creates an Opaque reference to the specified file.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a file.</param>
    /// <returns></returns>
    [PreserveSig]
    ReferencedOpaqueFileDescriptor Add([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
