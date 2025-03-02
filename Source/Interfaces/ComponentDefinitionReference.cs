namespace Oblikovati.API;

/// <summary>
/// Use F1 key to display help topic.
/// </summary>
public interface ComponentDefinitionReference
{
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ComponentOccurrencesEnumerator ImmediateOccurrences { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ComponentDefinition ReferencedDefinition { get; }
    /// <summary>
    /// Get the ReferencedFileDescriptor of the document containing the referenced component definition.
    /// </summary>
    ReferencedFileDescriptor ReferencedFileDescriptor { get; }
}
