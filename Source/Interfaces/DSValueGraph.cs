namespace Oblikovati.API;

/// <summary>
/// The DSValueGraph object represents the graph that defines  a value at various time steps.
/// </summary>
public interface DSValueGraph
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
    /// Gets the number of points in the graph.
    /// </summary>
    int PointCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SegmentIndex">SegmentIndex</param>
    /// <param name="InterpolationType">InterpolationType</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    [PreserveSig]
    void GetSegmentInterpolationType([In] int SegmentIndex, [Out] out DSGraphInterpolationTypeEnum InterpolationType, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap AdditionalInfo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TimeValueArray">TimeValueArray</param>
    [PreserveSig]
    void GetValueArray([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TimeValueArray);
    /// <summary>
    /// Sets the interpolation method used for the specified curve segment.&nbsp;A curve segment is defined as the curve between two of the value points.&nbsp;There are PointCount-1 segments.
    /// </summary>
    /// <param name="SegmentIndex">Input index value of the segment to set the interpolation information for.  This must be a value of 1 to PointCount-1.</param>
    /// <param name="InterpolationType">The type of interpolation to use for this curve segment.</param>
    /// <param name="AdditionalInfo">Additional information used to define the shape of the segment for certain interpolation types.</param>
    [PreserveSig]
    void SetSegmentInterpolationType([In] int SegmentIndex, [In] DSGraphInterpolationTypeEnum InterpolationType, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TimeValueArray">TimeValueArray</param>
    /// <param name="InterpolationType">InterpolationType</param>
    [PreserveSig]
    void SetValueUsingArray([In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] TimeValueArray, [In] DSGraphInterpolationTypeEnum? InterpolationType = DSGraphInterpolationTypeEnum.kLinearRampInterpolationType);
}
