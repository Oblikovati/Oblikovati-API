namespace Oblikovati.API;

public interface IRxFaceShell
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFaces Faces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdges Edges { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceBody SurfaceBody { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsClosed { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsVoid { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsPointInside { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox RangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Volume { get; }
}
