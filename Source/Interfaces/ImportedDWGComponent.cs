namespace Oblikovati.API;

/// <summary>
/// ImportedDWGComponent Object.
/// </summary>
public interface ImportedDWGComponent
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
    /// Read-only property that returns the DWGModelSpaceDefinition object.
    /// </summary>
    DWGBlockDefinition ModelSpaceDefinition { get; }
    /// <summary>
    /// Read-write property that gets and sets the crop in LocationPlane space. Set this to Nothing will clear the crop.
    /// </summary>
    Box2d Crop { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether&nbsp;this object is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns the ImportedDWGLayersEnumerator collection object.
    /// </summary>
    ImportedDWGLayersEnumerator Layers { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is grounded or not.
    /// </summary>
    bool Grounded { get; set; }
    /// <summary>
    /// Read-only property that returns the work plane that represents the X-Y plane for the component.
    /// </summary>
    object XYPlane { get; }
    /// <summary>
    /// Read-only property that returns the work plane that represents the X-Z plane for the component.
    /// </summary>
    object XZPlane { get; }
    /// <summary>
    /// Read-only property that returns the work plane that represents the Y-Z plane for the component.
    /// </summary>
    object YZPlane { get; }
    /// <summary>
    /// Read-only property that returns the work axis that represents the x-axis for the component.
    /// </summary>
    object XAxis { get; }
    /// <summary>
    /// Read-only property that returns the work axis that represents the y-axis for the component.
    /// </summary>
    object YAxis { get; }
    /// <summary>
    /// Read-only property that returns the work axis that represents the z-axis for the component.
    /// </summary>
    object ZAxis { get; }
    /// <summary>
    /// Read-only property that returns the work point that represents the origin for the component.
    /// </summary>
    object Origin { get; }
    /// <summary>
    /// Read-only property that returns the bounding box of the DWG graphics.
    /// </summary>
    Box RangeBox { get; }
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
