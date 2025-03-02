namespace Oblikovati.API;

/// <summary>
/// Provides access to all of the objects owned by a particular X and supports the methods to create additional Profiles. See the article in the overviews section.
/// </summary>
public interface Profiles : IEnumerable
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
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified Profile object from the collection.
    /// </summary>
    Profile Item { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    Profile _AddForSolid();
    /// <summary>
    /// Method that creates a profile containing multiple paths for creating solid features. The paths can include sketch curves as well as text boxes. Individual paths in the returned profile may be deleted to obtain the desired profile.
    /// </summary>
    /// <param name="Combine">Optional input Boolean that specifies whether to combine the profile paths obtained when this method is used to create a new profile. For instance, let us take the example of a sketch containing two concentric circles. If this argument is specified to be true, the resulting profile will contain 2 profile paths, and the profile path corresponding to the inner circle will have its AddsMaterial flag set to False. Hence, the resulting profile is a circular disc with a circular cut\-out. If the Combine flag is specified to be False, the resulting profile will contain 2 profile paths with the AddsMaterial flag set to True for both paths. If the sketch contains text boxes, then the profile paths corresponding to them will always have the AddsMaterial flag set to True irrespective of whether the Combine flag is specified to be True or False.</param>
    /// <param name="ProfilePathSegments">Optional input ObjectCollection that can contain sketch curves as well as text boxes. If sketch curves are specified, then the profile created by this method will include profile paths that are comprised of the exact set of sketch curves specified in the ObjectCollection. If text boxes are specified, then the profile created by this method will include profile paths that correspond to the exact set of text boxes specified in the ObjectCollection. Each text box in the collection will correspond to a unique profile path. If not specified, all the possible profile paths including sketch curves as well as text boxes will be included. This argument is ignored if the Combine argument is specified to be True.</param>
    /// <param name="Reserved">Optional input Variant reserved for future use. This argument is currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    Profile AddForSolid([In] bool? Combine = true, [In] [MarshalAs(UnmanagedType.Struct)] object? ProfilePathSegments = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    Profile _AddForSurface();
    /// <summary>
    /// Method that creates a profile for creating surface features. The resulting profile could be open or closed.
    /// </summary>
    /// <param name="Curve">Optional input sketch curve. The method retrieves the end connected chain of entities that this curve is a part of and creates a profile. If not specified, the method will create a new profile by examining the contents of the sketch and creating a single connected path.</param>
    /// <returns></returns>
    [PreserveSig]
    Profile AddForSurface([In] [MarshalAs(UnmanagedType.Struct)] object? Curve = default);
}
