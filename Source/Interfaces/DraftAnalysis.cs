namespace Oblikovati.API;

/// <summary>
/// The DraftAnalysis object represents an existing draft analysis feature in a part document.
/// </summary>
public interface DraftAnalysis
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent AnalysisManager object.
    /// </summary>
    AnalysisManager Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets the resolution or surface quality for the color gradient or color bands that represent the draft analysis results.
    /// </summary>
    int DisplayQuality { get; set; }
    /// <summary>
    /// Gets/Sets the end angle for the draft analysis.
    /// </summary>
    double EndAngle { get; set; }
    /// <summary>
    /// Gets/Sets the start angle for the draft analysis.
    /// </summary>
    double StartAngle { get; set; }
    /// <summary>
    /// Gets/Sets whether the pull direction of the draft should be reversed.
    /// </summary>
    bool PullDirectionReversed { get; set; }
    /// <summary>
    /// Gets/Sets the object that specifies the direction in which the draft is applied.
    /// </summary>
    object PullDirection { get; set; }
    /// <summary>
    /// Gets/Sets whether the draft analysis results should be displayed as a color gradient.
    /// </summary>
    bool GradientDisplay { get; set; }
    /// <summary>
    /// Gets/Sets the faces for the draft analysis.
    /// </summary>
    ObjectCollection Faces { get; set; }
    /// <summary>
    /// Gets and sets the name of the draft analysis.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Method that creates a copy of the draft analysis.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DraftAnalysis Copy();
    /// <summary>
    /// Method that deletes the draft analysis.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that activates the draft analysis.
    /// </summary>
    [PreserveSig]
    void Activate();
}
