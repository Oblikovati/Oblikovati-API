namespace Oblikovati.API;

/// <summary>
/// ImportedDWGComponentDefinition Collection Object.
/// </summary>
public interface ImportedDWGComponentDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedComponent Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the full filename of the source file.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Read-write property that gets and sets the translation and rotation of the imported DWG in part space.
    /// </summary>
    Matrix Transformation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the reference origin for the imported DWG component.
    /// </summary>
    object DWGReferenceOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the location plane for the imported DWG component.
    /// </summary>
    object LocationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the object indicating the position for the origin of the imported DWG component.
    /// </summary>
    object LocationOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the position of the imported DWG component origin.
    /// </summary>
    Point2d DWGReferenceOriginInLocationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the absolute rotation angle of the imported DWG component in LocationPlane space.
    /// </summary>
    object DWGRotationInLocationPlane { get; set; }
    /// <summary>
    /// Read-write property determines how solid and surface bodies are handled on import.
    /// </summary>
    ImportDWGBodyStyleEnum ImportDWGBodyStyle { get; set; }
    /// <summary>
    /// Method that creates a copy of this ImportedDWGComponentDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ImportedDWGComponentDefinition Copy();
    /// <summary>
    /// Method that sets the plane and origin to define the location of the imported DWG component.
    /// </summary>
    [PreserveSig]
    void SetLocation([In] [MarshalAs(UnmanagedType.IDispatch)] object LocationPlane, [In] [MarshalAs(UnmanagedType.IDispatch)] object LocationOrigin);
}
