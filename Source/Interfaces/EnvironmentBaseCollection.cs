namespace Oblikovati.API;

/// <summary>
/// Represents a EnvironmentsDef Object.
/// </summary>
public interface EnvironmentBaseCollection : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    EnvironmentBase this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets CommandBarBaseCollection object.
    /// </summary>
    CommandBarBaseCollection CommandBarBaseCollection { get; }
}
