namespace Oblikovati.API;

/// <summary>
/// MeshFeatureProxy Object.
/// </summary>
public interface MeshFeatureProxy
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
    /// Mesh Feature Name.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-only property that returns the Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Read-only property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    MeshFeatureSet Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the visiblity of this object.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the whether this object is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Read-only property that returns the MeshFeatureEntitiesEnumerator collection object.
    /// </summary>
    MeshFeatureEntitiesEnumerator Entities { get; }
    /// <summary>
    /// Read-write property that gets and sets the appearance of this object.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the source of the appearance for the object.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Read-only property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle RenderStyle { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    MeshFeature NativeObject { get; }
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
    /// <summary>
    /// Method that deletes this object.
    /// </summary>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies if dependent features and sketches should be deleted. If there are no dependent features this argument is ignored.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
}
