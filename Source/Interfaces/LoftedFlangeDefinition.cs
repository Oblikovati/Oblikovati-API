namespace Oblikovati.API;

/// <summary>
/// The LoftedFlangeDefinition object represents all of the information that defines a lofted flange feature. The LoftedFlangeDefinition object is used in two ways. First it is used as input when creating a lofted flange feature. Second it is used to query and edit existing lofted flange features.
/// </summary>
public interface LoftedFlangeDefinition
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
    /// Read-write property that provides access to the bend radius of a lofted flange feature.
    /// </summary>
    object BendRadius { get; set; }
    /// <summary>
    /// Read-write property that defines whether the corner of the lofted flange should converge.
    /// </summary>
    bool Converge { get; set; }
    /// <summary>
    /// Gets and sets the which side of the sketch entities is the direction for the material to be added.
    /// </summary>
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    /// <summary>
    /// Property that returns the parameter controlling the tolerance used to calculate the lofted flange. This will return Nothing in the case where the OutputType property returns kDieFormedLoftedFlange and where the LoftedFlangeDefinition object is not associated with an existing lofted flange.
    /// </summary>
    Parameter FacetTolerance { get; }
    /// <summary>
    /// Property that returns the technique being used to calculate the shape of the lofted flange. To set the output type use the SetOutputType method.
    /// </summary>
    LoftedFlangeOutputTypeEnum OutputType { get; }
    /// <summary>
    /// Property that returns the parent LoftedFlangeFeature object.
    /// </summary>
    LoftedFlangeFeature Parent { get; }
    /// <summary>
    /// Gets and sets the first of two profiles defining the lofted flange.
    /// </summary>
    Path ProfileOne { get; set; }
    /// <summary>
    /// Gets and sets the second of two profiles defining the lofted flange.
    /// </summary>
    Path ProfileTwo { get; set; }
    /// <summary>
    /// Gets and set the UnfoldMethod object that defines how the bends associated with this lofted flange feature are unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
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
    /// Method that creates a copy of this LoftedFlangeDefinition object. The new LoftedFlangeDefinition object is independent of any feature. It can edited and used as input to edit an existing feature or to create a new lofted flange feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LoftedFlangeDefinition Copy();
    /// <summary>
    /// Method that sets the technique that will be used to calculate the lofted flange.
    /// </summary>
    /// <param name="OutputType">Constant that defines the how the lofted flange will be calculated. Valid values are kDieFormedLoftedFlange, kPressBrakeChordToleranceLoftedFlange, kPressBrakeFacetAngleLoftedFlange, and kPressBrakeFacetDistanceLoftedFlange.</param>
    /// <param name="FacetTolerance">Optional Variant that defines the tolerance value used when calculating the lofted flange. This only applies to the press brake methods and is ignored if the OutputType argument is kDieFormedLoftedFlange.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input and the output type is kPressBrakeChordToleranceLoftedFlange or kPressBrakeFacetDistanceLoftedFlange, the units are centimeters. If the output type is kPressBrakeFacetAngleLoftedFlange, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current length or angle units of the document.</param>
    [PreserveSig]
    void SetOutputType([In] LoftedFlangeOutputTypeEnum OutputType, [In] [MarshalAs(UnmanagedType.Struct)] object? FacetTolerance = default);
}
