namespace Oblikovati.API;

/// <summary>
/// The MidpointConstraint object represents a constraint that connects a sketch point to the midpoint of a sketch line.
/// </summary>
public interface MidpointConstraint
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
    /// Property that returns the parent sketch of the object.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Indicates whether this object is deletable.
    /// </summary>
    bool Deletable { get; }
    /// <summary>
    /// Property that returns the sketch point being constrained.
    /// </summary>
    SketchPoint Point { get; }
    /// <summary>
    /// Property that returns the sketch line being constrained.
    /// </summary>
    SketchLine Line { get; }
    /// <summary>
    /// Gets the sketch arc being constrained.
    /// </summary>
    SketchArc Arc { get; }
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
