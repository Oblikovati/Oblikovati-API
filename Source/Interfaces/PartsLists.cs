namespace Oblikovati.API;

/// <summary>
/// The PartsLists collection object provides access to all existing objects on the sheet.
/// </summary>
public interface PartsLists : IEnumerable
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
    /// Returns the specified PartsList object from the collection. This is the default property of the PartsLists collection object.
    /// </summary>
    PartsList Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new PartsList. The newly created PartsList is returned. Currently, this method will fail if the sheet from which this collection was obtained is not active.
    /// </summary>
    /// <param name="ViewOrModel">Input object that specifies the source for the parts list. This can either be a DrawingView object or a Document object. Valid document types include part files and assembly files. Use the Documents.Open method to open the file if not already open and obtain a Document object. Typically you'll want to set the OpenVisible argument of the Open method to False so the open is invisible to the user.</param>
    /// <param name="PlacementPoint">Input Point2d that specifies the placement point of the parts list on the sheet.</param>
    /// <param name="Level">Optional input enum that sets the type of numbering for the parts list. If supplied, this input is only used in the case where the ParentView references an assembly file. If this value was previously set on the parent drawing view as a result of creating a parts list or a balloon based on the view, this argument is ignored. Valid enums are: kFirstLevelComponents, that creates a parts list in which subassemblies are assigned nested numbering (for example, 1, 1.1, 1.1.1) and the nested number extends as many levels as needed for the assembly levels in the model and kPartsOnly, that creates a parts list that sequentially numbers all parts in the top level assembly, even if they are contained in subassemblies.</param>
    /// <param name="NumberingScheme">Optional input NameValueMap object that specifies the numbering scheme to use for the parts list. The NameValueMap can contain the following entries based on the input 'Level' argument: 	*	For kStructured: MinimumDigits As Long 	*	For kStructuredAllLevels: Delimiter As String 	*	For kPartsOnly: NumberingScheme As NumberingSchemeEnum and MinimumDigits As Long Valid values for NumberingSchemeEnum are kNumericNumbering, kLowercaseAlphaNumbering and kUppercaseAlphaNumbering. This input should be supplied only if the input argument Level is specified to be kPartsOnly. If this argument is not supplied for a 'parts only' parts list, a default value of kNumericNumbering is assumed.</param>
    /// <param name="NumberOfSections">Optional input long that specifies the number of sections desired in the parts list. If supplied, this input is only used in the case where the ParentView references an assembly file. The default value is 1.</param>
    /// <param name="WrapLeft">Optional input Boolean that specifies whether to move the sections to the left or the right when the number of rows increase. If supplied, this input is only used in the case where the ParentView references an assembly file. The default value is true, indicating that sections will be moved to the left.</param>
    /// <returns></returns>
    [PreserveSig]
    PartsList Add([In] [MarshalAs(UnmanagedType.IDispatch)] object ViewOrModel, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] PartsListLevelEnum? Level = PartsListLevelEnum.kFirstLevelComponents, [In] [MarshalAs(UnmanagedType.Struct)] object? NumberingScheme = default, [In] int? NumberOfSections = default, [In] bool? WrapLeft = true);
}
