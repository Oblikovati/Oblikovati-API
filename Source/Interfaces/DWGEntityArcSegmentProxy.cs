namespace Oblikovati.API;

/// <summary>
/// DWGEntityArcSegmentProxy object.
/// </summary>
public interface DWGEntityArcSegmentProxy
{
    /// <summary>
    /// Read-only property that returns the segment geometry.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGEntityArcSegment NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
