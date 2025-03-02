namespace Oblikovati.API;

/// <summary>
/// DWGEntityLineSegmentProxy object.
/// </summary>
public interface DWGEntityLineSegmentProxy
{
    /// <summary>
    /// Read-only property that returns the segment geometry.
    /// </summary>
    LineSegment Geometry { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGEntityLineSegment NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
