namespace Oblikovati.API;

/// <summary>
/// The PositionalRepresentation object represents a positional representation in the assembly.
/// </summary>
public interface PositionalRepresentation
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
    /// Property that returns the parent RepresentationsManager object.
    /// </summary>
    RepresentationsManager Parent { get; }
    /// <summary>
    /// Gets and sets the name of the PositionalRepresentation. The name must be unique with respect to all other PositionalRepresentation objects in the document. Cannot be set if this is the master positional representation.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Master { get; }
    /// <summary>
    /// Gets whether this is the primary positional representation.
    /// </summary>
    bool Primary { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that activates the positional representation.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that creates a copy of the PositionalRepresentation. The new created PositionalRepresentation is returned. The method returns an error if this is the 'master' positional representation.
    /// </summary>
    /// <param name="NewName">Optional input string that specifies the name of the positional representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <returns></returns>
    [PreserveSig]
    PositionalRepresentation Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that deletes the PositionalRepresentation. The method returns an error if this is the 'master' positional representation.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    /// <param name="Expression">Expression</param>
    [PreserveSig]
    bool IsConstraintValueOverridden([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint, [Out] [MarshalAs(UnmanagedType.BStr)] out string Expression);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    /// <param name="Expression">Expression</param>
    [PreserveSig]
    void SetConstraintValueOverride([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint, [In] [MarshalAs(UnmanagedType.BStr)] string Expression);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    [PreserveSig]
    void RemoveConstraintValueOverride([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    /// <param name="Suppressed">Suppressed</param>
    [PreserveSig]
    bool IsConstraintSuppressionOverridden([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint, [Out] out bool Suppressed);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    /// <param name="Suppressed">Suppressed</param>
    [PreserveSig]
    void SetConstraintSuppressionOverride([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint, [In] bool Suppressed);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Constraint">Constraint</param>
    [PreserveSig]
    void RemoveConstraintSuppressionOverride([In] [MarshalAs(UnmanagedType.Interface)] AssemblyConstraint Constraint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="Transform">Transform</param>
    [PreserveSig]
    bool IsTransformOverridden([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [Out] [MarshalAs(UnmanagedType.Interface)] out Matrix Transform);
    /// <summary>
    /// Method that sets an override transform on the input occurrence. If not already overridden, the method has the effect of setting the 'Override' flag for the transform (offset).
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence to be overridden.</param>
    /// <param name="Transform">Matrix object that specifies the override transform.</param>
    [PreserveSig]
    void SetTransformOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Transform);
    /// <summary>
    /// Method that removes the transform override for the input occurrence.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence for which the override should be removed.</param>
    [PreserveSig]
    void RemoveTransformOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="Grounded">Grounded</param>
    [PreserveSig]
    bool IsGroundingOverridden([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [Out] out bool Grounded);
    /// <summary>
    /// Method that sets an override grounding state on the input occurrence. If not already overridden, the method has the effect of setting the 'Override' flag for grounding.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence to be overridden.</param>
    /// <param name="Grounded">Boolean that specifies the override grounding state.</param>
    [PreserveSig]
    void SetGroundingOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] bool Grounded);
    /// <summary>
    /// Method that removes the grounding override for the input occurrence.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence for which the override should be removed.</param>
    [PreserveSig]
    void RemoveGroundingOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="Flexible">Flexible</param>
    [PreserveSig]
    bool IsFlexibleOverridden([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [Out] out bool Flexible);
    /// <summary>
    /// Method that sets an override flexible state on the input occurrence. If not already overridden, the method has the effect of setting the 'Override' flag for flexible.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence to be overridden.</param>
    /// <param name="Flexible">Boolean that specifies the override flexible state.</param>
    [PreserveSig]
    void SetFlexibleOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] bool Flexible);
    /// <summary>
    /// Method that removes the flexible override for the input occurrence.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence for which the override should be removed.</param>
    [PreserveSig]
    void RemoveFlexibleOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="Representation">Representation</param>
    [PreserveSig]
    bool IsPositionalRepresentationOverridden([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [Out] [MarshalAs(UnmanagedType.BStr)] out string Representation);
    /// <summary>
    /// Method that sets an override positional representation on the input occurrence. If not already overridden, the method has the effect of setting the 'Override' flag for positional representation.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence to be overridden.</param>
    /// <param name="Representation">Input String that specifies the override positional representation.</param>
    [PreserveSig]
    void SetPositionalRepresentationOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] [MarshalAs(UnmanagedType.BStr)] string Representation);
    /// <summary>
    /// Method that removes the positional representation override for the input occurrence.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the occurrence for which the override should be removed.</param>
    [PreserveSig]
    void RemovePositionalRepresentationOverride([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Pattern">Pattern</param>
    /// <param name="ColumnOffset">ColumnOffset</param>
    [PreserveSig]
    bool IsPatternColumnOffsetOverridden([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern, [Out] [MarshalAs(UnmanagedType.BStr)] out string ColumnOffset);
    /// <summary>
    /// Method that sets an override column offset on the input rectangular pattern. If not already overridden, the method has the effect of setting the 'Override' flag for the column offset.
    /// </summary>
    /// <param name="Pattern">Input RectangularOccurrencePattern object that specifies the pattern to be overridden.</param>
    /// <param name="ColumnOffset">Input String that specifies the override column offset.</param>
    [PreserveSig]
    void SetPatternColumnOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern, [In] [MarshalAs(UnmanagedType.BStr)] string ColumnOffset);
    /// <summary>
    /// Method that removes the column offset override for the input pattern.
    /// </summary>
    /// <param name="Pattern">Input RectangularOccurrencePattern object that specifies the pattern for which the override should be removed.</param>
    [PreserveSig]
    void RemovePatternColumnOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Pattern">Pattern</param>
    /// <param name="RowOffset">RowOffset</param>
    [PreserveSig]
    bool IsPatternRowOffsetOverridden([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern, [Out] [MarshalAs(UnmanagedType.BStr)] out string RowOffset);
    /// <summary>
    /// Method that sets an override row offset on the input rectangular pattern. If not already overridden, the method has the effect of setting the 'Override' flag for the row offset.
    /// </summary>
    /// <param name="Pattern">Input RectangularOccurrencePattern object that specifies the pattern to be overridden.</param>
    /// <param name="RowOffset">Input String that specifies the override row offset.</param>
    [PreserveSig]
    void SetPatternRowOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern, [In] [MarshalAs(UnmanagedType.BStr)] string RowOffset);
    /// <summary>
    /// Method that removes the row offset override for the input pattern.
    /// </summary>
    /// <param name="Pattern">Input RectangularOccurrencePattern object that specifies the pattern for which the override should be removed.</param>
    [PreserveSig]
    void RemovePatternRowOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] RectangularOccurrencePattern Pattern);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Pattern">Pattern</param>
    /// <param name="AngleOffset">AngleOffset</param>
    [PreserveSig]
    bool IsPatternAngleOffsetOverridden([In] [MarshalAs(UnmanagedType.Interface)] CircularOccurrencePattern Pattern, [Out] [MarshalAs(UnmanagedType.BStr)] out string AngleOffset);
    /// <summary>
    /// Method that sets an override angle offset on the input circular pattern. If not already overridden, the method has the effect of setting the 'Override' flag for the angle offset.
    /// </summary>
    /// <param name="Pattern">Input CircularOccurrencePattern object that specifies the pattern to be overridden.</param>
    /// <param name="AngleOffset">Input String that specifies the override angle offset.</param>
    [PreserveSig]
    void SetPatternAngleOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] CircularOccurrencePattern Pattern, [In] [MarshalAs(UnmanagedType.BStr)] string AngleOffset);
    /// <summary>
    /// Method that removes the angle offset override for the input pattern.
    /// </summary>
    /// <param name="Pattern">Input CircularOccurrencePattern object that specifies the pattern for which the override should be removed.</param>
    [PreserveSig]
    void RemovePatternAngleOffsetOverride([In] [MarshalAs(UnmanagedType.Interface)] CircularOccurrencePattern Pattern);
    /// <summary>
    /// Method that clears all the overrides applied to the assembly constraint or joint object.
    /// </summary>
    /// <param name="Relationship">Input an assembly constraint or connection object to clear its overrides.</param>
    [PreserveSig]
    void ClearRelationshipOverrides([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Relationship">Relationship</param>
    /// <param name="Suppressed">Suppressed</param>
    [PreserveSig]
    bool IsRelationshipSuppressionOverridden([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [Out] out bool Suppressed);
    /// <summary>
    /// Method that sets an overridden suppression state for the input assembly relationship.
    /// </summary>
    /// <param name="Relationship">Input an assembly constraint or connection object to set the override.</param>
    /// <param name="Suppressed">Input Boolean that specifies the suppression override state of the assembly constraint or connection object.</param>
    [PreserveSig]
    void SetRelationshipSuppressionOverride([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [In] bool Suppressed);
    /// <summary>
    /// Method that removes the overridden suppression state of the input assembly relationship.
    /// </summary>
    /// <param name="Relationship">Input assembly constraint or connection object for which the override should be removed.</param>
    [PreserveSig]
    void RemoveRelationshipSuppressionOverride([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Relationship">Relationship</param>
    /// <param name="RelationShipValueType">RelationShipValueType</param>
    /// <param name="Expression">Expression</param>
    [PreserveSig]
    bool IsRelationshipValueOverridden([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [In] RelationshipValueTypeEnum RelationShipValueType, [Out] [MarshalAs(UnmanagedType.BStr)] out string Expression);
    /// <summary>
    /// Method that sets an overridden value for the input assembly relationship.
    /// </summary>
    /// <param name="Relationship">Input an assembly constraint or connection object to be queried for the override.</param>
    /// <param name="RelationShipValueType">Input RelationshipValueTypeEnum that specifies the value of the assembly constraint or connection object.</param>
    /// <param name="Expression">Input string that specifies the override expression of the specified value for the assembly constraint or connection object.</param>
    [PreserveSig]
    void SetRelationshipValueOverride([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [In] RelationshipValueTypeEnum RelationShipValueType, [In] [MarshalAs(UnmanagedType.BStr)] string Expression);
    /// <summary>
    /// Method that removes an overridden value of the input assembly relationship.
    /// </summary>
    /// <param name="Relationship">Input assembly constraint or connection object that had the overridden value to remove.</param>
    /// <param name="RelationShipValueType">Input RelationshipValueTypeEnum that specifies the value of the assembly constraint or connection object.</param>
    [PreserveSig]
    void RemoveRelationshipValueOverride([In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [In] RelationshipValueTypeEnum RelationShipValueType);
}
