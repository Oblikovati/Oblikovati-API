namespace Oblikovati.API;

/// <summary>
/// HelicalCurveShapeDefinitionRows object.
/// </summary>
public interface HelicalCurveShapeDefinitionRows : IEnumerable
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
    HelicalCurveShapeDefinitionRow Item { get; }
    /// <summary>
    /// Adds a new HelicalCurveShapeDefinitionRow.
    /// </summary>
    /// <param name="Diameter">Input value that defines the diameter of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Pitch">Optional input value that defines the pitch of the helical curve. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType or kPitchAndHeightShapeType.</param>
    /// <param name="Revolution">Optional input Double value that defines the revolution of the helical curve. This is required if  the ShapeDefinitionType is specified as kPitchAndRevolutionShapeType or kRevolutionAndHeightShapeType.</param>
    /// <param name="Height">Optional input value that defines the overall height of the helical curve till this row. This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This is required if  the ShapeDefinitionType is specified as kPitchAndHeightShapeType or kRevolutionAndHeightShapeType.</param>
    /// <param name="Index">Optional input value that specifies the index of the row to insert. If not provided this defaults to 0 means it will be placed at last.</param>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurveShapeDefinitionRow Add([In] [MarshalAs(UnmanagedType.Struct)] object Diameter, [In] [MarshalAs(UnmanagedType.Struct)] object? Pitch = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Revolution = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Index = default);
}
