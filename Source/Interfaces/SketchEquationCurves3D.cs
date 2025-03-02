namespace Oblikovati.API;

/// <summary>
/// The SketchEquationCurves3D object provides access to all the equation curves in a 3D sketch and supports the ability to create new equation curves.
/// </summary>
public interface SketchEquationCurves3D : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified SketchEquationCurve3D object from the collection.
    /// </summary>
    SketchEquationCurve3D this[int Index] { get; }
    /// <summary>
    /// Creates a new sketch equation curve in a 3D sketch.
    /// </summary>
    /// <param name="CoordinateSystemType">Enum value indicating if the coordinate system being used is Cartesian, Cylindrical, or Spherical.</param>
    /// <param name="XValueOrRadius">Expression that defines the equation for the X value when using a Cartesian coordinate system and the radius when using a Cylindrical or Spherical coordinate system.</param>
    /// <param name="YValueOrTheta">Expression that defines the equation for the Y value when using a Cartesian coordinate system and the theta value (or angle from the X axis) when using a Cylindrical coordinate system, and the theta value (or azimuth) for a spherical coordinate system.</param>
    /// <param name="ZValueOrPhi">Expression that defines the equation for the Z value when using a Cartesian or Cylindrical coordinate system, and the phi value (or inclination) for a spherical coordinate system.</param>
    /// <param name="MinValue">Expression defining the minimum value of “t”.</param>
    /// <param name="MaxValue">Expression defining the maximum value of “t”.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEquationCurve3D Add([In] CoordinateSystemTypeEnum CoordinateSystemType, [In] [MarshalAs(UnmanagedType.BStr)] string XValueOrRadius, [In] [MarshalAs(UnmanagedType.BStr)] string YValueOrTheta, [In] [MarshalAs(UnmanagedType.BStr)] string ZValueOrPhi, [In] [MarshalAs(UnmanagedType.Struct)] object MinValue, [In] [MarshalAs(UnmanagedType.Struct)] object MaxValue);
    /// <summary>
    /// Function that evaluates the provided expression and returns whether it is a valid expression or not.&nbsp;This can be useful when you allow the user to enter an expression and verify that it is valid before attempting to use it.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate.</param>
    /// <param name="Unit">Input variant value that specifies the unit type the expression is to be evaluated with. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in." String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in” or “in^3”.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsValidExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object Unit);
}
