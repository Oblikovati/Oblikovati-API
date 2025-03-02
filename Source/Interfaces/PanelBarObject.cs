namespace Oblikovati.API;

public interface PanelBarObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Environment Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBar DefaultCommandBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBar CurrentCommandBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarList CommandBarList { get; }
}
