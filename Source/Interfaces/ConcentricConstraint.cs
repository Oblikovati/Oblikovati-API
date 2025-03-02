namespace Oblikovati.API;

/// <summary>
/// The Sketch ConcentricConstraint object represents a concentric constraint within a sketch. Makes a circle, arc, ellipse, or elliptical arc concentric to another circle, arc, ellipse, or elliptical arc.
/// </summary>
public interface ConcentricConstraint
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
    /// Gets the sketch entity being constrained.
    /// </summary>
    SketchEntity EntityOne { get; }
    /// <summary>
    /// Gets the sketch entity being constrained.
    /// </summary>
    SketchEntity EntityTwo { get; }
    /// <summary>
    /// Gets a Boolean indicating if the constraint is between the arc and its centerpoint or not.
    /// </summary>
    bool CenterPointConstraint { get; }
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
