namespace Oblikovati.API;

/// <summary>
/// MoldDefinition Object.
/// </summary>
public interface MoldDefinition
{
    /// <summary>
    /// Read-only property that returns the core body of separate result.
    /// </summary>
    SurfaceBody Core { get; }
    /// <summary>
    /// Read-only property that returns the cavity body of separate result.
    /// </summary>
    SurfaceBody Cavity { get; }
    /// <summary>
    /// Read-write property that gets or sets the collection of SurfaceBody objects that represent the various hole patch surfaces.
    /// </summary>
    ObjectCollection HolePatches { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the collection of SurfaceBody objects that represent the various insert solid bodies.
    /// </summary>
    ObjectCollection InsertBodies { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the body that represents the part to analyze.
    /// </summary>
    SurfaceBody PartBody { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the vector that defines the pull direction of the mold.
    /// </summary>
    UnitVector PullDirection { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the set of SurfaceBody objects that represent the various run-off surfaces that define the split.
    /// </summary>
    ObjectCollection RunoffSurfaces { get; set; }
    /// <summary>
    /// Read-write property that defines the maximum gap tolerance size for the analysis.
    /// </summary>
    double Tolerance { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the body that represents the mold blank. This is used to determine the extents of the mold.
    /// </summary>
    SurfaceBody WorkpieceBody { get; set; }
    /// <summary>
    /// Method that generates core body and cavity body. API client then may get the newly generated core/cavity body from Core and Cavity property.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MoldSplitResult Separate();
}
