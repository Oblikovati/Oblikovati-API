namespace Oblikovati.API;

/// <summary>
/// The ModelCompositeAnnotations collection object provides access to all of the annotation groups in a part or assembly.
/// </summary>
public interface ModelCompositeAnnotations : IEnumerable
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
    ModelCompositeAnnotation this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Adds a new ModelCompositeAnnotation object.
    /// </summary>
    /// <param name="Definition">Input ModelCompositeAnnotationDefinition object that specifies the inputs to create a new ModelCompositeAnnotation.</param>
    /// <param name="ClientId">Input String value that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    ModelCompositeAnnotation Add([In] [MarshalAs(UnmanagedType.Interface)] ModelCompositeAnnotationDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
    /// <summary>
    /// Creates a model composite annotation definition.
    /// </summary>
    /// <param name="BaseAnnotation">Input ModelAnnotation object that specifies the base annotation in the ModelCompositeAnnotation. Valid base annotation can be a ModelDimension, ModelFeatureControlFrame, ModelSurfaceTextureSymbol, ModelLeaderNote and ModelHoleThreadNote.</param>
    /// <param name="AnnotationType">Optional input String value that specifies the annotation type of the ModelCompositeAnnotation.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelCompositeAnnotationDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation BaseAnnotation, [In] [MarshalAs(UnmanagedType.Struct)] object? AnnotationType = default);
}
