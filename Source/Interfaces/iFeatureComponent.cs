namespace Oblikovati.API;

/// <summary>
/// This object and its behavior will remain in its current state to support backward compatibility but it will be hidden because it's no longer needed in the new implementation.
/// </summary>
public interface iFeatureComponent
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
    ReferenceFeature ReferenceFeature { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iFeatureDefinition Definition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iFeatureTemplateDescriptor iFeatureTemplateDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SketchesEnumerator Sketches { get; }
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
}
