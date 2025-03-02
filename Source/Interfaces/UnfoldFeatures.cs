namespace Oblikovati.API;

/// <summary>
/// Object allowing iteration of the collection of UnfoldFeature objects, and allows creation of UnfoldFeature objects.
/// </summary>
public interface UnfoldFeatures : IEnumerable
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
    /// Returns the specified UnfoldFeature object from the collection.
    /// </summary>
    UnfoldFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of UnfoldFeature objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new unfold feature.
    /// </summary>
    /// <param name="StationaryFace">Input Face object that specifies the geometry that will remain fixed while other geometry unfolds. See Remarks.</param>
    /// <param name="Bends">Optional input ObjectCollection that defines the bend(s) to unfold. The bends specified must be in a folded state (IsFlat equals False). Not providing this argument or inputting Nothing indicates that all flat bends are to be unfolded.</param>
    /// <param name="Sketches">Optional input ObjectCollection that specifies any sketches to be copied and transformed as part of the unfolding operation. The input sketches must be a child of one of the faces being unfolded. Also only one sketch per unfolded face is allowed.</param>
    /// <returns></returns>
    [PreserveSig]
    UnfoldFeature Add([In] [MarshalAs(UnmanagedType.Interface)] Face StationaryFace, [In] [MarshalAs(UnmanagedType.Struct)] object? Bends = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Sketches = default);
}
