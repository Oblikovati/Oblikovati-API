namespace Oblikovati.API;

/// <summary>
/// The AssemblyJoints object is a collection that provides access to all of the existing assembly joints in the document and provided access to the functions to create new joints.
/// </summary>
public interface AssemblyJoints : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the specified AssemblyJoint object from the collection.
    /// </summary>
    AssemblyJoint this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new AssemblyJoint. The new created AssemblyJoint is returned.
    /// </summary>
    /// <param name="AssemblyJointDef">Input AssemblyJointDefinition object that defines the assembly joint you want to create.</param>
    /// <returns></returns>
    [PreserveSig]
    AssemblyJoint Add([In] [MarshalAs(UnmanagedType.Interface)] AssemblyJointDefinition AssemblyJointDef);
    /// <summary>
    /// Method that creates a new AssemblyJointDefinition object.
    /// </summary>
    /// <param name="JointType">Input AssemblyJointTypeEnum value that specifies the type of AssemblyJoint.</param>
    /// <param name="OriginOne">Input GeometryIntent object that defines the first origin and origin direction of the connection on an occurrence that being connected with others. Valid geometries for defining the first origin and origin direction are:
    /// Linear edge or sketch line on which the start/mid/end point can be specified as origin. The direction of the linear object defines the origin direction.
    /// Circular/elliptical edge or sketch entity which the center will be used as origin. The normal of the object defines the origin direction.
    /// Cylindrical/conical/elliptical-cylindrical face which the start/mid/end point on the axis of the face can be specified as origin. The axis of the face defines the origin direction.
    /// Toroidal/spherical face which the center will be used as origin. The axis of the toroidal face defines the origin direction.
    /// Planar face that has linear/circular/elliptical edges which the start/mid/end point of linear edge or center of circular/elliptical edge can be specified as origin. The normal of the planar face defines the origin direction.</param>
    /// <param name="OriginTwo">Input GeometryIntent object that defines the second origin and origin direction of the connection on an occurrence that the first occurrence will be connected to.
    /// Refer to OriginOne for the valid geometries for defining the second origin and origin direction.</param>
    /// <returns></returns>
    [PreserveSig]
    AssemblyJointDefinition CreateAssemblyJointDefinition([In] AssemblyJointTypeEnum JointType, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent OriginOne, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent OriginTwo);
}
