namespace Oblikovati.API;

/// <summary>
/// The IntersectionCurve object represents the results of creating an intersection curve calculation.  It consists of one or more sketch entities that represent the intersection of the original input entities.
/// </summary>
public interface IntersectionCurve
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that defines the first entity involved in the intersection.
    /// </summary>
    object EntityOne { get; set; }
    /// <summary>
    /// Read-write property that defines the second entity(s) involved in the intersection.
    /// </summary>
    object EntityTwo { get; set; }
    /// <summary>
    /// Property that gets and sets name of the intersection curve.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-only property that returns the parent 3D sketch of the intersection curve.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Read-only property that returns a collection of sketch entities that belong to the intersection curve. The sketch entities returned by this property cannot be edited or deleted because they are associated with the intersection curve in the model.&nbsp;The BreakLink method can be used to break this association so they are individually editable.
    /// </summary>
    SketchEntities3DEnumerator SketchEntities { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that breaks the link between the intersection curve and the model.&nbsp;This breaks the associativity to the model, allowing you to edit the individual sketch entities.
    /// </summary>
    [PreserveSig]
    void BreakLink();
    /// <summary>
    /// Method that deletes the intersection curve. This will delete all of the related sketch entities.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that edits all of the inputs used to compute the intersection curve.&nbsp;This method is more efficient than setting each of the individual properties since this will result in a single compute rather than computing after each property edit.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first entity. This can be one of the following: SurfaceBody, Face, WorkPlane or 2D sketch curve object. If a 2D sketch curve is specified, the sketch curves connected with the sketch curve might be automatically included for intersection operation.</param>
    /// <param name="EntityTwo">Input object that defines the second entity or set of entities being intersected by the first entity. This can be one of the following: SurfaceBody, Face, Faces, FaceCollection, WorkPlane or 2D sketch curve object with the following restrictions:
    /// If the EntityOne is a WorkPlane then EntityTwo cannot be a WorkPlane.
    /// If a Faces or FaceCollection object is provided, all the Face objects in the collection must belong to the same SurfaceBody.
    /// If EntityOne is a 2D sketch curve, then EntityTwo must also be a 2D sketch curve in a different 2D sketch. The 2D sketch curves connected with the one specified as EntityTwo might be automatically included for intersection operation.</param>
    /// <returns></returns>
    [PreserveSig]
    IntersectionCurve Edit([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
