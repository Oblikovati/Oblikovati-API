namespace Oblikovati.API;

public interface IRxComponentDefinition
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumSurfaceBodies SurfaceBodies { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _CurveBodies { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _Curve2dBodies { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumComponentOccurrences Occurrences { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumComponentDefinitionReferences ImmediateReferencedDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDocument Document { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _HasUnderlyingDefinition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDefinition _UnderlyingDefinition { get; }
}
