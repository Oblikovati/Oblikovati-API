namespace Oblikovati.API;

/// <summary>
/// The DesignProject object represents an Inventor project file (.ipj).
/// </summary>
public interface DesignProject
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the fully qualified file name for this design project.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentCenterConfiguration ContentCenterConfiguration { get; }
    /// <summary>
    /// Gets/Sets the status of the styles library access for the Design Project.
    /// </summary>
    StylesLibraryAccessEnum StylesLibraryAccess { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IntentConfiguration IntentConfiguration { get; }
    /// <summary>
    /// Read-write property that gets and sets the directory in which to look for the Content Center components.&nbsp;If set, this value overrides the corresponding application option.&nbsp;The ContentCenterPathOverridden property returns whether the path is overridden and provides the ability to clear the override.
    /// </summary>
    string ContentCenterPath { get; set; }
    /// <summary>
    /// Gets and sets whether the content center path is overridden by this project.&nbsp;Setting the property to False clears the override and path in the application option is used.
    /// </summary>
    bool ContentCenterPathOverridden { get; set; }
    /// <summary>
    /// Gets and sets the creation time of the project file.
    /// </summary>
    DateTime CreationTime { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the directory in which to look for the Design Data such as styles.&nbsp;If set, this value overrides the corresponding application option.&nbsp;The DesignDataPathOverridden property returns whether the path is overridden and provides the ability to clear the override.
    /// </summary>
    string DesignDataPath { get; set; }
    /// <summary>
    /// Gets and sets whether the design data path is overridden by this project.&nbsp;Setting the property to False clears the override and path in the application option is used.
    /// </summary>
    bool DesignDataPathOverridden { get; set; }
    /// <summary>
    /// Property that returns a ProjectPaths object that contains the list of frequently used paths and provides ability to add/remove paths.
    /// </summary>
    ProjectPaths FrequentlyUsedPaths { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ImportedComponentsFolderName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ImportedTopLevelAssembliesFolderName { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the full file name of another project to include in this project.&nbsp;The search paths in the included file are included in the project. The project type of the included file overrides the setting in the project.&nbsp;The property can be set to a null string to indicate that there are no included projects.
    /// </summary>
    string IncludedProject { get; set; }
    /// <summary>
    /// Property that returns a ProjectPaths object that contains the list of library paths and provides ability to add/remove paths.
    /// </summary>
    ProjectPaths LibraryPaths { get; }
    /// <summary>
    /// Gets and sets the name for this design project.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets the number of versions to store in the OldVersions folder for each file saved. The first time a file is saved.
    /// </summary>
    int OldVersionsToKeep { get; set; }
    /// <summary>
    /// Gets and sets the string identifying the owner of the project.
    /// </summary>
    string Owner { get; set; }
    /// <summary>
    /// Property that returns the parent DesignProjectManager object.
    /// </summary>
    DesignProjectManager Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the project type.&nbsp;Setting the type to shared or semi-isolated requires workgroup(s) to be specified. Setting the type to a Vault project requires a workspace to be specified but no workgroups or included project should be specified.
    /// </summary>
    MultiUserModeEnum ProjectType { get; set; }
    /// <summary>
    /// Gets and sets version of the project.
    /// </summary>
    string ReleaseId { get; set; }
    /// <summary>
    /// Gets and sets an array of strings specifying the shortcuts for the project.
    /// </summary>
    object Shortcuts { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the directory in which to look for the template files.&nbsp;If set, this value overrides the corresponding application option.&nbsp;The TemplatesPathOverridden property returns whether the path is overridden and provides the ability to clear the override.
    /// </summary>
    string TemplatesPath { get; set; }
    /// <summary>
    /// Gets and sets whether the templates path is overridden by this project.&nbsp;Setting the property to False clears the override and path in the application option is used.
    /// </summary>
    bool TemplatesPathOverridden { get; set; }
    /// <summary>
    /// Gets and sets whether duplicate file names are used in the project.
    /// </summary>
    bool UsingUniqueFileNames { get; set; }
    /// <summary>
    /// Gets and sets the vault name.&nbsp;Applicable only if the ProjectType is set to kVaultMode.
    /// </summary>
    string VaultName { get; set; }
    /// <summary>
    /// Gets and sets the publish folder for Vault.&nbsp;Applicable only if the ProjectType is set to kVaultMode.
    /// </summary>
    string VaultPublishPath { get; set; }
    /// <summary>
    /// Gets and sets the vault server.&nbsp;Applicable only if the ProjectType is set to kVaultMode.
    /// </summary>
    string VaultServer { get; set; }
    /// <summary>
    /// Gets and sets the virtual folder for Vault.&nbsp;Applicable only if the ProjectType is set to kVaultMode.
    /// </summary>
    string VaultVirtualPath { get; set; }
    /// <summary>
    /// Property that returns a ProjectPaths object that contains the list of workgroup paths and provides ability to add/remove paths.
    /// </summary>
    ProjectPaths WorkgroupPaths { get; }
    /// <summary>
    /// Gets and sets the workspace folder for the project.
    /// </summary>
    string WorkspacePath { get; set; }
    /// <summary>
    /// Read-only property that returns the currently active appearance library.
    /// </summary>
    ProjectAssetLibrary ActiveAppearanceLibrary { get; }
    /// <summary>
    /// Read-only property that returns the currently active material library.
    /// </summary>
    ProjectAssetLibrary ActiveMaterialLibrary { get; }
    /// <summary>
    /// Read-only property that returns the collection of appearance libraries associated with this project.
    /// </summary>
    ProjectAssetLibraries AppearanceLibraries { get; }
    /// <summary>
    /// Read-only property that returns the collection of material libraries associated with this project.
    /// </summary>
    ProjectAssetLibraries MaterialLibraries { get; }
    /// <summary>
    /// Gets and sets the directory in which to look for the Presets path.&nbsp;If set, this value overrides the corresponding directory.
    /// </summary>
    string PresetsPath { get; set; }
    /// <summary>
    /// Gets and sets whether the presets path is overridden by this project.&nbsp;Setting the property to False clears the override and path in the application option is used.
    /// </summary>
    bool PresetsPathOverridden { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Activate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Save();
    /// <summary>
    /// Method that returns a custom section (in the form of an XML string) from the project file.
    /// </summary>
    /// <param name="Name">Input String that specifies name of the custom section in the project file. If the section with the specified name is not found an error occurs. The following strings can be used to retrieve some of the built-in sections: 'ContentCenterConfig', 'VaultOptions', and 'AutodeskIntent.'</param>
    /// <returns></returns>
    [PreserveSig]
    string GetCustomSection([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Method that returns a custom section (in the form of an XML string) from the included project file.
    /// </summary>
    /// <param name="Name">Input String that specifies name of the custom section in the included project file. If the section with the specified name is not found or there is no included project, a null string is returned. The following strings can be used to retrieve some of the built-in sections: 'ContentCenterConfig', 'VaultOptions', and 'AutodeskIntent'.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetIncludedCustomSection([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Method that removes the DesignProject from the list of available project files. This does not delete the .ipj file on disk. This method fails if the project is currently active.
    /// </summary>
    [PreserveSig]
    void Remove();
    /// <summary>
    /// Method that adds or modifies a custom section (in the form of an XML string) in the project file. If a section with the given name is found, the section is replaced, else the section is added.
    /// </summary>
    /// <param name="Name">Input String that specifies name of the custom section in the project file. The name should be as unique and human-readable as possible. If a section with this name is found, the existing section is replaced with the input CustomSection string. If not found, a new section is created.</param>
    /// <param name="CustomSection">Input String containing an XML string with custom data to be stored in the project file. The name of the section should be included in this XML string, for example 'ApplicationXYZProjectOptions'.</param>
    [PreserveSig]
    void SetCustomSection([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string CustomSection);
    /// <summary>
    /// Method that activates the DesignProject. This requires all the documents to be closed in Oblikovati.
    /// </summary>
    /// <param name="SetAsDefaultProject">Optional input Boolean that specifies whether this project should be set as the default project for the next session of Inventor and Apprentice. If not specified, a value of True is used indicating the this project will be set as the default.</param>
    [PreserveSig]
    void Activate([In] bool? SetAsDefaultProject = true);
}
