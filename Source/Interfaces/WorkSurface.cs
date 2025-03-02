namespace Oblikovati.API;

/// <summary>
/// The WorkSurface object represents a work surface, which is a type of work feature.
/// </summary>
public interface WorkSurface
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
    /// Property that returns the parent <link Inventor::ComponentDefinition, ComponentDefinition> object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SurfaceBody _SurfaceBody { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    WorkSurface ReferencedEntity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Specifies the translucency of the work surface.
    /// </summary>
    bool Translucent { get; set; }
    /// <summary>
    /// Specifies the visibility of the work surface.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Suppressed { get; }
    /// <summary>
    /// Property that returns the surface bodies associated with this work surface. A work surface can contain more than one surface body.
    /// </summary>
    SurfaceBodies SurfaceBodies { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
