namespace Oblikovati.API;

/// <summary>
/// The ContentTableColumns object is a collection that provides access to the columns of the table associated with a particular content center family.
/// </summary>
public interface ContentTableColumns : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of ContentTableColumn objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ContentTableColumn object from the collection.
    /// </summary>
    ContentTableColumn Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new column. Any changes to the table are not actually applied until the Save method of the parent ContentFamily object is called.
    /// </summary>
    /// <param name="InternalName">Input String that specifies the internal name of this column.</param>
    /// <param name="DisplayHeading">Input String that specifies the display name of this column. This is the name of the column that the end-user sees within the user interface.</param>
    /// <param name="DataType">Input value from ValueTypeEnum that specifies the type of data within this column. Valid values are: kIntegerType, kDoubleType, kStringType, and kBooleanType.</param>
    /// <param name="Units">Input value that specifies the type of unit the values in the column are. The unit type needs to be specified if the DataType argument is kIntegerType or kDoubleType. For kStringType and kBooleanType this argument is ignored.
    /// You specify a unit type using a value from UnitsTypeEnum or a string that describes a unit. For example, both of the following are valid unit specifiers for inch: kInchLengthUnits and "in". String specifiers are typically used for units that are not defined in the enum list. For example, the volume measure for cubic inches is not defined in the enum list but you can specify it using the string "in in in".</param>
    /// <param name="Expression">Optional input Variant that specifies the expression to use to automatically populate the rows of this column. Not supplying this argument or providing an empty String will result in the default value of '1' being used.
    /// There are two things that can be defined for the expression, a standard expression and limits for a custom expression. These are defined below.
    /// Standard Expression ' This allows you to define an expression and will evaluate it to populate the rows of the table. Expressions can contain expression like you would use to define the value of a parameter and they can also contain the values of other columns. To use the values of other columns enclose the internal name within braces. Here are some examples of valid expression strings.
    /// 20 in
    /// {SIZE}
    /// {TOTAL_LENGTH} ' {HEAD_HEIGHT}
    /// {DIA} / 2
    /// Custom Expression Limits' A custom expression allows the end-user to specify the value when placing the member into an assembly. You can choose to define the limits for this value, i.e. minimum, maximum, increment and default values. These rules are defined using an ExpressionLimits object. You can create this object using the ContentTableColumn.CreateExpressionLimits method.</param>
    /// <param name="PropertySetId">Optional input String that specifies the name of the property set that contains the property. This is the InternalName or Name associated with the property set. If this argument is set you must also set the PropertyIdentifier argument to fully define the property to use.</param>
    /// <param name="PropertyIdentifier">Optional input Variant that identifies a property. This can be a Long value that specifies the PropId or the name of a property. If this argument is set you must also set the PropertySetId argument to fully define the property to use.</param>
    /// <returns></returns>
    [PreserveSig]
    ContentTableColumn Add([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayHeading, [In] ValueTypeEnum DataType, [In] [MarshalAs(UnmanagedType.Struct)] object? Units = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Expression = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PropertySetId = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PropertyIdentifier = default);
    /// <summary>
    /// Method that creates an ExpressionLimits object. This object can be used to define the limits of a custom expression associated with a table column.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ExpressionLimits CreateExpressionLimits();
}
