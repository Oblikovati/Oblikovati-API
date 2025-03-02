namespace Oblikovati.API;

/// <summary>
/// The HemDefinition object represents all of the information that defines a hem feature.
/// </summary>
public interface HemDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the bend options associated with this contour flange feature.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Gets and sets the EdgeCollection object that contains the edges that are used to define the hem feature.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Property that returns the method used to define the type of hem.
    /// </summary>
    HemTypeEnum HemType { get; }
    /// <summary>
    /// Property that returns the HemTypeDefinition object that defines the type of hem.
    /// </summary>
    object HemTypeDefinition { get; }
    /// <summary>
    /// Property that returns the parent HemFeature of this HemDefinition object.
    /// </summary>
    HemFeature Parent { get; }
    /// <summary>
    /// Gets and sets the UnfoldMethod object that defines how the bends associated with this contour flange feature are unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Property that returns the method used to define the width extent.
    /// </summary>
    PartFeatureExtentEnum WidthExtentType { get; }
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the width extent of the hem feature is defined.
    /// </summary>
    PartFeatureExtent WidthExtent { get; }
    /// <summary>
    /// Gets and sets the side of the part that the hem is on.
    /// </summary>
    bool IsOnEdgeSide { get; set; }
    /// <summary>
    /// Read-write property that gets and set whether the unfold method has been overridden for this feature. Setting this property to False clears the override.&nbsp;Setting the property to True returns a failure.
    /// </summary>
    bool IsUnfoldMethodOverridden { get; set; }
    /// <summary>
    /// Method that creates a copy of this HemDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HemDefinition Copy();
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem whose shape has a double bend.
    /// </summary>
    [PreserveSig]
    void SetDoubleHemType([In] [MarshalAs(UnmanagedType.Struct)] object Gap, [In] [MarshalAs(UnmanagedType.Struct)] object Length);
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem whose shape has a rolled bend.
    /// </summary>
    /// <param name="Radius">Input Variant that defines the radius of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Angle">Input Variant that defines the angle of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    [PreserveSig]
    void SetRolledHemType([In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] [MarshalAs(UnmanagedType.Struct)] object Angle);
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem whose shape has a single bend.
    /// </summary>
    /// <param name="Gap">Input Variant that defines the gap of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Length">Input Variant that defines the length of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetSingleHemType([In] [MarshalAs(UnmanagedType.Struct)] object Gap, [In] [MarshalAs(UnmanagedType.Struct)] object Length);
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem whose shape has a teardrop bend.
    /// </summary>
    /// <param name="Radius">Input Variant that defines the radius of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Angle">Input Variant that defines the angle of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    [PreserveSig]
    void SetTeardropHemType([In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] [MarshalAs(UnmanagedType.Struct)] object Angle);
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem that's centered along the edge and has a defined width.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance used for the width extent of the hem. This value is used to define that distance. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCenteredWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a hem whose width is defined by the length of the input edge(s). These are the same edges that were specified to define the location of the hems.
    /// </summary>
    [PreserveSig]
    void SetEdgeWidthExtent();
    /// <summary>
    /// Method that changes the FlangeDefinition object to define a hem whose width is defined as being between two entities.
    /// </summary>
    /// <param name="FromEntity">Input Object that defines the 'from' extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    /// <param name="ToEntity">Input Object that defines the 'to' extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    [PreserveSig]
    void SetFromToWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
    /// <summary>
    /// Method that changes the HemDefinition object to define a hem whose width is defined with respect to two entities.
    /// </summary>
    /// <param name="OffsetEntityOne">Input Object that defines the first entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceOne">Input Variant that defines the distance of the hem from offset entity one. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntityTwo">Input Object that defines the second entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceTwo">Input Variant that defines the distance of the hem from offset entity two. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetOffsetWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a hem whose width is defined relative to another entity.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance to use for the width extent of the hem. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetDistance">Input Variant that defines the distance of the hem from the offset entity. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntity">Input Object that defines the entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="PositiveDirection">Input Boolean that specifies the side of the offset entity the hem is on.</param>
    [PreserveSig]
    void SetWidthOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
}
