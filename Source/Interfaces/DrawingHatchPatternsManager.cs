namespace Oblikovati.API;

/// <summary>
/// DrawingHatchPatternsManager Object.
/// </summary>
public interface DrawingHatchPatternsManager : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    DrawingHatchPattern this[object Index] { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that exports hatch patterns to a PAT file.&nbsp;If a file with the same name already exists, it will be overwritten.
    /// </summary>
    /// <param name="DrawingHatchPatterns">Input a single DrawingHatchPattern object or ObjectCollection that contains one or more DrawingHatchPattern objects to export.</param>
    /// <param name="FullFileName">Input String value that specifies the full file name of the PAT(.pat) file being saved to.</param>
    [PreserveSig]
    void ExportHatchPatterns([In] [MarshalAs(UnmanagedType.IDispatch)] object DrawingHatchPatterns, [In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="PatternDefinitionNames">PatternDefinitionNames</param>
    /// <param name="Descriptions">Descriptions</param>
    [PreserveSig]
    void GetHatchPatternDefinitions([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[] PatternDefinitionNames, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[] Descriptions);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="PatternDefinitionNames">PatternDefinitionNames</param>
    [PreserveSig]
    void LoadHatchPatterns([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] PatternDefinitionNames);
}
