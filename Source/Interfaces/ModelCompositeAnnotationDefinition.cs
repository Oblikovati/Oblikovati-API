namespace Oblikovati.API;

/// <summary>
/// ModelCompositeAnnotationDefinition Object.
/// </summary>
public interface ModelCompositeAnnotationDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelCompositeAnnotation Parent { get; }
    /// <summary>
    /// Returns the ModelAnnotationsEnumerator collection that contains all the ModelAnnotation objects in the composite annotation.
    /// </summary>
    ModelAnnotationsEnumerator Annotations { get; }
    /// <summary>
    /// Returns the base annotation for the model composite annotation.
    /// </summary>
    ModelAnnotation BaseAnnotation { get; }
    /// <summary>
    /// Adds a new member to the model composite annotation.
    /// </summary>
    /// <param name="ModelAnnotation">Input ModelAnnotation object that specifies the ModelAnnotation to be added to the ModelCompositeAnnotation. A valid ModelAnnotation to be added to this ModelCompositeAnnotation should be directly or indirectly attached to the base annotation of this ModelCompositeAnnotation.</param>
    [PreserveSig]
    void AddAnnotation([In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation ModelAnnotation);
    /// <summary>
    /// Removes a member from the model composite annotation.
    /// </summary>
    /// <param name="ModelAnnotation">Input ModelAnnotation object that specifies the ModelAnnotation to be removed from the ModelCompositeAnnotation. The ModelAnnotation being removed should not be the base annotation.</param>
    [PreserveSig]
    void RemoveAnnotation([In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation ModelAnnotation);
    /// <summary>
    /// Creates a copy of this ModelCompositeAnnotationDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelCompositeAnnotationDefinition Copy();
}
