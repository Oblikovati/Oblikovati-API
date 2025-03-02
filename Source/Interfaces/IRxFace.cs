namespace Oblikovati.API;

public interface IRxFace
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdgeLoops EdgeLoops { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdges Edges { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumVertices Vertices { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFaceShell FaceShell { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceBody SurfaceBody { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsParamReversed { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid SurfaceType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IntPtr Surface { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    uint GeometryForm { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceEvaluator Evaluator { get; }
}
