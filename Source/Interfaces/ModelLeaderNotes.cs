namespace Oblikovati.API;

/// <summary>
/// The ModelLeaderNotes collection object provides access to all of the leader notes in a part or assembly and provides functionality to create new leader notes.
/// </summary>
public interface ModelLeaderNotes : IEnumerable
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
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    ModelLeaderNote Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a leader note.
    /// </summary>
    /// <param name="Definition">Input ModelLeaderNoteDefinition object that defines the leader note to be created</param>
    /// <returns></returns>
    [PreserveSig]
    ModelLeaderNote Add([In] [MarshalAs(UnmanagedType.Interface)] ModelLeaderNoteDefinition Definition);
    /// <summary>
    /// Method that creates a leader note definition.&nbsp;This is a not a leader note but an object that encapsulates all of the information that defines a leader note.&nbsp;You use the methods and properties of this object to define the leader note you want to create and then provide it as input to the Add method.
    /// </summary>
    /// <param name="LeaderPoints">ObjectCollection containing a series of Point objects representing the leader originating at the note. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating the geometry to attach the leader to. The ObjectCollection must contain at least one item, else the method will fail.  The points are projected onto the orientation plane.</param>
    /// <param name="FormattedText">Input String that specifies the text of the note. This string can contain tags that define internal formatting changes, which override the text style associated with the general note. The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the text style assigned to the note. You can use the XML tags to override the default style and apply style overrides for all or portions of the text. The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelLeaderNoteDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
