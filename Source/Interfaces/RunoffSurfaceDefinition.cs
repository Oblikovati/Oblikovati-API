namespace Oblikovati.API;

/// <summary>
/// This object represents a runoff surface definition.
/// </summary>
public interface RunoffSurfaceDefinition
{
    /// <summary>
    /// Method that adds an extrusion type of runoff surface to this runoff surface definition.
    /// </summary>
    /// <param name="EdgeUses">Input ObjectCollection of EdgeUse objects that define the curve(s) to use to create the runoff extrusion. The object collection can contain one or more EdgeUse objects.</param>
    /// <param name="Direction">Input UnitVector that defines the direction of the extrusion. The length of the extrusion is defined by the range box associated with the RunoffSurfaceDefinition.</param>
    /// <returns></returns>
    [PreserveSig]
    int AddExtrusionPiece([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection EdgeUses, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction);
    /// <summary>
    /// Method that adds an extrusion type of runoff surface to this runoff surface definition.
    /// </summary>
    /// <param name="EdgeUse">Input EdgeUse object that defines the curve to use to create the radiate runoff piece.</param>
    /// <param name="RulingPoints">Input ObjectCollection of Point objects. These are points along the input edge where you want to define a ruling condition. For each point in this collection there must be a matching vector supplied in the RulingVectors argument.</param>
    /// <param name="RulingVectors">Input ObjectCollection of UnitVector objects. These are vectors that define the radiate direction. These vectors match up with the ruling points to define a position along the curve and a direction for the ruling. This collection must contain the same number of vectors as there are points in the ObjectCollection supplied for the RulingPoints argument.</param>
    /// <returns></returns>
    [PreserveSig]
    int AddRadiatePiece([In] [MarshalAs(UnmanagedType.IDispatch)] object EdgeUse, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RulingPoints, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection RulingVectors);
    /// <summary>
    /// Method that creates a runoff piece by extending the face attached to the input EdgeUse object.
    /// </summary>
    /// <param name="EdgeUse">Input EdgeUse object that defines the surface to extend.</param>
    /// <returns></returns>
    [PreserveSig]
    int AddSurfaceExtensionPiece([In] [MarshalAs(UnmanagedType.IDispatch)] object EdgeUse);
    /// <summary>
    /// Method that adds a planar patch to fill in a corner of the runoff surface.
    /// </summary>
    /// <param name="Corner">Input Vertex object that defines the corner of the open area of the runoff surface that you want to generate a patch to fill.</param>
    /// <param name="StartVector">Input UnitVector that defines the start edge of the corner patch.</param>
    /// <param name="EndVector">Input UnitVector that defines the end edge of the corner patch.</param>
    /// <returns></returns>
    [PreserveSig]
    int AddCornerPiece([In] [MarshalAs(UnmanagedType.Interface)] Vertex Corner, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector StartVector, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector EndVector);
    /// <summary>
    /// Method that creates the runoff surface for a single piece of the runoff definition.
    /// </summary>
    /// <param name="Index">Input Long that specifies the index of the runoff piece you want to create. This is the index that was returned by the call to the AddExtrusionPiece, AddRadiatePiece, AddSurfaceExtensionPiece, or AddCornerPiece method.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateSingleRunoffPiece([In] int Index);
    /// <summary>
    /// Method that creates the runoff surface for all of the pieces defined in the RunoffSurfaceDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SurfaceBody CreateRunoff();
    /// <summary>
    /// Adds a runoff surface by tangentially extending the face attached to the input EdgeUse object.&nbsp;This method returns the index identifying this piece of the runoff.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    int AddTangentExtensionPiece([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection EdgeUses);
}
