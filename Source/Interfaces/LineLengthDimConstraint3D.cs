namespace Oblikovati.API;

/// <summary>
/// The LineLengthDimConstraint3D object represents a constraint that controls the length of a 3D sketch line.
/// </summary>
public interface LineLengthDimConstraint3D
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
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets whether this dimension constraint is driving the geometry or the geometry is defining the value associated with the constraint.
    /// </summary>
    bool Driven { get; set; }
    /// <summary>
    /// Property that returns the parameter associated with this dimension constraint. If the Driven property of the constraint is True, this will return a ReferenceParameter object. Otherwise it will return a ModelParameter object.
    /// </summary>
    Parameter Parameter { get; }
    /// <summary>
    /// Gets and sets the position of the dimension text.
    /// </summary>
    Point TextPoint { get; set; }
    /// <summary>
    /// Property that returns the transient dimension plane used to place and position the dimension text for this dimension constraint.
    /// </summary>
    Plane DimensionPlane { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets the anchor points of dimension.
    /// </summary>
    ObjectCollection AnchorPoints { get; }
    /// <summary>
    /// Property that returns the 3D sketch line being constrained.
    /// </summary>
    SketchLine3D Line { get; }
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
