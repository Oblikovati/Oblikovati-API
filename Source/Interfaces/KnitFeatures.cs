namespace Oblikovati.API;

/// <summary>
/// The KnitFeatures object represents a collection of knit features ( objects) on a part. Knit features connect edge-matched surfaces together to create a quilt.
/// </summary>
public interface KnitFeatures : IEnumerable
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
    /// Returns the specified KnitFeature object from the collection. This is the default property of the KnitFeatures collection object.
    /// </summary>
    KnitFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Surfaces">Surfaces</param>
    [PreserveSig]
    KnitFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Surfaces);
    /// <summary>
    /// Method that creates a new knit feature.
    /// </summary>
    /// <param name="Surfaces">Input ObjectCollection that defines the input surfaces for the knit feature. Valid objects for the surfaces are WorkSurface objects and the result solid body obtained from PartComponentDefinition.SurfaceBodies.Item(1).</param>
    /// <param name="MaximumTolerance">Optional Input Double that defines the maximum distance between the edges of two faces before being knit together.  This value is defined in centimeters.</param>
    /// <param name="MaintainAsSurface">Optional input Boolean that specifies if the resulting SurfaceBody should, if closed should continue to be treated as a surface or a solid.  If the result is not closed it will always result in a surface.</param>
    /// <returns></returns>
    [PreserveSig]
    KnitFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Surfaces, [In] double? MaximumTolerance = default, [In] bool? MaintainAsSurface = false);
}
