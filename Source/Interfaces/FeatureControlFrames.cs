namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrames collection object provides access to all the feature control frame symbols on a sheet and provides methods to create additional ones.
/// </summary>
public interface FeatureControlFrames : IEnumerable
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
    /// Method that returns the specified FeatureControlFrame object from the collection.
    /// </summary>
    FeatureControlFrame Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new FeatureControlFrameRows object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FeatureControlFrameRows CreateFeatureControlFrameRows();
    /// <summary>
    /// Method that creates a feature control frame symbol.
    /// </summary>
    /// <param name="LeaderPoints">Input ObjectCollection containing a series of Point2d objects representing the leader originating at the symbol. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="FeatureControlFrameRows">Input FeatureControlFrameRows object containing the definition of the rows of the feature control frame. The FeatureControlFrameRows object is created using the CreateFeatureControlFrameRows method on the FeatureControlFrames collection object.</param>
    /// <param name="AllAroundSymbol">Optional input Boolean that specifies whether to add the all-around indicator to the symbol. The diameter is specified in the leader style. Defaults to False.</param>
    /// <param name="DatumIdentifier">Optional input String that specifies a datum identifier for the feature control frame. This argument is ignored if the associated style does not allow the specification of a datum identifier. This can be checked using the FeatureControlFrameStyle.AllowDatumIdentifier property. The string can contain symbols specified using the StyleOverride tag. For instance, use 'm' to specify m.</param>
    /// <param name="Notes">Optional input String that specifies notes for the feature control frame symbol. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <param name="FeatureControlFrameStyle">Optional input FeatureControlFrameStyle object which specifies the feature control frame style to use for the symbol. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the symbol. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    FeatureControlFrame Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] FeatureControlFrameRows FeatureControlFrameRows, [In] bool? AllAroundSymbol = false, [In] [MarshalAs(UnmanagedType.BStr)] string? DatumIdentifier = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Notes = "", [In] [MarshalAs(UnmanagedType.Struct)] object? FeatureControlFrameStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
