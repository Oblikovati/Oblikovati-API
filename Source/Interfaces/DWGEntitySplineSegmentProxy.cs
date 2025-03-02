namespace Oblikovati.API;

/// <summary>
/// DWGEntitySplineSegmentProxy object.
/// </summary>
public interface DWGEntitySplineSegmentProxy
{
    /// <summary>
    /// Read-only property that returns the start point geometry.
    /// </summary>
    Point StartPoint { get; }
    /// <summary>
    /// Read-only property that returns the end point geometry.
    /// </summary>
    Point EndPoint { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGEntitySplineSegment NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
