namespace Oblikovati.API;

/// <summary>
/// The SketchSettings object provides access to properties that provide read and write access to the various sketch related document specific settings. This is somewhat equivalent to the Sketch tab of the Document Settings dialog.
/// </summary>
public interface SketchSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Document object.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the number of minor lines to appear between major lines.
    /// </summary>
    int MinorLinesPerMajorGridLine { get; set; }
    /// <summary>
    /// Gets and sets the distance between minor grid lines relative to the specified snap distance.
    /// </summary>
    int SnapsPerMinorGrid { get; set; }
    /// <summary>
    /// Gets and sets the spacing between snap points for the X axis.
    /// </summary>
    string XSnapSpacing { get; set; }
    /// <summary>
    /// Gets and sets the spacing between snap points for the Y axis.
    /// </summary>
    string YSnapSpacing { get; set; }
    /// <summary>
    /// Gets and sets the display of unique line weights.
    /// </summary>
    bool DisplayLineWeights { get; set; }
    /// <summary>
    /// Gets and sets the type of line weight to apply when displaying lines.
    /// </summary>
    LineWeightTypeEnum LineWeightType { get; set; }
    /// <summary>
    /// Gets and sets the upper limit for the first range of line weights.
    /// </summary>
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    /// <summary>
    /// Gets and sets the upper limit for the second range of line weights.
    /// </summary>
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    /// <summary>
    /// Gets and sets the upper limit for the third range of line weights.
    /// </summary>
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
}
