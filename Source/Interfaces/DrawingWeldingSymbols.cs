namespace Oblikovati.API;

/// <summary>
/// DrawingWeldingSymbols Collection Object.
/// </summary>
public interface DrawingWeldingSymbols : IEnumerable
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
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    DrawingWeldingSymbol this[int Index] { get; }
    /// <summary>
    /// Method that creates a drawing welding symbol.
    /// </summary>
    /// <param name="LeaderPoints">Input ObjectCollection containing a series of Point2d objects representing the leader originating at the symbol.  The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to.  A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.  The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="Definitions">Input DrawingWeldingSymbolDefinitions object that defines the input for the DrawingWeldingSymbol. A DrawingWeldingSymbolDefinitions  object can be created using the DrawingWeldingSymbols.CreateDefinitions method. It can also be obtained from an existing DrawingWeldingSymbol object.</param>
    /// <param name="WeldSymbolStyle">Optional input WeldSymbolStyle object to specify the weld symbol style for the object.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingWeldingSymbol Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] DrawingWeldingSymbolDefinitions Definitions, [In] [MarshalAs(UnmanagedType.Struct)] object? WeldSymbolStyle = default);
    /// <summary>
    /// Method that creates a drawing welding symbol definitions object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DrawingWeldingSymbolDefinitions CreateDefinitions();
}
