namespace Oblikovati.API;

/// <summary>
/// A collection of SketchFillRegion objects.
/// </summary>
public interface SketchFillRegions : IEnumerable
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
    /// Method that returns the specified object from the collection.
    /// </summary>
    SketchFillRegion this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method to add a SketchFillRegion object to the collection.
    /// </summary>
    /// <param name="Profile">The Profile object to use for this region.</param>
    /// <param name="Color">The color for this SketchFillRegion.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchFillRegion Add([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Struct)] object? Color = default);
}
