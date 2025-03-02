namespace Oblikovati.API;

/// <summary>
/// The BendNotes collection object provides access to all of the bend notes on the sheet.
/// </summary>
public interface BendNotes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified BendNote object from the collection.
    /// </summary>
    BendNote Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a bend note based on the input bend edge on the sheet. The initial placement of the bend note will be along the bend edge without a leader.
    /// </summary>
    /// <param name="BendEdge">Input DrawingCurve object that specifies the bend edge to create the note for. If the DrawingCurve does not represent a bend edge, the method returns an error.</param>
    /// <param name="DimensionStyle">Optional input Variant that specifies which dimension style to use for the note. The dimension style can be specified by providing the name of an existing style or by supplying a DimensionStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    BendNote Add([In] [MarshalAs(UnmanagedType.Interface)] DrawingCurve BendEdge, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default);
}
