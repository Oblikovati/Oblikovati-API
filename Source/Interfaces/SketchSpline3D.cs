namespace Oblikovati.API;

/// <summary>
/// The SketchSpline3D object represents a spline within a 3D sketch. See the article in the overviews section.
/// </summary>
public interface SketchSpline3D
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
    /// Property that gets the that defines the position of the end of the spline.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Property that returns the that defines the position of the start of the spline.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Gets and sets a BSplineCurve geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the sketch spline.
    /// </summary>
    BSplineCurve Geometry { get; set; }
    /// <summary>
    /// Double property that returns the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Specifies whether the curve is closed.&nbsp;Setting a curve to be closed will cause it to close and be periodic.
    /// </summary>
    bool Closed { get; set; }
    /// <summary>
    /// Specifies whether curvature information is displayed for the spline.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Specifies the fit method for the spline.
    /// </summary>
    SplineFitMethodEnum FitMethod { get; set; }
    /// <summary>
    /// Property that returns the number of fit points for the spline.
    /// </summary>
    int FitPointCount { get; }
    /// <summary>
    /// Property that returns the at the specified index. The indices correspond to the fit points in order from the start to the end of the spline. An Index of 1 returns the first SketchPoint3D. The FitPointCount property returns the total number of fit points for the spline.
    /// </summary>
    SketchPoint3D FitPoint { get; }
    /// <summary>
    /// Gets and sets the tangent scale parameter at the start point of the spline.
    /// </summary>
    Parameter StartTangentScale { get; }
    /// <summary>
    /// Gets and sets the tangent scale parameter at the end point of the spline.
    /// </summary>
    Parameter EndTangentScale { get; }
    /// <summary>
    /// Gets and sets the tension for the spline.
    /// </summary>
    int Tension { get; set; }
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
    /// Method that inserts a new fit point into the spline and returns the inserted fit point.
    /// </summary>
    /// <param name="FitPoint">Input object that specifies the position of the new fit point. This can be a , a SketchPoint, a workpoint or a vertex. If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the existing fit point to insert the new fit point next to. If not supplied, this value defaults to 0. If the value is 0, then the new fit point is inserted between the two existing fit points that are closest to the new fit point.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the fit point should be inserted before or after the target index. The default is true, meaning that the new fit point will be inserted before the target index. This Boolean is ignored if the TargetIndex specified is 0.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchPoint3D InsertFitPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object FitPoint, [In] int? TargetIndex = default, [In] bool? InsertBefore = true);
    /// <summary>
    /// Method that splits the spline at the specified location. After the split, the original object (the one on which this method was called) represents the part of the spline associated with the original start point. The SketchSpline3D object returned by this method represents the part of the spline associated with the original end point. The curvature of the final result may differ from the original spline.
    /// </summary>
    /// <param name="FitPoint">Input Variant value that specifies the location at which to split the spline. This can be either a numeric value indicating the index of the fit point (the indices corresponding to the fit points in order from the start to the end of the spline, where the first fit point has an index of 1) or it can be an existing fit point.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchSpline3D Split([In] [MarshalAs(UnmanagedType.Struct)] object FitPoint);
    /// <summary>
    /// Method that removes an existing fit point from the spline. This method can have the effect of deleting the sketch point if it is not associated with any other sketch entity.
    /// </summary>
    /// <param name="FitPoint">Input Variant value that specifies the point to disconnect. This can be either a numeric value indicating the index of the fit point (the indices corresponding to the fit points in order from the start to the end of the spline, where the first fit point has an index of 1) or it can be an existing fit point.</param>
    [PreserveSig]
    void Disconnect([In] [MarshalAs(UnmanagedType.Struct)] object FitPoint);
    /// <summary>
    /// Method that returns whether the handle at a given fit point is enabled or disabled.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint3D object that specifies the fit point at which to get the handle status.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetHandleStatus([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint3D FitPoint);
    /// <summary>
    /// Method that sets whether the handle at a given fit point is enabled or disabled.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint3D object that specifies the fit point at which to set the handle status.</param>
    /// <param name="Value">Input Boolean that specifies whether the handle at the input fit point is enabled or disabled.</param>
    [PreserveSig]
    void SetHandleStatus([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint3D FitPoint, [In] bool Value);
    /// <summary>
    /// Method that returns the fit point handle at the given fit point. The method returns Nothing if the handle is not enabled at the input fit point.
    /// </summary>
    /// <param name="FitPoint">Input SketchPoint3D object that specifies the fit point at which to obtain the handle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchSplineHandle3D GetHandle([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint3D FitPoint);
}
