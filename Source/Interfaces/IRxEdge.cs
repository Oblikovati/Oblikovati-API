namespace Oblikovati.API;

public interface IRxEdge
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxVertex StartVertex { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxVertex StopVertex { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdgeUses EdgeUses { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFaces Faces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsParamReversed { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid CurveType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IntPtr Curve { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    uint GeometryForm { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurveEvaluator Evaluator { get; }
}
