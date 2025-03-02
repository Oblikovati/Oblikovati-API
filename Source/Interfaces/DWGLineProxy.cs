namespace Oblikovati.API;

/// <summary>
/// DWGLineProxy Object.
/// </summary>
public interface DWGLineProxy
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
    /// Read-only property that returns the UnitVector indicating the direction of the line.
    /// </summary>
    UnitVector Direction { get; }
    /// <summary>
    /// Read-only property that returns the point that defines the position of the end of the line.
    /// </summary>
    Point EndPoint { get; }
    /// <summary>
    /// Read-only property that returns the point that defines the position of the start of the line.
    /// </summary>
    Point StartPoint { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGLine NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
