namespace Oblikovati.API;

/// <summary>
/// The ContourFlangeDefinition object represents all of the information that defines a contour flange feature.
/// </summary>
public interface ContourFlangeDefinition
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
    /// Defines if auto mitering should be performed.
    /// </summary>
    bool ApplyAutoMitering { get; set; }
    /// <summary>
    /// Gets and sets the bend options associated with this contour flange feature.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Gets and sets the bend radius of a contour flange feature.
    /// </summary>
    object BendRadius { get; set; }
    /// <summary>
    /// Gets and sets the CornerOptions object that defines how the corners of the contour flange are modeled.
    /// </summary>
    CornerOptions CornerOptions { get; set; }
    /// <summary>
    /// Gets and sets the EdgeCollection object that contains the edges that are used to define the contour flange feature.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Gets and sets the extent direction which indicates which side of the sketch the projection of the flange is in.
    /// </summary>
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    /// <summary>
    /// Gets and sets the miter gap size of the Contour flange feature.
    /// </summary>
    object MiterGap { get; set; }
    /// <summary>
    /// Property that returns the parent ContourFlangeFeature of this ContourFlangeDefinition object.
    /// </summary>
    ContourFlangeFeature Parent { get; }
    /// <summary>
    /// Gets and sets the Path object that defines the shape of the contour flange.
    /// </summary>
    Path Path { get; set; }
    /// <summary>
    /// Gets and sets the UnfoldMethod object that defines how the bends associated with this contour flange feature are unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Property that returns the method used to define the width extent.
    /// </summary>
    PartFeatureExtentEnum DefaultWidthExtentType { get; }
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the width extent of the contour flange feature is defined.
    /// </summary>
    PartFeatureExtent DefaultWidthExtent { get; }
    /// <summary>
    /// Specifies if the existing faces will be extended to the bend or if a perpendicular section should be created to connect to the bend.
    /// </summary>
    bool ExtendFaces { get; set; }
    /// <summary>
    /// Read-write property that gets and set whether the unfold method has been overridden for this feature. Setting this property to False clears the override.&nbsp;Setting the property to True returns a failure.
    /// </summary>
    bool IsUnfoldMethodOverridden { get; set; }
    /// <summary>
    /// Gets and sets the type of operation used to add the feature to the model.&nbsp;Valid inputs are kNewBodyOperation, kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use the document active sheet metal style for the body the feature is in. Set this property is applicable only when the feature is the first feature in a solid body and this can only be set to True from False.
    /// </summary>
    bool UseDefaultSheetMetalRule { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the sheet metal style for the body the feature is in. Set this property is applicable only when the feature is the first feature in a solid body. When set this property the default sheet metal rule will be overridden and.
    /// </summary>
    SheetMetalStyle SheetMetalRule { get; set; }
    /// <summary>
    /// Read-only property that returns the PartFeatureExtent object that defines how the second distance width extent of the contour flange feature is defined.
    /// </summary>
    PartFeatureExtent DistanceWidthExtentTwo { get; }
    /// <summary>
    /// Read-only property that returns whether the distance width extent is asymmetric or not.
    /// </summary>
    bool IsDistanceWidthExtentAsymmetric { get; }
    /// <summary>
    /// Method that creates a copy of this ContourFlangeDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ContourFlangeDefinition Copy();
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange that's centered along the edge and has a defined width.
    /// </summary>
    /// <param name="Edge">The Edge that identifies which physical contour flange to set the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to set the width extent for.</param>
    /// <param name="Width">Input Variant that defines the distance used for the width extent of the contour flange. This value is used to define that distance. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCenteredWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange whose width is defined by a distance from the input Profile.
    /// </summary>
    /// <param name="Distance">Defines the length of the extrusion. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Constant that indicates which side of the sketch plane to exend the flange to. Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetDistanceExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange whose width is defined by the length of the input edge(s). These are the same edges that were specified to define the location of the contour flanges.
    /// </summary>
    /// <param name="Edge">he Edge that identifies which physical contour flange to set the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to set the width extent for.</param>
    [PreserveSig]
    void SetEdgeWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange whose width is defined as being between two entities.
    /// </summary>
    /// <param name="Edge">The Edge that identifies which physical contour flange to set the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to set the width extent for.</param>
    /// <param name="FromEntity">Input Object that defines the 'from' extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    /// <param name="ToEntity">Input Object that defines the 'to' extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    [PreserveSig]
    void SetFromToWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange whose width is defined with respect to two entities.
    /// </summary>
    /// <param name="Edge">The Edge that identifies which physical contour flange to set the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to set the width extent for.</param>
    /// <param name="OffsetEntityOne">Input Object that defines the first entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceOne">Input Variant that defines the distance of the contour flange from offset entity one. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntityTwo">Input Object that defines the second entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceTwo">Input Variant that defines the distance of the contour flange from offset entity two. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Method that changes the ContourFlangeDefinition object to define a contour flange whose width is defined relative to another entity.
    /// </summary>
    /// <param name="Edge">The Edge that identifies which physical contour flange to set the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to set the width extent for.</param>
    /// <param name="Width">Input Variant that defines the distance to use for the width extent of the contour flange. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetDistance">Input Variant that defines the distance of the contour flange from the offset entity. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntity">Input Object that defines the entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="PositiveDirection">Input Boolean that specifies the side of the offset entity the contour flange is on.</param>
    [PreserveSig]
    void SetWidthOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
    /// <summary>
    /// Method that sets the default width extent to define a contour flange that"s centered along the edge and has a defined width.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance used for the width extent of the contour flange. This value is used to define that distance. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCenteredDefaultWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Method that sets the default width extent to define a contour flange whose width is defined by the length of the input edge(s). These are the same edges that were specified to define the location of the contour flanges.
    /// </summary>
    [PreserveSig]
    void SetEdgeDefaultWidthExtent();
    /// <summary>
    /// Method that sets the default width extent to define a contour flange whose width is defined as being between two entities.
    /// </summary>
    /// <param name="FromEntity">Input Object that defines the "from" extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    /// <param name="ToEntity">Input Object that defines the "to" extents. This can be a planar Face, WorkPlane, Vertex, or WorkPoint object that intersects the selected edge.</param>
    [PreserveSig]
    void SetFromToDefaultWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
    /// <summary>
    /// Method that sets the default width extent to define a contor flange whose width is defined with respect to two entities.
    /// </summary>
    /// <param name="OffsetEntityOne">Input Object that defines the first entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceOne">Input Variant that defines the distance of the contour flange from offset entity one. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntityTwo">Input Object that defines the second entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="OffsetDistanceTwo">Input Variant that defines the distance of the contour flange from offset entity two. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetOffsetDefaultWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Method that sets the default width extent for the contor flange feature to define a contour flange whose width is defined relative to another entity.
    /// </summary>
    /// <param name="Width">Input Variant that defines the distance to use for the width extent of the contour flange. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetDistance">Input Variant that defines the distance of the contour flange from the offset entity. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="OffsetEntity">Input Object that defines the entity the distance is measured relative to. This can be a point (WorkPoint or a Vertex object) or a plane (Face or WorkPlane object that is perpendicular to the selected edge).</param>
    /// <param name="PositiveDirection">Input Boolean that specifies the side of the offset entity the contour flange is on.</param>
    [PreserveSig]
    void SetWidthOffsetDefaultWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the width extent of the specified physical contour flange is defined.
    /// </summary>
    /// <param name="Edge">The Edge object that identifies the physical contour flange to return the width extent for. The creation of a single contour flange feature can result in many physical contour flanges being added to the part. Each edge specified for the contour flange feature wll result in a physical contour flange. The edge specified as input to this argument must be one of the edges that was specified as input to the contour flange feature and defines which physical contour flange to return the width extent for.</param>
    /// <returns></returns>
    [PreserveSig]
    PartFeatureExtent GetWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="HasOverride">HasOverride</param>
    [PreserveSig]
    PartFeatureExtentEnum GetWidthExtentType([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [Out] out bool HasOverride);
    /// <summary>
    /// Method that sets the second direction extent(Distance B) for the distance width extent of the ContourFlangeDefinition.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the length of the contour flange in the other direction for an asymmetric extent.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetDistanceWidthExtentTwo([In] [MarshalAs(UnmanagedType.Struct)] object Distance);
}
