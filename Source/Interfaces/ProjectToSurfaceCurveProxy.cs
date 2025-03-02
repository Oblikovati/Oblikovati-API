namespace Oblikovati.API;

/// <summary>
/// ProjectToSurfaceCurveProxy Object.
/// </summary>
public interface ProjectToSurfaceCurveProxy
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that defines the surfaces to project sketch curves to. The collection can contain Face and WorkPlane objects.
    /// </summary>
    ObjectCollection Faces { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the sketch curves to project. Valid objects are 2D&3D sketch entities.
    /// </summary>
    ObjectCollection Curves { get; set; }
    /// <summary>
    /// Read-write property that defines the projection type for project to surface curve. Set this from other value to kProjectAlongVectorType will fail, the Edit function can be used to change the ProjectionType and ProjectDirection.
    /// </summary>
    ProjectCurveToSurfaceTypeEnum ProjectionType { get; set; }
    /// <summary>
    /// Read-write property that defines the project direction. The direction is bidirectional. If the ProjectionType is not kProjectAlongVectorType setting this property will fail. If the ProjectionType is kProjectAlongVectorType, set this to Nothing to use the norma.
    /// </summary>
    object ProjectDirection { get; set; }
    /// <summary>
    /// Property that gets and sets name of the project to surface curve. When setting this property, the name must be unique with respect to all other project to surface curves in the document. If the name is not unique an error will occur.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Read-only property that returns a collection of sketch entities that belong to the project to surface curve. The sketch entities returned by this property cannot be edited or deleted because they are associated with the project to surface curve in the model. T.
    /// </summary>
    SketchEntities3DEnumerator SketchEntities { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ProjectToSurfaceCurve NativeObject { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that breaks the link between the project to surface curve and the model. This breaks the associativity to the model, allowing you to edit the individual sketch entities.
    /// </summary>
    [PreserveSig]
    void BreakLink();
    /// <summary>
    /// Method that deletes the project to surface curve. This will delete all of the related sketch entities.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that edits all of the inputs used to compute the project to surface curve. This method is more efficient than setting each of the individual properties since this will result in a single compute rather than computing after each property edit.
    /// </summary>
    /// <param name="Faces">Input ObjectCollection that specifies the faces and/or work planes to project curves to. Valid objects for this argument include Face and WorkPlane.</param>
    /// <param name="Curves">Input ObjectCollection that specifies the curves to project.  This can be one or more 2D/3D sketch entities, the sketch entities need not to be from the same sketch.</param>
    /// <param name="ProjectionType">Optional input ProjectCurveToSufaceTypeEnum that specifies the projection type.  If not specified this argument defaults to kProjectAlongVectorType and the PorjectDirection can be specified, and the Curves can include 2D&3D sketch entities. If kProjectToClosestPointType is specified the Curves can include 2D&3D sketch entities. If kWrapToFaceType is specified, the Faces should be developable faces, otherwise an error would occur. The Curves should include 2D sketch entities only.</param>
    /// <param name="ProjectDirection">Optional input an object to specify the project direction. The direction is bidirectional. This is ignored if the ProjectionType is not specified as kProjectAlongVectorType. If not specified the normal of the sketch of first selected sketch curve is used. Valid objects are:
    /// ·	Linear Edge/WorkAxis, the direction of the edge is used.
    /// ·	Planar Face/WorkPlane, the normal of the face is used.
    /// ·	Cylindrical/conical/elliptical Face, the axis of the face is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ProjectToSurfaceCurve Edit([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Faces, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Curves, [In] [MarshalAs(UnmanagedType.Struct)] object? ProjectionType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ProjectDirection = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
