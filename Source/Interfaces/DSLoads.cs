namespace Oblikovati.API;

/// <summary>
/// DSLoads Object.
/// </summary>
public interface DSLoads : IEnumerable
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
    /// Input Variant value that specifies the DSLoad to return.&nbsp;This can be either a numeric value indicating the index of the item in the collection or it can be a string indicating the DSLoad name.&nbsp;If an out of range index or a name of a non-existent DSLoad is provided, an error will occur.
    /// </summary>
    DSLoad this[object Index] { get; }
}
