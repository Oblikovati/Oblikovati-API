namespace Oblikovati.API;

public interface IRxSurfaceBody
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFaceShells FaceShells { get; }
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
    IRxComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox RangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsSolid { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Volume { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    uint GeometryForm { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox PreciseRangeBox { get; }
}
