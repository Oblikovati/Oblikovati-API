namespace Oblikovati.API;

/// <summary>
/// The SketchSplines3D object provides access to all the objects in a sketch and provides methods to create additional sketch splines. See the article in the overviews section.
/// </summary>
public interface SketchSplines3D : IEnumerable
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
    /// Returns the specified SketchSpline3D object from the collection.
    /// </summary>
    SketchSpline3D this[int Index] { get; }
    /// <summary>
    /// Method that creates a sketch spline through the set of input points.
    /// </summary>
    /// <param name="FitPoints">Input that contains the set of points to fit the curve through. The points can be either existing SketchPoint3D objects, SketchPointobjects, workpoints or vertices. If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point. The curve passes through all of the fit points and is related to them by the SplineFitPointsConstraint3D object, which is also automatically created.</param>
    /// <param name="FitMethod">Property that indicates the fit method (SplineFitMethodEnum) used for the spline.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchSpline3D Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection FitPoints, [In] SplineFitMethodEnum? FitMethod = SplineFitMethodEnum.kSweetSplineFit);
}
