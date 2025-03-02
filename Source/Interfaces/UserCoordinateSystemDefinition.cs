namespace Oblikovati.API;

/// <summary>
/// The UserCoordinateSystemDefinition object represents the information that defines a coordinate system. You can use this object as input to the UserCoordinateSystems.Add method to create the actual coordinate system.
/// </summary>
public interface UserCoordinateSystemDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns how the inputs for the coordinate system are defined. This can return either kTransformationDefinitionType or kThreePointsDefinitionType.
    /// </summary>
    UCSDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Property that returns the parent UserCoordinateSystem of this definition. In the case where this is a newly created UserCoordinateSystemDefinition object, this property will return Nothing because there is not a logical parent for the object.
    /// </summary>
    UserCoordinateSystem Parent { get; }
    /// <summary>
    /// Gets and puts the transformation matrix.
    /// </summary>
    Matrix Transformation { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Origin">Origin</param>
    /// <param name="XDirectionPoint">XDirectionPoint</param>
    /// <param name="YDirectionPoint">YDirectionPoint</param>
    [PreserveSig]
    void GetByThreePoints([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Origin, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object XDirectionPoint, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object YDirectionPoint);
    /// <summary>
    /// Method that sets the inputs that fully define the coordinate system. This method returns a failure in assembly documents.
    /// </summary>
    /// <param name="Origin">Input object that specifies the origin of the coordinate system. This can be one of the following objects: WorkPoint, Vertex, SketchPoint, SketchPoint3D or Edge. If a linear Edge is specified, it's midpoint is used. If circular or elliptical edges are specified, their center is used.</param>
    /// <param name="XDirectionPoint">Input object that specifies a point defining the x-direction for the coordinate system. The vector from the origin to this point defines the x-direction vector. This can be one of the following objects: WorkPoint, Vertex, SketchPoint, SketchPoint3D or Edge. If a linear Edge is specified, it's midpoint is used. If circular or elliptical edges are specified, their center is used.</param>
    /// <param name="YDirectionPoint">Input object that specifies a point defining the y-direction for the coordinate system. This can be one of the following objects: WorkPoint, Vertex, SketchPoint, SketchPoint3D or Edge. If a linear Edge is specified, it's midpoint is used. If circular or elliptical edges are specified, their center is used.</param>
    [PreserveSig]
    void SetByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object Origin, [In] [MarshalAs(UnmanagedType.IDispatch)] object XDirectionPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object YDirectionPoint);
}
