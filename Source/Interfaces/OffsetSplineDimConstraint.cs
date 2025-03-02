namespace Oblikovati.API;

/// <summary>
/// The OffsetSplineDimConstraint is automatically created when offset spline dimensions are created. The OffsetDimConstraint object represents a constraint that controls the distance between two parallel lines or a line and a point. This constraint cannot be explicitly deleted.
/// </summary>
public interface OffsetSplineDimConstraint
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
    /// Gets the SketchSpline being constrained.
    /// </summary>
    SketchSpline Spline { get; }
    /// <summary>
    /// Gets the SketchOffsetSpline being constrained to.
    /// </summary>
    SketchOffsetSpline OffsetSpline { get; }
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
