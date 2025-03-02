namespace Oblikovati.API;

/// <summary>
/// The iFeatureTableColumns collection object provides access to the columns of an iFeature table.
/// </summary>
public interface iFeatureTableColumns : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iFeatureTableColumn object from the collection.
    /// </summary>
    iFeatureTableColumn Item { get; }
}
