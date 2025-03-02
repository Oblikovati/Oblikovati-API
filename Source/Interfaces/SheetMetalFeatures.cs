namespace Oblikovati.API;

/// <summary>
/// The SheetMetalFeaturesFeatures collection object provides access to all of the SheetMetalFeature objects in a sheet metal component definition.
/// </summary>
public interface SheetMetalFeatures : IEnumerable
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
    /// Returns the specified PartFeature object from the collection. It accesses all of the features regardless of their type. If you increment through the features in the collection they are returned in the same order as they appear in the feature browser.
    /// </summary>
    PartFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    NonParametricBaseFeature NonParametricBaseFeature { get; }
    /// <summary>
    /// Property that returns the ChamferFeatures collection object. This collection provides access to existing ChamferFeature objects and provides functionality to create new ChamferFeature objects.
    /// </summary>
    ChamferFeatures ChamferFeatures { get; }
    /// <summary>
    /// Property that returns the CircularPatternFeatures collection object. This collection provides access to existing CircularPatternFeature objects and provides functionality to create new CircularPatternFeature objects.
    /// </summary>
    CircularPatternFeatures CircularPatternFeatures { get; }
    /// <summary>
    /// Property that returns the CoilFeatures collection object. This collection provides access to existing CoilFeature objects and provides functionality to create new CoilFeature objects.
    /// </summary>
    CoilFeatures CoilFeatures { get; }
    /// <summary>
    /// Property that returns the DecalFeatures collection object. This collection provides access to existing DecalFeature objects.
    /// </summary>
    DecalFeatures DecalFeatures { get; }
    /// <summary>
    /// Property that returns the DeleteFaceFeatures collection object. This collection provides access to existing DeleteFaceFeature objects.
    /// </summary>
    DeleteFaceFeatures DeleteFaceFeatures { get; }
    /// <summary>
    /// Property that returns the EmbossFeatures collection object. This collection provides access to existing EmbossFeature objects.
    /// </summary>
    EmbossFeatures EmbossFeatures { get; }
    /// <summary>
    /// Property that returns the collection object. This collection provides access to existing ExtrudeFeature objects and provides functionality to create new ExtrudeFeature objects.
    /// </summary>
    ExtrudeFeatures ExtrudeFeatures { get; }
    /// <summary>
    /// Property that returns the FaceDraftFeatures collection object. This collection provides access to existing FaceDraftFeature objects.
    /// </summary>
    FaceDraftFeatures FaceDraftFeatures { get; }
    /// <summary>
    /// Property that returns the FilletFeatures collection object. This collection provides access to existing FilletFeature objects and provides functionality to create new FilletFeature objects.
    /// </summary>
    FilletFeatures FilletFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are Freeform features, allows the creations of new Freeform features.
    /// </summary>
    FreeformFeatures FreeformFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are DirectEdit features.
    /// </summary>
    DirectEditFeatures DirectEditFeatures { get; }
    /// <summary>
    /// Property that returns the HoleFeatures collection object. This collection provides access to existing HoleFeature objects and provides functionality to create new HoleFeature objects.
    /// </summary>
    HoleFeatures HoleFeatures { get; }
    /// <summary>
    /// Property that returns the KnitFeatures collection object. This collection provides access to existing KnitFeature objects.
    /// </summary>
    KnitFeatures KnitFeatures { get; }
    /// <summary>
    /// Property that gets the collection object. Besides listing out the subset of part features that are BoundaryPatches, it allows the creation of new BoundaryPatches.
    /// </summary>
    BoundaryPatchFeatures BoundaryPatchFeatures { get; }
    /// <summary>
    /// Property that returns the LoftFeatures collection object. This collection provides access to existing LoftFeature objects and provides functionality to create new LoftFeature objects.
    /// </summary>
    LoftFeatures LoftFeatures { get; }
    /// <summary>
    /// Property that returns the MirrorFeatures collection object. This collection provides access to existing MirrorFeature objects and provides functionality to create new MirrorFeature objects.
    /// </summary>
    MirrorFeatures MirrorFeatures { get; }
    /// <summary>
    /// Property that returns the NonParametericBaseFeatures collection object. This collection provides access to existing NonParametericBaseFeature objects and provides functionality to create new NonParametericBaseFeature objects.
    /// </summary>
    NonParametricBaseFeatures NonParametricBaseFeatures { get; }
    /// <summary>
    /// Property that returns the RectangularPatternFeatures collection object. This collection provides access to existing RectangularPatternFeature objects and provides functionality to create new RectangularPatternFeature objects.
    /// </summary>
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are SketchDrivenPatterns, allows the creations of new SketchDrivenPatterns.
    /// </summary>
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    /// <summary>
    /// Property that returns the ReplaceFaceFeatures collection object. This collection provides access to existing ReplaceFaceFeature objects.
    /// </summary>
    ReplaceFaceFeatures ReplaceFaceFeatures { get; }
    /// <summary>
    /// Property that returns the RevolveFeatures collection object. This collection provides access to existing RevolveFeature objects and provides functionality to create new RevolveFeature objects.
    /// </summary>
    RevolveFeatures RevolveFeatures { get; }
    /// <summary>
    /// Property that returns the RibFeatures collection object. This collection provides access to existing RibFeature objects.
    /// </summary>
    RibFeatures RibFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are RuledSurfaceFeatures.
    /// </summary>
    RuledSurfaceFeatures RuledSurfaceFeatures { get; }
    /// <summary>
    /// Property that returns the ShellFeatures collection object. This collection provides access to existing ShellFeature objects.
    /// </summary>
    ShellFeatures ShellFeatures { get; }
    /// <summary>
    /// Property that returns the SplitFeatures collection object. This collection provides access to existing SplitFeature objects.
    /// </summary>
    SplitFeatures SplitFeatures { get; }
    /// <summary>
    /// Property that returns the SweepFeatures collection object. This collection provides access to existing SweepFeature objects and provides functionality to create new SweepFeature objects.
    /// </summary>
    SweepFeatures SweepFeatures { get; }
    /// <summary>
    /// Property that returns the ThickenFeatures collection object. This collection provides access to existing ThickenFeature objects.
    /// </summary>
    ThickenFeatures ThickenFeatures { get; }
    /// <summary>
    /// Property that returns the ThreadFeatures collection object. This collection provides access to existing ThreadFeature objects and provides functionality to create new ThreadFeature objects.
    /// </summary>
    ThreadFeatures ThreadFeatures { get; }
    /// <summary>
    /// Property that returns the ReferenceFeatures collection object.
    /// </summary>
    ReferenceFeatures ReferenceFeatures { get; }
    /// <summary>
    /// Property that returns the MoveFaceFeatures collection object.
    /// </summary>
    MoveFaceFeatures MoveFaceFeatures { get; }
    /// <summary>
    /// Property that returns the SculptFeatures collection object. This collection provides access to existing SculptFeature objects and provides functionality to create new SculptFeature objects.
    /// </summary>
    SculptFeatures SculptFeatures { get; }
    /// <summary>
    /// Property that returns the TrimFeatures collection object. This collection provides access to existing TrimFeature objects and provides functionality to create new TrimFeature objects.
    /// </summary>
    TrimFeatures TrimFeatures { get; }
    /// <summary>
    /// Property that returns the ExtendFeatures collection object. This collection provides access to existing ExtendFeature objects and provides functionality to create new ExtendFeature objects.
    /// </summary>
    ExtendFeatures ExtendFeatures { get; }
    /// <summary>
    /// Property returning the client features collection object.
    /// </summary>
    ClientFeatures ClientFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are BendPartFeatures, allows the creations of BendPartFeatures.
    /// </summary>
    BendPartFeatures BendPartFeatures { get; }
    /// <summary>
    /// Property that returns the iFeatures collection object.
    /// </summary>
    iFeatures iFeatures { get; }
    /// <summary>
    /// Property that returns the CombineFeatures collection object.
    /// </summary>
    CombineFeatures CombineFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of part features that are Moves, allows the creations of new Moves.
    /// </summary>
    MoveFeatures MoveFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are BossFeatures.
    /// </summary>
    BossFeatures BossFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are GrillFeatures.
    /// </summary>
    GrillFeatures GrillFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are LipFeatures.
    /// </summary>
    LipFeatures LipFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are RestFeatures.
    /// </summary>
    RestFeatures RestFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are RuleFilletFeatures.
    /// </summary>
    RuleFilletFeatures RuleFilletFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are SnapFitFeatures.
    /// </summary>
    SnapFitFeatures SnapFitFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are UnwrapFeatures.
    /// </summary>
    UnwrapFeatures UnwrapFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CoreCavityFeatures CoreCavityFeatures { get; }
    /// <summary>
    /// Returns the AliasFrreeformFeatures collection object.
    /// </summary>
    AliasFreeformFeatures AliasFreeformFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MidSurfaceFeatures MidSurfaceFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FaceOffsetFeatures FaceOffsetFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are MarkFeatures.
    /// </summary>
    MarkFeatures MarkFeatures { get; }
    /// <summary>
    /// Gets the collection object that lists the subset of part features that are FinishFeatures.
    /// </summary>
    FinishFeatures FinishFeatures { get; }
    /// <summary>
    /// Property that returns the CornerFeatures collection object.
    /// </summary>
    CornerFeatures CornerFeatures { get; }
    /// <summary>
    /// Property that returns the BendFeatures collection object. This collection provides access to existing BendFeature objects.
    /// </summary>
    BendFeatures BendFeatures { get; }
    /// <summary>
    /// Property that returns the CutFeatures object.
    /// </summary>
    CutFeatures CutFeatures { get; }
    /// <summary>
    /// Property that returns the HemFeatures collection object. This collection provides access to existing HemFeature objects.
    /// </summary>
    HemFeatures HemFeatures { get; }
    /// <summary>
    /// Property that returns the FoldFeatures collection object. This collection provides access to existing FoldFeature objects.
    /// </summary>
    FoldFeatures FoldFeatures { get; }
    /// <summary>
    /// Property that returns the CornerRoundFeatures collection object.
    /// </summary>
    CornerRoundFeatures CornerRoundFeatures { get; }
    /// <summary>
    /// Property that returns the CornerChamferFeatures collection object.
    /// </summary>
    CornerChamferFeatures CornerChamferFeatures { get; }
    /// <summary>
    /// Property that returns the FaceDraftFeatures collection object. This collection provides access to existing FaceFeature objects.
    /// </summary>
    FaceFeatures FaceFeatures { get; }
    /// <summary>
    /// Property that returns the FlangeFeatures collection object. This collection provides access to existing FlangeFeature objects.
    /// </summary>
    FlangeFeatures FlangeFeatures { get; }
    /// <summary>
    /// Property that returns the CounterFlangeFeatures collection object.
    /// </summary>
    ContourFlangeFeatures ContourFlangeFeatures { get; }
    /// <summary>
    /// Property that returns the PunchToolFeatures collection object.
    /// </summary>
    PunchToolFeatures PunchToolFeatures { get; }
    /// <summary>
    /// Property that returns the RefoldFeatures collection object. This collection provides access to existing RefoldFeature objects and provides functionality to create new RefoldFeature objects.
    /// </summary>
    RefoldFeatures RefoldFeatures { get; }
    /// <summary>
    /// Property that returns the UnfoldFeatures collection object. This collection provides access to existing UnfoldFeature objects and provides functionality to create new UnfoldFeature objects.
    /// </summary>
    UnfoldFeatures UnfoldFeatures { get; }
    /// <summary>
    /// Property that returns the RipFeatures collection object.
    /// </summary>
    RipFeatures RipFeatures { get; }
    /// <summary>
    /// Property that returns the ContourRollFeatures Object.
    /// </summary>
    ContourRollFeatures ContourRollFeatures { get; }
    /// <summary>
    /// Property that returns the LoftedFlangeFeatures collection object.
    /// </summary>
    LoftedFlangeFeatures LoftedFlangeFeatures { get; }
    /// <summary>
    /// Method that creates a path used to define the shape of several part features such as sweep, rectangular pattern, split, etc. All other 2D and 3D curves that are connected to the input curve are obtained and used to create a Path object. The new Path is returned.
    /// </summary>
    /// <param name="SketchCurve">Input sketch (planar or 3D) entity. This can be any entity that is part of the desired path. All curves that are end point connected will be found and used to create the path.</param>
    /// <returns></returns>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.IDispatch)] object SketchCurve);
    /// <summary>
    /// Method that creates a path used to define the shape of several part features such as sweep, rectangular pattern, split, etc. The new path is returned. This method will fail if the input curves are not connected end-to-end.
    /// </summary>
    /// <param name="SketchCurves">Input (planar or 3D) sketch entities. These are entities that are part of the desired path. The input curves must form a contiguous set.</param>
    /// <returns></returns>
    [PreserveSig]
    Path CreateSpecifiedPath([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchCurves);
}
