namespace Oblikovati.API;

/// <summary>
/// The TranslationContext object is used in TranslatorAddin workflows.
/// </summary>
public interface TranslationContext
{
    /// <summary>
    /// Specifies the IO operation type of the translation.
    /// </summary>
    IOMechanismEnum Type { get; set; }
    /// <summary>
    /// Specifies the object that is the target of the translation.
    /// </summary>
    object OpenIntoExisting { get; set; }
}
