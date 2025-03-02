namespace Oblikovati.API;

/// <summary>
/// Test Configuration Object.
/// </summary>
public interface TestConfiguration
{
    /// <summary>
    /// Gets/Sets installtion type. This has only three possible values: Developer/QA/Custom. It defaults to Developer/QA depending on the build that is running.
    /// </summary>
    string InstallationType { get; set; }
    /// <summary>
    /// Supporting Test Data Location.
    /// </summary>
    string TestDataLocation { get; set; }
    /// <summary>
    /// Required Test program location.
    /// </summary>
    string TestProgramsLocation { get; set; }
    /// <summary>
    /// Required Test case location.
    /// </summary>
    string TestCasesLocation { get; set; }
    /// <summary>
    /// Required Test results location.
    /// </summary>
    string TestResultsLocation { get; set; }
}
