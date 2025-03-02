namespace Oblikovati.API;

/// <summary>
/// Test Manager Object.
/// </summary>
public interface TestManager
{
    /// <summary>
    /// Gets the collection of test cases.
    /// </summary>
    TestCases TestCases { get; }
    /// <summary>
    /// Gets the collection of test programs.
    /// </summary>
    TestPrograms TestPrograms { get; }
    /// <summary>
    /// Locations for test files for running test cases.
    /// </summary>
    TestConfiguration TestConfiguration { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object TestHost { set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object TestObject { set; }
    /// <summary>
    /// Get a wrapper object for an enum type by name.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EnumType GetEnumType([In] [MarshalAs(UnmanagedType.BStr)] string EnumNameType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    TestInputOutput CreateTestIO();
}
