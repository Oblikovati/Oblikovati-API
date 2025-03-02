namespace Oblikovati.API;

/// <summary>
/// DrawingWeldingSymbol Object.
/// </summary>
public interface DrawingWeldingSymbol
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the DrawingWeldingSymbolDefinitions object associated with this symbol.
    /// </summary>
    DrawingWeldingSymbolDefinitions Definitions { get; set; }
    /// <summary>
    /// Gets and sets the position of the symbol on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Read-only property that indicates whether the symbol was created as a result of retrieving it from the model. Retrieved DrawingWeldingSymbol can not be edited.
    /// </summary>
    bool Retrieved { get; }
    /// <summary>
    /// Gets and sets the associated WeldSymbolStyle object.
    /// </summary>
    WeldSymbolStyle Style { get; set; }
    /// <summary>
    /// Read-only property that returns the leader associated with the drawing welding symbol.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Read-only property that returns the object that this symbol was retrieved from.
    /// </summary>
    object RetrievedFrom { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the DrawingWeldingSymbol.
    /// </summary>
    [PreserveSig]
    void Delete();
}
