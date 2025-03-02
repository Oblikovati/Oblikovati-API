namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface FaceShellProxy
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
    /// Property that returns a collection object generated as a result of the feature.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Gets the referenced by this FaceShell.
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Property that returns the surface body for this face shell.
    /// </summary>
    SurfaceBody SurfaceBody { get; }
    /// <summary>
    /// Indicates whether the FaceShell is closed.
    /// </summary>
    bool IsClosed { get; }
    /// <summary>
    /// Indicates whether the FaceShell is a void.
    /// </summary>
    bool IsVoid { get; }
    /// <summary>
    /// Property that returns a constant indicating whether the specified point is inside, on or outside the body.
    /// </summary>
    ContainmentEnum IsPointInside { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that returns the volume of the component in database units.
    /// </summary>
    double Volume { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that obtains an ID key that can be used to bind back to the live object. This transient key is only valid as long as the document state has not changed. For more information, see the ReferenceKeys overview.
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    FaceShell NativeObject { get; }
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
}
