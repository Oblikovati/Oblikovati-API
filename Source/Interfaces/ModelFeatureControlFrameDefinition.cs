namespace Oblikovati.API;

/// <summary>
/// ModelFeatureControlFrameDefinition Object.
/// </summary>
public interface ModelFeatureControlFrameDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelFeatureControlFrame Parent { get; }
    /// <summary>
    /// Gets and sets the annotation plane for the feature control frame.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Gets and sets the annotation plane definition for the feature control frame.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Gets the ModelFeatureControlFrameRows object associated with this definition.
    /// </summary>
    ModelFeatureControlFrameRows FeatureControlFrameRows { get; }
    /// <summary>
    /// Gets and sets the geometric entity the note is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Gets and sets the landing position of the note in the part or assembly.
    /// </summary>
    Point LandingPosition { get; set; }
    /// <summary>
    /// Gets and sets the position of the frame in the part or assembly. The point is projected onto the orientation plane first and then projected onto the landing line to locate the text.
    /// </summary>
    Point TextPosition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllAround { get; set; }
    /// <summary>
    /// Gets and sets the profile type for the feature control frame.
    /// </summary>
    FeatureControlFrameProfileTypeEnum ProfileType { get; set; }
    /// <summary>
    /// Gets and sets any notes associated with this feature control frame.
    /// </summary>
    string Notes { get; set; }
    /// <summary>
    /// Gets and sets the type of the arrowhead.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Gets and sets top notes associated with this feature control frame.
    /// </summary>
    string TopNotes { get; set; }
    /// <summary>
    /// Gets whether the OverrideMergeSymbol is set to override the MergeSymbol setting in FeatureControlFrameStyle. Set this to False will clear the override setting.
    /// </summary>
    bool MergeSymbolOverridden { get; set; }
    /// <summary>
    /// Gets and sets the merge symbol override value. Set this property will set the MergeSymbolOverridden to True.
    /// </summary>
    bool OverrideMergeSymbol { get; set; }
    /// <summary>
    /// Gets the absolute rotation angle of the symbol in radians. The value can either be positive (counter-clockwise rotation) or negative (clockwise rotation).
    /// </summary>
    double Rotation { get; }
    /// <summary>
    /// Read-only property that returns the leader associated with the feature control frame.
    /// </summary>
    ModelLeader Leader { get; }
    /// <summary>
    /// Method that creates a copy of this LinearModelDimensionDefinition object. The new LinearModelDimensionDefinition object is independent of any dimension. It can edited and used as input to edit an existing dimension or to create a new dimension.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelFeatureControlFrameDefinition Copy();
}
