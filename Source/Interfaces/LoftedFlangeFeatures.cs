namespace Oblikovati.API;

/// <summary>
/// The LoftedFlangeFeatures collection object provides access to the LoftedFlangeFeature objects.
/// </summary>
public interface LoftedFlangeFeatures : IEnumerable
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
    /// Returns the specified LoftedFlangeFeature object from the collection.
    /// </summary>
    LoftedFlangeFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new lofted flange feature. The newly created LoftedFlangeFeature object is returned.
    /// </summary>
    /// <param name="LoftedFlangeDefinition">Object that defines the lofted flange feature you want to create. A LoftedFlangeDefinition object can be created using the CreateLoftedFlangeDefinition method on the LoftedFlangeFeatures object.</param>
    /// <returns></returns>
    [PreserveSig]
    LoftedFlangeFeature Add([In] [MarshalAs(UnmanagedType.Interface)] LoftedFlangeDefinition LoftedFlangeDefinition);
    /// <summary>
    /// Method that creates a new LoftedFlangeDefinition object.
    /// </summary>
    /// <param name="ProfileOne">The first of two profiles that defines the shape of the lofted flange. Use PartFeatures.CreatePath method to create this path.</param>
    /// <param name="ProfileTwo">The second of two profiles that defines the shape of the lofted flange. Use PartFeatures.CreatePath method to create this path.</param>
    /// <returns></returns>
    [PreserveSig]
    LoftedFlangeDefinition CreateLoftedFlangeDefinition([In] [MarshalAs(UnmanagedType.Interface)] Path ProfileOne, [In] [MarshalAs(UnmanagedType.Interface)] Path ProfileTwo);
}
