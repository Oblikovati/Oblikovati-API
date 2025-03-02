namespace Oblikovati.API;

/// <summary>
/// Provides access to the objects associated with the object the collection was obtained from. Using the properties supported by the collection you can access the all of the parameters as a set or by type.
/// </summary>
public interface Parameters : IEnumerable
{
    /// <summary>
    /// Returns the specified Parameter object from the collection. This is the default property of the Parameters collection object.
    /// </summary>
    Parameter Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the ModelParameters collection object.
    /// </summary>
    ModelParameters ModelParameters { get; }
    /// <summary>
    /// Property that returns the ReferenceParameters collection object.
    /// </summary>
    ReferenceParameters ReferenceParameters { get; }
    /// <summary>
    /// Property that returns the UserParameters collection object.
    /// </summary>
    UserParameters UserParameters { get; }
    /// <summary>
    /// Property that returns the ParameterTables collection object.
    /// </summary>
    ParameterTables ParameterTables { get; }
    /// <summary>
    /// Gets/Sets the precision for angular dimensions in this document.
    /// </summary>
    int AngularDimensionPrecision { get; set; }
    /// <summary>
    /// Gets/Sets the standard tolerance for angular dimensions in this document.
    /// </summary>
    string AngularStandardTolerance { get; set; }
    /// <summary>
    /// Gets/Sets the precision for linear dimensions in this document.
    /// </summary>
    int LinearDimensionPrecision { get; set; }
    /// <summary>
    /// Gets/Sets the standard tolerance for linear dimensions in this document.
    /// </summary>
    string LinearStandardTolerance { get; set; }
    /// <summary>
    /// Gets/Sets the dimension display type for dimensions in this document.
    /// </summary>
    DimensionDisplayTypeEnum DimensionDisplayType { get; set; }
    /// <summary>
    /// Gets/Sets the boolean flag indicating whether to use standard tolerances for dimensions in this document.
    /// </summary>
    bool UseStandardTolerances { get; set; }
    /// <summary>
    /// Property that returns the CustomParameterGroups collection object.
    /// </summary>
    CustomParameterGroups CustomParameterGroups { get; }
    /// <summary>
    /// Property that returns the DerivedParameterTables collection object.
    /// </summary>
    DerivedParameterTables DerivedParameterTables { get; }
    /// <summary>
    /// Gets and sets whether to export dimensions to drawings using the standard tolerance values.
    /// </summary>
    bool ExportStandardTolerances { get; set; }
    /// <summary>
    /// Gets and sets whether parameters are displayed as values or expressions in edit boxes when a dimension or a feature is edited.
    /// </summary>
    bool DisplayParameterAsExpression { get; set; }
    /// <summary>
    /// Gets the collection of Finish Feature parameters.
    /// </summary>
    FinishParameters FinishParameters { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Expression">Expression</param>
    /// <param name="UnitsSpecifier">UnitsSpecifier</param>
    [PreserveSig]
    double _GetValueFromExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Method that evaluates the input expression using the units specified and returns a value in database units.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate. This string is evaluated the same ways a string entered in any of the Autodesk Inventor dialogs are evaluated. For example "3 in / 2 cm" is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input variant value that specifies the unit type the expression is to be evaluated with. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in." String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in."</param>
    /// <returns></returns>
    [PreserveSig]
    object GetValueFromExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Method that sets the values of all parameters to be the maximum value as defined by the parameter's tolerance.
    /// </summary>
    [PreserveSig]
    void SetAllToMax();
    /// <summary>
    /// Method that sets the values of all parameters to be the minimum value as defined by the parameter's tolerance.
    /// </summary>
    [PreserveSig]
    void SetAllToMin();
    /// <summary>
    /// Method that sets the values of all parameters to be the nominal value as defined by the parameter's tolerance.
    /// </summary>
    [PreserveSig]
    void SetAllToNominal();
    /// <summary>
    /// Sets the values of all parameters to be the median value as defined by the parameter's tolerance.
    /// </summary>
    [PreserveSig]
    void SetAllToMedian();
    /// <summary>
    /// Returns whether the input expression is valid or not.
    /// </summary>
    /// <param name="Expression">Input String value that specifies the equation. This string is evaluated the same way as strings entered in any of the Inventor dialogs are evaluated. For example '3 in + 2 cm' is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the expression should be evaluated. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum. If the equation references existing parameters, this unit type must be consistent with the unit type defined by the equation, otherwise an error will occur. If the expression does specify a unit type, it should match the unit type specified by the UnitsSpecifier otherwise an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsExpressionValid([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
}
