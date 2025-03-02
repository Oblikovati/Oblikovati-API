namespace Oblikovati.API;

/// <summary>
/// Document Sub Type Object.
/// </summary>
public interface DocumentSubType
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets SubTypeID associated with Sub Type.
    /// </summary>
    string DocumentSubTypeID { get; }
}
