namespace Oblikovati.API;

/// <summary>
/// The ModelGeneralNotes collection object provides access to all of the general notes in a part or assembly and provides functionality to create new general notes.
/// </summary>
public interface ModelGeneralNotes : IEnumerable
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
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelGeneralNote Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a general note.
    /// </summary>
    /// <param name="Definition">Input ModelGeneralNoteDefinition object that defines the general note to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelGeneralNote Add([In] [MarshalAs(UnmanagedType.Interface)] ModelGeneralNoteDefinition Definition);
    /// <summary>
    /// Method that creates a general note definition. This is a not a general note but an object that encapsulates all of the information that defines a general note.
    /// </summary>
    /// <param name="FormattedText">Input String that specifies the text of the note. This string can contain tags that define internal formatting changes, which override the text style associated with the general note. The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the text style assigned to the note. You can use the XML tags to override the default style and apply style overrides for all or portions of the text. The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="OnScreen">Input Boolean value that specifies whether the general note is on screen or not.</param>
    /// <param name="ScreenQuadrant">Optional input ScreenQuadrantEnum value that specifies the location of the general note on screen. This is ignored if the OnScreen is specified as False. This defaults to kLowerLeftQuadrant if not specified.</param>
    /// <param name="AnnotationPlaneDefinition">Optional input AnnotationPlaneDefinition object that defines the annotation plane the general note will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane. If the OnScreen is specified as True then this argument is ignored, otherwise this is required.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelGeneralNoteDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] bool OnScreen, [In] [MarshalAs(UnmanagedType.Struct)] object? ScreenQuadrant = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AnnotationPlaneDefinition = default);
    /// <summary>
    /// Method that creates a ModelSurfaceTextureSymbolDefinition.&nbsp;This ModelSurfaceTextureSymbolDefinition is to define the model surface texture symbol which is embedded in the model general note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelSurfaceTextureSymbolDefinition CreateEmbeddedSurfaceTextureSymbolDefinition();
    /// <summary>
    /// Method that creates a ModelFeatureControlFrameDefinition.&nbsp;This ModelFeatureControlFrameDefinition is to define the model feature control frame symbol which is embedded in the model general note.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelFeatureControlFrameDefinition CreateEmbeddedFeatureControlFrameDefinition();
}
