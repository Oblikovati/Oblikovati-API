namespace Oblikovati.API;

/// <summary>
/// The ContourFlangeFeatures collection object provides access to the ContourFlangeFeature objects. It"s also through the ContourFlangeFeatures object that you create new ContourFlangeFeature objects.
/// </summary>
public interface ContourFlangeFeatures : IEnumerable
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
    /// Returns the specified ContourFlangeFeature object from the collection. This is the default property of the ContourFlangeFeatures collection object.
    /// </summary>
    ContourFlangeFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new contour flange feature. The newly created ContourFlangeFeature object is returned.
    /// </summary>
    /// <param name="ContourFlangeDefinition">Input ContourFlangeDefinition object that defines the contour flange feature you want to create. A ContourFlangeDefinition object can be created using the ContourFlangeFeatures.CreateContourFlangeDefinition method. It can also be obtained from an existing ContourFlangeFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    ContourFlangeFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ContourFlangeDefinition ContourFlangeDefinition);
    /// <summary>
    /// Method that creates a new ContourFlangeDefinition object.
    /// </summary>
    /// <param name="Path">Input Path object that specifies the shape of the contour flange.</param>
    /// <param name="Edges">Optional input Object that specifies the edge(s) to create a contour flange feature on. This can be either an Edge object or an EdgeCollection containing at least one Edge object. If all of the edges of a Face are desired, it is up to you to obtain them from the Face and add them to the collection.
    /// Edges are not needed when a contour flange is created using a distance extent and this argument can be omitted in that case. You will need to call the SetDistanceExtent method to set the distance.</param>
    /// <returns></returns>
    [PreserveSig]
    ContourFlangeDefinition CreateContourFlangeDefinition([In] [MarshalAs(UnmanagedType.Interface)] Path Path, [In] [MarshalAs(UnmanagedType.Struct)] object? Edges = default);
}
