namespace Oblikovati.API;

/// <summary>
/// The FaceFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface FaceFeatures : IEnumerable
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
    /// Returns the specified FaceFeature object from the collection. This is the default property of the FaceFeatures collection object.
    /// </summary>
    FaceFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new face feature. The newly created FaceFeature object is returned.
    /// </summary>
    /// <param name="FaceFeatureDefinition">Input FaceFeatureDefinition object that defines the face feature you want to create. A FaceFeatureDefinition object can be created using the FaceFeatures.CreateFaceFeatureDefinition method. It can also be obtained from an existing FaceFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    FaceFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FaceFeatureDefinition FaceFeatureDefinition);
    /// <summary>
    /// Method that creates a new FaceFeatureDefinition object.
    /// </summary>
    /// <param name="Profile">Input Profile object that defines the shape of the face. The input profile must consist of one or more closed paths.</param>
    /// <returns></returns>
    [PreserveSig]
    FaceFeatureDefinition CreateFaceFeatureDefinition([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile);
}
