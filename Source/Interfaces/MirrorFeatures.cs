namespace Oblikovati.API;

/// <summary>
/// The MirrorFeatures object provides access to all of the objects in a component definition and provides methods to create additional MirrorFeature objects.
/// </summary>
public interface MirrorFeatures : IEnumerable
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
    /// Returns the specified MirrorFeature objects from the collection. This is the default property of the MirrorFeatures collection object.
    /// </summary>
    MirrorFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="MirrorPlaneEntity">MirrorPlaneEntity</param>
    /// <param name="AdjustToModel">AdjustToModel</param>
    [PreserveSig]
    MirrorFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object MirrorPlaneEntity, [In] bool? AdjustToModel = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="MirrorPlaneEntity">MirrorPlaneEntity</param>
    /// <param name="RemoveOriginal">RemoveOriginal</param>
    /// <param name="ComputeType">ComputeType</param>
    [PreserveSig]
    MirrorFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object MirrorPlaneEntity, [In] bool? RemoveOriginal = false, [In] PatternComputeTypeEnum? ComputeType = PatternComputeTypeEnum.kOptimizedCompute);
    /// <summary>
    /// Method that creates a new mirror feature.
    /// </summary>
    /// <param name="Definition">Input MirrorFeatureDefinition objet that defines the  MirrorFeature you want to create.</param>
    /// <returns></returns>
    [PreserveSig]
    MirrorFeature AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] MirrorFeatureDefinition Definition);
    /// <summary>
    /// Method that creates a new MirrorFeatureDefinition object.
    /// </summary>
    /// <param name="ParentFeatures">Input ObjectCollection object that contains the features or solids to be patterned. The collection could contain the various part features, sheet metal features, work planes, work axes, work points, or SurfaceBody objects. If SurfaceBody objects are supplied, the only other objects that can be in the collection are work planes, work axes, work points, and surface part features. Finish features such as fillets and chamfers may be included only if their parent feature is also included.</param>
    /// <param name="MirrorPlaneEntity">Input planar entity that defines the mirror plane.  This can be either a planar face or a work plane.</param>
    /// <param name="ComputeType">Optional input enum that indicates the method of solution for the pattern.
    /// <P>If specified as kOptimizedCompute, patterns are optimized for faster calculation.
    /// 
    /// <P>If kIdenticalCompute is specified, all occurrences in the pattern use an identical termination, regardless of where they intersect another feature.  Use this method to efficiently pattern large numbers of features when the feature being duplicated has a distance termination or terminates on a work plane.
    /// <P>If kAdjustToModelCompute is specified, the termination of each occurrence is calculated individually.  Computation time can be lengthy for patterns with a large number of occurrences.  You must use this method if the parent feature terminates on a model face.</param>
    /// <returns></returns>
    [PreserveSig]
    MirrorFeatureDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object MirrorPlaneEntity, [In] PatternComputeTypeEnum? ComputeType = PatternComputeTypeEnum.kOptimizedCompute);
}
