namespace Oblikovati.API;

/// <summary>
/// The ProjectedCut object represents a set of projected cut edges on the sketch.
/// </summary>
public interface ProjectedCut
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
    /// Gets and sets name of the projected cut edges.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the parent sketch of the projected cut edges.
    /// </summary>
    PlanarSketch Parent { get; }
    /// <summary>
    /// Property that returns a collection of sketch entities that belong to the projected cut edges. The sketch entities returned by this property cannot be edited or deleted because they are associated with the projected edges in the model.
    /// </summary>
    SketchEntitiesEnumerator SketchEntities { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that breaks the link between the projected cut edges and the model.
    /// </summary>
    [PreserveSig]
    void BreakLink();
    /// <summary>
    /// Method that deletes the projected cut edges.
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
}
