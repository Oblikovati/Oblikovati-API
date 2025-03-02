namespace Oblikovati.API;

/// <summary>
/// Pattern Boundary Settings object.
/// </summary>
public interface PatternBoundarySetting
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the boundary object for the pattern. This can be a FaceCollection object containing planar Face objects or a Profile object.
    /// </summary>
    object Boundary { get; set; }
    /// <summary>
    /// Read-write property that gets and sets boundary inclusion type. Use the SetBoundarySettingData method when set this to kOccurrenceBasePointInclusionType so the OccurrenceBasePoint can be specified also.
    /// </summary>
    PatternBoundaryInclusionEnum BoundaryInclusionType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the occurrence base point. This can be a WorkPoint, Vertex or GeometryIntent indicating the mid point of an edge or center of circular/elliptical edge.
    /// </summary>
    object OccurrenceBasePoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the offset value for the pattern.
    /// </summary>
    object Offset { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the offset is flipped or not.
    /// </summary>
    bool OffsetFlipped { get; set; }
    /// <summary>
    /// Method that creates a copy of this PatternBoundarySetting object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PatternBoundarySetting Copy();
    /// <summary>
    /// Method that sets the boundary setting data.
    /// </summary>
    /// <param name="Boundary">Input object that specifies the boundary for the pattern feature.  This can be a FaceCollection object containing planar Face objects or a Profile object. If a FaceCollection object is specified, all the planar Face objects should be co-planar.</param>
    /// <param name="BoundaryInclusionType">Optional input PatternBoundaryInclusionEnum that specifies the boundary inclusion type. If not provided the default kEnclosedGeometryInclusionType will be used. If set this to kOccurrenceBasePointInclusionType the OccurrenceBasePoint should be specified.</param>
    /// <param name="OccurrenceBasePoint">Optional input point to specify the occurrence base point position. This can be a WorkPoint, Vertex or GeometryIntent indicating the mid point of an edge or center of circular/elliptical edges. This is ignored if the BoundaryInclusionType is not set to kOccurrenceBasePointInclusionType.</param>
    /// <param name="Offset">Optional input value to specify the offset. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a numeric value is input, the units are centimeters.  If a String is input, the units can be specified as part of the string or it will default to the current length units of the document. If not provided this default to 0.</param>
    /// <param name="OffsetFlipped">Optional input Boolean value that specifies whether the offset is flipped or not. If not provided this default to False and the boundary is shrunk based on the offset value. If set to True the boundary is grown based on the offset value.</param>
    /// <param name="Reserved">Reserved argument for future use.</param>
    [PreserveSig]
    void SetBoundarySettingData([In] [MarshalAs(UnmanagedType.Struct)] object Boundary, [In] [MarshalAs(UnmanagedType.Struct)] object? BoundaryInclusionType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? OccurrenceBasePoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Offset = default, [In] [MarshalAs(UnmanagedType.Struct)] object? OffsetFlipped = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Boundary">Boundary</param>
    /// <param name="BoundaryInclusionType">BoundaryInclusionType</param>
    /// <param name="OccurrenceBasePoint">OccurrenceBasePoint</param>
    /// <param name="Offset">Offset</param>
    /// <param name="OffsetFlipped">OffsetFlipped</param>
    /// <param name="Reserved">Reserved</param>
    [PreserveSig]
    void GetBoundarySettingData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Boundary, [Out] out PatternBoundaryInclusionEnum BoundaryInclusionType, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object OccurrenceBasePoint, [Out] out double Offset, [Out] out bool OffsetFlipped, [Out] [MarshalAs(UnmanagedType.Struct)] out object Reserved);
}
