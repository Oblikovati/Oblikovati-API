namespace Oblikovati.API;

/// <summary>
/// The CircularOccurrencePattern object represents a circular pattern of assembly occurrences.
/// </summary>
public interface CircularOccurrencePattern
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
    /// Property returning the Parameter object that controls the angle offset between pattern instances.
    /// </summary>
    Parameter AngleOffset { get; }
    /// <summary>
    /// Gets/Sets the entity used to define the axis of the pattern.
    /// </summary>
    object AxisEntity { get; set; }
    /// <summary>
    /// Gets/Sets whether the axis direction is in the natural direction of the axis entity or not.
    /// </summary>
    bool AxisEntityNaturalDirection { get; set; }
    /// <summary>
    /// Property returning the Parameter object that controls the number of elements in the pattern.
    /// </summary>
    Parameter ElementCount { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the patterned elements keep the same rotation as their parent occurrences. This defaults to False when the CircularOccurrencePattern is just created indicates that the patterned elements will be rotated.
    /// </summary>
    bool LockRotation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the point used to define the pattern radius against the rotation axis. This property returns Nothing when the LockRotation is False. When the LockRotation is set to True, this property returns a Point object indicating th.
    /// </summary>
    object PatternRadiusPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the enum indicating the positioning method used for the component pattern.
    /// </summary>
    PatternPositioningMethodEnum PositioningMethod { get; set; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
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
