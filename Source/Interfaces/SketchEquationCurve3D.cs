namespace Oblikovati.API;

/// <summary>
/// The SketchEquationCurve3D object represents an equation curve within a 3D sketch.  The properties and methods listed below are in addition to those supported by the SketchEntity3D object.
/// </summary>
public interface SketchEquationCurve3D
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
    /// Property that returns the parent sketch of the entity.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns a collection of sketch constraints that are tied directly to this entity. This collection consists of geometric and bend constraints.
    /// </summary>
    SketchConstraints3DEnumerator Constraints3D { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Gets and sets whether this entity is a reference entity or not.
    /// </summary>
    bool Reference { get; set; }
    /// <summary>
    /// Property that returns the object this entity is dependent on. When sketch entities are created by projecting model edges or intersecting the model, the resulting entities are driven by the original model entities and cannot be modified. This property returns the model entity the sketch entity is dependent on. The Reference property indicates whether the sketch entity is driven by a model entity or not. If the sketch entity is not referencing a model entity, this property will return Nothing. This property can also return nothing even when the sketch entity is referencing a model entity in the case where the model entity has been consumed by some subsequent modeling operation.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets / sets the Sketch3D Construction Property.
    /// </summary>
    bool Construction { get; set; }
    /// <summary>
    /// Property indicating entity or entities that own this object.
    /// </summary>
    SketchEntities3DEnumerator OwnedBy { get; }
    /// <summary>
    /// Property that returns an enum indicating the constraint status of the sketch entity, signifying whether it is fully constrained, over constrained, or under constrained.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssociativeID { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    /// <summary>
    /// Specifies whether curvature information is displayed for the curve.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Read-only property that returns the sketch point that defines the position of the end of the curve.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Read-only property that gets a BSplineCurve2d geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the spline.
    /// </summary>
    BSplineCurve Geometry { get; }
    /// <summary>
    /// Gets the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Read-only property that gets the sketch point that defines the position of the start of the sketch spline.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Method that deletes the sketch entity.
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CoordinateSystemType">CoordinateSystemType</param>
    /// <param name="XValueOrRadius">XValueOrRadius</param>
    /// <param name="YValueOrTheta">YValueOrTheta</param>
    /// <param name="ZValueOrPhi">ZValueOrPhi</param>
    /// <param name="MinValue">MinValue</param>
    /// <param name="MaxValue">MaxValue</param>
    [PreserveSig]
    void GetEquation([Out] out CoordinateSystemTypeEnum CoordinateSystemType, [Out] [MarshalAs(UnmanagedType.BStr)] out string XValueOrRadius, [Out] [MarshalAs(UnmanagedType.BStr)] out string YValueOrTheta, [Out] [MarshalAs(UnmanagedType.BStr)] out string ZValueOrPhi, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter MinValue, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter MaxValue);
    /// <summary>
    /// Method that returns all of the information that defines the equatino for this curve. To edit use the SetEquation method.
    /// </summary>
    /// <param name="CoordinateSystemType">Enum value indicating if the coordinate system being used is Cartesian or Polar.</param>
    /// <param name="XValueOrRadius">Expression that defines the equation for the X value when using a Cartesian coordinate system and the radius when using a Cylindrical or Spherical coordinate system.</param>
    /// <param name="YValueOrTheta">Expression that defines the equation for the Y value when using a Cartesian coordinate system and the theta value (or angle from the X axis) when using a Cylindrical coordinate system, and the theta value (or azimuth) for a spherical coordinate system.</param>
    /// <param name="ZValueOrPhi">Expression that defines the equation for the Z value when using a Cartesian or Cylindrical coordinate system, and the phi value (or inclination) for a spherical coordinate system.</param>
    /// <param name="MinValue">Input Variant that defines the the minimum value of “t”. This can be either a numeric value or a string and is assigned to the associated parameter. If a string is input, the resulting equation must be unitless.</param>
    /// <param name="MaxValue">Input Variant that defines the the maximum value of “t”. This can be either a numeric value or a string and is assigned to the associated parameter. If a string is input, the resulting equation must be unitless.</param>
    [PreserveSig]
    void SetEquation([In] CoordinateSystemTypeEnum CoordinateSystemType, [In] [MarshalAs(UnmanagedType.BStr)] string XValueOrRadius, [In] [MarshalAs(UnmanagedType.BStr)] string YValueOrTheta, [In] [MarshalAs(UnmanagedType.BStr)] string ZValueOrPhi, [In] [MarshalAs(UnmanagedType.Struct)] object MinValue, [In] [MarshalAs(UnmanagedType.Struct)] object MaxValue);
}
