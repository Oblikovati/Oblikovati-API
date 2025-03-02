namespace Oblikovati.API;

/// <summary>
/// Publications collection object.
/// </summary>
public interface Publications : IEnumerable
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
    Publication Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Create a new publication object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Publication Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName);
    /// <summary>
    /// Publish Publication to SVF.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Publication PublishToSVF([MarshalAs(UnmanagedType.BStr)] string Name);
}
