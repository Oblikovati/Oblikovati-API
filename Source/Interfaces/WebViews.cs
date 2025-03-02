namespace Oblikovati.API;

/// <summary>
/// WebViews collection Object.
/// </summary>
public interface WebViews : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    WebView this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Creates a new Document of the specified type. Optionally, a template file can be specified instead.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    WebView Add([In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default);
}
