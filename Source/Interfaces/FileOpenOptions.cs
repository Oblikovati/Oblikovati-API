namespace Oblikovati.API;

/// <summary>
/// The FileOpenOptions object provides access to options affecting the opening of files.
/// </summary>
public interface FileOpenOptions
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LevelOfDetailEnum DefaultLevelOfDetail { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DesignViewTypeEnum DefaultDesignView { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DefaultDesignViewIsAssociative { get; set; }
    /// <summary>
    /// Enables/disables skip all unresolved files during openning in assembly.
    /// </summary>
    bool SkipAllUnresolvedFilesInAssembly { get; set; }
    /// <summary>
    /// Enables/disables skip all unresolved files during openning in part.
    /// </summary>
    bool SkipAllUnresolvedFilesInPart { get; set; }
    /// <summary>
    /// Enables/disables skip all unresolved files during openning in drawing.
    /// </summary>
    bool SkipAllUnresolvedFilesInDrawing { get; set; }
    /// <summary>
    /// Gets and sets whether the default design view representation is associative in assembly documents.
    /// </summary>
    bool DefaultDesignViewIsAssociativeInAssembly { get; set; }
    /// <summary>
    /// Gets and sets whether the default design view representation is associative in part documents.
    /// </summary>
    bool DefaultDesignViewIsAssociativeInPart { get; set; }
    /// <summary>
    /// Gets and sets the default design view representation to use when opening assembly documents.
    /// </summary>
    DesignViewTypeEnum DefaultDesignViewInAssembly { get; set; }
    /// <summary>
    /// Gets and sets the default design view representation to use when opening part documents.
    /// </summary>
    DesignViewTypeEnum DefaultDesignViewInPart { get; set; }
    /// <summary>
    /// Gets and sets the default model state to use when opening assembly documents.
    /// </summary>
    ModelStateTypeEnum DefaultModelStateInAssembly { get; set; }
    /// <summary>
    /// Gets and sets the default model state to use when opening part documents.
    /// </summary>
    ModelStateTypeEnum DefaultModelStateInPart { get; set; }
}
