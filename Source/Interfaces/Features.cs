namespace Oblikovati.API;

/// <summary>
/// Represents the collection of features in the assembly context. The API does not yet support addition of assembly features.
/// </summary>
public interface Features : IEnumerable
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
    /// Returns the specified feature from the collection.
    /// </summary>
    PartFeature Item { get; }
    /// <summary>
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the ChamferFeatures collection object. This collection provides access to existing ChamferFeature objects.
    /// </summary>
    ChamferFeatures ChamferFeatures { get; }
    /// <summary>
    /// Property that returns the collection object. This collection provides access to existing ExtrudeFeature objects.
    /// </summary>
    ExtrudeFeatures ExtrudeFeatures { get; }
    /// <summary>
    /// Property that returns the FilletFeatures collection object. This collection provides access to existing FilletFeature objects.
    /// </summary>
    FilletFeatures FilletFeatures { get; }
    /// <summary>
    /// Property that returns the HoleFeatures collection object. This collection provides access to existing HoleFeature objects.
    /// </summary>
    HoleFeatures HoleFeatures { get; }
    /// <summary>
    /// Property that returns the RevolveFeatures collection object. This collection provides access to existing RevolveFeature objects.
    /// </summary>
    RevolveFeatures RevolveFeatures { get; }
    /// <summary>
    /// Property that returns the SweepFeatures collection object. This collection provides access to existing SweepFeature objects.
    /// </summary>
    SweepFeatures SweepFeatures { get; }
    /// <summary>
    /// Property that returns the RectangularPatternFeatures collection object. This collection provides access to existing RectangularPatternFeature objects.
    /// </summary>
    RectangularPatternFeatures RectangularPatternFeatures { get; }
    /// <summary>
    /// Property that returns the CircularPatternFeatures collection object. This collection provides access to existing CircularPatternFeature objects.
    /// </summary>
    CircularPatternFeatures CircularPatternFeatures { get; }
    /// <summary>
    /// Property that returns the MirrorFeatures collection object. This collection provides access to existing MirrorFeature objects.
    /// </summary>
    MirrorFeatures MirrorFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of features that are SketchDrivenPatterns, allows the creations of new SketchDrivenPatterns.
    /// </summary>
    SketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    /// <summary>
    /// Property that returns the MoveFaceFeatures collection object. This collection provides access to existing MoveFaceFeatures objects.
    /// </summary>
    MoveFaceFeatures MoveFaceFeatures { get; }
    /// <summary>
    /// Gets the Client Features collection object.
    /// </summary>
    ClientFeatures ClientFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FaceOffsetFeatures FaceOffsetFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MidSurfaceFeatures MidSurfaceFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of features that are Threads, allows the creations of new Threads.
    /// </summary>
    ThreadFeatures ThreadFeatures { get; }
    /// <summary>
    /// Gets the collection object that besides listing out the subset of features that are FinishFeatures.
    /// </summary>
    FinishFeatures FinishFeatures { get; }
    /// <summary>
    /// Method that creates a path used to define the shape of several part features such as Sweep, RectangularPattern, Split, etc. All other 2D and 3D curves that are connected to the input curve are obtained and used to create a Path object. The new Path is returned.
    /// </summary>
    /// <param name="SketchCurve">Input sketch (planar or 3D) entity. This can be any entity that is part of the desired path. All curves that are end point connected will be found and used to create the path.</param>
    /// <returns></returns>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.IDispatch)] object SketchCurve);
    /// <summary>
    /// Method that creates a path used to define the shape of several part features such as Sweep, RectangularPattern, Split, etc. The new Path is returned. This method will fail if the input curves are not connected end to end.
    /// </summary>
    /// <param name="SketchCurves">Input (planar or 3D) sketch entities. These are entities that are part of the desired path. The input curves must form a contiguous set.</param>
    /// <returns></returns>
    [PreserveSig]
    Path CreateSpecifiedPath([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchCurves);
}
