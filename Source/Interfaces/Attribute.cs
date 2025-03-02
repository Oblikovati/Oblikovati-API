namespace Oblikovati.API;

/// <summary>
/// The Attribute object stores a name and value and belongs to a specific attribute set.
/// </summary>
public interface Attribute
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent AttributeSet.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets/Sets the name of the Attribute.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets/Sets the value of the Attribute.
    /// </summary>
    object Value { get; set; }
    /// <summary>
    /// Property that returns the type of the value stored within this attribute.
    /// </summary>
    ValueTypeEnum ValueType { get; }
    /// <summary>
    /// Method that deletes the attribute from the attribute set.
    /// </summary>
    [PreserveSig]
    void Delete();
}
