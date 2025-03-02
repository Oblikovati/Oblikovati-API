namespace Oblikovati.API;

/// <summary>
/// WebBrowserDialogs collection Object.
/// </summary>
public interface WebBrowserDialogs : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    WebBrowserDialog Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new WebBrowserDialog, the new WebBrowserDialog is returned.
    /// </summary>
    /// <param name="InternalName">Optional input String object that specifies the internal name of newly created WebBrowserDialog. If provided, the internal name should be unique in the WebBrowserDialogs collection, otherwise an error will occur. If not provided, the internal name is automatically generated.</param>
    /// <param name="Modal">Optional input Boolean value that specifies the whether the newly created WebBrowserDialog is modal dialog or not. This defaults to False if not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    WebBrowserDialog Add([In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default, [In] bool? Modal = false);
}
