namespace Oblikovati.API;

/// <summary>
/// The Sheets collection object provides access to all the existing objects in a drawing document and provides methods to create additional sheets. See here for an overview on drawing views.
/// </summary>
public interface Sheets : IEnumerable
{
    /// <summary>
    /// Returns the specified Sheet object from the collection.
    /// </summary>
    Sheet this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SheetToCopy">SheetToCopy</param>
    [PreserveSig]
    Sheet _Add([In] [MarshalAs(UnmanagedType.Interface)] Sheet SheetToCopy);
    /// <summary>
    /// Method that creates a new Sheet.
    /// </summary>
    /// <param name="Size">Optional input enum value that defines the size of sheet to create. If kCustomDrawingSheetSize is used the Width and Height arguments must be specified. If not specified, the default value kCDrawingSheetSize is used.</param>
    /// <param name="Orientation">Optional input PageOrientationTypeEnum that defines if the sheet will be landscape or portrait orientation. If not specified or if specified as kDefaultPageOrientation, the sheet will be created with a landscape orientation.</param>
    /// <param name="SheetName">Optional input String that defines the editable portion of the name that is displayed within the browser. If not specified, a default name is assigned to the sheet.</param>
    /// <param name="Width">Optional input Double that defines the width of the sheet. This value is used when the Size argument is kCustomDrawingSheetSize, otherwise it is ignored. The size is defined in centimeters.</param>
    /// <param name="Height">Optional input Double that defines the height of the sheet. This value is used when the Size argument is kCustomDrawingSheetSize, otherwise it is ignored. The size is defined in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    Sheet Add([In] DrawingSheetSizeEnum? Size = DrawingSheetSizeEnum.kCDrawingSheetSize, [In] PageOrientationTypeEnum? Orientation = PageOrientationTypeEnum.kLandscapePageOrientation, [In] [MarshalAs(UnmanagedType.BStr)] string? SheetName = "", [In] [MarshalAs(UnmanagedType.Struct)] object? Width = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default);
    /// <summary>
    /// Method that creates a new Sheet based on the input format. The newly created Sheet is returned.
    /// </summary>
    /// <param name="SheetFormat">Input Sheet object that specifies the sheet to be used as the template for creating the sheet format.</param>
    /// <param name="Model">Optional input that specifies the model to create drawings views of. This can either be the model Document object or a string that specifies the FullDocumentName of the model. This is a required input if the input SheetFormat defines at least one drawing view.</param>
    /// <param name="SheetName">Optional input String that defines the editable portion of the name that is displayed within the browser. If not specified, a default name is assigned to the sheet.</param>
    /// <param name="AdditionalOptions">Optional input NameValueMap object that specifies additional or advanced options for drawing view creation. See Remarks for supported values.</param>
    /// <param name="TitleBlockPromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the title block definition referenced by the sheet format.  The prompt strings and their order are obtained by querying the TextBox objects in the TitleBlockDefinition.  The order they’re returned by the TextBoxes collection is the same order the input strings need to be supplied in the TitleBlockPromptStrings array.</param>
    /// <param name="BorderPromptStrings">Optional input array of Strings that specifies the input strings to use as input for prompted text fields that my be present in the border definition.  The prompt strings and their order are obtained by querying the TextBox objects in the BorderDefinition.  The order they’re returned by the TextBoxes collection is the same order the input strings need to be supplied in the BorderPromptStrings array.</param>
    /// <returns></returns>
    [PreserveSig]
    Sheet AddUsingSheetFormat([In] [MarshalAs(UnmanagedType.Interface)] SheetFormat SheetFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Model = default, [In] [MarshalAs(UnmanagedType.BStr)] string? SheetName = "", [In] [MarshalAs(UnmanagedType.Struct)] object? AdditionalOptions = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TitleBlockPromptStrings = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BorderPromptStrings = default);
}
