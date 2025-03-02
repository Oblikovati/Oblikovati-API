namespace Oblikovati.API;

/// <summary>
/// ImportedComponents Object.
/// </summary>
public interface ImportedComponents : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ImportedComponent Item { get; }
    /// <summary>
    /// Method that creates a new ImportedComponent object using the information supplied by the input ImportedComponentDefinition object. Returns the imported component.
    /// </summary>
    /// <param name="Definition">Input ImportedComponentDefinition object that defines the imported component.</param>
    /// <returns></returns>
    [PreserveSig]
    ImportedComponent Add([In] [MarshalAs(UnmanagedType.Interface)] ImportedComponentDefinition Definition);
    /// <summary>
    /// Method that creates a new ImportedComponentDefinition object.&nbsp;The returned definition provides access to all of the items in the file that can be imported.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full filename of a CAD file.</param>
    /// <returns></returns>
    [PreserveSig]
    ImportedComponentDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that creates a new ImportedComponentDefinition object.&nbsp;Suitable for online import like FDX.
    /// </summary>
    /// <param name="exchangeUrn">Input string that specifies the Data Exchange urn.</param>
    /// <param name="Options">Optional input NameValueMap that specifies additional options. This is ignored at present.</param>
    /// <returns></returns>
    [PreserveSig]
    ImportedComponentDefinition CreateDataExchangeDefinition([In] [MarshalAs(UnmanagedType.BStr)] string exchangeUrn, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
