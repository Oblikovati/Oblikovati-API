namespace Oblikovati.API;

/// <summary>
/// The AssemblyJointDefinition is not an assembly joint but is an object that contains all of the information that defines an assembly joint. It is used to create new joints and to edit existing joints.
/// </summary>
public interface AssemblyJointDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the type of AssemblyJoint.
    /// </summary>
    AssemblyJointTypeEnum JointType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the first origin associated with the assembly joint object.
    /// </summary>
    GeometryIntent OriginOne { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the second origin associated with the assembly joint object.
    /// </summary>
    GeometryIntent OriginTwo { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether flip the origin direction defined by OriginOne.
    /// </summary>
    bool FlipOriginDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether flip the alignment direction defined by AlignmentOne.
    /// </summary>
    bool FlipAlignmentDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the translation between the first and second origins along the Z-axis.
    /// </summary>
    object Gap { get; set; }
    /// <summary>
    /// Read-only property that returns the parent AssemblyJoint object. This returns Nothing when the AssemblyJointDefinition is not associated with an AssemblyJoint object.
    /// </summary>
    AssemblyJoint Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the linear position of the first occurrence relative to the second occurrence that the assembly joint object.
    /// </summary>
    object LinearPosition { get; set; }
    /// <summary>
    /// Read-write property that indicates if the assembly joint has linear position end limit that the linear position value should not exceed to be valid.
    /// </summary>
    bool HasLinearPositionEndLimit { get; set; }
    /// <summary>
    /// Read-write property that indicates if the assembly joint has linear position start limit that the linear position value should not be less than it to be valid.
    /// </summary>
    bool HasLinearPositionStartLimit { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the linear position end limit for the assembly joint object.
    /// </summary>
    object LinearPositionEndLimit { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the linear position start limit for the assembly joint object.
    /// </summary>
    object LinearPositionStartLimit { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the angular position around the origin direction of the first occurrence the assembly joint object is between with.
    /// </summary>
    object AngularPosition { get; set; }
    /// <summary>
    /// Read-write property that indicates if the assembly joint has angular position start and end limits that the angular position value should not exceed to be valid.
    /// </summary>
    bool HasAngularPositionLimits { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the angular position end limit for the assembly joint object.
    /// </summary>
    object AngularPositionEndLimit { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the angular position start limit for the assembly joint object.
    /// </summary>
    object AngularPositionStartLimit { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the geometry object that defines the first alignment for the assembly joint.
    /// </summary>
    object AlignmentOne { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometry object that defines the alignment for the second component.
    /// </summary>
    object AlignmentTwo { get; set; }
    /// <summary>
    /// Read-only property that returns the definition type of the first joint origin.
    /// </summary>
    AssemblyJointOriginDefinitionTypeEnum OriginOneDefinitionType { get; }
    /// <summary>
    /// Read-only property that returns the offset of the OriginOne along origin X-axis direction. This returns Empty if the OriginOneDefinitonType is not equal to kOffsetOriginDefinitionType.
    /// </summary>
    object OriginOneXOffset { get; }
    /// <summary>
    /// Read-only property that returns the referenced geometry that used to define the offset of the OriginOne along X-axis direction. This returns Nothing if the offset is not referencing any geometry.
    /// </summary>
    object OriginOneXOffsetReferencedGeometry { get; }
    /// <summary>
    /// Read-only property that returns the offset of the OriginOne along origin Y-axis direction. This returns Empty if the OriginOneDefinitonType is not equal to kOffsetOriginDefinitionType.
    /// </summary>
    object OriginOneYOffset { get; }
    /// <summary>
    /// Read-only property that returns the referenced geometry that used to define the offset of the OriginOne along Y-axis direction. This returns Nothing if the offset is not referencing any geometry.
    /// </summary>
    object OriginOneYOffsetReferencedGeometry { get; }
    /// <summary>
    /// Read-only property that returns the two referenced planar faces to define the projecting plane for OriginOne. This returns Nothing if the OriginOneDefinitonType is not equal to kBetweenTwoFacesOriginDefinitionType.
    /// </summary>
    FaceCollection OriginOneReferencedFaces { get; }
    /// <summary>
    /// Read-only property that returns the definition type of the second joint origin.
    /// </summary>
    AssemblyJointOriginDefinitionTypeEnum OriginTwoDefinitionType { get; }
    /// <summary>
    /// Read-only property that returns the offset of the OriginTwo along origin X-axis direction. This returns Empty if the OriginTwoDefinitonType is not equal to kOffsetOriginDefinitionType.
    /// </summary>
    object OriginTwoXOffset { get; }
    /// <summary>
    /// Read-only property that returns the referenced geometry that used to define the offset of the OriginTwo along X-axis direction. This returns Nothing if the offset is not referencing any geometry.
    /// </summary>
    object OriginTwoXOffsetReferencedGeometry { get; }
    /// <summary>
    /// Read-only property that returns the offset of the OriginTwo along origin Y-axis direction. This returns Empty if the OriginTwoDefinitonType is not equal to kOffsetOriginDefinitionType.
    /// </summary>
    object OriginTwoYOffset { get; }
    /// <summary>
    /// Read-only property that returns the referenced geometry that used to define the offset of the OriginTwo along Y-axis direction. This returns Nothing if the offset is not referencing any geometry.
    /// </summary>
    object OriginTwoYOffsetReferencedGeometry { get; }
    /// <summary>
    /// Read-only property that returns the two referenced planar faces to define the projecting plane for OriginTwo. This returns Nothing if the OriginTwoDefinitonType is not equal to kBetweenTwoFacesOriginDefinitionType.
    /// </summary>
    FaceCollection OriginTwoReferencedFaces { get; }
    /// <summary>
    /// Method that creates a copy of this AssemblyJointDefinition object. The new AssemblyJointDefinition is independent of any assembly joint. It can be edited and used as input to edit an existing joint or to create a new assembly joint.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    AssemblyJointDefinition Copy();
    /// <summary>
    /// Method that sets assembly joint origin as infer origin for OriginOne.
    /// </summary>
    [PreserveSig]
    void SetOriginOneAsInfer();
    /// <summary>
    /// Method that sets assembly joint origin as offset origin for OriginOne.
    /// </summary>
    /// <param name="XOffset">Input Variant object to specify the offset value along the X-axis. A numeric or string value can be supplied for this argument and a parameter will be automatically created after the joint is created. If a numeric value is supplied, the value is in centimeters, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document length unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a length “d1+3 in”. If a geometry is provided, the offset value will be calculated with the OriginOne and the geometry. Valid geometries are Edge, Face, WorkPlane, WorkAxis and their proxies.</param>
    /// <param name="YOffset">Input Variant object to specify the offset value along the Y-axis. A numeric or string value can be supplied for this argument and a parameter will be automatically created after the joint is created. If a numeric value is supplied, the value is in centimeters, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document length unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a length “d1+3 in”. If a geometry is provided, the offset value will be calculated with the OriginOne and the geometry. Valid geometries are Edge, Face, WorkPlane, WorkAxis and their proxies.</param>
    [PreserveSig]
    void SetOriginOneAsOffset([In] [MarshalAs(UnmanagedType.Struct)] object XOffset, [In] [MarshalAs(UnmanagedType.Struct)] object YOffset);
    /// <summary>
    /// Method that sets assembly joint origin as between two faces origin for OriginOne.
    /// </summary>
    /// <param name="ReferencedFaces">Input FaceCollection object with two planar faces to define the projecting plane for the assembly joint origin.</param>
    [PreserveSig]
    void SetOriginOneAsBetweenTwoFaces([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection ReferencedFaces);
    /// <summary>
    /// Method that sets assembly joint origin as infer origin for OriginTwo.
    /// </summary>
    [PreserveSig]
    void SetOriginTwoAsInfer();
    /// <summary>
    /// Method that sets assembly joint origin as offset origin for OriginTwo.
    /// </summary>
    /// <param name="XOffset">Input Variant object to specify the offset value along the X-axis. A numeric or string value can be supplied for this argument and a parameter will be automatically created after the joint is created. If a numeric value is supplied, the value is in centimeters, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document length unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a length “d1+3 in”. If a geometry is provided, the offset value will be calculated with the OriginTwo and the geometry. Valid geometries are Edge, Face, WorkPlane, WorkAxis and their proxies.</param>
    /// <param name="YOffset">Input Variant object to specify the offset value along the Y-axis. A numeric or string value can be supplied for this argument and a parameter will be automatically created after the joint is created. If a numeric value is supplied, the value is in centimeters, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document length unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a length “d1+3 in”. If a geometry is provided, the offset value will be calculated with the OriginTwo and the geometry. Valid geometries are Edge, Face, WorkPlane, WorkAxis and their proxies.</param>
    [PreserveSig]
    void SetOriginTwoAsOffset([In] [MarshalAs(UnmanagedType.Struct)] object XOffset, [In] [MarshalAs(UnmanagedType.Struct)] object YOffset);
    /// <summary>
    /// Method that sets assembly joint origin as between two faces origin for OriginTwo.
    /// </summary>
    /// <param name="ReferencedFaces">Input FaceCollection object with two planar faces to define the projecting plane for the assembly joint origin.</param>
    [PreserveSig]
    void SetOriginTwoAsBetweenTwoFaces([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection ReferencedFaces);
}
