namespace Oblikovati.API;

/// <summary>
/// The DerivedPartEntity object contains the information associated with an entity being derived.
/// </summary>
public interface DerivedPartEntity
{
    /// <summary>
    /// Property that returns the entity in the part document. This can be used to perform additional queries to help to determine whether to include this entity or not.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IncludeEntity { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the derive status for this entity.
    /// </summary>
    DerivedComponentOptionEnum DeriveStatus { get; set; }
}
