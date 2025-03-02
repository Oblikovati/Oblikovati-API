namespace Oblikovati.API;

/// <summary>
/// Please Note =========================================================== While this object is still accessible, it is now hidden by default. Please use the Design Project APIs instead (see sample code below). Object that provides access to the current, active Project being used by Autodesk Inventor. A Project is an organization of 'file locations.'
/// </summary>
public interface FileLocations
{
    /// <summary>
    /// Gets/Sets the Workspace directory for the Project.
    /// </summary>
    string Workspace { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _WorkspaceActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _LocalsActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _WorkgroupsActive { get; set; }
    /// <summary>
    /// Gets/Sets the directory in which to look for the Project Files that can be used in Inventor sessions.
    /// </summary>
    string FileLocationsFilesDir { get; set; }
    /// <summary>
    /// Gets/Sets the currently active Project File.
    /// </summary>
    string FileLocationsFile { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _CurrentSettingsDirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _Dirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ContentCenterPath { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string TemplatesPath { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DesignDataPath { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string PresetsPath { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumLocals">NumLocals</param>
    /// <param name="Names">Names</param>
    /// <param name="Paths">Paths</param>
    [PreserveSig]
    void _Locals([Out] out int NumLocals, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Names, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Paths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    [PreserveSig]
    void _RemoveLocal([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="Path">Path</param>
    /// <param name="Index">Index</param>
    [PreserveSig]
    void _AddLocal([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Path, [In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumWorkGroups">NumWorkGroups</param>
    /// <param name="Names">Names</param>
    /// <param name="Paths">Paths</param>
    [PreserveSig]
    void Workgroups([Out] out int NumWorkGroups, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Names, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Paths);
    /// <summary>
    /// Method that removes a given Workgroup path, given its name.
    /// </summary>
    /// <param name="Name">Input String that specifies the Workgroup's name.</param>
    [PreserveSig]
    void RemoveWorkgroup([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Adds a given Workgroup path with its name at a specific position in the list.
    /// </summary>
    /// <param name="Name">Input String that specifies the work group path name.</param>
    /// <param name="Path">Input String that specifies the work group path to add.</param>
    /// <param name="Index">Input Long value that specifies the position in which to add the work group path name.</param>
    [PreserveSig]
    void AddWorkgroup([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Path, [In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumLibraries">NumLibraries</param>
    /// <param name="Names">Names</param>
    /// <param name="Paths">Paths</param>
    [PreserveSig]
    void Libraries([Out] out int NumLibraries, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Names, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Paths);
    /// <summary>
    /// Method that removes a given Library path, given its name.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the library.</param>
    [PreserveSig]
    void RemoveLibrary([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Adds a given library path with its name at a specific position in the list.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the library.</param>
    /// <param name="Path">Input String that specifies the library path to add.</param>
    [PreserveSig]
    void AddLibrary([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Path);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryName">LibraryName</param>
    [PreserveSig]
    string _GetLibraryVault([In] [MarshalAs(UnmanagedType.BStr)] string LibraryName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="VaultPath">VaultPath</param>
    [PreserveSig]
    void _SetLibraryVault([In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [In] [MarshalAs(UnmanagedType.BStr)] string VaultPath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _ApplyCurrentSettings();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Save();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LocationsFile">LocationsFile</param>
    [PreserveSig]
    void _SaveAs([In] [MarshalAs(UnmanagedType.BStr)] string LocationsFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="RepositoryName">RepositoryName</param>
    /// <param name="Type">Type</param>
    [PreserveSig]
    void FindInLocations([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RepositoryName, [Out] out LocationTypeEnum Type);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="RepositoryName">RepositoryName</param>
    /// <param name="Type">Type</param>
    [PreserveSig]
    void FindLogicalInLocations([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RepositoryName, [Out] out LocationTypeEnum Type);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumProjectFiles">NumProjectFiles</param>
    /// <param name="ProjectFileNamePaths">ProjectFileNamePaths</param>
    [PreserveSig]
    void ProjectFiles([Out] out int NumProjectFiles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] ProjectFileNamePaths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VaultServer">VaultServer</param>
    /// <param name="VaultName">VaultName</param>
    /// <param name="VaultProject">VaultProject</param>
    /// <param name="StreamlineWatchFolder">StreamlineWatchFolder</param>
    [PreserveSig]
    void GetVaultData([Out] [MarshalAs(UnmanagedType.BStr)] out string VaultServer, [Out] [MarshalAs(UnmanagedType.BStr)] out string VaultName, [Out] [MarshalAs(UnmanagedType.BStr)] out string VaultProject, [Out] [MarshalAs(UnmanagedType.BStr)] out string StreamlineWatchFolder);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VaultServer">VaultServer</param>
    /// <param name="VaultName">VaultName</param>
    /// <param name="VaultProject">VaultProject</param>
    /// <param name="StreamlineWatchFolder">StreamlineWatchFolder</param>
    [PreserveSig]
    void SetVaultData([In] [MarshalAs(UnmanagedType.BStr)] string VaultServer, [In] [MarshalAs(UnmanagedType.BStr)] string VaultName, [In] [MarshalAs(UnmanagedType.BStr)] string VaultProject, [In] [MarshalAs(UnmanagedType.BStr)] string StreamlineWatchFolder);
}
