namespace Oblikovati.API;

public interface PromptMessage
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Id { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Title { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayedPromptText { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string PromptText { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Buttons { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int DefaultAnswer { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PromptMessageRestrictionsEnum Restrictions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Display();
}
