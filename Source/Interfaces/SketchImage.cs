namespace Oblikovati.API;

/// <summary>
/// The SketchImage object represents an image within a sketch.
/// </summary>
public interface SketchImage
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent sketch.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the four construction sketch lines that form the boundary of the image.
    /// </summary>
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    /// <summary>
    /// Property that returns whether this image is linked to the picture file that was used to create this image.
    /// </summary>
    bool LinkedToFile { get; }
    /// <summary>
    /// Gets and sets the name of the image.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets the position of the image on the sketch.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Get and set the image height.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Get and set the image width.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Property that returns the reference to the picture file used to create this image. This property returns Nothing if the source file is not linked (use the LinkedToFile property to determine this).
    /// </summary>
    ReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    /// <summary>
    /// Gets and sets whether the image is transparent.
    /// </summary>
    bool Transparent { get; set; }
    /// <summary>
    /// Gets and sets whether the image is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns the sketch block that contains this object. This is the same SketchBlock returned as the last item in the SketchBlockPath property. This property returns Nothing if this object does not belong to a sketch block and lives directly under a sketch.
    /// </summary>
    SketchBlock ContainingSketchBlock { get; }
    /// <summary>
    /// Property that returns the path of sketch blocks at the leaf of which this sketch object is found. The enumerator returns a count of 0 if the object lives directly under a sketch.
    /// </summary>
    SketchBlocksEnumerator SketchBlockPath { get; }
    /// <summary>
    /// Gets the Picture object representing the associated bitmap.
    /// </summary>
    IPictureDisp Image { get; }
    /// <summary>
    /// Gets the Alpha channel bitmap of the Picture object representing the associated bitmap.&nbsp;Returns Nothing if there is no alpha data being used.
    /// </summary>
    IPictureDisp ImageAlpha { get; }
    /// <summary>
    /// Method that deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that mirrors the image horizontally.
    /// </summary>
    [PreserveSig]
    void MirrorHorizontal();
    /// <summary>
    /// Method that mirrors the image vertically.
    /// </summary>
    [PreserveSig]
    void MirrorVertical();
    /// <summary>
    /// Method that rotates the image counter-clockwise by 90 degrees.
    /// </summary>
    [PreserveSig]
    void RotateLeft();
    /// <summary>
    /// Method that rotates the image clockwise by 90 degrees.
    /// </summary>
    [PreserveSig]
    void RotateRight();
    /// <summary>
    /// Method that updates this image if the linked source file has been modified. This method returns a failure if there is no linked file associated with this image.
    /// </summary>
    [PreserveSig]
    void Update();
}
