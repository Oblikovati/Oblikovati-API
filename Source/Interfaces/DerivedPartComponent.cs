namespace Oblikovati.API;

/// <summary>
/// The DerivedPartComponent object represents a specific derived part instance.
/// </summary>
public interface DerivedPartComponent
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
    /// Property that returns the parent object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns whether the derived component is still linked to the base part or assembly document. If True, the link still exists. If False, the link has been broken and the ReferencedFile property will return Nothing.
    /// </summary>
    bool LinkedToFile { get; }
    /// <summary>
    /// Property that returns the DocumentDescriptor object.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the component's name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property that returns whether the reference component refers to an embedded document or a linked document.
    /// </summary>
    bool IsEmbedded { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptor ReferencedFile { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceFeature PrimaryBody { get; }
    /// <summary>
    /// Property that returns the PlanarSketch objects that were created as a result of this derived part.
    /// </summary>
    SketchesEnumerator Sketches { get; }
    /// <summary>
    /// Property that returns the WorkPlane, WorkAxis, and WorkPoint objects that were created as a result of this derived part.
    /// </summary>
    ObjectsEnumerator WorkFeatures { get; }
    /// <summary>
    /// Property that returns the SurfaceBody objects that represent work surfaces that were created as a result of this derived part.
    /// </summary>
    ReferenceFeaturesEnumerator SurfaceBodies { get; }
    /// <summary>
    /// Property that returns the Parameter objects that were created as a result of this derived part. This property will return Nothing in the case where the link to the part has been broken.
    /// </summary>
    ParametersEnumerator Parameters { get; }
    /// <summary>
    /// Gets the DerivedPartDefinition that defines the current state of the derived part.
    /// </summary>
    DerivedPartDefinition Definition { get; set; }
    /// <summary>
    /// Gets and Sets a Boolean flag indicating whether the link to the part file is suppressed.
    /// </summary>
    bool SuppressLinkToFile { get; set; }
    /// <summary>
    /// Property that returns the Sketch3D objects that were created as a result of this derived part.
    /// </summary>
    Sketches3DEnumerator Sketches3D { get; }
    /// <summary>
    /// Property that returns the ReferenceFeature objects that represent the solids that were created as a result of this derived part.
    /// </summary>
    ReferenceFeaturesEnumerator SolidBodies { get; }
    /// <summary>
    /// Property that returns the iMateDefinition objects that were created as a result of this derived part.
    /// </summary>
    iMateDefinitionsEnumerator iMateDefinitions { get; }
    /// <summary>
    /// Property that returns the SketchBlockDefinition objects that were created as a result of this derived part.
    /// </summary>
    SketchBlockDefinitionsEnumerator SketchBlockDefinitions { get; }
    /// <summary>
    /// Property that returns the SketchBlock objects that were created as a result of this derived part.
    /// </summary>
    SketchBlocksEnumerator SketchBlocks { get; }
    /// <summary>
    /// Method that breaks the connection of the derived component with the part or assembly from which it was created. When the link is broken the ReferencedFile property will return Nothing.
    /// </summary>
    [PreserveSig]
    void BreakLinkToFile();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the ReferenceComponent.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this reference component. A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Replaces current derived part component with another file.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the new file to be used to replace the existing component.</param>
    /// <param name="Options">Input NameValueMap value that specifies the options when replace the component. Valid options include:
    /// Name = ModelState. Value = String value that specifies the model state name.</param>
    [PreserveSig]
    void Replace([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
}
