namespace Oblikovati.API;

/// <summary>
/// Cosmetic Weld Definition Object.
/// </summary>
public interface CosmeticWeldDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that provides access to the area of the cosmetic weld.
    /// </summary>
    object Area { get; set; }
    /// <summary>
    /// Read only property that gets and set the extent type for the weld.
    /// </summary>
    PartFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Read-write property that gets and sets the set of edges the cosmetic weld is on.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Read only property that gets and sets a planar object as beginning plane to terminate the cosmetic weld.
    /// </summary>
    object FromFace { get; }
    /// <summary>
    /// Read only property that gets and sets a planar object as ending plane to terminate the cosmetic weld.
    /// </summary>
    object ToFace { get; }
    /// <summary>
    /// Method that set the extent type to from-to extent for the weld. Calling this method will set the ExtentType to kFromToExtent.
    /// </summary>
    [PreserveSig]
    void SetFromToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace);
    /// <summary>
    /// Method that changes the extents to be “through all” extents.
    /// </summary>
    [PreserveSig]
    void SetThroughAllExtent();
    /// <summary>
    /// Creates a copy of this CosmeticWeldDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CosmeticWeldDefinition Copy();
}
