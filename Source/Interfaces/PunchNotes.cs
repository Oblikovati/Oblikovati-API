namespace Oblikovati.API;

/// <summary>
/// The PunchNotes collection object provides access to all of the punch notes on the sheet.
/// </summary>
public interface PunchNotes : IEnumerable
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
    /// Returns the specified PunchNote object from the collection.
    /// </summary>
    PunchNote Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a punch note on the sheet based on the \input punch edge.
    /// </summary>
    /// <param name="Position">Input Point2d that specifies the position of the punch note on the sheet.</param>
    /// <param name="PunchEdge">Input GeometryIntent object that specifies the punch geomery to create the note for. The GeometryIntent object defines the geometry (typically a curve but can also be a center mark that represents the origin of a punch) and the location on the geometry where the note will point. If the GeometryIntent does not represent a punch edge or punch center, the method returns an error.</param>
    /// <param name="DimensionStyle">Optional input Variant that specifies which dimension style to use for the note. The dimension style can be specified by providing the name of an existing style or by supplying a DimensionStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    PunchNote Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent PunchEdge, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default);
}
