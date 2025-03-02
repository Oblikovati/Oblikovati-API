namespace Oblikovati.API;

/// <summary>
/// The AnnotationPlaneDefinition object represents the information used to define an annotation plane.  It’s not the actual annotation plane, but only the definition of a plane.
/// </summary>
public interface AnnotationPlaneDefinition
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent annotation plane this definition is associated with.&nbsp;This property can be Nothing in the case the definition was created using either the CreateAnnotationPlaneDefinitionUsingIntents or CreateAnnotationPlaneDefinitionUsingPlane methods of the ModelAnnotations object.
    /// </summary>
    AnnotationPlane Parent { get; }
    /// <summary>
    /// Read-only property returning kAnnotationPlaneDefinitionObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns origin of the annotation plane in model space.
    /// </summary>
    Point Origin { get; }
    /// <summary>
    /// Read-only property that returns the orientation of the x axis of the annotation plane in model space.
    /// </summary>
    Line XAxis { get; }
    /// <summary>
    /// Read-write property that sets and gets the entity that defines the x axis of the annotation plane.
    /// </summary>
    object XAxisEntity { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the rotation of the x-axis in radians against the XAxisEntity. Valid value is in (-Pi, Pi].
    /// </summary>
    double XAxisRotation { get; set; }
    /// <summary>
    /// Read-only property that returns the plane geometry indicating the position and orientation of the annotation plane in model space.
    /// </summary>
    Plane Plane { get; }
    /// <summary>
    /// Read-only property that returns the planar entity the annotation plane is associated with.&nbsp;This property can return Nothing in the case it’s not associated with a planar entity.
    /// </summary>
    object PlanarEntity { get; }
    /// <summary>
    /// Read-only property that returns a matrix indicating the position and orientation of the annotation plane in model space.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Method that takes a 2d coordinate in annotation plane space, and returns a Point3d containing the coordinates of the point in model space.
    /// </summary>
    /// <param name="AnnotationPlaneCoordinate">Input Point2d object defining the 2d coordinate in annotation plane space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point AnnotationPlaneToModel([In] [MarshalAs(UnmanagedType.Interface)] Point2d AnnotationPlaneCoordinate);
    /// <summary>
    /// Method that takes a 3d coordinate in model space, projects it onto the annotation plane along the normal of the plane and returns a Point2d object containing the resulting coordinate point in annotation plane space.
    /// </summary>
    /// <param name="ModelCoordinate">Input Point object defining the 3d coordinate in model space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d ModelToAnnotationPlane([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
    /// <summary>
    /// Method that creates a copy of this AnnotationPlaneDefinition object. The new AnnotationPlaneDefinition object is independent any annotation plane. It can edited and used as input to edit an existing annotation plane or to create a new annotation plane.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    AnnotationPlaneDefinition Copy();
}
