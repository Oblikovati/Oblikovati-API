namespace Oblikovati.API;

/// <summary>
/// The HemFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface HemFeatures : IEnumerable
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
    /// Returns the specified HemFeature object from the collection. This is the default property of the HemFeatures collection object.
    /// </summary>
    HemFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new hem feature. The newly created HemFeature object is returned.
    /// </summary>
    /// <param name="HemDefinition">Input HemDefinition object that defines the hem feature you want to create. A HemDefinition object can be created using the HemFeatures.CreateHemDefinition method. It can also be obtained from an existing HemFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    HemFeature Add([In] [MarshalAs(UnmanagedType.Interface)] HemDefinition HemDefinition);
    /// <summary>
    /// Method that creates a new HemDefinition object.
    /// </summary>
    /// <param name="Edges">Input EdgeCollection object that specifies the edges to create a hem feature on.</param>
    /// <returns></returns>
    [PreserveSig]
    HemDefinition CreateHemDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges);
}
