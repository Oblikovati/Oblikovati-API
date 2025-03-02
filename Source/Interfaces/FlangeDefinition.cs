namespace Oblikovati.API;

/// <summary>
/// The FlangeDefinition object represents the information that defines a flange feature, not a flange feature.
/// </summary>
public interface FlangeDefinition
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
    /// Gets and sets the bend options associated with this bend feature.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    BendPositionEnum BendPosition { get; set; }
    /// <summary>
    /// Gets and sets the bend radius of a sheet metal flange feature.
    /// </summary>
    object BendRadius { get; set; }
    /// <summary>
    /// Gets and sets the CornerOptions object that defines how the corners of the bend are modeled.
    /// </summary>
    CornerOptions CornerOptions { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Gets and sets the bend angle of a sheet metal flange feature.
    /// </summary>
    object FlangeAngle { get; set; }
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the height extent of the flange feature is defined.
    /// </summary>
    PartFeatureExtent HeightExtent { get; }
    /// <summary>
    /// Property that returns the method used to define the height extent.
    /// </summary>
    PartFeatureExtentEnum HeightExtentType { get; }
    /// <summary>
    /// Gets and sets the miter gap size of the flange feature.
    /// </summary>
    object MiterGap { get; set; }
    /// <summary>
    /// Property that returns the parent FlangeFeature of this FlangeDefinition object.
    /// </summary>
    FlangeFeature Parent { get; }
    /// <summary>
    /// Gets and sets the UnfoldMethod object that defines how the bends associated with this flange feature are unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PartFeatureExtent DefaultWidthExtent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PartFeatureExtentEnum DefaultWidthExtentType { get; }
    /// <summary>
    /// Read-write property that gets and set whether the unfold method has been overridden for this feature. Setting this property to False clears the override.&nbsp;Setting the property to True returns a failure.
    /// </summary>
    bool IsUnfoldMethodOverridden { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the reference plane(WorkPlane or Face) object that is used to define the flange angle. When set this property the WorkPlane or Face should be parallel to the flange edge, otherwise an error would occur.
    /// </summary>
    object FlangeAngleReferencePlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the flange placement type.
    /// </summary>
    DirectionEnum FlangePlacementType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the flange angle reference type. When change this from flange angle value type to reference plane type the SetFlangeAngleReferenceType should be used.
    /// </summary>
    FlangeReferenceTypeEnum FlangeAngleReferenceType { get; set; }
    /// <summary>
    /// Read-only property that returns the flange edge set count currently defined in this flange definition.
    /// </summary>
    int EdgeSetCount { get; }
    /// <summary>
    /// Method that creates a copy of this FlangeDefinition object. The new FlangeDefinition object is independent of any feature. It can edited and used as input to edit an existing feature or to create a new flange feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FlangeDefinition Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="Width">Width</param>
    [PreserveSig]
    void SetCenteredWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Method that changes the FlangeDefinition object to define a flange whose height is measured by a distance.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the distance used for the height extent of the flange. When the FlangeDefinition object is created it defaults to a distance height extent. This value is used to define that distance.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input value from PartFeatureExtentDirectionEnum that defines the direction of the flange. kPositiveExtentDirection indicates that the direction of the flange is on the side of the selected edge. kNegativeExtentDirection indicates the flange is on the opposite side of the select edge. kSymmetricExtentDirection is not valid for a flange direction.</param>
    /// <param name="HeightDatumType">Input value from HeightDatumTypeEnum that defines how the height of the flange is defined. There are five options to define the height. Three of these are measured along the flange and two are measured in an orthogonal direction. These are illustrated in the figures below, along with the corresponding option as shown in the Flange dialog. In the examples below the flange distance is 1.00, the angle is 135.0 and the position of the bend is outside of the base face extents.</param>
    [PreserveSig]
    void SetDistanceHeightExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] HeightDatumTypeEnum HeightDatumType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    [PreserveSig]
    void SetEdgeWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="FromEntity">FromEntity</param>
    /// <param name="ToEntity">ToEntity</param>
    [PreserveSig]
    void SetFromToWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
    /// <summary>
    /// Method that changes the FlangeDefinition object to define a flange whose height is measured by a distance. The way the distance is computed for this type of height extent was used in earlier versions of Oblikovati and is supported in the current versions to support backward compatibility with older models.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the distance used for the height extent of the flange. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input value from PartFeatureExtentDirectionEnum that defines the direction of the flange. kPositiveExtentDirection indicates that the direction of the flange is on the side of the selected edge. kNegativeExtentDirection indicates the flange is on the opposite side of the select edge. kSymmetricExtentDirection is not valid for a flange direction.</param>
    /// <param name="HeightDatumType">HeightDatumTypeEnum</param>
    [PreserveSig]
    void SetLegacyDistanceHeightExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] HeightDatumTypeEnum HeightDatumType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="OffsetEntityOne">OffsetEntityOne</param>
    /// <param name="OffsetDistanceOne">OffsetDistanceOne</param>
    /// <param name="OffsetEntityTwo">OffsetEntityTwo</param>
    /// <param name="OffsetDistanceTwo">OffsetDistanceTwo</param>
    [PreserveSig]
    void SetOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Method that changes the FlangeDefinition object to define a flange whose height is defined by extending to the specified entity.
    /// </summary>
    /// <param name="ToEntity">Input Object that defines the 'To' point. A WorkPoint or Vertex object is valid for input.</param>
    /// <param name="Offset">Optional Input Variant that defines the offset distance from the 'To' point. The default value is zero. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetToHeightExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity, [In] [MarshalAs(UnmanagedType.Struct)] object? Offset = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="Width">Width</param>
    /// <param name="OffsetDistance">OffsetDistance</param>
    /// <param name="OffsetEntity">OffsetEntity</param>
    /// <param name="PositiveDirection">PositiveDirection</param>
    [PreserveSig]
    void SetWidthOffsetWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Width">Width</param>
    [PreserveSig]
    void SetCenteredDefaultWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void SetEdgeDefaultWidthExtent();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromEntity">FromEntity</param>
    /// <param name="ToEntity">ToEntity</param>
    [PreserveSig]
    void SetFromToDefaultWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OffsetEntityOne">OffsetEntityOne</param>
    /// <param name="OffsetDistanceOne">OffsetDistanceOne</param>
    /// <param name="OffsetEntityTwo">OffsetEntityTwo</param>
    /// <param name="OffsetDistanceTwo">OffsetDistanceTwo</param>
    [PreserveSig]
    void SetOffsetDefaultWidthExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistanceTwo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Width">Width</param>
    /// <param name="OffsetDistance">OffsetDistance</param>
    /// <param name="OffsetEntity">OffsetEntity</param>
    /// <param name="PositiveDirection">PositiveDirection</param>
    [PreserveSig]
    void SetWidthOffsetDefaultWidthExtent([In] [MarshalAs(UnmanagedType.Struct)] object Width, [In] [MarshalAs(UnmanagedType.Struct)] object OffsetDistance, [In] [MarshalAs(UnmanagedType.IDispatch)] object OffsetEntity, [In] bool PositiveDirection);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    [PreserveSig]
    void RemoveOverrideWidthExtent([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Method that removes the override width extent for the specified physical flange.
    /// </summary>
    /// <param name="ReferenceType">Input FlangeReferenceTypeEnum that specifies which reference type to apply to the flange feature.</param>
    /// <param name="FlangeAngleOrReferencePlane">Optional input value to specify the flange angle or object to specify the reference plane. When the ReferenceType is speficied for flange angle, this can be a Double to indicate the radian value of the flange angle, or a String to indicate the flange angle as expression(like “135 deg”). When the ReferenceType is specified as kReferenceSelectedFaceOrWorkPlane then a Face or WorkPlance should be specified here as the reference plane.</param>
    /// <param name="PlancementType">Optional input DirectionEnum to specify the flange placement type. If this is not provided the kOutwardDirection is the default value for this argument, while the kInwardDirection is the flipped direction for the placement.</param>
    [PreserveSig]
    void SetFlangeAngleReferenceType([In] FlangeReferenceTypeEnum ReferenceType, [In] [MarshalAs(UnmanagedType.Struct)] object? FlangeAngleOrReferencePlane = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PlancementType = default);
    /// <summary>
    /// Method that adds a new flange edge set.
    /// </summary>
    /// <param name="Edges">Input EdgeCollection containing Edge objects used to create the flange edge set.</param>
    /// <returns></returns>
    [PreserveSig]
    FlangeEdgeSet AddFlangeEdgeSet([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges);
    /// <summary>
    /// Method that returns the specified FlangeEdgeSet object from the collection.
    /// </summary>
    /// <param name="Index">Input Long that specifies the index within the collection of the item to return. If an out of range index is provided, an error occurs.</param>
    /// <returns></returns>
    [PreserveSig]
    FlangeEdgeSet EdgeSetItem([In] int Index);
}
