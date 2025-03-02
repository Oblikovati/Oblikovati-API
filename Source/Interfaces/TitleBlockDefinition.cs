namespace Oblikovati.API;

/// <summary>
/// The TitleBlockDefinition object represents a title block definition.
/// </summary>
public interface TitleBlockDefinition
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
    /// Property returning the parent .
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Property that specifies if the title block definition is being referenced or not. A title block definition is referenced whenever it is used on a sheet. A referenced title block definition cannot be deleted.
    /// </summary>
    bool IsReferenced { get; }
    /// <summary>
    /// Property that returns the sketch associated with the title block definition. The DrawingSketch returned by the Sketch property supports all query functionality but cannot be edited. To edit the contents of a title block definition, use the Edit method. This creates a copy of the title block definition's sketch for edit. The ExitEdit method of the TitleBlockDefinition can then be used to save the edited sketch as the title block definition's sketch.
    /// </summary>
    DrawingSketch Sketch { get; }
    /// <summary>
    /// Gets and sets the name of the title block definition.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Method that deletes the TitleBlockDefinition object. This method will fail in the case where the definition is being referenced. This can be determined by using the IsReferenced property.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Result">Result</param>
    [PreserveSig]
    void Edit([Out] [MarshalAs(UnmanagedType.Interface)] out DrawingSketch Result);
    /// <summary>
    /// Method that closes the currently active sketch (see below for limitations) and depending on the input parameters, replaces the sketch of the title block definition with the edited sketch.
    /// </summary>
    /// <param name="SaveChanges">Input Boolean that specifies whether to save the changes or not. True indicates to save the changes. Setting this property to False will cause the sketch to close and lose all edits.</param>
    /// <param name="SaveAsName">Input String that specifies the name of the new title block definition to create. This argument is used in the case where the SaveChanges argument is True. If not specified, or an empty string is supplied, the edited sketch replaces the sketch associated with the title block definition being edited. If a string is supplied, a new title block definition is created and the edited sketch is used for it. The supplied name must be unique with respect to all other TitleBlockDefinition objects in the document.</param>
    [PreserveSig]
    void ExitEdit([In] bool? SaveChanges = true, [In] [MarshalAs(UnmanagedType.Struct)] object? SaveAsName = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetDocument">TargetDocument</param>
    /// <param name="ReplaceExisting">ReplaceExisting</param>
    [PreserveSig]
    TitleBlockDefinition CopyTo([In] [MarshalAs(UnmanagedType.Interface)] _DrawingDocument TargetDocument, [In] bool? ReplaceExisting = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
