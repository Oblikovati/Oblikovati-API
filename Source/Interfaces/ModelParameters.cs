namespace Oblikovati.API;

/// <summary>
/// Provides access to the model parameters ( objects) associated with the object the collection was obtained from.
/// </summary>
public interface ModelParameters : IEnumerable
{
    /// <summary>
    /// Returns the specified ModelParameter object from the collection.
    /// </summary>
    ModelParameter this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new model parameter given an expression.
    /// </summary>
    /// <param name="Expression">Input String value that specifies the equation for the parameter. This string is evaluated the same way as strings entered in any of the Inventor dialogs are evaluated. For example 'x + 3 in / 2 cm' is a valid string for input.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the parameter is. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum. If the equation references existing parameters, this unit type must be consistent with the unit type defined by the equation, otherwise an error will occur.</param>
    /// <param name="Name">Optional input String value that specifies the name for the parameter. The name must be unique with respect to all other parameters in this document. If a unique name is not specified an error will occur. If not specified, a unique name generated by Inventor is assigned to the parameter.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelParameter AddByExpression([In] [MarshalAs(UnmanagedType.BStr)] string Expression, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Value">Value</param>
    /// <param name="UnitsSpecifier">UnitsSpecifier</param>
    /// <param name="Name">Name</param>
    [PreserveSig]
    ModelParameter _AddByValue([In] double Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a new model parameter given a name and equation.
    /// </summary>
    /// <param name="Value">Specifies the value for the parameter. This value is given in database units for the unit type defined by the UnitsSpecifier argument.</param>
    /// <param name="UnitsSpecifier">Input value that specifies the type of unit the parameter is. The units can be specified using either a string defining a valid unit or an item from the UnitsTypeEnum. If the equation references existing parameters, this unit type must be consistent with the unit type defined by the equation, otherwise an error will occur.</param>
    /// <param name="Name">Optional input String value that specifies the name for the parameter. The name must be unique with respect to all other parameters in this document. If a unique name is not specified an error will occur. If not specified, a unique name generated by Inventor is assigned to the parameter.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelParameter AddByValue([In] [MarshalAs(UnmanagedType.Struct)] object Value, [In] [MarshalAs(UnmanagedType.Struct)] object UnitsSpecifier, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
}
