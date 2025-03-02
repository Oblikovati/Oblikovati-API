namespace Oblikovati.API;

/// <summary>
/// Provides access to all of the 3d profiles owned by a particular 3d sketch and supports the methods to create additional 3d profiles.
/// </summary>
public interface Profiles3D : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified Profile3D object from the collection.
    /// </summary>
    Profile3D Item { get; }
    /// <summary>
    /// Method that creates a new profile by examining the contents of the sketch and creating as many closed paths as possible. The resulting Profile3D is returned.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Profile3D AddClosed();
    /// <summary>
    /// Method that creates a new profile by examining the contents of the sketch for a set of connected entities and creating as many paths as possible. The paths may be open or closed. The resulting Profile3D is returned.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Profile3D AddOpen();
}
