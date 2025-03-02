namespace Oblikovati.API;

/// <summary>
/// Generic object. Weakly-typed (IDispatch).
/// </summary>
public interface GenericObject
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the constant that indicates the real type of this object.
    /// </summary>
    ObjectTypeEnum ObjectType { get; }
}
