namespace Oblikovati.API;

/// <summary>
/// DWGSpline Object.
/// </summary>
public interface DWGSpline
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the HandleID for the DWGEntity.
    /// </summary>
    string HandleID { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedDWGComponent Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the parent DWGEntity of the entity.
    /// </summary>
    DWGEntity ParentEntity { get; }
    /// <summary>
    /// Read-only property that returns the start point geometry.
    /// </summary>
    Point StartPoint { get; }
    /// <summary>
    /// Read-only property that returns the end point geometry.
    /// </summary>
    Point EndPoint { get; }
}
