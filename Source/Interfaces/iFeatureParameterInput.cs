namespace Oblikovati.API;

/// <summary>
/// The iFeatureParameterInput object contains the information associated with a parameter of an iFeature.
/// </summary>
public interface iFeatureParameterInput
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
    /// Property that gets the prompt that is used for this input during the placement of the iFeature.
    /// </summary>
    string Prompt { get; }
    /// <summary>
    /// Property that gets the name associated with this input. When placing an iFeature using the API you can use the name to identify each input when assigning the desired values and entities.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property that returns the type of geometry that are valid. The value returned is the sum of values specifying the valid entity types.
    /// </summary>
    iFeatureEntityInputTypeEnum EntityType { get; }
    /// <summary>
    /// Property that returns the parameter in the model this iFeature parameter is dependent on. This property will return Nothing in the case where the iFeatureDefinition object is not associated with an iFeature instance.
    /// </summary>
    Parameter Parameter { get; }
    /// <summary>
    /// Property that gets the expression which specifies the default value and unit. This is the default value of the Expression property. This property will fail in the case where the iFeatureDefinition object is associated with an iFeature instance.
    /// </summary>
    string DefaultExpression { get; }
    /// <summary>
    /// Gets and sets the expression of the parameter.
    /// </summary>
    string Expression { get; set; }
    /// <summary>
    /// Property specifies if this parameter input is used to define the custom depth of a punch tool.
    /// </summary>
    bool IsPunchToolDepth { get; }
    /// <summary>
    /// Property that returns the number of limit values if the LimitType is kParamLimitList. This property will fail in the case where the iFeatureDefinition object is associated with an iFeature instance.
    /// </summary>
    int LimitListCount { get; }
    /// <summary>
    /// Property that returns the limit type of the parameter. If this returns kParamLimitRange, the LimitExpression property will return the upper and lower limits will be two limit values: the value of the lower and upper bounds. If the LimitType property is kParamLimitList there will be n values. This property will fail in the case where the iFeatureDefinition object is associated with an iFeature instance.
    /// </summary>
    iFeatureParamLimitTypeEnum LimitType { get; }
    /// <summary>
    /// Gets/(Sets) the evaluation of this iFeature parameter in database units. Setting this is equivalent to setting the 'Expression' with the constant string.
    /// </summary>
    double Value { get; set; }
    /// <summary>
    /// Method that gets the expressions of the LimitType kParamLimitList. This property will fail in the case where the iFeatureDefinition object is associated with an iFeature instance.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the expression to return.</param>
    /// <returns></returns>
    [PreserveSig]
    string LimitListExpressions([In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LeftLimitValue">LeftLimitValue</param>
    /// <param name="LeftRangeSpec">LeftRangeSpec</param>
    /// <param name="RightRangeSpec">RightRangeSpec</param>
    /// <param name="RightLimitValue">RightLimitValue</param>
    [PreserveSig]
    void LimitRangeExpressions([Out] [MarshalAs(UnmanagedType.BStr)] out string LeftLimitValue, [Out] [MarshalAs(UnmanagedType.BStr)] out string LeftRangeSpec, [Out] [MarshalAs(UnmanagedType.BStr)] out string RightRangeSpec, [Out] [MarshalAs(UnmanagedType.BStr)] out string RightLimitValue);
}
