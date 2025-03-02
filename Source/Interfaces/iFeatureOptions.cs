namespace Oblikovati.API;

/// <summary>
/// The iFeatureOptions object provides access to properties that provide read and write access of the iFeature related application options. This is somewhat equivalent to the iFeature tab of the Application Options dialog.
/// </summary>
public interface iFeatureOptions
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
    /// Gets/Sets the location of iFeature files used by the View Catalog dialog box.
    /// </summary>
    string RootPath { get; set; }
    /// <summary>
    /// Gets/Sets the location of iFeature files used by both the Create iFeature and Insert iFeature dialog boxes.
    /// </summary>
    string UserRootPath { get; set; }
    /// <summary>
    /// Gets/Sets the location of iFeature files used by the sheet metal Punch Tool dialog box.
    /// </summary>
    string SheetMetalPunchesRootPath { get; set; }
    /// <summary>
    /// Gets/sets the viewer application used to manage the iFeature files.
    /// </summary>
    string Viewer { get; set; }
    /// <summary>
    /// Gets/Sets the viewer command line arguments for run-time options.
    /// </summary>
    string ViewerArguments { get; set; }
    /// <summary>
    /// Gets/Sets whether to use the Key 1 column of a table-driven iFeature as the Browser Name column.
    /// </summary>
    bool UseKey1AsBrowserNameColumn { get; set; }
}
