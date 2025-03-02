namespace Oblikovati.API;

/// <summary>
/// The UserCoordinateSystems collection object contains all user coordinate systems within the document and provides methods to create additional ones.
/// </summary>
public interface UserCoordinateSystems : IEnumerable
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
    /// Returns the specified UserCoordinateSystem object from the collection.
    /// </summary>
    UserCoordinateSystem this[object Index] { get; }
    /// <summary>
    /// Method that creates a new User Coordinate System. The newly created UserCoordinateSystem object is returned.
    /// </summary>
    /// <param name="Definition">Input UserCoordinateSystemDefinition object that defines the coordinate system you want to create. A UserCoordinateSystemDefinition object can be created using the UserCoordinateSystems.CreateDefinition method. It can also be obtained from an existing UserCoordinateSystem object.</param>
    /// <returns></returns>
    [PreserveSig]
    UserCoordinateSystem Add([In] [MarshalAs(UnmanagedType.Interface)] UserCoordinateSystemDefinition Definition);
    /// <summary>
    /// Method that creates a new UserCoordinateSystemDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UserCoordinateSystemDefinition CreateDefinition();
}
