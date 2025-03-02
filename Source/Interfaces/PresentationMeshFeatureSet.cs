namespace Oblikovati.API;

/// <summary>
/// PresentationMeshFeatureSet Object.
/// </summary>
public interface PresentationMeshFeatureSet : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PresentationMeshFeature this[int Index] { get; }
    /// <summary>
    /// Read-only property that gets the name of the object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationComponent Parent { get; }
    /// <summary>
    /// Read-only property that gets whether all of the mesh features within this set are suppressed or not.
    /// </summary>
    MeshFeaturesSuppressionEnum Suppressed { get; }
    /// <summary>
    /// Read-only property that gets whether all of the mesh features within this set are visible.
    /// </summary>
    MeshFeaturesVisibilityEnum Visible { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
