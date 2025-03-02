namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface VertexProxy
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    SurfaceBody Parent { get; }
    /// <summary>
    /// Gets the <link Inventor::Edges, Edges> referenced by this Vertex.
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Property that returns the <link Inventor::Faces, Faces> that this Vertex is referenced from.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Property that returns a Point geometry object. The Point object returned provides information about the position of the vertex.
    /// </summary>
    Point Point { get; }
    /// <summary>
    /// Indicates if this vertex is using tolerant modeling to allow a non-exact model.
    /// </summary>
    bool IsTolerant { get; }
    /// <summary>
    /// Returns the tolerance being used for modeling calculations and this Vertex.
    /// </summary>
    double Tolerance { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that obtains an ID key that can be used to bind back to the live object. This transient key is only valid as long as the document state has not changed. For more information, see the ReferenceKeys overview
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    Vertex NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    [PreserveSig]
    void GetPoint([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Point);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that gets the source vertex that has been overridden by this vertex. The method returns Nothing if this vertex is not an override. An error is returned if this method is called on a vertex in a part.
    /// </summary>
    /// <param name="GetLeafSource">Optional input Boolean that specifies whether to get the 'leaf' source vertex in the case where there are multiple levels of override. If specified to be False, the method returns the next level override vertex. If not specified, the argument defaults to True indicating that the leaf source will be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Vertex GetSourceVertex([In] bool? GetLeafSource = true);
}
