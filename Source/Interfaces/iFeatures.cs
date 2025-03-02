namespace Oblikovati.API;

/// <summary>
/// The iFeatures collection object provides access to all of the iFeature objects in a part component definition and provides methods to create additional iFeatures..
/// </summary>
public interface iFeatures : IEnumerable
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
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iFeature object from the collection..
    /// </summary>
    iFeature Item { get; }
    /// <summary>
    /// Method that creates a new iFeature using the input placement information. If successfully created the new iFeature is returned.
    /// </summary>
    /// <param name="Definition">Input iFeatureDefinition object used to define the various input required for the placement of an iFeature. Appropriate input must be defined in the iFeatureDefinition object in order to place the iFeature.</param>
    /// <returns></returns>
    [PreserveSig]
    iFeature Add([In] [MarshalAs(UnmanagedType.Interface)] iFeatureDefinition Definition);
    /// <summary>
    /// Method that creates a new iFeatrureDefinition. The returned definition provides access to all of the inputs that are necessary for placing an iFeature. Using this object you provide the parameter and the geometry inputs necessary for placing the iFeature.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the name of the iFeature file (.ide) to create the definition for. The file must be an existing iFeature file. If an invalid file is specified an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    iFeatureDefinition CreateiFeatureDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
