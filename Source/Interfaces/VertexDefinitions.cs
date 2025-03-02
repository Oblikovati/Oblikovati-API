namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface VertexDefinitions : IEnumerable
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
    VertexDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new VertexDefinition within the associated SurfaceBodyDefinition.
    /// </summary>
    /// <param name="Position">Input Point object that specifies the position of the vertex.</param>
    /// <returns></returns>
    [PreserveSig]
    VertexDefinition Add([In] [MarshalAs(UnmanagedType.Interface)] Point Position);
}
