namespace Oblikovati.API;

/// <summary>
/// The Path object represents a single set of connected curves. The order of the objects within the collection is the same as the connection order of the entities.
/// </summary>
public interface Path : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified PathEntity object from the collection.
    /// </summary>
    PathEntity this[int Index] { get; }
    /// <summary>
    /// Property that returns a Boolean indicating if the path is closed or not. Returns True in the case of a closed path.
    /// </summary>
    bool Closed { get; }
    /// <summary>
    /// Property returning the Wires collection object associated with this Path.
    /// </summary>
    Wires Wires { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
