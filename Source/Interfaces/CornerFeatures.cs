namespace Oblikovati.API;

/// <summary>
/// The CornerFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface CornerFeatures : IEnumerable
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
    /// Returns the specified CornerFeature object from the collection. This is the default property of the CornerFeatures collection object.
    /// </summary>
    CornerFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new sheet metal corner feature.
    /// </summary>
    /// <param name="CornerDefinition">Input CornerDefinition object that defines the corner feature you want to create. A CornerDefinition object can be created using the CornerFeature.CreateCornerDefinition method. It can also be obtained from an existing CornerFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerFeature Add([In] [MarshalAs(UnmanagedType.Interface)] CornerDefinition CornerDefinition);
    /// <summary>
    /// Method that creates a new sheet metal corner feature.
    /// </summary>
    /// <param name="Edges">Input EdgeCollection object that contains the two edges that define the two sheet metal faces to create the corner between or the edges to create a ripped corner on.</param>
    /// <param name="RippedCorner">Input Boolean that specifies if the corner is a ripped corner or a seam corner. A value of True indicates a ripped corner.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerDefinition CreateCornerDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] bool RippedCorner);
}
