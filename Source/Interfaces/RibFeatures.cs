namespace Oblikovati.API;

/// <summary>
/// The Part RibFeatures collection object. A is a closed, thin-walled support shape.
/// </summary>
public interface RibFeatures : IEnumerable
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
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    RibFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Rib feature.&nbsp;The newly created RibFeature object is returned.
    /// </summary>
    /// <param name="Definition">Input RibDefinition object that defines the rib feature you want to create.  A RibDefinition object can be created using the RibFeatures.CreateDefinition method.  It can also be obtained from an existing RibFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    RibFeature Add([In] [MarshalAs(UnmanagedType.Interface)] RibDefinition Definition);
    /// <summary>
    /// Method that creates a new RibDefinition object.&nbsp;The object created does not represent a rib feature but instead is a representation of the information that defines a rib feature.&nbsp;You can use this object as input to the RibFeatures.Add method to create the actual feature.
    /// </summary>
    /// <param name="ProfileCurves">Input ObjectCollection containing the sketch entities that will form the profile of the feature.</param>
    /// <param name="IsRib">Input Boolean that specifies whether the sketch profile is projected lateral to the sketch plane (rib) or normal to the sketch plane (web) to create the feature.  A value of True indicates that the profile is projected lateral to the sketch plane.</param>
    /// <param name="DirectionReversed">Input Boolean that specifies whether the direction of the profile projection should be reversed. If the profile is projected normal to the sketch plane, setting this property to True causes the profile to be projected in the reverse direction of the sketch normal.  If the profile is projected lateral to the sketch plane, setting this property to True causes the profile to be projected in the reverse direction of the natural normal direction of the base sketch entity. The natural normal of a sketch entity is defined as the cross-product of the vector representing the tangent at that point and the vector representing the sketch normal.</param>
    /// <param name="Thickness">Input Variant that defines the thickness of the rib feature. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    RibDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ProfileCurves, [In] bool IsRib, [In] bool DirectionReversed, [In] [MarshalAs(UnmanagedType.Struct)] object Thickness);
}
