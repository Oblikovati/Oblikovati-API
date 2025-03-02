namespace Oblikovati.API;

public interface IRxEdgeUse
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEdge Edge { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEdgeLoop EdgeLoop { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEdgeUse Partner { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEdgeUse Next { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEdgeUse Previous { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsOpposedToEdge { get; }
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
    IRxCurve2dEvaluator Evaluator { get; }
}
