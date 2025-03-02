namespace Oblikovati.API;

public interface iLogicOptions
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object ExternalRuleDirectories { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object ExternalRuleFileNames { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ExternalRuleDefaultExtension { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CustomAddInDirectory { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iLogicEventTriggersFilterEnum EventTriggersFilter { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableRuleSecurityInspection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iLogicExcelEngineTypeEnum ExcelEngineType { get; set; }
}
