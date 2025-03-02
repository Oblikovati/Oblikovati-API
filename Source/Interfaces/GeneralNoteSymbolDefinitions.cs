namespace Oblikovati.API;

/// <summary>
/// GeneralNoteSymbolDefinitions Collection Object.
/// </summary>
public interface GeneralNoteSymbolDefinitions : IEnumerable
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    GeneralNoteSymbolDefinition this[int Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Add a GeneralNote with size defined by diagonal corners.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    GeneralNoteSymbolDefinition Add([In] [MarshalAs(UnmanagedType.IDispatch)] object SymbolDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object? TargetIndex = default, [In] [MarshalAs(UnmanagedType.Struct)] object? InsertBefore = default);
}
