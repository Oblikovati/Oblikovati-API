namespace Oblikovati.API;

/// <summary>
/// The Sketch3D object provides access to the current contents of a specific 3D sketch and its related properties and methods. See the article in the overviews section.
/// </summary>
public interface Sketch3D
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent of the object. This will return the parent PartComponentDefinition.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets name of the 3D sketch.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns a collection of the objects that are dependent on the 3D sketch. Examples of objects that can be returned are profiles, features, work features, other sketches, and assembly constraints.
    /// </summary>
    ObjectsEnumerator Dependents { get; }
    /// <summary>
    /// Property that returns the Profiles3D collection object.
    /// </summary>
    Profiles3D Profiles3D { get; }
    /// <summary>
    /// Property that returns a collection of all geometric entities on the sketch, regardless of their type.
    /// </summary>
    SketchEntities3DEnumerator SketchEntities3D { get; }
    /// <summary>
    /// Property that returns the SketchArcs3D collection object. This collection provides access to the existing arcs and bends in the sketch and provides functionality to create new bends.
    /// </summary>
    SketchArcs3D SketchArcs3D { get; }
    /// <summary>
    /// Property that returns the SketchLines3D collection object. This collection provides access to the existing lines in the sketch and provides functionality to create new lines.
    /// </summary>
    SketchLines3D SketchLines3D { get; }
    /// <summary>
    /// Property that returns the SketchPoints3D collection object. This collection provides access to the existing points in the sketch.
    /// </summary>
    SketchPoints3D SketchPoints3D { get; }
    /// <summary>
    /// Property that returns the SketchCircles3D collection object. This collection provides access to the existing circles in the sketch.
    /// </summary>
    SketchCircles3D SketchCircles3D { get; }
    /// <summary>
    /// Property that returns the SketchEllipses3D collection object. This collection provides access to the existing ellipses in the sketch.
    /// </summary>
    SketchEllipses3D SketchEllipses3D { get; }
    /// <summary>
    /// Property that returns the SketchEllipticalArcs3D collection object. This collection provides access to the existing elliptical arcs in the sketch.
    /// </summary>
    SketchEllipticalArcs3D SketchEllipticalArcs3D { get; }
    /// <summary>
    /// Property that returns the SketchSplines3D collection object. This collection provides access to the existing splines in the sketch.
    /// </summary>
    SketchSplines3D SketchSplines3D { get; }
    /// <summary>
    /// Property that returns the referenced 3D sketch, if there is one. Currently this property always returns 'Nothing'; it was implemented to support future functionality.
    /// </summary>
    Sketch3D ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets and sets the visibility of the sketch.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns a collection of all geometric constraints on the 3D sketch.
    /// </summary>
    GeometricConstraints3D GeometricConstraints3D { get; }
    /// <summary>
    /// Gets whether the 3D Sketch is consumed or not.
    /// </summary>
    bool Consumed { get; }
    /// <summary>
    /// Specifies the override color, if any, for this sketch.
    /// </summary>
    Color OverrideColor { get; set; }
    /// <summary>
    /// Property that gets the collection object.
    /// </summary>
    SketchFixedSplines3D SketchFixedSplines3D { get; }
    /// <summary>
    /// Gets the SilhouetteCurve collection Object.
    /// </summary>
    SilhouetteCurves SilhouetteCurves { get; }
    /// <summary>
    /// Gets and sets the action types valid for this sketch.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Gets and sets whether the dimensions on the sketch are visible.
    /// </summary>
    bool DimensionsVisible { get; set; }
    /// <summary>
    /// Gets and sets whether the sketch is shared or not.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets and sets whether to defer the solving of the sketch.
    /// </summary>
    bool DeferUpdates { get; set; }
    /// <summary>
    /// Property that returns a collection of all dimension constraints on the 3D sketch.
    /// </summary>
    DimensionConstraints3D DimensionConstraints3D { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. If True, the OwnedBy property returns the owning feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Read-only property that returns the client feature that owns this object.&nbsp;This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Read-only property that returns the SketchControlPointSplines3D collection object.&nbsp;This collection provides access to the existing control point splines in the sketch and provides functionality to create new control point curves.
    /// </summary>
    SketchControlPointSplines3D SketchControlPointSplines3D { get; }
    /// <summary>
    /// Read-only property that returns the SketchEquationCurves3D collection object.&nbsp;This collection provides access to the existing equation curves in the sketch and provides functionality to create new equation curves.
    /// </summary>
    SketchEquationCurves3D SketchEquationCurves3D { get; }
    /// <summary>
    /// Read-only property that returns the IntersectionCurves collection object.&nbsp;This collection provides access to the existing intersection curves in the sketch and provides functionality to create new intersection curves.
    /// </summary>
    IntersectionCurves IntersectionCurves { get; }
    /// <summary>
    /// Gets the 3D Sketch OnFaceCurves collection Object.
    /// </summary>
    OnFaceCurves OnFaceCurves { get; }
    /// <summary>
    /// Gets the HelicalCurves collection object.
    /// </summary>
    HelicalCurves HelicalCurves { get; }
    /// <summary>
    /// Gets sketch checksum value.
    /// </summary>
    int CheckSumValue { get; }
    /// <summary>
    /// Read-only property that returns the ProjectToSurfaceCurves collection object. This object provides access to all the existing ProjectToSurfaceCurve objects in the sketch and also provides methods to create new ProjectToSurfaceCurve objects.
    /// </summary>
    ProjectToSurfaceCurves ProjectToSurfaceCurves { get; }
    /// <summary>
    /// Method that deletes the 3D sketch. This method will fail in the cases where the sketch is active, and when there are dependents on the sketch. In the cases where other geometry, besides a feature, is dependent on the sketch, the dependent geometry will be deleted or modified.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that causes the Sketch environment to be invoked with this sketch available for interactive edit.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that causes the Sketch environment to be closed and the user interface to return to the previous environment. This is equivalent to the Return command. This method is only valid in the case where this sketch is open for edit within the user interface. Calling this method in other cases will not do anything.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
    /// <summary>
    /// Method that creates a new sketch entity by copying other entities into the sketch.
    /// </summary>
    /// <param name="Entity">Input object to copy into the sketch. In a part context, valid input includes Edges, 3d sketch entities and planar sketch entities. In an assembly context (where this method is called on a Sketch3DProxy object) this method that includes an entity from one part into a sketch in another part. The valid input in this case includes EdgeProxy objects, the various 3d sketch proxy objects and the various 2d sketch proxy objects.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntity3D Include([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Entity">Entity</param>
    /// <param name="DestinationOccurrence">DestinationOccurrence</param>
    [PreserveSig]
    SketchEntity3D _CrossPartInclude([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence DestinationOccurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from. The argument defines if the end-of-part marker will be positioned just before or just after the object. If the object is contained within another object and is not in the top level of the browser, the positioning of the marker will be relative to the top-level object the calling object is contained within. An example of this case is a sketch that has not been shared and has been consumed by a feature. Another example is a nested work feature.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this 3D sketch A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Method that causes the sketch to solve.
    /// </summary>
    [PreserveSig]
    void Solve();
}
