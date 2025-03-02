namespace Oblikovati.API;

/// <summary>
/// The ClientFeatures collection object provides access to client features and provides methods to create additional client features.
/// </summary>
public interface ClientFeatures : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ClientFeature object from the collection.
    /// </summary>
    ClientFeature Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new ClientFeatureDefinition. The newly created ClientFeatureDefinition is returned.
    /// </summary>
    /// <param name="FeatureType">Optional input string that defines the naming of the client feature in the browser. If not specified, a default string 'ClientFeature' is used.</param>
    /// <param name="StartElement">Optional input object that specifies the first element to be composited in this feature. This object must correspond to a node in the browser. This can be a PartFeature, DerivedPartComponent, DerivedAssemblyComponent, iFeatureComponent, Sketch, Sketch3D, WorkPoint, WorkPlane, or a WorkAxis.</param>
    /// <param name="EndElement">Optional input object that specifies the last element to be composited in this feature. This object must correspond to a node in the browser. An error occurs if the EndElement is not at the same level as the StartElement in the browser tree. If the StartElement argument is specified and this argument is not specified, the feature just composites the StartElement. If both StartElement and EndElement arguments are specified and they are the same, the feature just composites the StartElement. This argument is ignored if the StartElement argument is not specified. This can be a PartFeature, DerivedPartComponent, DerivedAssemblyComponent, iFeatureComponent, Sketch, Sketch3D, WorkPoint, WorkPlane, or a WorkAxis.</param>
    /// <param name="FeatureInputs">Optional input ObjectCollection that specifies the inputs use to create this feature. The inputs are currently limited to 2D & 3D sketches. The inputs must be above the feature in the browser. When sketches are specified as inputs, the behavior is the same as a regular Inventor feature (such as Extrude) consuming a sketch. The sketch appears under the client feature and can be 'shared' by the user so it is usable in other downstream features. The input objects are not 'strongly owned' by the client feature. i.e. when the client feature is deleted, the user has the option to retain the feature inputs. The feature inputs do not highlight with the client feature.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientFeatureDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string? FeatureType = "", [In] [MarshalAs(UnmanagedType.Struct)] object? StartElement = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndElement = default, [In] [MarshalAs(UnmanagedType.Struct)] object? FeatureInputs = default);
    /// <summary>
    /// Method that creates a new ClientFeature. The newly created ClientFeature is returned.
    /// </summary>
    /// <param name="Definition">Input ClientFeatureDefinition object created using the CreateDefinition method.</param>
    /// <param name="ClientId">Input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    ClientFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ClientFeatureDefinition Definition, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
}
