namespace Oblikovati.API;

/// <summary>
/// The UnfoldMethod object provides access to the information associated with a specific unfold method. This object derives from the Style object.
/// </summary>
public interface UnfoldMethod
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingStylesManager _Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the name of the Style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the internal name of the style. The name is the internal English name of the standard style. This name will remain constant and is not affected by locale. This name is never displayed to the user. Note that this name is not guaranteed to be unique.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the location of this style, i.e. local to the document, cached locally in the document, exists in the library. Styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the type of the style.
    /// </summary>
    StyleTypeEnum StyleType { get; }
    /// <summary>
    /// Gets and sets comments associated with the style.
    /// </summary>
    string Comments { get; set; }
    /// <summary>
    /// Property returning the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the type of unfold method used by this UnfoldMethod object. kLinearUnfoldMethod, kBendTableUnfoldMethod, and kCustomEquationUnfoldMethod are possible return values.
    /// </summary>
    UnfoldMethodTypeEnum UnfoldMethodType { get; }
    /// <summary>
    /// Gets/sets the kFactor associated with this unfold method.
    /// </summary>
    string kFactor { get; set; }
    /// <summary>
    /// Gets and sets whether the bend or open angle value is to be used for the angle in equations.
    /// </summary>
    BendAngleTypeEnum BendAngleType { get; set; }
    /// <summary>
    /// Property that reports the number of equations currently associated with this unfold method. This property is only used in the case where the UnfoldMethodType property returns kCustomEquationUnfoldMethod and will return 0 for other unfold method types.
    /// </summary>
    int EquationCount { get; }
    /// <summary>
    /// Property that specifies the type of equation defined for the unfold method. This property is only valid in the case where the UnfoldMethodType property returns kCustomEquationUnfoldMethod. In all other cases the value of this property should be ignored.
    /// </summary>
    UnfoldMethodEquationTypeEnum EquationType { get; }
    /// <summary>
    /// Gets and sets the factor used when unfolding ruled surfaces defined using ellipses and splines.
    /// </summary>
    string SplineFactor { get; set; }
    /// <summary>
    /// Method that deletes the Style/Layer/UnfoldMethod.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Style ConvertToLocal();
    /// <summary>
    /// Method that creates a new local Style object. The newly created style is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a dimension style is being copied, the name must be unique with respect to all the other dimension styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Style Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that writes the bend table information of the UnfoldMethod object into an external file. This method is only valid in the case where UnfoldMethodType is kBendTableUnfoldMethod.
    /// </summary>
    /// <param name="FileName">Input String that specifies the name of the file to write bend table information to.</param>
    [PreserveSig]
    void WriteBendTableToFile([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Method that deletes the specified equation. An equation unfold method always needs to have at least one equation. Deleting the last equation will cause a default equation to be created.
    /// </summary>
    /// <param name="Index">Input Long that specifies which equation to delete. Valid values are 1 to the current value of the UnfoldMethod.EquationCount property.</param>
    [PreserveSig]
    void DeleteEquation([In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    /// <param name="Equation">Equation</param>
    /// <param name="MinimumValue">MinimumValue</param>
    /// <param name="MinimumCompareCondition">MinimumCompareCondition</param>
    /// <param name="BoundedVariable">BoundedVariable</param>
    /// <param name="MaximumValue">MaximumValue</param>
    /// <param name="MaximumCompareCondition">MaximumCompareCondition</param>
    [PreserveSig]
    void GetEquation([In] int Index, [Out] [MarshalAs(UnmanagedType.BStr)] out string Equation, [Out] [MarshalAs(UnmanagedType.BStr)] out string MinimumValue, [Out] out ComparisonTypeEnum MinimumCompareCondition, [Out] [MarshalAs(UnmanagedType.BStr)] out string BoundedVariable, [Out] [MarshalAs(UnmanagedType.BStr)] out string MaximumValue, [Out] out ComparisonTypeEnum MaximumCompareCondition);
    /// <summary>
    /// Method that creates or edits an equation associated with this unfold method. Creating the first equation will change the unfold method be to a custom equation type of unfold method.
    /// </summary>
    /// <param name="Index">Input Long that specifies which equation to set. When editing an existing equation, valid values are 1 to the current value of the UnfoldMethod.EquationCount property. Any value outside of this range will cause a new equation to be created.
    /// If a new equation is created it will be positioned within the existing equations depending on how its bounding conditions compare to the other equations. This is the same behavior as in the user-interface.</param>
    /// <param name="EquationType">Input value from UnfoldMethodEquationTypeEnum that specifies the type of equation being defined.</param>
    /// <param name="Equation">Inputt String that contains the equation. This String uses xml like syntax to allow the inclusion of predefined variables. The available variables and an example of their use are shown below.
    /// <Angle\> - Variable used to specify the bend angle within an equation (β).
    /// <Thickness\> - Variable used to specify the thickness within an equation (μ).
    /// <Radius\> - Variable used to specify the inner radius within an equation (ρ).
    /// <Pi\> - Variable used to specify pi within an equation (π).
    /// Example:
    /// "<Pi\> * ((180 deg - <Angle\>)/180 deg) * (<Radius\> + (<Thickness\>/2 ul) * (0.65 ul + 0.5 ul * log(<Radius\> / <Thickness\>))) – 2 ul * (<Radius\> + <Thickness\> * tan(( 180 deg - <Angle\>) / 2 ul)"</param>
    /// <param name="MinimumValue">Optional input String that specifies the minimum value. This can be any valid expression. If this argument is supplied the MinimumCompareCondition and BoundedVariable arguments must also be provided. The maximum value is optional. If this is not supplied then there is no minimum limit to the value.</param>
    /// <param name="MinimumCompareCondition">Optional input value from ComparisonTypeEnum that specifies the method used to compare the value to the minimum value. Valid values are kGreaterThanComparisonTypekLessThanComparisonType, kGreaterThanOrEqualToComparisonTypekLessThanOrEqualToComparisonType, or kEqualToComparisonType. If this argument is supplied the MinimumValue and BoundedVariable arguments must also be provided.</param>
    /// <param name="BoundedVariable">Optional input String that specifies the name of the variable whose values are being bounded. Possible values are "Angle" (&beta;), "Thickness" (&mu;), and "Radius" (&rho;).</param>
    /// <param name="MaximumValue">Optional input String that specifies the maximum value as an expression. This argument is ignored in the case where the MinimumCompareCondition is kEqualToComparisonType.</param>
    /// <param name="MaximumCompareCondition">Optional input value from ComparisonTypeEnum that specifies the method used to compare the value to the maximum value. Valid values are kLessThanComparisonType or kLessThanOrEqualToComparisonType. This argument is ignored in the case where the MinimumCompareCondition is kEqualToComparisonType.</param>
    [PreserveSig]
    void SetEquation([In] int Index, [In] UnfoldMethodEquationTypeEnum EquationType, [In] [MarshalAs(UnmanagedType.BStr)] string Equation, [In] [MarshalAs(UnmanagedType.BStr)] string? MinimumValue = "0 deg", [In] ComparisonTypeEnum? MinimumCompareCondition = ComparisonTypeEnum.kLessThanOrEqualToComparisonType, [In] [MarshalAs(UnmanagedType.BStr)] string? BoundedVariable = "Angle", [In] [MarshalAs(UnmanagedType.BStr)] string? MaximumValue = "180 deg", [In] ComparisonTypeEnum? MaximumCompareCondition = ComparisonTypeEnum.kLessThanOrEqualToComparisonType);
}
