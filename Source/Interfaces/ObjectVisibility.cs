namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface ObjectVisibility
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Document object.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Gets and sets whether all work features should be visible.
    /// </summary>
    bool AllWorkFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether construction work surfaces should be visible.
    /// </summary>
    bool ConstructionSurfaces { get; set; }
    /// <summary>
    /// Gets and sets whether group diagnostics should be visible in the construction environment of parts.
    /// </summary>
    bool GroupDiagnostics { get; set; }
    /// <summary>
    /// Gets and sets whether group solids should be visible in the construction environment of parts.
    /// </summary>
    bool GroupSolids { get; set; }
    /// <summary>
    /// Gets and sets whether group surfaces should be visible in the construction environment of parts.
    /// </summary>
    bool GroupSurfaces { get; set; }
    /// <summary>
    /// Gets and sets whether group wires should be visible in the construction environment of parts.
    /// </summary>
    bool GroupWires { get; set; }
    /// <summary>
    /// Gets and sets whether origin work axes should be visible.
    /// </summary>
    bool OriginWorkAxes { get; set; }
    /// <summary>
    /// Gets and sets whether origin work planes should be visible.
    /// </summary>
    bool OriginWorkPlanes { get; set; }
    /// <summary>
    /// Gets and sets whether origin work points should be visible.
    /// </summary>
    bool OriginWorkPoints { get; set; }
    /// <summary>
    /// Gets and sets whether 2d sketches should be visible.
    /// </summary>
    bool Sketches { get; set; }
    /// <summary>
    /// Gets and sets whether 3d sketches should be visible.
    /// </summary>
    bool Sketches3D { get; set; }
    /// <summary>
    /// Gets and sets whether user coordinate system triads should be visible.
    /// </summary>
    bool UCSTriads { get; set; }
    /// <summary>
    /// Gets and sets whether user coordinate system work axes should be visible.
    /// </summary>
    bool UCSWorkAxes { get; set; }
    /// <summary>
    /// Gets and sets whether user coordinate system work planes should be visible.
    /// </summary>
    bool UCSWorkPlanes { get; set; }
    /// <summary>
    /// Gets and sets whether user coordinate system work points should be visible.
    /// </summary>
    bool UCSWorkPoints { get; set; }
    /// <summary>
    /// Gets and sets whether user work axes should be visible.
    /// </summary>
    bool UserWorkAxes { get; set; }
    /// <summary>
    /// Gets and sets whether user work planes should be visible.
    /// </summary>
    bool UserWorkPlanes { get; set; }
    /// <summary>
    /// Gets and sets whether user work points should be visible.
    /// </summary>
    bool UserWorkPoints { get; set; }
    /// <summary>
    /// Gets and sets whether welds should be visible.
    /// </summary>
    bool Welds { get; set; }
    /// <summary>
    /// Gets and sets whether weldment symbols should be visible.
    /// </summary>
    bool WeldmentSymbols { get; set; }
    /// <summary>
    /// Gets and sets whether sketch (2D/3D) dimensions should be visible.
    /// </summary>
    bool SketchDimensions { get; set; }
    /// <summary>
    /// Gets and sets whether 3d annotations should be visible.
    /// </summary>
    bool Annotations3D { get; set; }
    /// <summary>
    /// Gets and sets whether component 3d annotations should be visible.
    /// </summary>
    bool ComponentAnnotations3D { get; set; }
}
