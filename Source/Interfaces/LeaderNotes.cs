namespace Oblikovati.API;

/// <summary>
/// The LeaderNotes collection object provides access to all of the leader notes on the sheet.
/// </summary>
public interface LeaderNotes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the specified LeaderNote object from the collection.
    /// </summary>
    LeaderNote Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a leader note.
    /// </summary>
    /// <param name="LeaderPoints">ObjectCollection containing a series of Point2d objects representing the leader originating at the note. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating a geometry to attach the leader to. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. The ObjectCollection must contain at least one item, else the method will fail.</param>
    /// <param name="FormattedText">Input String that specifies the text of the general note. This string can contain tags that define internal formatting changes, which override the text style associated with the general note. The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the text style assigned to the note. You can use the XML tags to override the default style and apply style overrides for all or portions of the text. The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="DimensionStyle">Specifies which dimension style to use for the leader note. The dimension style can be specified by providing the name of an existing style or by supplying a DimensionStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    LeaderNote Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default);
}
