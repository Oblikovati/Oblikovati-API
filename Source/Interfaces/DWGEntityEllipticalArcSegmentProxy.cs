namespace Oblikovati.API;

/// <summary>
/// DWGEntityEllipticalArcSegmentProxy object.
/// </summary>
public interface DWGEntityEllipticalArcSegmentProxy
{
    /// <summary>
    /// Read-only property that returns the segment geometry.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Get the object in the context of the definition instead of the containing assembly.
    /// </summary>
    DWGEntityEllipticalArcSegment NativeObject { get; }
    /// <summary>
    /// Get the component occurrence context through which the native object is being seen through.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
