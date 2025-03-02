namespace Oblikovati.API;

/// <summary>
/// The EdgeUseDefinitions collection object provides access to existing EdgeUseDefinition objects, and allows creation of new EdgeUseDefinition objects.
/// </summary>
public interface EdgeUseDefinitions : IEnumerable
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
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    EdgeUseDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new EdgeUseDefinition within the associated EdgeLoopDefinition.
    /// </summary>
    /// <param name="EdgeDefinition">Input EdgeDefinition that defines the geometry for this EdgeUseDefinition.</param>
    /// <param name="IsOpposedToEdge">Input Boolean that indicates if the parameterization of this EdgeUseDefinition is reversed with respect to the associated EdgeDefinition object.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeUseDefinition Add([In] [MarshalAs(UnmanagedType.Interface)] EdgeDefinition EdgeDefinition, [In] bool IsOpposedToEdge);
}
