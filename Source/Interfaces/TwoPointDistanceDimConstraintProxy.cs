namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface TwoPointDistanceDimConstraintProxy
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
    /// Gets and sets the position of the dimension text.
    /// </summary>
    Point2d TextPoint { get; set; }
    /// <summary>
    /// Gets and sets whether this dimension constraint is driving the geometry or the geometry is defining the value associated with the constraint.
    /// </summary>
    bool Driven { get; set; }
    /// <summary>
    /// Property that returns the parameter associated with this dimension constraint. If the Driven property of the constraint is True, this will return a ReferenceParameter object. Otherwise it will return a ModelParameter object.
    /// </summary>
    Parameter Parameter { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _DisplayValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets the center of the dimension line.
    /// </summary>
    Point2d DimensionCenterPoint { get; }
    /// <summary>
    /// Gets the anchor points of dimension.
    /// </summary>
    ObjectCollection AnchorPoints { get; }
    /// <summary>
    /// Property that returns the first sketch point being constrained.
    /// </summary>
    SketchPoint PointOne { get; }
    /// <summary>
    /// Property that returns the second sketch point being constrained.
    /// </summary>
    SketchPoint PointTwo { get; }
    /// <summary>
    /// Property that indicates an enum indicating if the constraint is controlling the horizontal, vertical, or true distance between the points.
    /// </summary>
    DimensionOrientationEnum Orientation { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    TwoPointDistanceDimConstraint NativeObject { get; }
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
