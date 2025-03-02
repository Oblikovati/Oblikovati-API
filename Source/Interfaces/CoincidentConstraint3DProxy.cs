namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface CoincidentConstraint3DProxy
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
    /// Indicates whether this object can be deleted.
    /// </summary>
    bool Deletable { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SketchPoint3D SketchPoint { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Vertex Vertex { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    WorkPoint WorkPoint { get; }
    /// <summary>
    /// Property that returns the first entity being constrained. This can be a SketchPoint3D, SketchLine3D, WorkPlane or a Face.
    /// </summary>
    object EntityOne { get; }
    /// <summary>
    /// Property that returns the second entity being constrained. This can be a SketchPoint3D, SketchLine3D, WorkPlane or a Face.
    /// </summary>
    object EntityTwo { get; }
    /// <summary>
    /// Property that returns the entity connected to this constraint. This can be a SketchPoint, Vertex or a WorkPoint. This property returns Nothing in the case where there isn't a connected entity.
    /// </summary>
    object ConnectedEntity { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    CoincidentConstraint3D NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the constraint. In the case of coincident constraint, all the connected lines are disconnected and the constraint is deleted.
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
    /// Method that disconnects the input entity from the coincident constraint. Valid inputs are SketchPoint, Vertex or WorkPoint.
    /// </summary>
    /// <param name="Entity">Input object that specifies which entity to disconnect. Valid inputs are , Vertex or WorkPoint.</param>
    [PreserveSig]
    void Disconnect([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
}
