namespace Oblikovati.API;

/// <summary>
/// In an assembly, two or more components cannot occupy the same space at the same time. To detect such errors, you can analyze assemblies for interference.
/// </summary>
public interface InterferenceResult
{
    /// <summary>
    /// Property that returns the centroid of the volume of interference.
    /// </summary>
    Point Centroid { get; }
    /// <summary>
    /// Property that returns the first interfering .
    /// </summary>
    ComponentOccurrence OccurrenceOne { get; }
    /// <summary>
    /// Property that returns the second interfering .
    /// </summary>
    ComponentOccurrence OccurrenceTwo { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the volume of interference in cubic centimeters.
    /// </summary>
    double Volume { get; }
    /// <summary>
    /// Gets the transient body representing the interference volume.
    /// </summary>
    SurfaceBody InterferenceBody { get; }
}
