namespace Oblikovati.API;

/// <summary>
/// RevitExports Object.
/// </summary>
public interface RevitExports : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    RevitExport Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new Revit model using the information supplied by the input RevitExportDefinition object. If RevitExportDefinition.EnableUpdating is set to True, the new RevitExport is returned and a browser node will for it.
    /// </summary>
    /// <param name="Definition">Input RevitExportDefinition object that defines the RevitExport.</param>
    /// <returns></returns>
    [PreserveSig]
    RevitExport Add([In] [MarshalAs(UnmanagedType.Interface)] RevitExportDefinition Definition);
    /// <summary>
    /// Method that creates a new RevitExportDefinition. The returned definition provides control over the selection of components to be exported, the simplification options to be applied, and aspects of the exact format of the resulting Revit model.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RevitExportDefinition CreateDefinition();
}
