namespace Oblikovati.API;

public interface PromptsOptions
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PromptMessages PromptMessages { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DoNotShowMessagesForPreexistingProblems { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
}
