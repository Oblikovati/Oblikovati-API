namespace Oblikovati.API;

/// <summary>
/// The MoveFaceFeatures object provides access to all of the objects in a component definition and provides methods to create additional MoveFaceFeature objects.
/// </summary>
public interface MoveFaceFeatures : IEnumerable
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
    /// Returns the specified feature object from the collection. This is the default property of this collection object.
    /// </summary>
    MoveFaceFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Move Face feature. The newly created MoveFaceFeature object is returned.
    /// </summary>
    /// <param name="Definition">MoveFaceDefinition object that defines the move face feature you want to create. A MoveFaceDefinition object can be created using the MoveFaceFeatures.CreateDefinition method. It can also be obtained from an existing MoveFaceFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    MoveFaceFeature Add([In] [MarshalAs(UnmanagedType.Interface)] MoveFaceDefinition Definition);
    /// <summary>
    /// Method that creates a new MoveFaceDefinition object
    /// </summary>
    /// <param name="Faces">FaceCollection object that specifies the faces to move.</param>
    /// <returns></returns>
    [PreserveSig]
    MoveFaceDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces);
}
