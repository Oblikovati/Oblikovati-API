namespace Oblikovati.API;

/// <summary>
/// The DraftAnalyses collection object provides access to existing draft analyses and supports the ability to create new draft analysis.
/// </summary>
public interface DraftAnalyses : IEnumerable
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
    /// Method that returns the specified DraftAnalysis object from the collection.
    /// </summary>
    DraftAnalysis Item { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new draft analysis. If the draft analysis is created successfully, a DraftAnalysis object corresponding to the newly created draft analysis is returned from this method.
    /// </summary>
    /// <param name="StartAngle">Input Double that defines the start angle for the draft analysis. The units for the input value will be assumed to be radians. If a value in another units (e.g. degrees) or a string expression needs to be used, the methods of the UnitsOfMeasure object can be used to first convert that value to the corresponding double value in radians units. The converted double value in radians units can then be specified as the input value for this argument.</param>
    /// <param name="EndAngle">Input Double that defines the end angle for the draft analysis. The units for the input value will be assumed to be radians. If a value in another units (e.g. degrees) or a string expression needs to be used, the methods of the UnitsOfMeasure object can be used to first convert that value to the corresponding double value in radians units. The converted double value in radians units can then be specified as the input value for this argument.</param>
    /// <param name="PullDirection">Input Object that defines the direction in which the draft is applied. This can be any one of the following: * Face - planar, cylindrical, conical or torus
    /// For a planar face, the normal direction of the face will be used as the pull direction. For a cylindrical, conical or torus face, the axis direction of the face will be used as the pull direction. * Edge * WorkPlane * WorkAxis
    /// Face and edges that belong to surfaces can also be used to specify the pull direction for the draft analysis. The same limitations that apply for the pull direction when creating a draft analysis interactively through the command also apply when creating a draft analysis using the API.</param>
    /// <param name="Reversed">Optional input Boolean that specifies whether the pull direction of the draft should be reversed. If no value is explicitly specified, then a default value of False will be assumed to indicate that the pull direction will not be reversed.</param>
    /// <param name="Faces">Optional input Variant that specifies an ObjectCollection containing the faces for the draft analysis. If no value is specified for this argument, then all faces in the part will be used for the draft analysis. If only a specific set of faces need to be used for the draft analysis, then they have to be specified as an ObjectCollection. The input collection can contain a combination of Face and WorkSurface objects. If WorkSurface objects are specified, then all faces of the WorkSurface will be used for the draft analysis.</param>
    /// <param name="GradientDisplay">Optional input Boolean that specifies whether the draft analysis results should be displayed as a color gradient. If a value of True is specified, then the draft analysis results will be displayed as a color gradient. If a value of False is specified, then the draft analysis results will be displayed as discrete color bands. If no value is explicitly specified, then a default value of False will be assumed to indicate that the draft analysis results should be displayed as discrete color bands.</param>
    /// <param name="DisplayQuality">Optional input Long that specifies the resolution or surface quality for the color gradient or color bands that represent the draft analysis results. The value indicates a scale, the valid values are in the range of 0 and 10. The specified value will then be interpreted in terms of the percentage value which is the type of value that is specified interactively through the command. For example, if a value of 1 is specified for this argument, this will be indicate a value of 10 percentage.</param>
    /// <param name="Name">Optional input String that specifies the name of the draft analysis. If not specified, Inventor assigns a name to the draft analysis.</param>
    /// <returns></returns>
    [PreserveSig]
    DraftAnalysis Add([In] double StartAngle, [In] double EndAngle, [In] [MarshalAs(UnmanagedType.IDispatch)] object PullDirection, [In] bool? Reversed = false, [In] [MarshalAs(UnmanagedType.Struct)] object? Faces = default, [In] bool? GradientDisplay = false, [In] int? DisplayQuality = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
}
