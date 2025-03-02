namespace Oblikovati.API;

/// <summary>
/// The DrawingWeldingSymbolDefinitions collection object provides access to the definitions for a drawing welding symbol.
/// </summary>
public interface DrawingWeldingSymbolDefinitions : IEnumerable
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
    DrawingWeldingSymbolDefinition Item { get; }
    /// <summary>
    /// Method that creates a new DrawingWeldingSymbolDefinition. The newly created DrawingWeldingSymbolDefinition object is returned.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long value indicating the target index to position this new DrawingWeldingSymbolDefinition. The newly created DrawingWeldingSymbolDefinition will be placed just before the target index, if not provided the newly created DrawingWeldingSymbolDefinition will be placed as the first one.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingWeldingSymbolDefinition Add([In] [MarshalAs(UnmanagedType.Struct)] object? TargetIndex = default);
    /// <summary>
    /// Method that remove the specified DrawingWeldingSymbolDefinition from the DrawingWeldingSymbolDefinitions collection.
    /// </summary>
    /// <param name="Index">Input Long value indicating the index of DrawingWeldingSymbolDefinition to return.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that creates a copy of this DrawingWeldingSymbolDefinitions object. The new DrawingWeldingSymbolDefinitions object is independent of any drawing welding symbol.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DrawingWeldingSymbolDefinitions Copy();
}
