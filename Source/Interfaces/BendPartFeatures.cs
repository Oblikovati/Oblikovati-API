namespace Oblikovati.API;

/// <summary>
/// The BendPartFeatures collection object provides access to existing bend part features and supports the ability to create new bend part features.
/// </summary>
public interface BendPartFeatures : IEnumerable
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
    /// Returns the specified BendPartFeature object from the collection. This is the default property of the BendPartFeatures collection object.
    /// </summary>
    BendPartFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new bend part feature. If the bend part feature is created successfully, a BendPartFeature object corresponding to the newly created bend part feature is returned.
    /// </summary>
    /// <param name="BendLine">Input SketchLine object that represents the bend line.</param>
    /// <param name="BendPartType">Input constant that indicates the type of the bend part feature. See Note 1.</param>
    /// <param name="InputOne">Input Variant that defines the first input for the bend arc. See Note 2.</param>
    /// <param name="InputTwo">Input Variant that defines the second input for the bend arc. See Note 3.</param>
    /// <param name="BendSide">Input constant that indicates which side of the model to bend. See Note 4</param>
    /// <param name="BendInSketchNormalDirection">Input boolean that indicates the bend direction. If True is specified, the model will be bent in the direction normal to the sketch on which the input bend line (sketch line) exists. If False is specified, the model will be bent in the direction opposite to the sketch normal. If no value is explicitly specified, the default value of True will be used.</param>
    /// <param name="Body">Optional input SurfaceBody object that specifies the solid body to bend. If not specified, a default body is chosen in the case of multi solid body parts.</param>
    /// <param name="BendMinimum">Optional Input boolean that indicates whether minimum bend should be applied. If True is specified, minium bend will be applied. If no value is explicitly specified, the default value of True will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    BendPartFeature Add([In] [MarshalAs(UnmanagedType.Interface)] SketchLine BendLine, [In] BendPartTypeEnum BendPartType, [In] [MarshalAs(UnmanagedType.Struct)] object InputOne, [In] [MarshalAs(UnmanagedType.Struct)] object InputTwo, [In] PartFeatureExtentDirectionEnum BendSide, [In] bool BendInSketchNormalDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? Body = default, [In] bool? BendMinimum = true);
}
