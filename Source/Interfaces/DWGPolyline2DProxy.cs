namespace Oblikovati.API;

/// <summary>
/// DWGPolyline2DProxy Object.
/// </summary>
public interface DWGPolyline2DProxy
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DWGEntitiesEnumerator Entities { get; }
    /// <summary>
    /// Read-only property that returns the DWGEntitySegmentsEnumerator object.
    /// </summary>
    DWGEntitySegmentsEnumerator Segments { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGPolyline2D NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
