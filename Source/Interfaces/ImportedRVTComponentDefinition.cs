namespace Oblikovati.API;

/// <summary>
/// ImportedRVTComponentDefinition Object.
/// </summary>
public interface ImportedRVTComponentDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedComponent Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the full filename of the source file.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Read-write property that gets and sets the imported assembly organization type.
    /// </summary>
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the imported Revit language type.
    /// </summary>
    ImportedRevitLanguageTypeEnum ImportedLanguage { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the 3D view of the Revit data to import.
    /// </summary>
    string Imported3DView { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to import the component as linked reference.
    /// </summary>
    bool ReferenceModel { get; set; }
}
