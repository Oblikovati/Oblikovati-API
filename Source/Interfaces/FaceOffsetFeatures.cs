namespace Oblikovati.API;

/// <summary>
/// Part FaceOffset Features Collection Object.
/// </summary>
public interface FaceOffsetFeatures : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FaceOffsetFeature _Item { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="simulationId">simulationId</param>
    /// <param name="Definition">Definition</param>
    [PreserveSig]
    FaceOffsetFeature _Add([In] uint simulationId, [In] [MarshalAs(UnmanagedType.Interface)] FaceOffsetDefinition Definition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Faces">Faces</param>
    /// <param name="Distance">Distance</param>
    /// <param name="Direction">Direction</param>
    /// <param name="AutomaticFaceChain">AutomaticFaceChain</param>
    /// <param name="IsOptimized">IsOptimized</param>
    /// <param name="ApproxTol">ApproxTol</param>
    /// <param name="approxType">approxType</param>
    [PreserveSig]
    FaceOffsetDefinition _CreateFaceOffsetDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Faces, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] bool Direction, [In] bool AutomaticFaceChain, [In] bool IsOptimized, [In] [MarshalAs(UnmanagedType.Struct)] object ApproxTol, [In] FeatureApproximationTypeEnum approxType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    FaceOffsetPreview _GetFaceOffsetPreview();
}
