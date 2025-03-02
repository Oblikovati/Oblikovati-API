namespace Oblikovati.API;

/// <summary>
/// ImportedDataExchangeComponent Object.
/// </summary>
public interface ImportedDataExchangeComponent
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
    /// Read-write property that gets and sets the ImportedComponentDefinition which defines the various inputs that were used to create the imported component.
    /// </summary>
    ImportedComponentDefinition Definition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to suppress the connection of the imported component with the file from which it was created.
    /// </summary>
    bool SuppressLinkToFile { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UpdateAvailable { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string VersionData { get; }
    /// <summary>
    /// Read-only property that returns the DataExchange urn.
    /// </summary>
    string Urn { get; }
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
    /// Updates the component from the exchange if there is update available.
    /// </summary>
    /// <param name="Options">Optional input NameValueMap that specifies additional options. This is ignored at present.</param>
    [PreserveSig]
    void Update([In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
