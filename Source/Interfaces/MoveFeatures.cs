namespace Oblikovati.API;

/// <summary>
/// The MoveFeatures object provides access to all of the MoveFeature objects in a part.
/// </summary>
public interface MoveFeatures : IEnumerable
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
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    MoveFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Creates a new move feature.
    /// </summary>
    /// <param name="MoveDefinition">Input MoveDefinition object that defines the input for the move feature.</param>
    /// <returns></returns>
    [PreserveSig]
    MoveFeature Add([In] [MarshalAs(UnmanagedType.Interface)] MoveDefinition MoveDefinition);
    /// <summary>
    /// Creates a MoveDefinition object.
    /// </summary>
    /// <param name="Bodies">Input ObjectCollection object that contains the surface bodies to move. The WorkSurface is also valid to be added into the ObjectCollection to move.</param>
    /// <returns></returns>
    [PreserveSig]
    MoveDefinition CreateMoveDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Bodies);
}
