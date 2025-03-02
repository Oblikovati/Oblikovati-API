namespace Oblikovati.API;

/// <summary>
/// The BreakOperations collection object contains information about all the break operations applied to a drawing view as well as methods to add breaks to the view.
/// </summary>
public interface BreakOperations : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified break operation object from the collection.
    /// </summary>
    BreakOperation Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a break to a drawing view. The newly created BreakOperation object is returned.
    /// </summary>
    /// <param name="Orientation">Input BreakOrientationEnum that specifies whether the orientation of the break is horizontal or vertical. Valid values are kHorizontalBreakOrientation and kVerticalBreakOrientation.</param>
    /// <param name="StartPoint">Input Point2d object that specifies the start point of the break in sheet space. For a horizontal break orientation, only the 'x' component of the point is used and the 'y' component is ignored. For a vertical break, only the 'y' component of the point is used and the 'x' component is ignored.</param>
    /// <param name="EndPoint">Input Point2d object that specifies the end point of the break in sheet space. For a horizontal break orientation, only the 'x' component of the point is used and the 'y' component is ignored. For a vertical break, only the 'y' component of the point is used and the 'x' component is ignored.</param>
    /// <param name="BreakStyle">Optional input BreakStyleEnum that specifies the break style. Valid values are kRectangularBreakStyle and kStructuralBreakStyle. If not specified, a rectangular style break is created.</param>
    /// <param name="DisplayLevel">Optional input Long that specifies the appearance of the break lines. Valid range of values is 1 through10. For rectangular break style, this value controls the quantity or pitch of break edges displayed. For structural break style, this value controls amplitude of break line. If not specified, a value of 5 is used.</param>
    /// <param name="Gap">Optional input Double that specifies the gap (in centimeters) between the break lines. If not specified, a gap value is automatically calculated based on the view size.</param>
    /// <param name="NumberOfSymbols">Optional input Long that specifies the number of break symbols to use for a structural style break. Valid values are 1, 2 and 3. This argument is not applicable and is ignored for rectangular style breaks. If not specified, a value of 1 is assumed.</param>
    /// <param name="PropagateToParentView">Optional input Boolean that specifies whether to apply this break to the parent view as well. This is not applicable in all situations and is ignored if not applicable. The default value is False.</param>
    /// <returns></returns>
    [PreserveSig]
    BreakOperation Add([In] BreakOrientationEnum Orientation, [In] [MarshalAs(UnmanagedType.Interface)] Point2d StartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point2d EndPoint, [In] BreakStyleEnum? BreakStyle = BreakStyleEnum.kRectangularBreakStyle, [In] int? DisplayLevel = default, [In] double? Gap = default, [In] int? NumberOfSymbols = default, [In] bool? PropagateToParentView = false);
}
