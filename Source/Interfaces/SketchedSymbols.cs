namespace Oblikovati.API;

/// <summary>
/// The SketchedSymbols collection object provides access to the objects on a specific sheet. It also provides the ability to place sketched symbols onto a sheet. See the article in the overviews section.
/// </summary>
public interface SketchedSymbols : IEnumerable
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
    /// Method that returns the specified SketchedSymbol object from the collection.
    /// </summary>
    SketchedSymbol Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SketchedSymbolDefinition">SketchedSymbolDefinition</param>
    /// <param name="Position">Position</param>
    /// <param name="PromptStrings">PromptStrings</param>
    [PreserveSig]
    SketchedSymbol _Add([In] [MarshalAs(UnmanagedType.Struct)] object SketchedSymbolDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default);
    /// <summary>
    /// Method that places a sketched symbol onto the sheet.
    /// </summary>
    /// <param name="SketchedSymbolDefinition">Input Variant that specifies which SketchedSymbolDefinition to use. The input for the argument can be either a SketchedSymbolDefinition object or string containing the name of an existing SketchedSymbolDefinition object.</param>
    /// <param name="Position">Input that specifies the location on the sheet to place the sketched symbol instance.</param>
    /// <param name="Rotation">The rotation of the symbol, in radians.</param>
    /// <param name="Scale">The scale of the symbol.</param>
    /// <param name="PromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the sketched symbol definition. If prompted strings exist in the sketched symbol definition you must supply input strings through this argument or this method will fail. The prompt strings and their order are obtained by querying the TextBox objects in the SketchedSymbolDefinition. The order they're returned by the TextBoxes collection is the same order the input strings need to be supplied in the PromptStrings array.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchedSymbol Add([In] [MarshalAs(UnmanagedType.Struct)] object SketchedSymbolDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] double? Rotation = default, [In] double? Scale = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default);
    /// <summary>
    /// Method that places a sketched symbol with a leader.
    /// </summary>
    /// <param name="SketchedSymbolDefinition">Input Variant that specifies which SketchedSymbolDefinition to use.  The input for the argument can be either a SketchedSymbolDefinition object or string containing the name of an existing SketchedSymbolDefinition object.</param>
    /// <param name="LeaderPoints">Input ObjectCollection containing a series of Point2d objects representing the leader originating at the symbol.  The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to.  A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.  The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="Rotation">Optional input double that specifies a rotation angle for the symbol in radians. If not specified, a default value of 0 is used, indicating that no rotation is applied.</param>
    /// <param name="Scale">Optional input double that specifies a scale for the symbol in radians. If not specified, a default value of 1 is used, indicating that no scaling is applied.</param>
    /// <param name="PromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the sketched symbol definition.  If prompted strings exist in the sketched symbol definition you must supply input strings through this argument or this method will fail.  The prompt strings and their order are obtained by querying the TextBox objects in the SketchedSymbolDefinition.  The order they’re returned by the TextBoxes collection is the same order the input strings need to be supplied in the PromptStrings array.</param>
    /// <param name="SymbolClipping">Optional input Boolean that indicates whether to trim the annotations applied to the symbol.  If True, the annotations are trimmed.  If not specified, a value of True is used.</param>
    /// <param name="Static">Optional input Boolean that indicates whether to show the scale and rotation grip points on the symbol.  If True, the grip points are disabled.  If not specified, a value of False is used.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchedSymbol AddWithLeader([In] [MarshalAs(UnmanagedType.Struct)] object SketchedSymbolDefinition, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] double? Rotation = default, [In] double? Scale = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default, [In] bool? SymbolClipping = true, [In] bool? Static = false);
}
