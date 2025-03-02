namespace Oblikovati.API;

/// <summary>
/// FinishParameter Object.
/// </summary>
public interface FinishParameter
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Document of this parameter.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that allows you to get the type of the parameter. The parameter type can be either kModelParameterType, kDerivedParameter, kFinishParameter,&nbsp;kReferenceParameterType, kTableParameterType, or kUserParameterType.
    /// </summary>
    ParameterTypeEnum ParameterType { get; }
    /// <summary>
    /// Gets the user comments against this parameter.
    /// </summary>
    string Comment { get; set; }
    /// <summary>
    /// Property that returns the collection of objects that have a direct dependency on the parameter.
    /// </summary>
    ObjectCollection Dependents { get; }
    /// <summary>
    /// Method that returns the collection objects that the parameter is dependent on.
    /// </summary>
    ObjectCollection DrivenBy { get; }
    /// <summary>
    /// Gets/Sets the name of this parameter.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets/(Sets) the string that denotes the algebraic expression making up the definition of this parameter. Maybe a constant. 'Set' may not be allowed on some parameter types.
    /// </summary>
    string Expression { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _Value { get; set; }
    /// <summary>
    /// Gets/(Sets) the value of this parameter. Numeric values are in database units. Setting this is equivalent to setting the 'Expression' with a constant string. 'Set' may not be allowed on some parameter types.
    /// </summary>
    object Value { get; set; }
    /// <summary>
    /// Gets/(Sets) the units of the parameter. Note that the units is always retrieved as a string, but may be set using a constant from UnitsTypeEnum. 'Set' may not be allowed on some parameter types.
    /// </summary>
    string Units { get; set; }
    /// <summary>
    /// Gets and sets whether this parameter is a key parameter or not. Key parameters are typically those that need to be easily accessed and are designated as key to be filtered out from the rest of the parameters.
    /// </summary>
    bool IsKey { get; set; }
    /// <summary>
    /// Property that returns the expression list associated with this parameter.
    /// </summary>
    ExpressionList ExpressionList { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/(Sets) the Boolean indicating if this parameter is exposed as a property of this Document.
    /// </summary>
    bool ExposedAsProperty { get; set; }
    /// <summary>
    /// Property that returns the tolerance for this parameter. This property returns Nothing in the case where the unit type of this parameter is kTextUnits or kBooleanUnits.
    /// </summary>
    Tolerance Tolerance { get; }
    /// <summary>
    /// Property that returns the evaluation of this parameter (in database units) that is currently used by the model. This takes into account the value computed from the expression and the tolerance. This method is only valid for numeric unit types and will fail for Text and Boolean unit types.
    /// </summary>
    double ModelValue { get; }
    /// <summary>
    /// Gets/(Sets) the setting which is used for determining the method used to compute the model value.
    /// </summary>
    ModelValueTypeEnum ModelValueType { get; set; }
    /// <summary>
    /// Gets/(Sets) the the number of decimal places displayed for this parameter. Note that the precision is used when applying a standard tolerance to the parameter.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Gets and sets the action types valid for this parameter.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns whether whether this parameter is currently in use (by a dimension, feature or by any other parameter).
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the CustomPropertyFormat object associated with this parameter. The CustomPropertyFormat provides control over how the parameter value is formatted when it is exposed as a custom iProperty.
    /// </summary>
    CustomPropertyFormat CustomPropertyFormat { get; }
    /// <summary>
    /// Gets and sets the display format for the parameter.
    /// </summary>
    ParameterDisplayFormatEnum DisplayFormat { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ToleranceInfo { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes this Parameter.
    /// </summary>
    [PreserveSig]
    void Delete();
}
