namespace Oblikovati.API;

/// <summary>
/// FlatPatternOrientations Object.
/// </summary>
public interface FlatPatternOrientations : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    FlatPatternOrientation Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the active FlatPatternOrientation object.
    /// </summary>
    FlatPatternOrientation ActiveFlatPatternOrientation { get; }
}
