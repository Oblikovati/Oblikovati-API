namespace Oblikovati.API;

/// <summary>
/// The IntersectionCurves object provides access to all the intersection curve results in a 3D sketch and supports the ability to create new intersection curves.
/// </summary>
public interface IntersectionCurves : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// returns the specified IntersectionCurve object from the collection.
    /// </summary>
    IntersectionCurve this[int Index] { get; }
    /// <summary>
    /// Creates a new intersection curve.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first entity. This can be one of the following: SurfaceBody, Face, WorkPlane or 2D sketch curve object. If a 2D sketch curve is specified, then sketch curves connected with the sketch curve might be automatically included for intersection operation.</param>
    /// <param name="EntityTwo">Input object that defines the second entity or set of entities being intersected by the first entity. This can be one of the following: SurfaceBody, Face, Faces, FaceCollection, WorkPlane or 2D sketch curve object with the following restrictions:
    /// If the EntityOne is a WorkPlane then EntityTwo cannot be a WorkPlane.
    /// If a Faces or FaceCollection object is provided, all the Face objects in the collection must belong to the same SurfaceBody.
    /// If EntityOne is a 2D sketch curve, then EntityTwo must also be a 2D sketch curve in a different 2D sketch. The 2D sketch curves connected with the one specified as EntityTwo might be automatically included for intersection operation.</param>
    /// <returns></returns>
    [PreserveSig]
    IntersectionCurve Add([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo);
}
