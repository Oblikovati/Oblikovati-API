namespace Oblikovati.API;

/// <summary>
/// A TextureCoordinateSet defines the coordinates of the map on the face. The TextureMap.Transformation matrix defines how the coordinates map to the actual face coordinates. Several TextureMaps could reference a single TextureCoordinateSet.
/// </summary>
public interface TextureCoordinateSet
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the specified coordinates from the set.
    /// </summary>
    Point this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of coordinates in this set.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coordinates">Coordinates</param>
    [PreserveSig]
    void GetCoordinates([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] Coordinates);
}
