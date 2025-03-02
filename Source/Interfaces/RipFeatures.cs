namespace Oblikovati.API;

/// <summary>
/// The RipFeatures collection object provides access to the RipFeature objects
/// </summary>
public interface RipFeatures : IEnumerable
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
    /// Returns the specified RipFeature object from the collection.
    /// </summary>
    RipFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new rip feature. The newly created RipFeature object is returned.
    /// </summary>
    /// <param name="RipDefinition">Input LoftedFlangeDefinition object that defines the lofted flange feature you want to create.
    /// A LoftedFlangeDefinition object can be created using the CreateLoftedFlangeDefinition method on the LoftedFlangeFeatures object.</param>
    /// <returns></returns>
    [PreserveSig]
    RipFeature Add([In] [MarshalAs(UnmanagedType.Interface)] RipDefinition RipDefinition);
    /// <summary>
    /// Method that creates a new RipDefinition object.
    /// </summary>
    /// <param name="RipFace">The face that the rip is defined along. This must be a face this is valid for defining a rip extent. For example a face along the edge of the part where the thickness of the part is represented is not valid as input.</param>
    /// <returns></returns>
    [PreserveSig]
    RipDefinition CreateRipDefinition([In] [MarshalAs(UnmanagedType.Interface)] Face RipFace);
}
