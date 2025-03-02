namespace Oblikovati.API;

/// <summary>
/// BIMComponent object.
/// </summary>
public interface BIMComponent
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
    /// Read-only property that returns the BIMComponentDescription object associated this document.
    /// </summary>
    BIMComponentDescription ComponentDescription { get; }
    /// <summary>
    /// Read-only property that returns the collection of connectors for this document. Through the returned object you can access all existing connectors and create new connectors.
    /// </summary>
    BIMConnectors Connectors { get; }
    /// <summary>
    /// Read-only property that returns the collection of connector links for this document. Through the returned object you can access all existing links between connectors and create new links between connectors.
    /// </summary>
    BIMConnectorLinks ConnectorLinks { get; }
    /// <summary>
    /// Read-only property that returns the Inventor PartComponentDefinition or AssemblyComponentDefinition that this BIMComponent object is associated with.
    /// </summary>
    ComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LiveUpdate { get; set; }
    /// <summary>
    /// Method that exports the BIM component as an adsk, ifc or rfa file.
    /// </summary>
    /// <param name="FullFileName">Input String that defines the full filename to write the building component to.  The filename should have an adsk, ifc or rfa extension.</param>
    [PreserveSig]
    void ExportBuildingComponent([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="pOptions">pOptions</param>
    [PreserveSig]
    void ExportBuildingComponentWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap pOptions);
}
