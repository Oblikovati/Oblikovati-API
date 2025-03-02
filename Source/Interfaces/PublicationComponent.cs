namespace Oblikovati.API;

/// <summary>
/// PublicationComponent object.
/// </summary>
public interface PublicationComponent
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Publication Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the referenced DocumentDescriptor.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Read-write property that gets and sets the overridden visibility of the publication component.
    /// </summary>
    bool OverrideVisible { get; set; }
    /// <summary>
    /// Read-only property that gets the publication component name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the parent PublicationComponent object.
    /// </summary>
    PublicationComponent ParentComponent { get; }
    /// <summary>
    /// Read-only property that returns the collection of components for a PublicationComponent object.
    /// </summary>
    PublicationComponentsEnumerator SubComponents { get; }
    /// <summary>
    /// Read-write property that gets and sets the opacity of a publication component.
    /// </summary>
    double OverrideOpacity { get; set; }
    /// <summary>
    /// Read-only property that returns the initial visibility of the publication component.
    /// </summary>
    bool InitialVisible { get; }
    /// <summary>
    /// Read-only property that returns whether the visibility of the publication component is overridden or not.
    /// </summary>
    bool IsVisibleOverridden { get; }
    /// <summary>
    /// Read-only property that returns the range box that represents the bounds of the component.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Read-only property that returns the Matrix object indicating the transform of the component.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Read-only property that returns the Matrix object indicating the transform of the component when it was placed in the publication.
    /// </summary>
    Matrix InitialTransformation { get; }
    /// <summary>
    /// Read-only property that returns the initial opacity of this publication component.
    /// </summary>
    double InitialOpacity { get; }
    /// <summary>
    /// Read-only property that returns all the PublicationBody objects contained within the publication component.
    /// </summary>
    PublicationBodiesEnumerator SurfaceBodies { get; }
    /// <summary>
    /// Read-only property that returns whether this component is leaf component or not.
    /// </summary>
    bool IsLeaf { get; }
    /// <summary>
    /// Read-write property that gets and sets the display mode for this object. property is valid when DisplayModeSourceTypeEnum equals to kOverrideDisplayMode.
    /// </summary>
    DisplayModeEnum DisplayMode { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the display mode source type for this object.
    /// </summary>
    DisplayModeSourceTypeEnum DisplayModeSourceType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the current appearance for this publication component.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the source of the appearance for this publication component.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MeshFeatureSets MeshFeatureSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that clears the visible overrides of the publication component and its sub publication components.
    /// </summary>
    [PreserveSig]
    void ClearVisibleOverrides();
    /// <summary>
    /// Method that gets the publication component tweak transformation in a storyboard at specified time.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix GetTweakTransformationAt([In] [MarshalAs(UnmanagedType.Interface)] Storyboard Storyboard, [In] double Time);
}
