namespace Oblikovati.API;

/// <summary>
/// The CutDefinition object represents all of the information that defines a cut feature.
/// </summary>
public interface CutDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns whether this cut feature goes across bends or not.
    /// </summary>
    bool CutAcrossBends { get; }
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the extent of the feature is defined.
    /// </summary>
    PartFeatureExtent Extent { get; }
    /// <summary>
    /// Property that returns an enum value indicating how the extent of the feature is defined.
    /// </summary>
    PartFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Property that returns the parent CutFeature object of this CutDefinition object.
    /// </summary>
    CutFeature Parent { get; }
    /// <summary>
    /// Gets the Profile object that defines the shape of the cut.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the side faces of this cut feature are perpendicular to the top/bottom faces of the flat.&nbsp;This simulates most manufacturing processes where the cut is made perpendicular to the sheet stock.
    /// </summary>
    bool CutNormalToFlat { get; set; }
    /// <summary>
    /// Method that changes the cut to cut across bends.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the depth of the cut. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCutAcrossBendsExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance);
    /// <summary>
    /// Method that changes the extent to be a 'to' extent.
    /// </summary>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a face or work plane. The same limitations for the 'to' face that exist when creating a cut feature interactively through the command exist when using the API to create a cut feature.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    [PreserveSig]
    void SetToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace);
    /// <summary>
    /// Method that changes the extent to be a 'to next' extent.
    /// </summary>
    /// <param name="Direction">Input PartFeatureExtentDirectionEnum value to indicate which side of the sketch the cut should be. kPositiveExtentDirection and kNegativeExtentDirection are valid values. The value kPositiveExtentDirection defines the cut direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetToNextExtent([In] PartFeatureExtentDirectionEnum Direction);
    /// <summary>
    /// Method that changes the extent to be a 'to next' extent.
    /// </summary>
    /// <param name="Direction">Input PartFeatureExtentDirectionEnum value to indicate which side of the sketch the cut should be. The value kPositiveExtentDirection defines the cut direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetThroughAllExtent([In] PartFeatureExtentDirectionEnum Direction);
    /// <summary>
    /// Method that changes the extent to be a 'from to' extent.
    /// </summary>
    /// <param name="FromFace">Input Object that defines the 'from face'. This can be either a face or work plane. The same limitations for the 'from' face that exist when creating a cut feature interactively through the command exist when using the API to create a cut feature.</param>
    /// <param name="ExtendFromFace">Input Boolean that defines whether the 'from face' should be extended to contain the extents of the profile.</param>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a face or work plane. The same limitations for the 'to' plane that exist when creating a cut feature interactively through the command exist when using the API to create a cut feature.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    [PreserveSig]
    void SetFromToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace);
    /// <summary>
    /// Method that changes the extent to be a distance extent.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the depth of the cut. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Direction">Input PartFeatureExtentDirectionEnum value to indicate which side of the sketch the cut should be. The value kPositiveExtentDirection defines the cut direction to be in the same direction as the normal of the sketch plane.</param>
    [PreserveSig]
    void SetDistanceExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum Direction);
}
