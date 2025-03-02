namespace Oblikovati.API;

/// <summary>
/// The Profile3D object defines a set of connected curves within a 3D sketch. The Profile3D object is used as input for various features that support 3D sketches as input, such as sweep and loft. See the article in the overviews section.
/// </summary>
public interface Profile3D : IEnumerable
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
    /// Method that returns the specified ProfilePath3D object from the collection.
    /// </summary>
    ProfilePath3D this[int Index] { get; }
    /// <summary>
    /// Property that returns the 3D sketch that the profile was derived from.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property returning the Wires collection object associated with this Profile3D.
    /// </summary>
    Wires Wires { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes this Profile3D object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
