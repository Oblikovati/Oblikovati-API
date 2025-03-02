namespace Oblikovati.API;

/// <summary>
/// The CollinearConstraint object represents a collinear constraint within a sketch.
/// </summary>
public interface CollinearConstraint
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
    /// Property that returns the first sketch entity being constrained.
    /// </summary>
    SketchEntity EntityOne { get; }
    /// <summary>
    /// Property that returns the second sketch entity being constrained.
    /// </summary>
    SketchEntity EntityTwo { get; }
    /// <summary>
    /// Property used in the case where the entity returned by the EntityOne property is an ellipse. This property specifies if the major or minor axis of the ellipse is collinear to EntityTwo. True if it is the major axis.
    /// </summary>
    bool UseEllipseOneMajorAxis { get; }
    /// <summary>
    /// Property used in the case where the entity returned by the EntityTwo property is an ellipse. This property specifies if the major or minor axis of the ellipse is collinear to EntityOne. True if it is the major axis.
    /// </summary>
    bool UseEllipseTwoMajorAxis { get; }
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
