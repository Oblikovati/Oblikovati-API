namespace Oblikovati.API;

/// <summary>
/// The FaceDefinitions collection provides access to exisitng FaceDefinition objects and allows creation of new FaceDefinition objects.
/// </summary>
public interface FaceDefinitions : IEnumerable
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
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    FaceDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new FaceDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <param name="SurfaceGeometry">Input transient geometry object that defines the surface geometry of the face. Valid objects for input are BSplineSurface, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Plane, Sphere, and Torus.</param>
    /// <param name="IsParamReversed">Input Boolean that indicates if the normal of this face is reversed with respect to the geometry.</param>
    /// <returns></returns>
    [PreserveSig]
    FaceDefinition Add([In] [MarshalAs(UnmanagedType.IDispatch)] object SurfaceGeometry, [In] bool IsParamReversed);
}
