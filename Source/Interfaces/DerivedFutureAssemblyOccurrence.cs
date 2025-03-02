namespace Oblikovati.API;

/// <summary>
/// The DerivedFutureAssemblyOccurrence object defines the behavior of an occurrence within a derived future assembly. This object is derived from the ReferenceComponent object.
/// </summary>
public interface DerivedFutureAssemblyOccurrence
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the occurrences in the top-level of the assembly this DerivedFutureAssemblyOccurrence object represents.&nbsp;This property is only valid in the case where the IsAssembly property is True.
    /// .
    /// </summary>
    DerivedFutureAssemblyOccurrences SubOccurrences { get; }
    /// <summary>
    /// Read-only property that specifies whether this DerivedFutureAssemblyOccurrence object represents a subassembly or a leaf part.&nbsp;This property is True in the case where it represents a subassembly.&nbsp;When it is a subassembly, the SubOccurrences property can be used to access the occurrences within this subassembly.
    /// </summary>
    bool IsAssembly { get; }
    /// <summary>
    /// Read-write property that defines if this occurrence is included and if it is how it is used in the derived assembly.&nbsp;Valid values for this property are kDerivedIncludeAll, kDerivedExcludeAll and kDerivedIndividualDefined.
    /// &nbsp;
    /// If this occurrence represents a subassembly, setting to kDerivedIncludeAll will cause all sub occurrences to add material to the solid body.&nbsp;If setting to kDerivedIndividualDefined, the sub occurrence’s define their behavior.&nbsp;An important distinction between “All” and “IndividualDefined” switches is that as occurrences are added to the subassembly they will automatically be included if any of the “All” switches are used.&nbsp;If the “InidividualDefined” switch is used, new components added to the assembly will be set to kDerivedExludeAll.
    /// If this occurrence represents a leaf part, then valid options are kDerivedIncludeAll or kDerivedExcludeAll.
    /// </summary>
    DerivedComponentOptionEnum InclusionOption { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the name of this DerivedFutureAssemblyOccurrence within the scope of this Document.
    /// </summary>
    string Name { get; }
}
