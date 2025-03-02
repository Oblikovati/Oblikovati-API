namespace Oblikovati.API;

/// <summary>
/// The FlangeFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface FlangeFeatures : IEnumerable
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
    /// Returns the specified FlangeFeature object from the collection. This is the default property of the FlangeFeatures collection object.
    /// </summary>
    FlangeFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new flange feature. The newly created FlangeFeature object is returned.
    /// </summary>
    /// <param name="FlangeDefinition">Input FlangeDefinition object that defines the flange feature you want to create. A FlangeDefinition object can be created using the FlangeFeatures.CreateFlangeDefinition method. It can also be obtained from an existing FlangeFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    FlangeFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FlangeDefinition FlangeDefinition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edges">Edges</param>
    /// <param name="FlangeAngleOrFlangeAngleReferencePlane">FlangeAngleOrFlangeAngleReferencePlane</param>
    /// <param name="Distance">Distance</param>
    [PreserveSig]
    FlangeDefinition CreateFlangeDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Struct)] object FlangeAngleOrFlangeAngleReferencePlane, [In] [MarshalAs(UnmanagedType.Struct)] object Distance);
    /// <summary>
    /// Method that creates a new FlangeDefinition object. The object created does not represent a flange feature but instead is a representation of the information that defines a flange feature.&nbsp;You can use this object as input to the FlangeFeatures.Add method to cr.
    /// </summary>
    /// <param name="Edges">Input EdgeCollection containing Edge objects used to create the flange feature. These Edge objects are in the first edge set for flange feature, the newly created FlangeDefinition can be used to add more FlangeEdgeSet objects. The FlangeEdgeSet object provides functions to set the width extent type, if not changed default kWidthEdgeExtent will be applied for it.</param>
    /// <param name="FlangeAngleReferenceType">Input FlangeReferenceTypeEnum that defines the flange angle reference type.</param>
    /// <param name="FlangeAngleOrFlangeAngleReferencePlane">Input Variant that defines the angle of the flange. When the FlangeAngleReferenceType is set to kReferencePlaneThroughPartnerEdge,
    /// kReferencePlaneThroughSelectedEdge or
    /// kReferencePlaneAtSideFace,
    /// this can be a numeric value or a string to specify the flange angle value. When the FlangeAngleReferenceType is set to kReferenceSelectedFaceOrWorkPlane, this can be a WorkPlane or a Face to specify the flange angle reference plane. If a string or a numeric value is input, a parameter for this value will be created and the supplied string or numeric value is assigned to the parameter. If a numeric value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document. If a WorkPlane or Face is input, the WorkPlane or Face should be parallel to the flange edge.</param>
    /// <param name="FlangePlacementType">Optional input DirectionEnum that defines the flange placement type. If not provided the default kOutwardDirection is used.</param>
    /// <param name="Distance">Optional input Variant that defines the distance used for the height extent of the flange. When the FlangeDefinition object is created it defaults to a distance height extent. This value is used to define that distance. If you want to define the height using a “to” extent instead you can edit the definition and change it, but to initially create the definition you must still supply an value for the distance.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. If not provided a default value will be used.</param>
    /// <param name="Options">Optional input NameValueMap to specify more options. This is reserved for future use.</param>
    /// <returns></returns>
    [PreserveSig]
    FlangeDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] FlangeReferenceTypeEnum FlangeAngleReferenceType, [In] [MarshalAs(UnmanagedType.Struct)] object FlangeAngleOrFlangeAngleReferencePlane, [In] [MarshalAs(UnmanagedType.Struct)] object? FlangePlacementType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Distance = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
