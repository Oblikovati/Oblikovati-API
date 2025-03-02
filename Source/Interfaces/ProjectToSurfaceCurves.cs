namespace Oblikovati.API;

/// <summary>
/// ProjectToSurfaceCurves Object.
/// </summary>
public interface ProjectToSurfaceCurves : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
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
    ProjectToSurfaceCurve this[object Index] { get; }
    /// <summary>
    /// Method that creates a project to surface curve.
    /// </summary>
    /// <param name="Faces">Input ObjectCollection that specifies the faces and/or work planes to project curves to. Valid objects for this argument include Face and WorkPlane.</param>
    /// <param name="Curves">Input ObjectCollection that specifies the curves to project.  This can be one or more 2D/3D sketch entities, the sketch entities need not to be from the same sketch.</param>
    /// <param name="ProjectionType">Optional input ProjectCurveToSufaceTypeEnum that specifies the projection type.
    /// If not specified this argument defaults to kProjectAlongVectorType and the PorjectDirection can be specified, and the Curves can include 2D&3D sketch entities.
    /// If kProjectToClosestPointType is specified the Curves can include 2D&3D sketch entities.
    /// If kWrapToFaceType is specified, the Faces should be developable faces, otherwise an error would occur. The Curves should include 2D sketch entities only.</param>
    /// <param name="ProjectDirection">Optional input an object to specify the project direction. The direction is bidirectional. If not specified the normal of the sketch of first selected sketch entity is used. Valid objects are:
    /// ·	Linear Edge/WorkAxis, the direction of the edge is used.
    /// ·	Planar Face/WorkPlane, the normal of the face is used.
    /// ·	Cylindrical/conical/elliptical Face, the axis of the face is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ProjectToSurfaceCurve Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Faces, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Curves, [In] [MarshalAs(UnmanagedType.Struct)] object? ProjectionType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ProjectDirection = default);
}
