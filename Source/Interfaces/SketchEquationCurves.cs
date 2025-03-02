namespace Oblikovati.API;

/// <summary>
/// The SketchEquationCurves object provides access to all the equation curves in a sketch.
/// </summary>
public interface SketchEquationCurves : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchEquationCurve object from the collection
    /// </summary>
    SketchEquationCurve Item { get; }
    /// <summary>
    /// Creates a new sketch equation curve.
    /// </summary>
    /// <param name="EquationType">Enum value indicating if the equation is parametric or explicit.</param>
    /// <param name="CoordinateSystemType">Enum value indicating if the coordinate system being used is Cartesian or Polar.</param>
    /// <param name="XValueOrRadius">Expression that defines the equation for the X value when using a Cartesian coordinate system and the radius when using a Polar coordinate system.</param>
    /// <param name="YValueOrTheta">Expression that defines the equation for the Y value when using a Cartesian coordinate system and the theta value (or angle from the X axis) when using a Polar coordinate system.</param>
    /// <param name="MinValue">Expression defining the minimum value of “t”.</param>
    /// <param name="MaxValue">Expression defining the maximum value of “t”.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEquationCurve Add([In] CurveEquationTypeEnum EquationType, [In] CoordinateSystemTypeEnum CoordinateSystemType, [In] [MarshalAs(UnmanagedType.BStr)] string XValueOrRadius, [In] [MarshalAs(UnmanagedType.BStr)] string YValueOrTheta, [In] [MarshalAs(UnmanagedType.Struct)] object MinValue, [In] [MarshalAs(UnmanagedType.Struct)] object MaxValue);
    /// <summary>
    /// Function that evaluates the provided expression and returns whether it is a valid expression or not.&nbsp;This can be useful when you allow the user to enter an expression and verify that it is valid before attempting to use it.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate.</param>
    /// <param name="Unit">Input variant value that specifies the unit type the expression is to be evaluated with. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in." String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in” or “in^3”.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsValidExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object Unit);
}
