namespace Oblikovati.API;

/// <summary>
/// ApplicationUtilities Object.
/// </summary>
public interface ApplicationUtilities
{
    /// <summary>
    /// Method that creates a MoldDefinition object that can be used for analyzing and creating core/cavity geometry.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MoldDefinition CreateMoldDefinition([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody PartBody, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody WorkpieceBody, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RunoffSurfaces, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector PullDirection, [In] double? Tolerance = default, [In] [MarshalAs(UnmanagedType.Struct)] object? HolePatches = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Inserts = default);
    /// <summary>
    /// Modifies a surface body by removing the specified holes have been removed.
    /// </summary>
    [PreserveSig]
    void CreateHolePatch([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection HoleEdges, [In] bool PatchSpecifiedHoles);
    /// <summary>
    /// Creates a new body that represents the patch of the defined hole.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateHolePatch2([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection EdgeUseLoop);
    /// <summary>
    /// Creates a new body that represents the patch of the defined hole.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateHolePatch3([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RangeBox">RangeBox</param>
    [PreserveSig]
    RunoffSurfaceDefinition CreateRunoffSurfaceDefinition([In] [MarshalAs(UnmanagedType.Interface)] Box RangeBox);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MoldBlocks">MoldBlocks</param>
    /// <param name="BlockAttributes">BlockAttributes</param>
    /// <param name="CoolingCurves">CoolingCurves</param>
    /// <param name="CoolingAttributes">CoolingAttributes</param>
    /// <param name="RunnerCurves">RunnerCurves</param>
    /// <param name="RunnerAttributes">RunnerAttributes</param>
    /// <param name="FileName">FileName</param>
    [PreserveSig]
    void ExportMoldCoolingAnalysisData([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection MoldBlocks, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection BlockAttributes, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection CoolingCurves, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection CoolingAttributes, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RunnerCurves, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RunnerAttributes, [In] [MarshalAs(UnmanagedType.BStr)] string FileName);
}
