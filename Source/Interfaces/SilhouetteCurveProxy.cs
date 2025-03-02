namespace Oblikovati.API;

/// <summary>
/// SilhouetteCurveProxy Object.
/// </summary>
public interface SilhouetteCurveProxy
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets and sets name of the silhouette curve.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-write property gets and set the direction used to calculate the silhouette curve.
    /// </summary>
    object DirectionEntity { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IncludeCoincidentSilhouettes { get; set; }
    /// <summary>
    /// Read-only property that returns a collection of sketch entities that belong to silhouette curve.
    /// </summary>
    SketchEntities3DEnumerator SketchEntities { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object FacesOrBody { get; set; }
    /// <summary>
    /// Read-write property that defines the surfaces the silhouette is calculated for.
    /// </summary>
    SurfaceBody Body { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the faces that are excluded in the silhouette curve projection.
    /// </summary>
    FaceCollection ExcludedFaces { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to exclude the faces that are perpendicular to the project direction from the silhouette curve projection.
    /// </summary>
    bool ExcludeStraightFaces { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to exclude the internal faces from the silhouette curve projection.
    /// </summary>
    bool ExcludeInternalFaces { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SilhouetteCurve NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that breaks the link between the silhouette curve and the model.
    /// </summary>
    [PreserveSig]
    void BreakLink();
    /// <summary>
    /// Method that deletes the silhouette curve. This will delete all of the related sketch entities.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FacesOrBody">FacesOrBody</param>
    /// <param name="DirectionEntity">DirectionEntity</param>
    /// <param name="IncludeCoincidentSilhouettes">IncludeCoincidentSilhouettes</param>
    [PreserveSig]
    SilhouetteCurve _Edit([In] [MarshalAs(UnmanagedType.IDispatch)] object FacesOrBody, [In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] bool IncludeCoincidentSilhouettes);
    /// <summary>
    /// Method that edits all of the inputs used to compute the silhouette curve.&nbsp;This method is more efficient than setting each of the individual properties since this will result in a single compute rather than computing after each property edit.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SilhouetteCurve Edit([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody FacesOrBody, [In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludedFaces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludeStraightFaces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExcludeInternalFaces = default);
}
