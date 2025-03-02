namespace Oblikovati.API;

/// <summary>
/// HelicalCurves Object.
/// </summary>
public interface HelicalCurves : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    HelicalCurve this[object Index] { get; }
    /// <summary>
    /// Creates a helical curve shape definition which can be used to create a helical curve.
    /// </summary>
    /// <param name="ShapeDefinitionType">Input HelicalShapeDefinitionTypeEnum that defines the helical curve shape definition type. Valid value includes: kPitchAndRevolutionShapeType, kPitchAndHeightShapeType, kRevolutionAndHeightShapeType and kSpiralShapeType.</param>
    /// <param name="AxisStartPoint">Input Point object that defines the axis start point of the helical curve.</param>
    /// <param name="AxisEndPoint">Input Point object that defines the axis end point of the helical curve.</param>
    /// <param name="CurveStartPoint">Input Point object that defines the start point of the helical curve. This maybe not the exact position of the start point of the helical curve, but defines the direction of the helical curve start point will be in, the direction is from the AxisStartPoint to CurveStartPoint. If the CurveStartPoint is not on the plane that is perpendicular to the axis and across the AxisStartPoint then it will be projected onto the plane.</param>
    /// <param name="Diameter">Input value that defines the diameter of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Pitch">Optional input value that defines the pitch of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType, kPitchAndHeightShapeType or kSpiralShapeType.</param>
    /// <param name="Revolution">Optional input Double value that defines the revolution of the helical curve. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType, kRevolutionAndHeightShapeType or kSpiralShapeType.</param>
    /// <param name="Height">Optional input value that defines the height of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndHeightShapeType or kRevolutionAndHeightShapeType.</param>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurveConstantShapeDefinition CreateConstantShapeDefinition([In] HelicalShapeDefinitionTypeEnum ShapeDefinitionType, [In] [MarshalAs(UnmanagedType.Interface)] Point AxisStartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point AxisEndPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point CurveStartPoint, [In] [MarshalAs(UnmanagedType.Struct)] object Diameter, [In] [MarshalAs(UnmanagedType.Struct)] object? Pitch = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Revolution = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default);
    /// <summary>
    /// Creates a helical curve shape definition which can be used to create a helical curve.
    /// </summary>
    /// <param name="ShapeDefinitionType">Input HelicalShapeDefinitionTypeEnum that defines the helical curve shape definition type. Valid value includes: kPitchAndRevolutionShapeType, kPitchAndHeightShapeType, and kRevolutionAndHeightShapeType.</param>
    /// <param name="AxisStartPoint">Input Point object that defines the axis start point of the helical curve.</param>
    /// <param name="AxisEndPoint">Input Point object that defines the axis end point of the helical curve.</param>
    /// <param name="CurveStartPoint">Input Point object that defines the start point of the helical curve. This maybe not the exact position of the start point of the helical curve, but defines the direction of the helical curve start point will be in, the direction is from the AxisStartPoint to CurveStartPoint. If the CurveStartPoint is not on the plane that is perpendicular to the axis and across the AxisStartPoint then it will be projected onto the plane.</param>
    /// <param name="Diameter">Input value that defines the diameter of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Pitch">Optional input value that defines the pitch of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType, kPitchAndHeightShapeType or kSpiralShapeType.</param>
    /// <param name="Revolution">Optional input Double value that defines the revolution of the helical curve. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType, kRevolutionAndHeightShapeType or kSpiralShapeType.</param>
    /// <param name="Height">Optional input value that defines the height of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndHeightShapeType or kRevolutionAndHeightShapeType.</param>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurveVariableShapeDefinition CreateVariableShapeDefinition([In] HelicalShapeDefinitionTypeEnum ShapeDefinitionType, [In] [MarshalAs(UnmanagedType.Interface)] Point AxisStartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point AxisEndPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point CurveStartPoint, [In] [MarshalAs(UnmanagedType.Struct)] object Diameter, [In] [MarshalAs(UnmanagedType.Struct)] object? Pitch = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Revolution = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default);
    /// <summary>
    /// Creates a helical curve.
    /// </summary>
    /// <param name="HelicalCurveDefinition">Input HelicalCurveDefinition object that defines the inputs of the helical curve.</param>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurve Add([In] [MarshalAs(UnmanagedType.Interface)] HelicalCurveDefinition HelicalCurveDefinition);
}
