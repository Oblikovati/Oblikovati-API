namespace Oblikovati.API;

/// <summary>
/// The SketchEllipses object provides access to all the objects in a sketch and provides methods to create additional sketch ellipses. See the article in the overviews section.
/// </summary>
public interface SketchEllipses : IEnumerable
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
    /// Returns the specified SketchEllipse object from the collection.
    /// </summary>
    SketchEllipse Item { get; }
    /// <summary>
    /// Method that creates a new sketch ellipse.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, the ellipse will be attached to the point.</param>
    /// <param name="MajorAxisVector">Input UnitVector2d that defines the direction of the major axis.</param>
    /// <param name="MajorRadius">Input Double that defines the major radius in centimeters.</param>
    /// <param name="MinorRadius">Input Double that defines the minor radius in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEllipse Add([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d MajorAxisVector, [In] double MajorRadius, [In] double MinorRadius);
}
