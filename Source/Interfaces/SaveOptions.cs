namespace Oblikovati.API;

/// <summary>
/// The SaveOptions object provides access to properties that provide read and write access of the save related application options. This is somewhat equivalent to the Save tab of the Application Options dialog.
/// </summary>
public interface SaveOptions
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool PromptSaveForRecomputableChanges { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has been migrated from a previous version of Autodesk Inventor is closed without being explicitly saved.
    /// </summary>
    bool PromptSaveForMigration { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has been migrated from a previous version of Autodesk Inventor is closed without being explicitly saved.
    /// </summary>
    bool DefaultToSaveForMigration { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has user edits.
    /// </summary>
    bool PromptSaveForUserEdits { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has user edits.
    /// </summary>
    bool DefaultToSaveForUserEdits { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has API changes.
    /// </summary>
    bool PromptSaveForAPIChanges { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has API changes.
    /// </summary>
    bool DefaultToSaveForAPIChanges { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has manual updates.
    /// </summary>
    bool PromptSaveForManualUpdates { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has manual updates.
    /// </summary>
    bool DefaultToSaveForManualUpdates { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has file resolution change.
    /// </summary>
    bool PromptSaveForFileResolutionChange { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has file resolution change.
    /// </summary>
    bool DefaultToSaveForFileResolutionChange { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has mass property update.
    /// </summary>
    bool PromptSaveForMassPropertyUpdate { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has mass property update.
    /// </summary>
    bool DefaultToSaveForMassPropertyUpdate { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has implicit update.
    /// </summary>
    bool PromptSaveForImplicitUpdate { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has implicit update.
    /// </summary>
    bool DefaultToSaveForImplicitUpdate { get; set; }
    /// <summary>
    /// Gets/Sets whether to save the files in library folders or not.
    /// </summary>
    bool SaveFilesInLibraryFolders { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ListReferencedFilesInSaveDialog { get; set; }
    /// <summary>
    /// Gets/Sets the save reminder timer (in minutes).
    /// </summary>
    double SaveReminderTimer { get; set; }
    /// <summary>
    /// Gets/Sets whether to display a save reminder to the user.
    /// </summary>
    bool ShowSaveReminder { get; set; }
    /// <summary>
    /// Gets/Sets whether to create a tranlation report and where to save it.
    /// </summary>
    ReportLocationEnum TranslatorReportLocation { get; set; }
    /// <summary>
    /// Gets/Sets whether a prompt to save the document should be displayed when a document that has model state updates.
    /// </summary>
    bool PromptSaveForModelStateUpdates { get; set; }
    /// <summary>
    /// Gets/Sets the default save condition for a document that has model state updates.
    /// </summary>
    bool DefaultToSaveForModelStateUpdates { get; set; }
}
