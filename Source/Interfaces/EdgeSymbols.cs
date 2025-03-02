namespace Oblikovati.API;

/// <summary>
/// EdgeSymbols Object.
/// </summary>
public interface EdgeSymbols : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    EdgeSymbol this[int Index] { get; }
    /// <summary>
    /// Method that creates a new edge symbol definition.
    /// </summary>
    /// <param name="ValuePositionType">Optional input EdgeSymbolValuePositionTypeEnum   indicating the text position type of the edge symbol. If not provided, this defaults to kEdgeSymbolValueDirectionVertical.</param>
    /// <param name="IndicationType">Optional input EdgeSymbolIndicationTypeEnum   indicating the indication type. If not provided, this defaults to kAllEdgesIndicationType.</param>
    /// <param name="SymbolOptions">Optional input NameValueMap to specify more options for the definition. Below are the options can be specified:
    /// Name = RangeOfValues. Value = Boolean indicating if use the range of values. If not provided, this defaults to False.
    /// Name = StatesOfAllEdgesAroundProfile. Value = Boolean indicating the states of all edges around the profile of a part. If not provided, this defaults to False.
    /// Name = SidesDefined. Value = Boolean indicating the states of all edges around the profile of a part with sides clearly defined. If not provided, this defaults to False.
    /// Name = ReferenceToISO. Value = Boolean indicating whether to reference to ISO 13715. If not provided, this defaults to False.
    /// Name = VerticalValue. Value = String value indicating the vertical value. This is applicable when the ValuePositionType is set to kEdgeSymbolValueVerticalDirectionDefined or kEdgeSymbolValueVerticalAndHorizontalDirectionDefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = VerticalValueLower. Value = String value indicating the vertical value lower. This is applicable when the RangeOfValues is set to True and ValuePositionType is set to kEdgeSymbolValueVerticalDirectionDefined or kEdgeSymbolValueVerticalAndHorizontalDirectionDefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = HorizontalValue. Value = String value indicating the horizontal value. This is applicable when the ValuePositionType is set to kEdgeSymbolValueHorizontalDirectionDefined or kEdgeSymbolValueVerticalAndHorizontalDirectionDefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = HorizontalValueLower. Value = String value indicating the horizontal value lower. This is applicable when the RangeOfValues is set to True and the ValuePositionType is set to kEdgeSymbolValueHorizontalDirectionDefined or kEdgeSymbolValueVerticalAndHorizontalDirectionDefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = UndefinedValue. Value = String value indicating the direction undefined value. This is applicable when the ValuePositionType is set to kEdgeSymbolValueDirectionUndefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = UndefinedValueLower. Value = String value indicating the direction undefined value lower. This is applicable when the RangeOfValues is set to True and ValuePositionType is set to kEdgeSymbolValueDirectionUndefined. The value should contain at least a sign “+”, “-” or “±”, and if “±” is specified a number should be specified along with it.
    /// Name = Edges. Value = String value indicating the edges text. This is applicable when the SidesDefined is set to True.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeSymbolDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Struct)] object? ValuePositionType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? IndicationType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? SymbolOptions = default);
    /// <summary>
    /// Method that creates a new edge symbol. The newly created EdgeSymbol object is returned.
    /// </summary>
    /// <param name="LeaderPoints">Input ObjectCollection object containing a series of Point2d objects representing the leader originating at the edge symbol. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="EdgeSymbolDefinition">Input EdgeSymbolDefinition object that defines the edge symbol to create.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeSymbol Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] EdgeSymbolDefinition EdgeSymbolDefinition);
}
