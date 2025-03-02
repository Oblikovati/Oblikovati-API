namespace Oblikovati.API;

/// <summary>
/// PresentationComponent Object.
/// </summary>
public interface PresentationComponent
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that gets and sets the current appearance for this presentation component.
    /// </summary>
    Asset Appearance { get; }
    /// <summary>
    /// Read-only property that gets and sets the source of the appearance for this presentation component. This can be set to kMaterialAppearance to clear the override.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    /// <summary>
    /// Read-only property that returns&nbsp;the presentation component name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationMeshFeatureSet objects contained within the presentation component.
    /// </summary>
    PresentationMeshFeatureSetsEnumerator MeshFeatureSets { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationBody objects contained within the presentation component.
    /// </summary>
    PresentationBodiesEnumerator SurfaceBodies { get; }
    /// <summary>
    /// Read-only property that returns whether this component is leaf component or not.
    /// </summary>
    bool IsLeaf { get; }
    /// <summary>
    /// Read-only property that returns the Matrix object indicating the transform of the component.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Read-only property that gets the opacity of this presentation component.
    /// </summary>
    double Opacity { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationScene Parent { get; }
    /// <summary>
    /// Read-only property that returns the parent PresentationComponent object. This property is only valid for the components in a multi-level assembly that are not in the top level.
    /// </summary>
    PresentationComponent ParentComponent { get; }
    /// <summary>
    /// Read-only property that returns the collection of components for a PresentationComponent object. This property applies to components that represent a.
    /// </summary>
    PresentationComponentsEnumerator SubComponents { get; }
    /// <summary>
    /// Read-only property that gets the visibility of the presentation component.
    /// </summary>
    bool Visible { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
