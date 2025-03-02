namespace Oblikovati.API;

/// <summary>
/// The Welds object provides access to all of the existing welds within a weldment.
/// </summary>
public interface Welds : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified Weld object from the collection.
    /// </summary>
    Weld this[object Index] { get; }
    /// <summary>
    /// Property that returns the CosmeticWelds object.
    /// </summary>
    CosmeticWelds CosmeticWelds { get; }
    /// <summary>
    /// Property that returns the WeldBeads object.
    /// </summary>
    WeldBeads WeldBeads { get; }
    /// <summary>
    /// Method that activates this object for editing by the user.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that causes the current editing environment to be closed and the user interface to return to weldment editing environment.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
}
