namespace Oblikovati.API;

/// <summary>
/// The AliasFreeFormFeatures collection object provides access to existing AliasFreeFormFeature objects.
/// </summary>
public interface AliasFreeformFeatures : IEnumerable
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
    /// Returns the specified object from the collection.
    /// </summary>
    AliasFreeformFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BaseBody">BaseBody</param>
    [PreserveSig]
    AliasFreeformFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody BaseBody);
}
