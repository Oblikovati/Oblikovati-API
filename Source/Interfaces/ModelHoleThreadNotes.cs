namespace Oblikovati.API;

/// <summary>
/// The ModelHoleThreadNotes collection object provides access to all of the hole and thread notes in a part or assembly and provides functionality to create new hole and thread notes.
/// </summary>
public interface ModelHoleThreadNotes : IEnumerable
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
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    ModelHoleThreadNote Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a thread or hole note.
    /// </summary>
    /// <param name="Definition">Input ModelHoleThreadNoteDefinition object that defines the hole or thread note to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelHoleThreadNote Add([In] [MarshalAs(UnmanagedType.Interface)] ModelHoleThreadNoteDefinition Definition);
    /// <summary>
    /// Method that creates a hole or thread note definition.&nbsp;This is a not a hole or thread note but an object that encapsulates all of the information that defines a hole or thread note.&nbsp;You use the methods and properties of this object to define the hole or threa???[??????.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that defines the hole or thread geometry to attach the note to.  The intent object must reference geometry associated with a hole or thread, otherwise an error will occur.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <param name="LandingPosition">Input Point object that specifies the landing position of the note.  The point will be projected onto the orientation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelHoleThreadNoteDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point LandingPosition);
    /// <summary>
    /// Method that creates a new HoleClearanceInfo object that can be used in editing HoleFeature objects.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HoleClearanceInfo CreateClearanceInfo([In] [MarshalAs(UnmanagedType.BStr)] string FastenerStandard, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerType, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerSize, [In] [MarshalAs(UnmanagedType.Struct)] object? FastenerFitType = default);
}
