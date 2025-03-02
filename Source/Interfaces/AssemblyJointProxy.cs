namespace Oblikovati.API;

/// <summary>
/// Represents an AssemblyJoint object in a subaussembly within another assemby.
/// </summary>
public interface AssemblyJointProxy
{
    /// <summary>
    /// Read-only property that returns the first of the two occurrences affected by this joint.&nbsp;This is the same as the owning occurrence obtained from the OccurrenceOne property in the case where the owning assembly is not adaptive.&nbsp;Else, this is the first non-adaptive occurrence in the path leading from the owning occurrence to the occurrence that contains the first of the two geometries that this joint is between.
    /// </summary>
    ComponentOccurrence AffectedOccurrenceOne { get; }
    /// <summary>
    /// Read-only property that returns the second of the two occurrences affected by this joint.&nbsp;This is the same as the owning occurrence obtained from the OccurrenceTwo property in the case where the owning assembly is not adaptive.&nbsp;Else, this is the first non-adaptive occurrence in the path leading from the owning occurrence to the occurrence that contains the second of the two geometries that this joint is between.
    /// </summary>
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets the AssemblyJointDefinition object associated with this assembly joint object.
    /// </summary>
    AssemblyJointDefinition Definition { get; set; }
    /// <summary>
    /// Read-only property that returns the DriveSettings object associated with this joint.
    /// </summary>
    DriveSettings DriveSettings { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the degree of freedom of the assembly joint is locked or not.
    /// </summary>
    bool Locked { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the assembly joint.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the degree of freedom of the assembly joint is protected or not.
    /// </summary>
    bool Protected { get; set; }
    /// <summary>
    /// Read-only property that returns the first of the two components this assembly joint is between.
    /// </summary>
    ComponentOccurrence OccurrenceOne { get; }
    /// <summary>
    /// Read-only property that returns the second of the two components this assembly joint is between.
    /// </summary>
    ComponentOccurrence OccurrenceTwo { get; }
    /// <summary>
    /// Read-only property that returns the parent AssemblyComponentDefinition object.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of the object.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the assembly joint is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    AssemblyJoint NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the AssemblyJoint object.
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
}
