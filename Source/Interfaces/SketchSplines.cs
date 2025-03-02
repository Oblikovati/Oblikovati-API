namespace Oblikovati.API;

/// <summary>
/// The SketchSplines object provides access to all the objects in a sketch and provides methods to create additional sketch splines. See the article in the overviews section.
/// </summary>
public interface SketchSplines : IEnumerable
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
    /// Returns the specified SketchSpline object from the collection.
    /// </summary>
    SketchSpline this[int Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FitPoints">FitPoints</param>
    [PreserveSig]
    SketchSpline _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection FitPoints);
    /// <summary>
    /// Method that creates a sketch spline through the set of input points.
    /// </summary>
    /// <param name="FitPoints">Input ObjectCollection that contains the set of points to fit the curve through. The points can be either existing SketchPoint objects or Point2d objects. If a Point2d object is input a SketchPoint is automatically created at that position. The curve passes through all of the fit points and is related to them by SplineFitPointConstraints, which are also automatically created.</param>
    /// <param name="FitMethod">Property that indicates the fit method (SplineFitMethodEnum) used for the spline.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchSpline Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection FitPoints, [In] SplineFitMethodEnum? FitMethod = SplineFitMethodEnum.kSweetSplineFit);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FitPoints">FitPoints</param>
    /// <param name="FitMethod">FitMethod</param>
    [PreserveSig]
    SketchSpline _AddFixedLengthSpline([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection FitPoints, [In] SplineFitMethodEnum? FitMethod = SplineFitMethodEnum.kSweetSplineFit);
}
