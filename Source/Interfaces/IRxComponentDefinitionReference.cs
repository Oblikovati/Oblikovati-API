namespace Oblikovati.API;

public interface IRxComponentDefinitionReference
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumComponentOccurrences ImmediateOccurrences { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDefinition ReferencedDefinition { get; }
}
