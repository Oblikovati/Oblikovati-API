namespace Oblikovati.API;

/// <summary>
/// The FileOptions object provides access to properties that provide read and write access of the file related application options.
/// </summary>
public interface FileOptions
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the full filename of the VBA project file.
    /// </summary>
    string DefaultVBAProjectFileFullFilename { get; set; }
    /// <summary>
    /// Gets and sets the location of a new project file.
    /// </summary>
    string ProjectsPath { get; set; }
    /// <summary>
    /// Gets and sets the full filename of the html file.
    /// </summary>
    string TeamWebFullFilename { get; set; }
    /// <summary>
    /// Gets and sets the location of Inventor template files.
    /// </summary>
    string TemplatesPath { get; set; }
    /// <summary>
    /// Gets and sets the location of the temporary file used for transactions.
    /// </summary>
    string UndoPath { get; set; }
    /// <summary>
    /// Gets and sets the location of design data files such as Style files.
    /// </summary>
    string DesignDataPath { get; set; }
    /// <summary>
    /// Gets and sets the location of content center components.
    /// </summary>
    string ContentCenterPath { get; set; }
    /// <summary>
    /// Property that gets the FileOpenOptions object.
    /// </summary>
    FileOpenOptions FileOpenOptions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool QuickFileOpenEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool QuickFileOpenCacheLastAssembly { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string QuickFileOpenCachedAssembly { get; set; }
    /// <summary>
    /// Gets and sets the units for the default template, the options are either inches or millimeters.
    /// </summary>
    bool DefaultTemplateUnitsAreInches { get; set; }
    /// <summary>
    /// Gets and sets the standard for the default template.
    /// </summary>
    DraftingStandardEnum DefaultTemplateDrawingStandard { get; set; }
    /// <summary>
    /// Gets and sets the location of sketch symbol library.
    /// </summary>
    string SymbolLibraryPath { get; set; }
    /// <summary>
    /// Gets and sets the location of texture files.
    /// </summary>
    string TexturePath { get; set; }
    /// <summary>
    /// Gets and sets the location of presets files.
    /// </summary>
    string PresetsPath { get; set; }
    /// <summary>
    /// Gets and sets the location of environment files.
    /// </summary>
    string EnvironmentPath { get; set; }
}
