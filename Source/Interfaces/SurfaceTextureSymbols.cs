namespace Oblikovati.API;

/// <summary>
/// The SurfaceTextureSymbols collection object provides access to all the surface texture symbols on a sheet and provides methods to create additional ones.
/// </summary>
public interface SurfaceTextureSymbols : IEnumerable
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
    /// Method that returns the specified SurfaceTextureSymbol object from the collection.
    /// </summary>
    SurfaceTextureSymbol Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LeaderPoints">LeaderPoints</param>
    /// <param name="SurfaceTextureType">SurfaceTextureType</param>
    /// <param name="ForceTail">ForceTail</param>
    /// <param name="Majority">Majority</param>
    /// <param name="AllAroundSymbol">AllAroundSymbol</param>
    /// <param name="MaximumRoughness">MaximumRoughness</param>
    /// <param name="MinimumRoughness">MinimumRoughness</param>
    /// <param name="ProductionMethod">ProductionMethod</param>
    /// <param name="AdditionalProductionMethod">AdditionalProductionMethod</param>
    /// <param name="SamplingLength">SamplingLength</param>
    /// <param name="AdditionalSamplingLength">AdditionalSamplingLength</param>
    /// <param name="LayDirection">LayDirection</param>
    /// <param name="MachiningAllowance">MachiningAllowance</param>
    /// <param name="AdditionalRoughness">AdditionalRoughness</param>
    /// <param name="SurfaceWaviness">SurfaceWaviness</param>
    /// <param name="SurfaceTextureStyle">SurfaceTextureStyle</param>
    /// <param name="Layer">Layer</param>
    [PreserveSig]
    SurfaceTextureSymbol Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] SurfaceTextureTypeEnum? SurfaceTextureType = SurfaceTextureTypeEnum.kBasicSurfaceType, [In] bool? ForceTail = false, [In] bool? Majority = false, [In] bool? AllAroundSymbol = false, [In] [MarshalAs(UnmanagedType.BStr)] string? MaximumRoughness = "", [In] [MarshalAs(UnmanagedType.BStr)] string? MinimumRoughness = "", [In] [MarshalAs(UnmanagedType.BStr)] string? ProductionMethod = "", [In] [MarshalAs(UnmanagedType.BStr)] string? AdditionalProductionMethod = "", [In] [MarshalAs(UnmanagedType.BStr)] string? SamplingLength = "", [In] [MarshalAs(UnmanagedType.BStr)] string? AdditionalSamplingLength = "", [In] LayDirectionTypeEnum? LayDirection = default, [In] [MarshalAs(UnmanagedType.BStr)] string? MachiningAllowance = "", [In] [MarshalAs(UnmanagedType.BStr)] string? AdditionalRoughness = "", [In] [MarshalAs(UnmanagedType.BStr)] string? SurfaceWaviness = "", [In] [MarshalAs(UnmanagedType.Struct)] object? SurfaceTextureStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a surface texture symbol.
    /// </summary>
    /// <param name="LeaderPoints">Input ObjectCollection containing a series of Point2d objects representing the leader originating at the symbol.  The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to.  A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.  The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="SurfaceTextureSymbolDefinition">Input SurfaceTextureSymbolDefinition object that defines the input for the SurfaceTextureSymbol. A SurfaceTextureSymbolDefinition  object can be created using the SurfaceTextureSymbols.CreateDefinition method. It can also be obtained from an existing SurfaceTextureSymbol object.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceTextureSymbol AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceTextureSymbolDefinition SurfaceTextureSymbolDefinition);
    /// <summary>
    /// Method that creates a surface texture definition.
    /// </summary>
    /// <param name="SurfaceTextureStyle">Optional input SurfaceTextureStyle object to determine which standard reference will be used to define the requirements in the SurfaceTextureSymbol. If not specified, the style defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    SurfaceTextureSymbolDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Struct)] object? SurfaceTextureStyle = default);
}
