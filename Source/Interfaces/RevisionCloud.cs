namespace Oblikovati.API;

/// <summary>
/// RevisionCloud Object.
/// </summary>
public interface RevisionCloud
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the RevisionCloudDefinition object associated with this revision cloud.
    /// </summary>
    RevisionCloudDefinition Definition { get; set; }
    /// <summary>
    /// Gets and sets the name of the RevisionCloud.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets the position of the revision cloud on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Returns a Box2d object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Returns the associative DrawingSketch object.
    /// </summary>
    DrawingSketch Sketch { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that copies the revision cloud to specified sheet.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet to copy the revision cloud to.</param>
    /// <param name="NewName">Optional input String value that specifies the name of the new revision cloud. If not provided the default name will be used.</param>
    /// <param name="Position">Optional input Point2d object that specifies the position on the sheet to copy the revision cloud to. If not provided the default position will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionCloud CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet, [In] [MarshalAs(UnmanagedType.Struct)] object? NewName = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Position = default);
    /// <summary>
    /// Method that deletes the RevisionCloud.
    /// </summary>
    [PreserveSig]
    void Delete();
}
