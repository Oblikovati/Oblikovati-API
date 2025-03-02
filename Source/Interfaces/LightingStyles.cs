namespace Oblikovati.API;

/// <summary>
/// The LightingStyles collection object allows for the creation of new LightingStyle objects and provides access to existing LightingStyle objects.
/// </summary>
public interface LightingStyles : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the specified from the collection.
    /// </summary>
    LightingStyle this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new LightingStyle object. The name of the new style is specified, while the rendering attributes are initialized with the same values as the Default style.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the new rendering style. This name must be unique with respect to all other rendering styles defined in the document. The method will fail if the name is not unique.</param>
    /// <returns></returns>
    [PreserveSig]
    LightingStyle Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
}
