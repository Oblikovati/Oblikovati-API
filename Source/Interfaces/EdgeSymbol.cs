namespace Oblikovati.API;

/// <summary>
/// EdgeSymbol Object.
/// </summary>
public interface EdgeSymbol
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
    /// Read-write property that gets and sets the position of the edge symbol on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the EdgeSymbolDefinition object associated with this edge symbol.
    /// </summary>
    EdgeSymbolDefinition Definition { get; set; }
    /// <summary>
    /// Method that copies the edge symbol to specified sheet.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet to copy the edge symbol to.</param>
    /// <param name="NewName">Optional input String value that specifies the name of the new edge symbol. If not provided the default name will be used.</param>
    /// <param name="Position">Optional input Point2d object that specifies the position on the sheet to copy the edge symbol to. If not provided the default position will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeSymbol CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet, [In] [MarshalAs(UnmanagedType.Struct)] object? NewName = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Position = default);
    /// <summary>
    /// Method that deletes the EdgeSymbol.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
