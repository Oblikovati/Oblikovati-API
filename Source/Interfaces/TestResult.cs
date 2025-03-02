namespace Oblikovati.API;

/// <summary>
/// Test Result Object.
/// </summary>
public interface TestResult
{
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    TestCase Parent { get; }
    /// <summary>
    /// Returns the validation output for the result as an XML string.
    /// </summary>
    string ValidationText { get; }
    /// <summary>
    /// Returns the validation output for the result as an XML string.
    /// </summary>
    bool Succeeded { get; }
    /// <summary>
    /// Compare the two test results and returns true if they match.
    /// </summary>
    bool Compare { get; }
}
