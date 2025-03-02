namespace Oblikovati.API;

/// <summary>
/// The DrawingOptions object provides access to properties that provide read and write access of the drawing related application options. This is somewhat equivalent to the Drawing tab of the Application Options dialog.
/// </summary>
public interface DrawingOptions
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
    /// Gets/Sets the display of unique line weights in drawings.
    /// </summary>
    bool DisplayLineWeights { get; set; }
    /// <summary>
    /// Gets/Sets the dimension text is to be centered when adding dimensions to drawing views.
    /// </summary>
    bool CenterDimensionText { get; set; }
    /// <summary>
    /// Gets/Sets the type of dimensioning to use while placing arc dimensions on drawing sheets.
    /// </summary>
    ArcDimensionTypeEnum ArcDimensionType { get; set; }
    /// <summary>
    /// Gets/Sets the type of dimensioning to use while placing circle dimensions on drawing sheets.
    /// </summary>
    CircleDimensionTypeEnum CircleDimensionType { get; set; }
    /// <summary>
    /// Gets/Sets the type of line weight to apply when displaying lines in the drawing.
    /// </summary>
    LineWeightTypeEnum LineWeightType { get; set; }
    /// <summary>
    /// Gets/Sets the default for the dimensions option in the create view dialog boxes.
    /// </summary>
    bool GetModelDimensions { get; set; }
    /// <summary>
    /// Gets/Sets the type of dimensioning to use while placing linear dimensions on drawing sheets.
    /// </summary>
    LinearDimensionTypeEnum LinearDimensionType { get; set; }
    /// <summary>
    /// Gets/Sets the sectioning behavior for standard parts when section views are created in the drawing.
    /// </summary>
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    /// <summary>
    /// Gets/Sets the default title block location.
    /// </summary>
    TitleBlockAlignmentEnum TitleBlockAlignment { get; set; }
    /// <summary>
    /// Gets/Sets the upper limit for the first range of line weights.
    /// </summary>
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    /// <summary>
    /// Gets/Sets the upper limit for the second range of line weights.
    /// </summary>
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    /// <summary>
    /// Gets/Sets the upper limit for the third range of line weights.
    /// </summary>
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
    /// <summary>
    /// Gets/Sets the default drawing view justification.
    /// </summary>
    ViewJustificationEnum ViewJustification { get; set; }
    /// <summary>
    /// Gets/Sets the default file type (.idw or .dwg) to use when creating new drawings.
    /// </summary>
    DefaultDrawingFileTypeEnum DefaultDrawingFileType { get; set; }
    /// <summary>
    /// Gets/Sets the default style to use for drawing layers.
    /// </summary>
    DefaultLayerStyleEnum DefaultLayerStyle { get; set; }
    /// <summary>
    /// Gets/Sets the default file open behavior for non-Inventor DWG files.
    /// </summary>
    DefaultNonInventorDWGFileOpenBehaviorEnum DefaultNonInventorDWGFileOpenBehavior { get; set; }
    /// <summary>
    /// Gets/Sets the default style to use for drawing objects.
    /// </summary>
    DefaultObjectStyleEnum DefaultObjectStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MemorySavingMode { get; set; }
    /// <summary>
    /// Gets/Sets the section view previews should be displayed in uncut mode.
    /// </summary>
    bool ShowUncutSectionViewPreview { get; set; }
    /// <summary>
    /// Gets/Sets the preview type for drawing views.
    /// </summary>
    ViewPreviewTypeEnum ViewPreview { get; set; }
    /// <summary>
    /// Gets/Sets the selection of drawing geometry when creating ordinate dimensions.
    /// </summary>
    bool EnableOrdinateDimGeomSelection { get; set; }
    /// <summary>
    /// Gets/Sets whether the edit dimension dialog should be shown when a dimension is created using the 'General Dimension' command.
    /// </summary>
    bool EditDimensionWhenCreated { get; set; }
    /// <summary>
    /// Gets/Sets the AutoCAD DWG version for Inventor DWG files.
    /// </summary>
    DWGFileVersionEnum InventorDWGFileVersion { get; set; }
    /// <summary>
    /// Gets/Sets default insertion point for a view block.
    /// </summary>
    ViewBlockInsertionPointEnum ViewBlockInsertionPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SkipAllUnresolvedFiles { get; set; }
    /// <summary>
    /// Gets/Sets whether drawing views are computed as a background process or not.
    /// </summary>
    bool EnableBackgroundUpdates { get; set; }
    /// <summary>
    /// Enables/disables part modification from within a drawings.
    /// </summary>
    bool EnablePartModificationFromDrawing { get; set; }
}
