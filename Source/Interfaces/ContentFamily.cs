namespace Oblikovati.API;

/// <summary>
/// The ContentFamily object represents a content center family and provides access to the information associated with a family.
/// </summary>
public interface ContentFamily
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the description of this family.
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// Gets/Sets the name of this family.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets/Sets the name of the directory where family members are saved.
    /// </summary>
    string MemberDirectory { get; set; }
    /// <summary>
    /// Property that indicates if this library is writable or not. Returns True in the case where the library is modifiable.
    /// </summary>
    bool IsModifiable { get; }
    /// <summary>
    /// Gets/Sets the manufacturer of the parts within this family.
    /// </summary>
    string Manufacturer { get; set; }
    /// <summary>
    /// Gets/Sets the standard this family is based on.
    /// </summary>
    string Standard { get; set; }
    /// <summary>
    /// Gets/Sets the standard organization this family is part of.
    /// </summary>
    string StandardOrganization { get; set; }
    /// <summary>
    /// Gets/Sets the standard revision this family is based on.
    /// </summary>
    string StandardRevision { get; set; }
    /// <summary>
    /// Property that returns the collection of columns for the table associated with this family.
    /// </summary>
    ContentTableColumns TableColumns { get; }
    /// <summary>
    /// Property that returns the collection of rows for the table associated with this family.
    /// </summary>
    ContentTableRows TableRows { get; }
    /// <summary>
    /// Gets/Sets the image used for the thumbnail of this family.
    /// </summary>
    IPictureDisp Thumbnail { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the internal name of the ContentFamily. The internal name uniquely identifies this family with respect to other families in the library and it cannot be changed so it will remain consistent.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the identifier for this object. This can be used with the GetContentObject method of the ContentCenter object to obtain this object at a later time.
    /// </summary>
    string ContentIdentifier { get; }
    /// <summary>
    /// Property that returns the internal name of the library this family is defined within.
    /// </summary>
    string LibraryInternalName { get; }
    /// <summary>
    /// Property that returns the display name of the library this family is defined within.
    /// </summary>
    string LibraryName { get; }
    /// <summary>
    /// Property that indicates if this family is a custom or standard family. A custom family has at least one custom column and requires the additional input of the values for the custom columns and a filename when creating a member of the family.
    /// </summary>
    bool IsCustom { get; }
    /// <summary>
    /// Property that returns the constant that indicates what type of family this family is; kContentPartFamily or kContentFeatureFamily.
    /// </summary>
    ContentFamilyTypeEnum FamilyType { get; }
    /// <summary>
    /// Property that returns the column representing family file name values.
    /// </summary>
    ContentTableColumn FileNameColumn { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string TemplateFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool HasiMates { get; }
    /// <summary>
    /// Property that returns the family revision Id, which is a GUID in string format.
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Property that returns the column representing family designation values.
    /// </summary>
    ContentTableColumn DesignationColumn { get; }
    /// <summary>
    /// Property that returns a floating cell object that caller can use for iterating the table using indices. Set the Row and Column properties on the returned object to iterate through the table.
    /// </summary>
    ContentTableCell ActiveCell { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Row">Row</param>
    /// <param name="FailureReason">FailureReason</param>
    /// <param name="FailureMessage">FailureMessage</param>
    /// <param name="Refresh">Refresh</param>
    /// <param name="Custom">Custom</param>
    /// <param name="FileName">FileName</param>
    /// <param name="CustomInput">CustomInput</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    string CreateMember([In] [MarshalAs(UnmanagedType.Struct)] object Row, [Out] out MemberManagerErrorsEnum FailureReason, [Out] [MarshalAs(UnmanagedType.BStr)] out string FailureMessage, [In] ContentMemberRefreshEnum? Refresh = ContentMemberRefreshEnum.kUseDefaultRefreshSetting, [In] bool? Custom = false, [In] [MarshalAs(UnmanagedType.BStr)] string? FileName = "", [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Row">Row</param>
    /// <param name="Custom">Custom</param>
    /// <param name="CustomInput">CustomInput</param>
    [PreserveSig]
    string GetMemberFileName([In] [MarshalAs(UnmanagedType.Struct)] object Row, [In] bool? Custom = false, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="CustomData">CustomData</param>
    [PreserveSig]
    void GetCustomData([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[] CustomData);
    /// <summary>
    /// Property indicates if the family has the specified custom data. Returns True if the data exists.
    /// </summary>
    /// <param name="ClientId">Input String that uniquely identifies the application that created the custom data. This is commonly the CLSID of the Add-In in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", but can be any string.</param>
    /// <param name="InternalName">Input String value that specifies the unique name of the custom data.</param>
    /// <returns></returns>
    [PreserveSig]
    bool HasCustomData([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName);
    /// <summary>
    /// Method that saves the changes that have been made to this family. This method fails if the family is not modifiable
    /// </summary>
    [PreserveSig]
    void Save();
}
