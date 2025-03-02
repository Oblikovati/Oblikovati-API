namespace Oblikovati.API;

/// <summary>
/// Test Case Object.
/// </summary>
public interface TestCase
{
    /// <summary>
    /// Gets the name of the test case.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the description of the test case.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Gets the associated Test program object.
    /// </summary>
    TestProgram Program { get; }
    /// <summary>
    /// Gets the full path of the test case.
    /// </summary>
    string Path { get; }
    /// <summary>
    /// Gets the collection of all the results of the test case.
    /// </summary>
    TestResults TestResults { get; }
    /// <summary>
    /// Gets the inputs as XML string.
    /// </summary>
    string TestInputs { get; }
    /// <summary>
    /// Gets the basline result object.
    /// </summary>
    TestResult Baseline { get; }
    /// <summary>
    /// Runs the associated test program with the given inputs and returns the result object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TestResult Run([In] [MarshalAs(UnmanagedType.BStr)] string? ResultName = "Regression", [In] bool? bDebug = true);
}
