namespace Oblikovati.API;

/// <summary>
/// PresentationMeshFeature Object.
/// </summary>
public interface PresentationMeshFeature
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that gets the source of the appearance for the object.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    /// <summary>
    /// Read-only property that gets the appearance of this object.
    /// </summary>
    Asset Appearance { get; }
    /// <summary>
    /// Read-only property that returns the PresentationMeshFeatureEntitiesEnumerator collection object.
    /// </summary>
    PresentationMeshFeatureEntitiesEnumerator Entities { get; }
    /// <summary>
    /// Read-only property that gets the name of the object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationMeshFeatureSet Parent { get; }
    /// <summary>
    /// Read-only property that gets whether this object is suppressed or not.
    /// </summary>
    bool Suppressed { get; }
    /// <summary>
    /// Read-only property that gets the visiblity of this object.
    /// </summary>
    bool Visible { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
