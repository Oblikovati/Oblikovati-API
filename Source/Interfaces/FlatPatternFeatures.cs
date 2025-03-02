namespace Oblikovati.API;

/// <summary>
/// The FlatPatternFeatures object represents a collection of FlatPatternFeature objects.
/// </summary>
public interface FlatPatternFeatures : IEnumerable
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
    /// Returns the specified PartFeature object from the collection. This is limited to the features within the flat pattern.
    /// </summary>
    PartFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of features in the flat pattern.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Inventor::PartFeatures::ChamferFeatures
    /// </summary>
    ChamferFeatures ChamferFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::CornerChamferFeatures
    /// </summary>
    CircularPatternFeatures CircularPatternFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::CornerChamferFeatures
    /// </summary>
    CornerChamferFeatures CornerChamferFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::CornerRoundFeatures
    /// </summary>
    CornerRoundFeatures CornerRoundFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::CutFeatures
    /// </summary>
    CutFeatures CutFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::EmbossFeatures
    /// </summary>
    EmbossFeatures EmbossFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::ExtrudeFeatures
    /// </summary>
    ExtrudeFeatures ExtrudeFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::FilletFeatures
    /// </summary>
    FilletFeatures FilletFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::HoleFeatures
    /// </summary>
    HoleFeatures HoleFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::iFeatures
    /// </summary>
    iFeatures iFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::MirrorFeatures
    /// </summary>
    MirrorFeatures MirrorFeatures { get; }
    /// <summary>
    /// Inventor::SheetMetalFeatures::PunchToolFeatures
    /// </summary>
    PunchToolFeatures PunchToolFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::RectangularPatternFeatures
    /// </summary>
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::RevolveFeatures
    /// </summary>
    RevolveFeatures RevolveFeatures { get; }
    /// <summary>
    /// Inventor::PartFeatures::SweepFeatures
    /// </summary>
    SweepFeatures SweepFeatures { get; }
    /// <summary>
    /// Returns the CosmeticBendFeatures collection object.
    /// </summary>
    CosmeticBendFeatures CosmeticBendFeatures { get; }
    /// <summary>
    /// Gets the ClientFeatures object associated with the flat pattern.
    /// </summary>
    ClientFeatures ClientFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are SketchDrivenPatterns, allows the creations of new SketchDrivenPatterns.
    /// </summary>
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    /// <summary>
    /// Property that returns the MarkFeature collection object. This collection provides access to existing MarkFeature objects and provides functionality to create new MarkFeature objects.
    /// </summary>
    MarkFeatures MarkFeatures { get; }
    /// <summary>
    /// Method that creates a path used to define the shape of several part features such as sweep, rectangular pattern, split, etc. All other 2D and 3D curves that are connected to the input curve are obtained and used to create a Path object. The new Path is returned.
    /// </summary>
    /// <param name="SketchCurve">Input sketch (planar or 3D) entity. This can be any entity that is part of the desired path. All curves that are end point connected will be found and used to create the path.</param>
    /// <returns></returns>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.IDispatch)] object SketchCurve);
}
