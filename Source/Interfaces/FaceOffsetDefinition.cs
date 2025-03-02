namespace Oblikovati.API;

/// <summary>
/// FaceOffset modeling feature Object.
/// </summary>
public interface FaceOffsetDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _AutomaticFaceChain { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _Reverse { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FaceOffsetFeature Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter _Distance { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FaceCollection _InputFaces { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FeatureApproximationTypeEnum _ApproximationType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ApproximationOptimized { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _ApproximationTolerance { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    FaceOffsetDefinition _Copy();
}
