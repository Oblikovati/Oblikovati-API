namespace Oblikovati.API;

/// <summary>
/// AnnotationPlaneProxy Object.
/// </summary>
public interface AnnotationPlaneProxy
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
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-only property that returns the parent component definition of the object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Read-only property returning kAnnotationPlaneObject indicating this objects type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the annotation plane definition object associated with this annotation plane.
    /// </summary>
    AnnotationPlaneDefinition Definition { get; }
    /// <summary>
    /// Read-only property that returns the annotations associated with this annotation plane.
    /// </summary>
    ModelAnnotationsEnumerator Annotations { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    AnnotationPlane NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
