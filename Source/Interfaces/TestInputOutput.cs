namespace Oblikovati.API;

/// <summary>
/// Test Input/Output Object.
/// </summary>
public interface TestInputOutput
{
    /// <summary>
    /// Gets the result for validation.
    /// </summary>
    string ValidationText { get; }
    /// <summary>
    /// Gets the trace text.
    /// </summary>
    string TraceText { get; }
    /// <summary>
    /// Gets the entire input as a text string.
    /// </summary>
    string InputText { get; }
    /// <summary>
    /// Gets/sets a test context. It is usually added by the Test manager and used by the test program.
    /// </summary>
    string TestContext { get; set; }
    /// <summary>
    /// Gets a string from the input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    string GetString([In] [MarshalAs(UnmanagedType.BStr)] string strPrompt);
    /// <summary>
    /// Gets a double value from the input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    double GetValue([In] [MarshalAs(UnmanagedType.BStr)] string strPrompt);
    /// <summary>
    /// Gets a integer from the input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    int GetInteger([In] [MarshalAs(UnmanagedType.BStr)] string strPrompt);
    /// <summary>
    /// Gets a boolean value from the input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool GetChoice([In] [MarshalAs(UnmanagedType.BStr)] string strPrompt);
    /// <summary>
    /// Gets an Oblikovati document full file name from the input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    string GetDocument([In] [MarshalAs(UnmanagedType.BStr)] string strPrompt);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="strName">strName</param>
    /// <param name="strValue">strValue</param>
    [PreserveSig]
    void ValidateString([In] [MarshalAs(UnmanagedType.BStr)] string strName, [In] [MarshalAs(UnmanagedType.BStr)] string strValue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="strName">strName</param>
    /// <param name="dValue">dValue</param>
    /// <param name="strTolType">strTolType</param>
    [PreserveSig]
    void ValidateValue([In] [MarshalAs(UnmanagedType.BStr)] string strName, [In] double dValue, [In] [MarshalAs(UnmanagedType.BStr)] string? strTolType = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="strName">strName</param>
    /// <param name="nValue">nValue</param>
    [PreserveSig]
    void ValidateNumber([In] [MarshalAs(UnmanagedType.BStr)] string strName, [In] int nValue);
    /// <summary>
    /// Adds the first value to the result. If the comparison with the second value fails, it reports an error to the result.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool Verify([In] [MarshalAs(UnmanagedType.BStr)] string strName, [In] [MarshalAs(UnmanagedType.Struct)] object varExpected, [In] [MarshalAs(UnmanagedType.Struct)] object varActual, [In] double? dTolerancePercentage = default);
    /// <summary>
    /// Adds the string to the trace text of the test case.
    /// </summary>
    [PreserveSig]
    void Trace([In] [MarshalAs(UnmanagedType.BStr)] string strTraceText);
    /// <summary>
    /// Adds a special error indicator to the result.
    /// </summary>
    [PreserveSig]
    void Error([In] [MarshalAs(UnmanagedType.BStr)] string strError);
    /// <summary>
    /// Adds a label to the result.
    /// </summary>
    [PreserveSig]
    void AddLabel([In] [MarshalAs(UnmanagedType.BStr)] string strLabelName);
    /// <summary>
    /// Adds the given string to the result, to bracket the following result values.
    /// </summary>
    [PreserveSig]
    void BeginContext([In] [MarshalAs(UnmanagedType.BStr)] string strContext);
    /// <summary>
    /// Ends the current bracketing of the result values.
    /// </summary>
    [PreserveSig]
    void EndContext();
    /// <summary>
    /// Adds a special label to the result indicating that a functionality is not implemented.
    /// </summary>
    [PreserveSig]
    void NotImplemented([In] [MarshalAs(UnmanagedType.BStr)] string strMessage);
    /// <summary>
    /// Adds a special label to the result indicating that a known defect has been reproduced.
    /// </summary>
    [PreserveSig]
    void Defect([In] [MarshalAs(UnmanagedType.BStr)] string strDefectNumMsg);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="strName">strName</param>
    /// <param name="strValue">strValue</param>
    [PreserveSig]
    void ValidateRawXml([In] [MarshalAs(UnmanagedType.BStr)] string strName, [In] [MarshalAs(UnmanagedType.BStr)] string strValue);
    /// <summary>
    /// Assign an Integer value to a Boolean variable without converting to valid Boolean value.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool AssignBadBoolValue([In] short bVal);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="strXmlFile">strXmlFile</param>
    [PreserveSig]
    void SetInputFile([In] [MarshalAs(UnmanagedType.BStr)] string strXmlFile);
}
