namespace Oblikovati.API;

public interface IRxEdgeLoop
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdgeUses EdgeUses { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdges Edges { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxFace Face { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsOuterEdgeLoop { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox RangeBox { get; }
}
