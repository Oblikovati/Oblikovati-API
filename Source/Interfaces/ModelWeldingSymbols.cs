namespace Oblikovati.API;

/// <summary>
/// The ModelWeldingSymbols collection object provides access to all the model welding symbols in part or assembly and provides methods to create additional ones.
/// </summary>
public interface ModelWeldingSymbols : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelWeldingSymbol Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a model welding symbol.
    /// </summary>
    /// <param name="Definitions">Input ModelWeldingSymbolDefinitions object that defines the input for the ModelWeldingSymbol. A ModelWeldingSymbolDefinitions object can be created using the ModelWeldingSymbols.CreateDefinitions method. It can also be obtained from an existing ModelWeldingSymbol object.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelWeldingSymbol Add([In] [MarshalAs(UnmanagedType.Interface)] ModelWeldingSymbolDefinitions Definitions);
    /// <summary>
    /// Method that creates a model welding symbol definitions object.
    /// </summary>
    /// <param name="LeaderPoints">ObjectCollection containing a series of Point objects representing the leader originating at the model welding symbol. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating the geometry to attach the leader to. The ObjectCollection must contain at least one item, else the method will fail.  The points are projected onto the orientation plane.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelWeldingSymbolDefinitions CreateDefinitions([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
