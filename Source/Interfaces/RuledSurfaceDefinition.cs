namespace Oblikovati.API;

/// <summary>
/// The RuledSurfaceDefinition Object represents the definition for a RuledSurfaceFeature Object.
/// </summary>
public interface RuledSurfaceDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the ruled surface type.
    /// </summary>
    RuledSurfaceTypeEnum RuledSurfaceType { get; }
    /// <summary>
    /// Read-write property that gets and sets the the extend distance of the ruled surface.
    /// </summary>
    object Distance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the draft angle of the ruled surface.
    /// </summary>
    object DraftAngle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the generatrix curves base on which to create the ruled surface.
    /// </summary>
    object GeneratrixCurves { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to flip the extend direction of the ruled surface.
    /// </summary>
    bool FlipExtendDirection { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RuledSurfaceFeature Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the extend direction of the ruled surface.
    /// </summary>
    object Vector { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a copy of this RuledSurfaceDefinition Object.&nbsp;The new RuledSurfaceDefinition Object is independent of any RuledSurfaceFeature Object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RuledSurfaceDefinition Copy();
    /// <summary>
    /// Method that sets ruled surface to normal to face type.
    /// </summary>
    /// <param name="GeneratrixCurves">Input RuledSurfaceEdgeFacePairs object containing the edges base on which to create the ruled surface. The edges should be connected end-to-end with each other.</param>
    /// <param name="Distance">Input Variant that defines the length of the ruled surface.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="FlipExtendDirection">Optional input Boolean that specifies whether flip the extend direction or not.</param>
    [PreserveSig]
    void SetToNormal([In] [MarshalAs(UnmanagedType.Interface)] RuledSurfaceEdgeFacePairs GeneratrixCurves, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] bool? FlipExtendDirection = false);
    /// <summary>
    /// Method that sets ruled surface to tangent to face type.
    /// </summary>
    /// <param name="GeneratrixCurves">Input RuledSurfaceEdgeFacePairs object containing the edges base on which to create the ruled surface. The edges should be connected end-to-end with each other.</param>
    /// <param name="Distance">Input Variant that defines the length of the ruled surface.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="FlipExtendDirection">Optional input Boolean that specifies whether flip the extend direction or not.</param>
    [PreserveSig]
    void SetToTangent([In] [MarshalAs(UnmanagedType.Interface)] RuledSurfaceEdgeFacePairs GeneratrixCurves, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] bool? FlipExtendDirection = false);
    /// <summary>
    /// Method that sets ruled surface to sweep type.
    /// </summary>
    /// <param name="GeneratrixCurves">Input RuledSurfaceEdgeFacePairs object containing edge face pairs that the edges are connected end-to-end with each other, or Path object containing the 2D/3D sketch curves.</param>
    /// <param name="Distance">Input Variant that defines the length of the ruled surface.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Vector">Input object that defines the extend direction of ruled surface.
    /// Valid inputs are Edge, Face, WorkAxis, WorkPlane, SketchLine, and SketchLine3D.</param>
    /// <param name="FlipExtendDirection">Optional input Boolean that specifies whether flip the extend direction or not.</param>
    [PreserveSig]
    void SetToSweep([In] [MarshalAs(UnmanagedType.IDispatch)] object GeneratrixCurves, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.IDispatch)] object Vector, [In] bool? FlipExtendDirection = false);
}
