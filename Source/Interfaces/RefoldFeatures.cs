namespace Oblikovati.API;

/// <summary>
/// Object allowing iteration of the collection of RefoldFeature objects, and allows creation of RefoldFeature objects.
/// </summary>
public interface RefoldFeatures : IEnumerable
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
    /// Returns the specified RefoldFeature object from the collection.
    /// </summary>
    RefoldFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of RefoldFeature objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new refold feature.
    /// </summary>
    /// <param name="StationaryFace">Input Face object that specifies the geometry that will remain fixed while other geometry refolds. See Remarks.</param>
    /// <param name="Bends">Optional input ObjectCollection that defines the bend(s) to refold. The bends specified must be in an unfolded state (IsFlat equals True). Not providing this argument or inputting Nothing indicates that all flat bends are to be refolded.</param>
    /// <param name="Sketches">Optional input ObjectCollection that specifies any sketches to be copied and transformed as part of the folding operation. The input sketches must be a child of one of the faces being folded. Also only one sketch per folded face is allowed.</param>
    /// <returns></returns>
    [PreserveSig]
    RefoldFeature Add([In] [MarshalAs(UnmanagedType.Interface)] Face StationaryFace, [In] [MarshalAs(UnmanagedType.Struct)] object? Bends = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Sketches = default);
}
