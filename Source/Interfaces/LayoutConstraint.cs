namespace Oblikovati.API;

/// <summary>
/// The LayoutConstraint object represents a layout constraint within an assembly.
/// </summary>
public interface LayoutConstraint
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Gets/Sets the displayable name of this constraint.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the flush constraint that defines the XY plane of the layout constraint.
    /// </summary>
    FlushConstraint XYFlushConstraint { get; }
    /// <summary>
    /// Property that returns the flush constraint that defines the XZ plane of the layout constraint.
    /// </summary>
    FlushConstraint XZFlushConstraint { get; }
    /// <summary>
    /// Property that returns the flush constraint that defines the YZ plane of the layout constraint.
    /// </summary>
    FlushConstraint YZFlushConstraint { get; }
    /// <summary>
    /// Property that returns the angle constraint that defines the rotation about the Z axis of the layout constraint.
    /// </summary>
    AngleConstraint ZAngleConstraint { get; }
    /// <summary>
    /// Method that deletes the constraint.
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
}
