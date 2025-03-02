namespace Oblikovati.API;

/// <summary>
/// The AnalysisManager object provides access to all types of surface analysis in a part document.
/// </summary>
public interface AnalysisManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the DraftAnalyses collection object.
    /// </summary>
    DraftAnalyses DraftAnalyses { get; }
    /// <summary>
    /// Gets/Sets whether the analysis visibility is turned on.
    /// </summary>
    bool IsAnalysisVisible { get; set; }
    /// <summary>
    /// Property that returns the enum indicating the type of the currently active analysis.
    /// </summary>
    AnalysisTypeEnum ActiveAnalysisType { get; }
    /// <summary>
    /// Property that returns the active analysis object.
    /// </summary>
    object ActiveAnalysis { get; }
}
