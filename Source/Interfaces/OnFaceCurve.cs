namespace Oblikovati.API;

/// <summary>
/// OnFaceCurve Object.
/// </summary>
public interface OnFaceCurve
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the curve is closed. Set this to True may result to generate new splines in the curve to make the curve to be closed. Defining a curve to be closed will cause it to close and be periodic if possible at the closure.
    /// </summary>
    bool Closed { get; set; }
    /// <summary>
    /// Read-only property that returns a collection of sketch constraints that are tied directly to this entity. This collection consists of geometric and bend constraints.
    /// </summary>
    SketchConstraints3DEnumerator Constraints3D { get; }
    /// <summary>
    /// Read-only property that returns an enum indicating the constraint status of the sketch entity, signifying whether it is fully constrained, over constrained, or under constrained.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Read-only property that returns the NameValueMap object that contains the faces in sequence that the sketch splines on.
    /// </summary>
    NameValueMap Faces { get; }
    /// <summary>
    /// Read-only property that returns the number of fit points for the curve.
    /// </summary>
    int FitPointCount { get; }
    /// <summary>
    /// Read-only property that returns the SketchPoint3D that defines the position of the start of the curve.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Read-only property that returns the SketchPoint3D that defines the position of the end of the curve.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Read-write properrty that gets and sets name of the OnFaceCurve. When setting this property, the name must be unique with respect to all other OnFaceCurve objects in the document. If the name is not unique an error will occur.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Read-only property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Read-only property that returns a collection of sketch entities that belong to the on face curve.
    /// </summary>
    SketchEntities3DEnumerator SketchEntities { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that breaks the link between the intersection curve and the model.
    /// </summary>
    [PreserveSig]
    void BreakLink();
    /// <summary>
    /// Method that edit the on face curve object.
    /// </summary>
    /// <param name="Faces">Input NameValueMap object that specifies an array of faces to create the splines on. The faces are in sequence and a face should be connected with the faces that are before and after it in the sequence, otherwise an error will occur. The format is as below:
    /// <P>Name = “Face1”. Value = A Face object. The number in the Name is 1-based, and can be increased for more faces to be added.</param>
    /// <param name="FitPoints">Input NameValueMap object that contains an array of ObjectCollection objects that each ObjectCollection specifies the fit points for a spline curve on a face. The format is as below:
    /// <P>Name = “Face1”. Value = An ObjectCollection object that contains the Point or SketchPoint3D objects which indicate the fit points positions. The number in the Name is 1-based and can be increased for more ObjectCollection objects to be added. The name in this argument should be matched to the name in the Faces argument so the fit points are located on the corresponding Face object.
    /// <P>If the count of items in this argument is different from that in the Faces argument or the Name are not matched in the Faces and FitPoints argument, an error occurs.</param>
    [PreserveSig]
    void Edit([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Faces, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap FitPoints);
    /// <summary>
    /// Method that deletes the intersection curve.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Read-only property that returns the fit point at the specified index. The indices correspond to the fit points in order from the start to the end of the splines in the curve. An Index of 1 returns the first SketchPoint3D. The FitPointCount property returns the.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the fit point to return.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchPoint3D FitPoint([In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
