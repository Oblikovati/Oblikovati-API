namespace Oblikovati.API;

/// <summary>
/// MeshFeatureEntityProxy Object.
/// </summary>
public interface MeshFeatureEntityProxy
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    MeshFeature Parent { get; }
    /// <summary>
    /// Read-only property that returns the coordinate set of the mesh feature entity.
    /// </summary>
    GraphicsCoordinateSet CoordinateSet { get; }
    /// <summary>
    /// Read-only property that returns the coordinate index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet CoordinateIndexSet { get; }
    /// <summary>
    /// Read-only property that returns the color set of the mesh feature entity.
    /// </summary>
    GraphicsColorSet ColorSet { get; }
    /// <summary>
    /// Read-only property that returns the color index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet ColorIndexSet { get; }
    /// <summary>
    /// Read-only property that returns the normal set of the mesh feature entity.
    /// </summary>
    GraphicsNormalSet NormalSet { get; }
    /// <summary>
    /// Read-only property that returns the normal index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet NormalIndexSet { get; }
    /// <summary>
    /// Read-only property that returns the color binding of the mesh feature entity.
    /// </summary>
    ColorBindingEnum ColorBinding { get; }
    /// <summary>
    /// Read-only property that returns the normal binding of the mesh feature entity.
    /// </summary>
    NormalBindingEnum NormalBinding { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    MeshFeatureEntity NativeObject { get; }
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
