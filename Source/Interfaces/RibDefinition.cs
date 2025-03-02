namespace Oblikovati.API;

/// <summary>
/// RibDefinition Object.
/// </summary>
public interface RibDefinition
{
    /// <summary>
    /// Read-write property that gets and sets the solid body affected by the creation of this rib feature.&nbsp;For parts containing multiple solid bodies, this property defaults to the primary solid body of the part, and can be set to any of the other solid bodies.
    /// </summary>
    SurfaceBody AffectedBody { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the direction of the profile projection should be reversed. If the profile is projected normal to the sketch plane, setting this property to True causes the profile to be projected in the reverse direction of the.
    /// </summary>
    bool DirectionReversed { get; set; }
    /// <summary>
    /// Read-write property that provides access to the taper angle of a rib feature.&nbsp;This property is writable when the RibDefinition object has been created using the RibFeatures.CreateDefinition or RibDefinition.Copy methods.
    /// </summary>
    IntPtr DraftAngle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the draft profile ends value.
    /// </summary>
    bool DraftProfileEnds { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the rib profile should be extended/trimmed to intersect faces, if necessary.&nbsp;This property defaults to True for a newly created RibDefinition object.
    /// </summary>
    bool ExtendProfile { get; set; }
    /// <summary>
    /// Read-only property that returns the parameter that corresponds to the distance value for rib feature defined with a finite extent.&nbsp;This property returns a parameter only if the ExtentType is kFiniteRibExtent, else this property returns Nothing. Also, in the case where this is a newly created RibDefinition object or it has been copied from an existing RibDefinition object, this property returns Nothing since there isn’t a parameter created yet.
    /// </summary>
    IntPtr ExtentDistance { get; }
    /// <summary>
    /// Read-only property that returns the extent type of the rib feature.&nbsp;The possible return values are kFiniteRibExtent and kToNextRibExtent.&nbsp;When the RibDefinition object is initially created, this defaults to kToNextRibExtent.&nbsp;If this property returns kFiniteRibExtent, the ExtentDistance property returns the correspond parameter.&nbsp;Use the SetFiniteExtent and Set ToNextExtent methods to edit the extent type.
    /// </summary>
    RibFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the sketch profile is projected lateral to the sketch plane (rib) or normal to the sketch plane (web) to create the feature.&nbsp;A value of True indicates that the profile is projected lateral to the sketch plane.
    /// </summary>
    bool IsRib { get; set; }
    /// <summary>
    /// Read-only property that returns the parent RibFeature of this RibDefinition object.&nbsp;In the case where this is a newly created RibDefinition object or it has been copied from an existing RibDefinition object, this property will return Nothing because there is not a logical parent for the object.
    /// </summary>
    RibFeature Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of sketch entities used as the profile for feature creation.
    /// </summary>
    ObjectCollection ProfileCurves { get; set; }
    /// <summary>
    /// Read-write property that provides access to the thickness of the feature.&nbsp;This property is writable when the RibDefinition object has been created using the RibFeatures.CreateDefinition or RibDefinition.Copy methods.&nbsp;The value can be set using either a doubl.
    /// </summary>
    IntPtr Thickness { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the side of the profile on which to apply the thickness.&nbsp;This property defaults to kSymmetricExtentDirection for a newly created RibDefinition object.
    /// </summary>
    PartFeatureExtentDirectionEnum ThicknessDirection { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the BossSets collection object containing boss definitions of the rib feature.
    /// </summary>
    BossSets BossSets { get; }
    /// <summary>
    /// Method that creates a copy of this RibDefinition object. The new RibDefinition object is independent of any feature. It can be edited and used as input to edit an existing feature or to create a new Rib feature.
    /// One typical use of this method is when you need to make several changes to an existing Rib feature. If you edit the RibDefinition object associated with the Rib feature, the feature will recompute after each edit. It’s more efficient to make a copy, edit the copy, and then assign the copy to the feature. This will result in a single recompute.
    /// 
    /// The RibFeatures.CreateDefinition method can also be used to create an independent RibDefinition object. The difference is that one created with the Copy method will have the same initial values as the object is was copied from. One that’s created with the CreateDefinition method will be initialized to predefined default values.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RibDefinition Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HoldThicknessAt">HoldThicknessAt</param>
    /// <param name="NeutralGeometry">NeutralGeometry</param>
    [PreserveSig]
    void GetThicknessPlane([Out] out RibThicknessPlaneEnum HoldThicknessAt, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object NeutralGeometry);
    /// <summary>
    /// Method that sets the plane at which the input thickness is held.
    /// </summary>
    /// <param name="HoldThicknessAt">Input RibThicknessPlaneEnum that defines the plane at which the thickness should be held.  Valid inputs are kRibThicknessAtSketchPlane, kRibThicknessAtRoot and kRibThicknessAtNeutralGeometry. If kRibThicknessAtNeutralGeometry is provided as input, the NeutralGeometry argument must also be provided, else the method will fail.</param>
    /// <param name="NeutralGeometry">Optional input object that specifies the neutral geometry if the HoldThicknessAt argument is specified to be kRibThicknessAtNeutralGeometry.</param>
    [PreserveSig]
    void SetThicknessPlane([In] RibThicknessPlaneEnum HoldThicknessAt, [In] [MarshalAs(UnmanagedType.Struct)] object? NeutralGeometry = default);
    /// <summary>
    /// Method that sets the extent type to be a finite distance.
    /// </summary>
    /// <param name="Distance">Input Variant that defines the distance associated with the extent of the rib feature. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetFiniteExtent([In] [MarshalAs(UnmanagedType.Struct)] object Distance);
    /// <summary>
    /// Method that sets the extent type to be ‘to next’ (i.e. it terminates on the next face).
    /// </summary>
    [PreserveSig]
    void SetToNextExtent();
}
