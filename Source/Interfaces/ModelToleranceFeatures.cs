namespace Oblikovati.API;

/// <summary>
/// ModelToleranceFeatures Object.
/// </summary>
public interface ModelToleranceFeatures : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelToleranceFeature this[object Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Definition">Definition</param>
    /// <param name="ClientId">ClientId</param>
    [PreserveSig]
    ModelToleranceFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeatureDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Definition">Definition</param>
    /// <param name="__MIDL__ModelToleranceFeatures0000">__MIDL__ModelToleranceFeatures0000</param>
    /// <param name="ClientId">ClientId</param>
    [PreserveSig]
    ModelToleranceFeature Rebuild([In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeatureDefinition Definition, [In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeature __MIDL__ModelToleranceFeatures0000, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FeatureType">FeatureType</param>
    /// <param name="Faces">Faces</param>
    [PreserveSig]
    ModelToleranceFeatureDefinition CreateDefinition([In] ModelToleranceFeatureTypeEnum FeatureType, [In] [MarshalAs(UnmanagedType.Struct)] object? Faces = default);
    /// <summary>
    /// Gets the model tolerance feature that consumes the face.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelToleranceFeature GetToleranceFeatureFromFace([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Updates the status face coloring if it is switched on.
    /// </summary>
    [PreserveSig]
    void UpdateStatusVisualization();
    /// <summary>
    /// Creates the status face coloring.
    /// </summary>
    [PreserveSig]
    void CreateStatusVisualization();
    /// <summary>
    /// Removes the status face coloring if it is switched on.
    /// </summary>
    [PreserveSig]
    void RemoveStatusVisualization();
    /// <summary>
    /// Indicates whether the status face coloring is switched on.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool StatusVisualized();
}
