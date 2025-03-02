namespace Oblikovati.API;

/// <summary>
/// Object that represents a Property. See the article in the overviews section.
/// </summary>
public interface Property
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    PropertySet Parent { get; }
    /// <summary>
    /// Gets the identifier (PROPID) of this Property.
    /// </summary>
    int PropId { get; }
    /// <summary>
    /// Gets the human-readable name of this Property, if any.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets/Sets the value of this Property.
    /// </summary>
    object Value { get; set; }
    /// <summary>
    /// Property that returns a Boolean flag that indicates whether this property has been edited or created.
    /// </summary>
    bool Dirty { get; }
    /// <summary>
    /// Gets/Sets the human-readable name associated with this Property.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets/Sets expression that defines the value of this property.
    /// </summary>
    string Expression { get; set; }
    /// <summary>
    /// Method that deletes this Property from its PropertySet.
    /// </summary>
    [PreserveSig]
    void Delete();
}
