namespace Oblikovati.API;

/// <summary>
/// PublicationMarkedViews object.
/// </summary>
public interface PublicationMarkedViews : IEnumerable
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
    PublicationMarkedView Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the specified PublicationMarkedView object from the collection.
    /// </summary>
    PublicationMarkedView ItemById { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PublicationMarkedView ActiveItem { get; }
    /// <summary>
    /// Method that adds a new PublicationMarkedView object based on the current frame time.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationMarkedView Add([In] [MarshalAs(UnmanagedType.Struct)] object? DisplayName = default);
}
