namespace Oblikovati.API;

/// <summary>
/// PublicationTweakPaths collection object.
/// </summary>
public interface PublicationTweakPaths : IEnumerable
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
    PublicationTweakPath this[int Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the specified PublicationTweakPath object from the collection according to the specified PublicationComponent.
    /// </summary>
    PublicationTweakPath ItemByComponent { get; }
}
