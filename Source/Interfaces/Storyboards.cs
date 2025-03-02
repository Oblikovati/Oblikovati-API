namespace Oblikovati.API;

/// <summary>
/// Storyboards collection object.
/// </summary>
public interface Storyboards : IEnumerable
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
    Storyboard Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Return the specified Storyboard object from the collection.
    /// </summary>
    Storyboard ItemById { get; }
    /// <summary>
    /// Create a new Storyboard object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Storyboard Add([In] [MarshalAs(UnmanagedType.Struct)] object? StoryboardId = default);
}
