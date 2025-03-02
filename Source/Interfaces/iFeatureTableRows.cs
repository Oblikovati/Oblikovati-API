namespace Oblikovati.API;

/// <summary>
/// The iFeatureTableRows collection object provides access to the rows of an iFeature table.
/// </summary>
public interface iFeatureTableRows : IEnumerable
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
    /// Method that returns the specified iFeatureTableRow object from the collection.
    /// </summary>
    iFeatureTableRow this[object Index] { get; }
}
