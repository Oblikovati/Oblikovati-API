namespace Oblikovati.API;

/// <summary>
/// The ModelLeaderNoteDefinition provides access to all of the information that defines a model leader note.
/// </summary>
public interface ModelLeaderNoteDefinition
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
    /// Read-write property that gets and sets the annotation plane for the dimension.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the dimension.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the arrowhead type of the leader.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometric entity the note is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-only property that returns the leader associated with the leader note. This property will return Nothing in the cases where this object is not associated with a leader.
    /// </summary>
    ModelLeader Leader { get; }
    /// <summary>
    /// Read-only property that returns the parent model leader note that this definition is associated with.&nbsp;If the definition is not associated with any existing note this property will return Nothing.
    /// </summary>
    ModelAnnotation Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the position of the note in the part or assembly. The point is projected onto the orientation plane.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Read-only property that returns an object that controls all of the text information associated with this note. Properties on the returned ModelAnnoationText object can be edited to change the displayed text.
    /// </summary>
    ModelAnnotationText Text { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to show the text border or not.
    /// </summary>
    bool ShowTextBorder { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the associated geometries. Valid geometries include faces, edges and vertices.
    /// </summary>
    ObjectCollection AssociatedGeometries { get; set; }
    /// <summary>
    /// Method that creates a copy of this LeaderModelNoteDefinition object. The new LeaderModelNoteDefinition object is independent of any leader note. It can edited and used as input to edit an existing note or to create a new note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelLeaderNoteDefinition Copy();
}
