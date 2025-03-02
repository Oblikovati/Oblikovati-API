namespace Oblikovati.API;

/// <summary>
/// Flange edge set Object.
/// </summary>
public interface FlangeEdgeSet
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of edges in the edge set.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Read-only property that returns width extent of this FlangeEdgeSet.
    /// </summary>
    PartFeatureExtent WidthExtent { get; }
    /// <summary>
    /// Read-only property that returns width extent type of this FlangeEdgeSet.
    /// </summary>
    PartFeatureExtentEnum WidthExtentType { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that deletes the flange edge set.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that changes the flange edge set object to define a flange whose width is defined by the length of the input edge(s).
    /// </summary>
    [PreserveSig]
    void SetEdgeWidthExtent();
    /// <summary>
    /// Method that sets the width extent of the specified physical flange to define a flange that’s centered along the edge and has a defined width.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance used for the width extent of the flange.   This value is used to define that distance.  This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCenteredWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Method that sets the width extent of the specified physical flange to define a flange whose width is defined relative to another entity.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance used for the width extent of the flange.   This value is used to define that distance.  This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetDistance">Input Variant that defines the distance of the flange from the offset entity.   This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntity">Input Object that defines the entity the distance is measured relative to.  This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="PositiveDirection">Input Boolean that specifies the side of the offset entity the flange is on.</param>
    [PreserveSig]
    void SetWidthOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
    /// <summary>
    /// Method that sets the width extent of the specified physical flange to define a flange whose width is defined with respect to two entities.
    /// </summary>
    /// <param name="OffsetEntityOne">Input Object that defines the first entity the distance is measured relative to.  This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceOne">Input Variant that defines the distance of the flange from offset entity one.   This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntityTwo">Input Object that defines the second entity the distance is measured relative to.  This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceTwo">Input Variant that defines the distance of the flange from offset entity two.   This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetOffsetdWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Method that sets the width extent of the specified physical flange to define a flange whose width is defined as being between two entities.
    /// </summary>
    /// <param name="FromEntity">Input Object that defines the “from” extents.  This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    /// <param name="ToEntity">Input Object that defines the “to” extents.  This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    [PreserveSig]
    void SetFromToWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
}
