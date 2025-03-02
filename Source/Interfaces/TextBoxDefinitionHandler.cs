namespace Oblikovati.API;

/// <summary>
/// Represents a ButtonDefinitionHandler Object.
/// </summary>
public interface TextBoxDefinitionHandler
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Executes the handler.
    /// </summary>
    [PreserveSig]
    void Execute();
}
