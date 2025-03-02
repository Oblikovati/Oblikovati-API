namespace Oblikovati.API;

/// <summary>
/// The SketchCircles3D object provides access to all the objects in a sketch. See the article in the overviews section.
/// </summary>
public interface SketchCircles3D : IEnumerable
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
    /// Returns the specified SketchCircle3D object from the collection.
    /// </summary>
    SketchCircle3D Item { get; }
    /// <summary>
    /// Method that creates a new sketch circle at a specified location and radius.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can currently only be a Point object.</param>
    /// <param name="Normal">Input UnitVector that defines the normal of the circle.</param>
    /// <param name="Radius">Input Double that defines the radius of the circle in centimeters</param>
    /// <returns></returns>
    [PreserveSig]
    SketchCircle3D AddByCenterRadius([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] double Radius);
    /// <summary>
    /// Method that creates a new sketch circle passing through the three input points.
    /// </summary>
    /// <param name="StartPoint">Input Point that defines the first point along the circle.</param>
    /// <param name="MidPoint">Input Point that defines the second point along the circle.</param>
    /// <param name="EndPoint">Input Point that defines the third point along the circle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchCircle3D AddByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object MidPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint);
}
