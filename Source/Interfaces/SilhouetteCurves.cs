namespace Oblikovati.API;

/// <summary>
/// SilhouetteCurves Collection Object.
/// </summary>
public interface SilhouetteCurves : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    SilhouetteCurve Item { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FacesOrBody">FacesOrBody</param>
    /// <param name="DirectionEntity">DirectionEntity</param>
    /// <param name="IncludeCoincidentSilhouettes">IncludeCoincidentSilhouettes</param>
    [PreserveSig]
    SilhouetteCurve Add([In] [MarshalAs(UnmanagedType.IDispatch)] object FacesOrBody, [In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] bool IncludeCoincidentSilhouettes);
    /// <summary>
    /// Method that creates a silhouette curve.
    /// </summary>
    /// <param name="Body">Input SurfaceBody that defines the surfaces to project the silhouette curve from.</param>
    /// <param name="DirectionEntity">Input entity that defines the direction used to calculate the silhouette curve.  Valid input is a planar face or work plane (the normal of the face or work plane is used), a cylindrical/conical face (the axis is used), a work axis, or a linear edge.</param>
    /// <param name="ExcludedFaces">Optional input FaceCollection that specifies the faces that are excluded in the silhouette curve projection.</param>
    /// <param name="ExcludeStraightFaces">Optional input Boolean that specifies whether to exclude the faces that are perpendicular to the project direction from the silhouette curve projection.</param>
    /// <param name="ExcludeInteralFaces">Optional input Boolean that specifies whether to exclude the internal faces from the silhouette curve projection.</param>
    /// <returns></returns>
    [PreserveSig]
    SilhouetteCurve AddSilhouette([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body, [In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludedFaces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludeStraightFaces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludeInteralFaces = default);
}
