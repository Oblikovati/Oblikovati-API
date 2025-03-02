namespace Oblikovati.API;

/// <summary>
/// The ModelFeatureControlFrames collection object provides access to all the model feature control frame symbols in a part or assembly and provides methods to create additional feature control frames.
/// </summary>
public interface ModelFeatureControlFrames : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelFeatureControlFrame Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MaterialRemovalModifierEnum AvailableModifiers { get; }
    /// <summary>
    /// Method that creates a feature control frame symbol.
    /// </summary>
    /// <param name="Definition">Input ModelFeatureControlFrameDefinition object that defines the feature control frame to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelFeatureControlFrame Add([In] [MarshalAs(UnmanagedType.Interface)] ModelFeatureControlFrameDefinition Definition);
    /// <summary>
    /// Method that creates a feature control frame definition.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that defines the geometry to attach the symbol to.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <param name="LandingPosition">Input Point object that specifies the landing position of the frame.  The point will be projected onto the orientation plane. This can be Nothing in the case where the symbol is attached directly to the object without a leader.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelFeatureControlFrameDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point LandingPosition);
}
