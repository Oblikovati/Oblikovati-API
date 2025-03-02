namespace Oblikovati.API;

/// <summary>
/// Provides access to the user parameters ( <link Inventor::UserParameter, UserParameter> objects) associated with the object the collection was obtained from.
/// </summary>
public interface UserParameters : IEnumerable
{
    /// <summary>
    /// Returns the specified UserParameter object from the collection. This is the default property of the UserParameters collection object.
    /// </summary>
    UserParameter this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new parameter given a name and expression.
    /// </summary>
    /// <param name="Name">Input String value that specifies the name for the parameter. The name must be unique with respect to all other parameters in this document. If a unique name is not specified an error will occur.</param>
    /// <param name="Expression">Input String value that specifies the equation for the parameter. This string is evaluated the same way as strings entered in any of the Autodesk Inventor dialogs are evaluated. For example "x + 3 in / 2 cm" is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the parameter is. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum. If the equation references existing parameters, this unit type must be consistent with the unit type defined by the equation, otherwise an error will occur. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    UserParameter AddByExpression([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="Value">Value</param>
    /// <param name="UnitsSpecifier">UnitsSpecifier</param>
    [PreserveSig]
    UserParameter _AddByValue([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] double Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
    /// <summary>
    /// Method that creates a new parameter given a name and equation.
    /// </summary>
    /// <param name="Name">Input String value that specifies the name for the parameter. The name must be unique with respect to all other parameters in this document. If a unique name is not specified an error will occur.</param>
    /// <param name="Value">Input Double value that specifies the value for the parameter. This value is given in database units for the unit type defined by the UnitType argument.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the parameter is. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum. If the equation references existing parameters, this unit type must be consistent with the unit type defined by the equation, otherwise an error will occur. You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For \example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <returns></returns>
    [PreserveSig]
    UserParameter AddByValue([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier);
}
