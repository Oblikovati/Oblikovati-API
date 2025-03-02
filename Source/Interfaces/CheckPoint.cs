namespace Oblikovati.API;

/// <summary>
/// The CheckPoint object serves as a bookmark within a transaction. See the article in the overviews section.
/// </summary>
public interface CheckPoint
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    TransactionManager Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the numeric identifier of this check point.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Gets the user-friendly display name of this check point.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the transaction in which this check point is defined.
    /// </summary>
    Transaction ContainingTransaction { get; }
}
