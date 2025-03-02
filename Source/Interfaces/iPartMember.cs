namespace Oblikovati.API;

/// <summary>
/// The iPartMember object provides access to the iPart.
/// </summary>
public interface iPartMember
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
    /// Property that returns the primary body as a solid body. The solid body corresponds to the resultant body obtained from the iPartFactory.
    /// </summary>
    ReferenceFeature PrimaryBody { get; }
    /// <summary>
    /// Property that specifies whether this iPartMember represents a custom member or a standard member. This property is True if the iPartMember is a CustomMember.
    /// </summary>
    bool CustomMember { get; }
    /// <summary>
    /// Property that returns the iPart factory that created this iPartMember.
    /// </summary>
    iPartFactory ParentFactory { get; }
    /// <summary>
    /// Property that returns the row in the iPart table that this iPartMember represents.
    /// </summary>
    iPartTableRow Row { get; }
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
    /// Method that changes the row in the iPartTable that this custom iPartMember represents. This method is only valid for custom members. This can be determined using the CustomMember property.
    /// </summary>
    /// <param name="NewRow">Input Variant that specifies the new row. The row index is specified either by a Long (row index), a String (part identifier, i.e. ''[Height=1.000 in][Length=2.000 in][Radius=0.250 in]''), or an iPartTableRow object. If a RowIndex is not specified, default row will be used to create the iPart member.</param>
    /// <param name="CustomInput">Optional input safearray of Strings that specifies the input to use for the custom input. If the factory is a custom factory and this is not supplied the default values for custom values are used. The custom input strings are supplied in a column order. If the factory is not a custom factory this argument is ignored.</param>
    [PreserveSig]
    void ChangeRow([In] [MarshalAs(UnmanagedType.Struct)] object NewRow, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
    /// <summary>
    /// Method that breaks the link to the parent factory and converts the iPart member to a derived part.
    /// </summary>
    [PreserveSig]
    void BreakLinkToFactory();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RowName">RowName</param>
    [PreserveSig]
    void SetRowName([In] [MarshalAs(UnmanagedType.BStr)] string RowName);
}
