namespace Oblikovati.API;

/// <summary>
/// The DerivedAssemblyOccurrence object defines the behavior of an occurrence within a derived assembly.
/// </summary>
public interface DerivedAssemblyOccurrence
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the in the assembly document. This can be used to perform additional queries to help to determine whether to include this occurrence or not.
    /// </summary>
    ComponentOccurrence ReferencedOccurrence { get; }
    /// <summary>
    /// Property that returns the in the top-level of the assembly this DerivedAssemblyOccurrence object represents. This property is only valid in the case where the IsAssembly property is True.
    /// </summary>
    DerivedAssemblyOccurrences SubOccurrences { get; }
    /// <summary>
    /// Property that specifies whether this DerivedAssemblyOccurrence object represents a subassembly or a leaf part. This property is True in the case where it represents a subassembly. When it is a subassembly, the SubOccurrences property can be used to access the occurrences within this subassembly.
    /// </summary>
    bool IsAssembly { get; }
    /// <summary>
    /// Property that defines if this occurrence is included and if it is how it is used in the derived assembly. Valid values for this property are kDerivedIncludeAll, kDerivedSubtractAll, kDerivedExcludeAll, kDerivedBoundingBox, kDerivedIntersect and kDerivedIndividualDefined.
    /// </summary>
    DerivedComponentOptionEnum InclusionOption { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the name of the derived occurrence.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns whether this occurrence failed the Boolean operation resulting in creation of separate, independent bodies. This occurs only if the IndependentSolidsOnFailedBoolean property on DerivedAssemblyDefinition is set to true.
    /// </summary>
    bool FailedBooleanOperation { get; }
}
