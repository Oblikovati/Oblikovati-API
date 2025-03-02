namespace Oblikovati.API;

/// <summary>
/// The iMateResult object represents the result of using an iMate in an assembly.
/// </summary>
public interface iMateResult
{
    /// <summary>
    /// Property that indicates if this iMateResult represents a composite iMate result.
    /// </summary>
    bool IsComposite { get; }
    /// <summary>
    /// Property that returns an AssemblyConstraintstEnumerator containing the constraints associated with this iMate. If the iMate is not a composite iMate this collection will contain one constraint. If it is a composite it can contain any number of constraints.
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Property that returns the parent iMateResult object. This property is only valid in the case when the iMateResult object it is being called from is not a composite. This can be checked for by using the IsComposite property of the iMateResult object.
    /// </summary>
    iMateResult ParentComposite { get; }
    /// <summary>
    /// Property that returns an iMateResultsEnumerator object that provides access to the iMate results object that are part of a composite iMate. This property is only valid in the case when the iMateResult object it is being called from is a composite. This can be checked for by using the IsComposite property of the iMateResult object.
    /// </summary>
    iMateResultsEnumerator Results { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the name of the iMateResult.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets whether the iMateResult is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="iMateDefinition">iMateDefinition</param>
    /// <param name="Entity">Entity</param>
    [PreserveSig]
    void GetInputs([Out] [MarshalAs(UnmanagedType.Interface)] out iMateDefinition iMateDefinition, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Entity);
    /// <summary>
    /// Method that deletes the iMateResult. This method will fail if the iMateResult is a part of a composite iMateResult.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that edits the inputs of an iMate result.
    /// </summary>
    /// <param name="iMateDefinition">Input iMateDefinitionProxy object that defines the input iMate.</param>
    /// <param name="Entity">Input object that defines the second entity. This object can be either a iMateDefinition proxy object or a geometric entity.</param>
    /// <param name="EntityBiasPoint">Optional input Point object that is used to help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the bias point coincident with the iMate. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias point you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="SolutionType">Optional input AngleConstraintSolutionTypeEnum that specifies the solution type when creating an angle constraint. If specified to be kDirectedSolution, the solution always applies the right hand rule. If specified to be kUndirectedSolution, the solution allows either orientation, thus resolving situations where component orientation flips during a constraint drive or drag. The default value is kDirectedSolution.</param>
    [PreserveSig]
    void SetInputs([In] [MarshalAs(UnmanagedType.Interface)] iMateDefinition iMateDefinition, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object? EntityBiasPoint = default, [In] AngleConstraintSolutionTypeEnum? SolutionType = AngleConstraintSolutionTypeEnum.kDirectedSolution);
}
