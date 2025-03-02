namespace Oblikovati.API;

/// <summary>
/// The DerivedAssemblyComponent object represents a specific derived assembly instance.
/// </summary>
public interface DerivedAssemblyComponent
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
    /// Property that returns the collection containing the ReferenceFeatures that was created as a result of the derived component.
    /// </summary>
    ReferenceFeaturesEnumerator ReferenceFeatures { get; }
    /// <summary>
    /// Property that gets and sets the suppress state for all of the Reference features created by this derived assembly component.
    /// </summary>
    bool SuppressAll { get; set; }
    /// <summary>
    /// Gets or sets DerivedAssemblyDefinition that defines the current state of this derived assembly.
    /// </summary>
    DerivedAssemblyDefinition Definition { get; set; }
    /// <summary>
    /// Gets and Sets a Boolean flag indicating whether the link to the assembly file is suppressed.
    /// </summary>
    bool SuppressLinkToFile { get; set; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
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
    /// Replaces current derived assembly component with another file.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the new file to be used to replace the existing component.</param>
    /// <param name="Options">Input NameValueMap value that specifies the options when replace the component. Valid options include:
    /// Name = ModelState. Value = String value that specifies the model state name.</param>
    [PreserveSig]
    void Replace([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
}
