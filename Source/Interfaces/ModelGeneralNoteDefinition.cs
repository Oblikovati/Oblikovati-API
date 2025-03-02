namespace Oblikovati.API;

/// <summary>
/// The ModelGeneralNoteDefinition provides access to all of the information that defines a model leader note.
/// </summary>
public interface ModelGeneralNoteDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelAnnotation Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane for the dimension.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the dimension.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometric entity the note is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the position of the note in the part or assembly. The point is projected onto the orientation plane.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Read-only property that returns an object that controls all of the text information associated with this note. Properties on the returned ModelAnnoationText object can be edited to change the displayed text.
    /// </summary>
    ModelAnnotationText Text { get; }
    /// <summary>
    /// Returns the GeneralNoteSymbolDefinitions object, which allows you add model annotation definitions that can be used to display their symbols in the general note.
    /// </summary>
    GeneralNoteSymbolDefinitions SymbolDefinitions { get; }
    /// <summary>
    /// Gets whether the general note is displayed on screen.
    /// </summary>
    bool OnScreen { get; }
    /// <summary>
    /// Gets or sets the location where the general note is displayed on screen. Setting this property is only applicable when the OnScreen returns True.
    /// </summary>
    IntPtr ScreenQuadrant { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to show the text border or not.
    /// </summary>
    bool ShowTextBorder { get; set; }
    /// <summary>
    /// Method that creates a copy of this LeaderModelNoteDefinition object. The new LeaderModelNoteDefinition object is independent of any leader note. It can edited and used as input to edit an existing note or to create a new note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelGeneralNoteDefinition Copy();
    /// <summary>
    /// Sets the general note to be displayed on screen. This will set the OnScreen to be True.
    /// </summary>
    /// <param name="ScreenQuadrant">Optional input ScreenQuadrantEnum value that specifies the location of the general note on screen. This is ignored if the OnScreen is specified as False. This defaults to kLowerLeftQuadrant if not specified.</param>
    [PreserveSig]
    void SetToOnScreenDisplay([In] [MarshalAs(UnmanagedType.Struct)] object? ScreenQuadrant = default);
    /// <summary>
    /// Sets the general note to be displayed in model space. This will set the OnScreen to be False.
    /// </summary>
    [PreserveSig]
    void SetToModelSpaceDisplay([In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object Intent, [In] [MarshalAs(UnmanagedType.Struct)] object? Position = default);
}
