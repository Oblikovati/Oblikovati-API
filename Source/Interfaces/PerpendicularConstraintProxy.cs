namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface PerpendicularConstraintProxy
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
    /// Property that returns the sketch entity being constrained. This will be a line, ellipse, or elliptical arc. In the case where an elliptical entity is returned, the UsesEllipseOneMajorAxis property indicates if the perpendicular constraint is between the major or minor axis of the ellipse.
    /// </summary>
    SketchEntity EntityOne { get; }
    /// <summary>
    /// Property that returns the sketch entity being constrained. This will be a line, ellipse, or elliptical arc. In the case where an elliptical entity is returned, the UsesEllipseTwoMajorAxis property indicates if the perpendicular constraint is between the major or minor axis of the ellipse.
    /// </summary>
    SketchEntity EntityTwo { get; }
    /// <summary>
    /// Property used in the case where the entity returned by the EntityOne property is an ellipse. This property specifies if the major or minor axis of the ellipse is perpendicular to EntityTwo. True if it is the major axis.
    /// </summary>
    bool UseEllipseOneMajorAxis { get; }
    /// <summary>
    /// Property used in the case where the entity returned by the EntityTwo property is an ellipse. This property specifies if the major or minor axis of the ellipse is perpendicular to EntityOne. True if it is the major axis.
    /// </summary>
    bool UseEllipseTwoMajorAxis { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    PerpendicularConstraint NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
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
