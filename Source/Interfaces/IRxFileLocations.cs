namespace Oblikovati.API;

public interface IRxFileLocations
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Workspace { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _WorkspaceActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _LocalsActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _WorkgroupsActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string FileLocationsFilesDir { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string FileLocationsFile { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _CurrentSettingsDirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte _Dirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnPaths">pnPaths</param>
    /// <param name="pppNames">pppNames</param>
    /// <param name="ppbstrPaths">ppbstrPaths</param>
    void Locals([Out] out int pnPaths, [Out] out IntPtr pppNames, [Out] out IntPtr ppbstrPaths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    void RemoveLocal([In] [MarshalAs(UnmanagedType.BStr)] string bstrName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    /// <param name="bstrPath">bstrPath</param>
    /// <param name="nIndex">nIndex</param>
    void AddLocal([In] [MarshalAs(UnmanagedType.BStr)] string bstrName, [In] [MarshalAs(UnmanagedType.BStr)] string bstrPath, [In] int nIndex);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnPaths">pnPaths</param>
    /// <param name="ppbstrNames">ppbstrNames</param>
    /// <param name="ppbstrPaths">ppbstrPaths</param>
    void Workgroups([Out] out int pnPaths, [Out] out IntPtr ppbstrNames, [Out] out IntPtr ppbstrPaths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    void RemoveWorkgroup([In] [MarshalAs(UnmanagedType.BStr)] string bstrName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    /// <param name="bstrPath">bstrPath</param>
    /// <param name="nIndex">nIndex</param>
    void AddWorkgroup([In] [MarshalAs(UnmanagedType.BStr)] string bstrName, [In] [MarshalAs(UnmanagedType.BStr)] string bstrPath, [In] int nIndex);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnPaths">pnPaths</param>
    /// <param name="ppbstrNames">ppbstrNames</param>
    /// <param name="ppbstrPaths">ppbstrPaths</param>
    void Libraries([Out] out int pnPaths, [Out] out IntPtr ppbstrNames, [Out] out IntPtr ppbstrPaths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    void RemoveLibrary([In] [MarshalAs(UnmanagedType.BStr)] string bstrName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrName">bstrName</param>
    /// <param name="bstrPath">bstrPath</param>
    void AddLibrary([In] [MarshalAs(UnmanagedType.BStr)] string bstrName, [In] [MarshalAs(UnmanagedType.BStr)] string bstrPath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void _ApplyCurrentSettings();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void _Save();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrFile">bstrFile</param>
    void _SaveAs([In] [MarshalAs(UnmanagedType.BStr)] string bstrFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrFullFileName">bstrFullFileName</param>
    /// <param name="pbstrRepositoryName">pbstrRepositoryName</param>
    /// <param name="pType">pType</param>
    void FindInLocations([In] [MarshalAs(UnmanagedType.BStr)] string bstrFullFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string pbstrRepositoryName, [Out] out LocationTypeEnum pType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="bstrRelativeFileName">bstrRelativeFileName</param>
    /// <param name="bstrLibraryName">bstrLibraryName</param>
    /// <param name="pbstrRepositoryName">pbstrRepositoryName</param>
    /// <param name="pType">pType</param>
    void FindLogicalInLocations([In] [MarshalAs(UnmanagedType.BStr)] string bstrRelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string bstrLibraryName, [Out] [MarshalAs(UnmanagedType.BStr)] out string pbstrRepositoryName, [Out] out LocationTypeEnum pType);
}
