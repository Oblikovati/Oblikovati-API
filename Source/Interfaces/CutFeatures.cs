namespace Oblikovati.API;

/// <summary>
/// The CutFeatures collection object provides access to the CutFeature objects. It"s also through the CutFeatures object that you create new CutFeature objects.
/// </summary>
public interface CutFeatures : IEnumerable
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
    /// Returns the specified CutFeature object from the collection. This is the default property of the CutFeatures collection object.
    /// </summary>
    CutFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new cut feature.
    /// </summary>
    /// <param name="CutDefinition">Input CutDefinition object that defines the face feature you want to create. A CutDefinition object can be created using the CutFeatures.CreateCutDefinition method. It can also be obtained from an existing CutFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    CutFeature Add([In] [MarshalAs(UnmanagedType.Interface)] CutDefinition CutDefinition);
    /// <summary>
    /// Method that creates a new CutDefinition object.
    /// </summary>
    /// <param name="Profile">Input Profile object that defines the shape of the cut feature. The input profile must consist of one or more closed paths.</param>
    /// <returns></returns>
    [PreserveSig]
    CutDefinition CreateCutDefinition([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile);
}
