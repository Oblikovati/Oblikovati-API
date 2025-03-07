namespace Oblikovati.API;

/// <summary>
/// The FeatureBasedOccurrencePattern object represents a feature-based occurrence pattern.
/// </summary>
public interface FeatureBasedOccurrencePattern
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
    /// Property that returns the parent of the object.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Gets/Sets the name for the pattern.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets/Sets the Visible property for the pattern.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property returning an OccurrencePatternElements collection object. The first element within this collection will contain the components that were provided as input for the pattern.
    /// </summary>
    OccurrencePatternElements OccurrencePatternElements { get; }
    /// <summary>
    /// Property that gets and sets the components used as input for the pattern.
    /// </summary>
    ObjectCollection ParentComponents { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that indicates whether this occurrence pattern is itself an element of a parent pattern. In the case where this occurrence pattern represents a pattern element, this property returns True. The PatternElement property can be used to get that pattern element.
    /// </summary>
    bool IsPatternElement { get; }
    /// <summary>
    /// Property that returns the pattern element this occurrence pattern represents. In the case where this occurrence pattern is not part of a parent pattern this property returns Nothing. The IsPatternElement property can be used to check if this occurrence pattern is part of a parent pattern.
    /// </summary>
    OccurrencePatternElement PatternElement { get; }
    /// <summary>
    /// Returns the suppress state of the occurrence pattern.
    /// </summary>
    OccurrencePatternSuppressionEnum Suppressed { get; }
    /// <summary>
    /// Gets/Sets the feature pattern used as input for this occurrence pattern.
    /// </summary>
    object FeaturePattern { get; set; }
    /// <summary>
    /// Method that deletes the pattern.
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
    /// Suppress the occurrence pattern.
    /// </summary>
    /// <param name="SkipDocumentSave">Optional input Boolean that specifies whether to skip document save or not. Default to False indicating the dirty documents will be saved.</param>
    [PreserveSig]
    void Suppress([In] bool? SkipDocumentSave = false);
    /// <summary>
    /// Unsuppress the occurrence pattern.
    /// </summary>
    [PreserveSig]
    void Unsuppress();
}
