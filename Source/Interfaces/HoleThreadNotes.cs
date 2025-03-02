namespace Oblikovati.API;

/// <summary>
/// The HoleThreadNotes collection object provides access to all of the hole and thread notes on the sheet.
/// </summary>
public interface HoleThreadNotes : IEnumerable
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
    /// Returns the specified HoleThreadNote object from the collection.
    /// </summary>
    HoleThreadNote this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a hole or thread note on the sheet. Different results are possible depending on the input provided, as discussed below.
    /// </summary>
    /// <param name="Position">Input Point2d that specifies the position of the hole/thread note on the sheet.</param>
    /// <param name="HoleOrThreadEdge">Input DrawingCurve or GeometryIntent object that specifies the edge to create the note for and the location along the edge the note points to. If the drawing curve or geometry intent does not represent a hole or thread edge, the method returns an error. See the discussion above for more information about how to get different results by providing different inputs for this argument.</param>
    /// <param name="LinearDiameterType">Optional Input Boolean that specifies whether to create a leader type of note or a linear diameter type of note. There are two examples of linear diameter types in the figure above. These are the uncircled notes in the right view. The three circled notes illustrate a leader type of note.</param>
    /// <param name="DimensionStyle">Optional input Variant that specifies which dimension style to use for the note. The dimension style can be specified by providing the name of an existing style or by supplying a DimensionStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleThreadNote Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.IDispatch)] object HoleOrThreadEdge, [In] bool? LinearDiameterType = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default);
}
