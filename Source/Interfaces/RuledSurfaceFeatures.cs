namespace Oblikovati.API;

/// <summary>
/// Part RuledSurfaceFeatures Collection Object.
/// </summary>
public interface RuledSurfaceFeatures : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    RuledSurfaceFeature this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new RuledSurfaceFeature Object.
    /// </summary>
    /// <param name="Definition">Input RuledSurfaceDefinition object that defines the ruled surface feature you want to create. An RuledSurfaceDefinition object can be created using the RuledSurfaceFeatures.CreateDefinition method. It can also be obtained from an existing RuledSurfaceFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    RuledSurfaceFeature Add([In] [MarshalAs(UnmanagedType.Interface)] RuledSurfaceDefinition Definition);
    /// <summary>
    /// Method that creates a new RuledSurfaceDefinition Object.
    /// </summary>
    /// <param name="RuledSurfaceType">Input RuledSurfaceTypeEnum to specify the type of the ruled surface.</param>
    /// <param name="GeneratrixCurves">Input RuledSurfaceEdgeFacePairs object or Path containing the 2D or 3D sketch entities base on which to create the ruled surface. If the RuledSurfaceType is specified as  kNormalRuledSurfaceType or kTangentRuledSurfaceType this property should be a RuledSurfaceEdgeFacePairs object including Edge objects which are connected end-to-end with each other. If the RuledSurfaceType is specified as  kSweepRuledSurfaceType this property can either be a RuledSurfaceEdgeFacePairs object including Edge objects which are connected end-to-end with each other or an Path object  including 2D or 3D sketch curves.</param>
    /// <param name="Distance">Input Variant that defines the length of the ruled surface.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Vector">Optional input object that defines the extend direction of ruled surface. This is required if the RuledSurfaceType is specified as kSweepRuledSurfaceType, otherwise this argument is ignored.
    /// Valid inputs are Edge, Face, WorkAxis, WorkPlane, SketchLine,  and SketchLine3D .</param>
    /// <returns></returns>
    [PreserveSig]
    RuledSurfaceDefinition CreateDefinition([In] RuledSurfaceTypeEnum RuledSurfaceType, [In] [MarshalAs(UnmanagedType.IDispatch)] object GeneratrixCurves, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object? Vector = default);
    /// <summary>
    /// Method that creates a new RuledSurfaceEdgeFacePairs object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RuledSurfaceEdgeFacePairs CreateRuledSurfaceEdgeFacePairs();
}
