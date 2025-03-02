namespace Oblikovati.API;

/// <summary>
/// The iAssemblyTableColumns collection object provides access to all existing iAssemblyTableColumn objects in the iAssembly factory table.
/// </summary>
public interface iAssemblyTableColumns : IEnumerable
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
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iAssemblyTableColumn object from the collection.
    /// </summary>
    iAssemblyTableColumn this[object Index] { get; }
}
