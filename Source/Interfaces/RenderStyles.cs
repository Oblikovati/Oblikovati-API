namespace Oblikovati.API;

/// <summary>
/// The RenderStyles collection object allows for the creation of new objects and provides access to existing RenderStyle objects.
/// </summary>
public interface RenderStyles : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    RenderStyle Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new RenderStyle object. The name of the new style is specified, while the rendering attributes are initialized with the same values as the Default style.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the new rendering style. This name must be unique with respect to all other rendering styles defined in the document. The method will fail if the name is not unique.</param>
    /// <returns></returns>
    [PreserveSig]
    RenderStyle Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
}
