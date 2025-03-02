namespace Oblikovati.API;

/// <summary>
/// PresentationMeshFeatureEntity Object.
/// </summary>
public interface PresentationMeshFeatureEntity
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the coordinate set of the mesh feature entity.
    /// </summary>
    GraphicsCoordinateSet CoordinateSet { get; }
    /// <summary>
    /// Read-only property that returns the coordinate index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet CoordinateIndexSet { get; }
    /// <summary>
    /// Read-only property that returns how the colors are defined for the mesh entity.
    /// </summary>
    ColorBindingEnum ColorBinding { get; }
    /// <summary>
    /// Read-only property that returns the color set of the mesh feature entity.
    /// </summary>
    GraphicsColorSet ColorSet { get; }
    /// <summary>
    /// Read-only property that returns the color index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet ColorIndexSet { get; }
    /// <summary>
    /// Read-only property that returns how the normals are defined for the mesh entity.
    /// </summary>
    NormalBindingEnum NormalBinding { get; }
    /// <summary>
    /// Read-only property that returns the normal set of the mesh feature entity.
    /// </summary>
    GraphicsNormalSet NormalSet { get; }
    /// <summary>
    /// Read-only property that returns the normal index set of the mesh feature entity.
    /// </summary>
    GraphicsIndexSet NormalIndexSet { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationMeshFeature Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
