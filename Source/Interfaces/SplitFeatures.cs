namespace Oblikovati.API;

/// <summary>
/// The Part SplitFeatures object represents a collection of objects.
/// </summary>
public interface SplitFeatures : IEnumerable
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
    /// Returns the specified SplitFeature object from the collection.
    /// </summary>
    SplitFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SketchCurve">SketchCurve</param>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity SketchCurve);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SplitTool">SplitTool</param>
    /// <param name="RemovePositiveSide">RemovePositiveSide</param>
    [PreserveSig]
    SplitFeature SplitPart([In] [MarshalAs(UnmanagedType.IDispatch)] object SplitTool, [In] bool? RemovePositiveSide = true);
    /// <summary>
    /// Method that creates a new SplitFeature by splitting faces of a part. The new SplitFeature is returned.
    /// </summary>
    /// <param name="SplitTool">Input Object that defines the parting line for the split. The input can be a WorkPlane, WorkSurface, SurfaceBody or a Path. Use the CreatePath or CreateSpecifiedPath method on the PartFeatures object to create a Path. Currently, a Path may only consist of 2D sketch elements.</param>
    /// <param name="SplitAll">Optional input Boolean that indicates whether to split all the faces possible on the part. The default is true indicating that all possible faces will be split. If False, the FacesOrBody argument must be supplied as an ObjectCollection and must contain at least one face</param>
    /// <param name="FacesOrBody">Optional input Variant that specifies either an ObjectCollection containing the faces to be split or the SurfaceBody object that contains the faces to be split. If an ObjectCollection of faces is supplied, all the faces must belong to the same body. This argument must be specified if the SplitAll argument is False. If the SplitAll argument is True and this argument is not supplied, all the faces on the solid body are split.</param>
    /// <returns></returns>
    [PreserveSig]
    SplitFeature SplitFaces([In] [MarshalAs(UnmanagedType.IDispatch)] object SplitTool, [In] bool? SplitAll = true, [In] [MarshalAs(UnmanagedType.Struct)] object? FacesOrBody = default);
    /// <summary>
    /// Method that creates a new SplitFeature by splitting a body. The original body is consumed by the operation and two new bodies are created. The new SplitFeature is returned.
    /// </summary>
    /// <param name="SplitTool">Input Object that specifies the entity that will be used to define the split. The input can be a WorkPlane, WorkSurface, or 2D Path. Use the CreatePath or CreateSpecifiedPath method on the PartFeatures object to create a Path. Currently, a Path may only consist of 2D sketch elements.</param>
    /// <param name="Body">Input SurfaceBody object that specifies the body to be split.</param>
    /// <returns></returns>
    [PreserveSig]
    SplitFeature SplitBody([In] [MarshalAs(UnmanagedType.IDispatch)] object SplitTool, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body);
    /// <summary>
    /// Method that creates a new SplitFeature by splitting a solid body. The specified portion of the solid is removed. The new SplitFeature is returned.
    /// </summary>
    /// <param name="SplitTool">Input Object that specifies the entity that will be used to define the split. The input can be a WorkPlane, WorkSurface, or 2D Path. Use the CreatePath or CreateSpecifiedPath method on the PartFeatures object to create a Path. Currently, a Path may only consist of 2D sketch elements.</param>
    /// <param name="Body">Input SurfaceBody object that specifies the body to be trimmed. Only solid bodies are valid.</param>
    /// <param name="RemovePositiveSide">Optional input Boolean that indicates which portion of the split body is to be removed. The default value is True, which indicates that the positive side will be removed.</param>
    /// <returns></returns>
    [PreserveSig]
    SplitFeature TrimSolid([In] [MarshalAs(UnmanagedType.IDispatch)] object SplitTool, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body, [In] bool? RemovePositiveSide = true);
}
