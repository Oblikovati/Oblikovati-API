namespace Oblikovati.API;

/// <summary>
/// The UnitsOfMeasure object supports various functions to allow you to interact with the units associated with the document.
/// </summary>
public interface UnitsOfMeasure
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returning the parent Document object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets/Sets the default unit of length for this Document.
    /// </summary>
    UnitsTypeEnum LengthUnits { get; set; }
    /// <summary>
    /// Gets/Sets the default unit of angle for this Document.
    /// </summary>
    UnitsTypeEnum AngleUnits { get; set; }
    /// <summary>
    /// Gets/Sets the default unit of mass for this Document.
    /// </summary>
    UnitsTypeEnum MassUnits { get; set; }
    /// <summary>
    /// Gets/Sets the default unit of time for this Document.
    /// </summary>
    UnitsTypeEnum TimeUnits { get; set; }
    /// <summary>
    /// Gets/Sets the number of places to display after the decimal point, when displaying a length value.
    /// </summary>
    int LengthDisplayPrecision { get; set; }
    /// <summary>
    /// Gets/Sets the number of places to display after the decimal point, when displaying an angle value.
    /// </summary>
    int AngleDisplayPrecision { get; set; }
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
    /// Method that creates a string that represents the input value evaluated using the specified units.
    /// </summary>
    /// <param name="Value">Input Double value that contains the value in database units for the unit category specified in the second argument.</param>
    /// <param name="UnitsSpecifier">Input variant value that specifies the unit type the string is to be returned in. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". string specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    string GetStringFromValue([In] double Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Given a string defining a unit this method returns the corresponding unit from the UnitsTypeEnum constant list. If the unit specified by the string does not exist in the constant list an error will occur. For example, inputting "mm" will return kMillimeterLengthUnits. This method is not currently supported when the UnitsOfMeasure object was obtained using Apprentice.
    /// </summary>
    /// <param name="UnitsString">Input string specifies the unit type.</param>
    /// <returns></returns>
    [PreserveSig]
    UnitsTypeEnum GetTypeFromString([In] [MarshalAs(UnmanagedType.BStr)] string UnitsString);
    /// <summary>
    /// Given a unit type from the UnitsTypeEnum as input, this method returns the string that can be used to specify the same unit type.
    /// </summary>
    /// <param name="UnitsType">Input constant value that specifies the unit type.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetStringFromType([In] UnitsTypeEnum UnitsType);
    /// <summary>
    /// Method that evaluates the two input expressions and determines if the result in units that have the same base unit type.
    /// </summary>
    /// <param name="Expression1">The first expression to be used in the comparison.</param>
    /// <param name="UnitsSpecifier1">Input variant value that specifies the unit type the first expression is to be evaluated with. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch\: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in". A common use of this method will be to evaluate an expression using the current display units of the document. For example if the expression should define a length you can use kDefaultDisplayLengthUnit as the unit specifier so the expression will be evaluated as a length in the current document units. The enum values that specify to use the document default display units are kDefaultDisplayLengthUnit, kDefaultDisplayAngleUnit, kDefaultDisplayMassUnit, kDefaultDisplayTimeUnit, and kDefaultDisplayTemperatureUnit.</param>
    /// <param name="Expression2">The second expression to be used in the comparison.</param>
    /// <param name="UnitsSpecifier2">Input variant value that specifies the unit type the second expression is to be evaluated with. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch\: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in". A common use of this method will be to evaluate an expression using the current display units of the document. For example if the expression should define a length you can use kDefaultDisplayLengthUnit as the unit specifier so the expression will be evaluated as a length in the current document units. The enum values that specify to use the document default display units are kDefaultDisplayLengthUnit, kDefaultDisplayAngleUnit, kDefaultDisplayMassUnit, kDefaultDisplayTimeUnit, and kDefaultDisplayTemperatureUnit.</param>
    /// <returns></returns>
    [PreserveSig]
    bool CompatibleUnits([In] [MarshalAs(UnmanagedType.BStr)] string Expression1, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier1, [In] [MarshalAs(UnmanagedType.BStr)] string Expression2, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier2);
    /// <summary>
    /// Method that converts a value from one unit to another. The input and output unit specifiers must both define compatible units. For example, "in" (inches) and "cm" (centimeters) will work because they both define lengths. If incompatible units are specified, this method will fail. The converted value, in the units specified by the OutputUnitsSpecifier argument is returned.
    /// </summary>
    /// <param name="Value">Input Double value that specifies the value to be converted. This value is in the units specified by the InputUnitsSpecifier argument.</param>
    /// <param name="InputUnitsSpecifier">Input Variant value that specifies the unit type of the input value. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <param name="OutputUnitsSpecifier">Input Variant value that specifies the unit type of the output value. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    double ConvertUnits([In] double Value, [In] [MarshalAs(UnmanagedType.Struct)] object InputUnitsSpecifier, [In] [MarshalAs(UnmanagedType.Struct)] object OutputUnitsSpecifier);
    /// <summary>
    /// This method converts the input expression to a locale-friendly version. For instance, if you input "1.0 in" on a machine set to the German locale, the return value is "1,0 in". In this case, the decimal separator is different.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate. This string is evaluated the same ways a string entered in any of the Autodesk Inventor dialogs are evaluated. For example "3 in / 2 cm" is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input variant value that specifies the unit type the string is to be returned in. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and 'in'. string specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string 'in in in'.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetLocaleCorrectedExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Obtains the driving parameters enumerator corresponding to the input string.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate. This string is evaluated the same ways a string entered in any of the Autodesk Inventor dialogs are evaluated. For example "3 in / 2 cm" is a valid string for input.</param>
    /// <returns></returns>
    [PreserveSig]
    ParametersEnumerator GetDrivingParameters([In] [MarshalAs(UnmanagedType.BStr)] string Expression);
    /// <summary>
    /// Evaluates an input string and returns equivalent database units as a string.
    /// </summary>
    /// <param name="Expression">Input String value that contains the expression to evaluate. This string is evaluated the same ways a string entered in any of the Autodesk Inventor dialogs are evaluated. For example "3 in / 2 cm" is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input Variant value that specifies the unit type of the input value. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    string GetDatabaseUnitsFromExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Obtains the precise string along with the units, given a value. The output units needs to be specified as well.
    /// </summary>
    /// <param name="Value">Value from which to obtain precise string and units.</param>
    /// <param name="UnitsSpecifier">Input variant value that specifies the unit type the string is to be returned in. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". string specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    string GetPreciseStringFromValue([In] double Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Returns whether the input expression is valid or not.
    /// </summary>
    /// <param name="Expression">Input String value that specifies the equation. This string is evaluated the same way as strings entered in any of the Inventor dialogs are evaluated. For example '3 in + 2 cm' is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the expression should be evaluated. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum.  If the expression does specify a unit type, it should match the unit type specified by the UnitsSpecifier, otherwise an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsExpressionValid([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
}
