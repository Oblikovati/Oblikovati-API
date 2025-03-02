namespace Oblikovati.API;

/// <summary>
/// ImportedGenericComponentDefinition Object.
/// </summary>
public interface ImportedGenericComponentDefinition
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
    /// Read-write property that gets and sets whether to import the component as linked reference.
    /// </summary>
    bool ReferenceModel { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the imported assembly organization type.
    /// </summary>
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the imported surface organization type.
    /// </summary>
    ImportedSurfaceOrganizationTypeEnum ImportedSurfaceOrganizationType { get; set; }
    /// <summary>
    /// Read-only property that returns the ImportedModelEntities collection object.
    /// </summary>
    ImportedModelEntities ImportedModelEntities { get; }
    /// <summary>
    /// Read-write property that gets and sets the location for save files.
    /// </summary>
    string SaveFilesLocation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to add string as prefix for file names.
    /// </summary>
    bool SaveFileNamesWithPrefix { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the prefix or suffix that being added to file names.
    /// </summary>
    string SaveFileNamesPrefixOrSuffix { get; set; }
    /// <summary>
    /// Read-write property that gets and sets a bit mask defining the imported model geometry types. A combination of enum values can be provided.
    /// </summary>
    ImportedModelGeometryTypeEnum ImportedModelGeometryTypes { get; set; }
    /// <summary>
    /// Read-write property that gets and sets a bit mask defining the imported work geometry types. A combination of enum values can be provided.
    /// </summary>
    ImportedWorkGeometryTypeEnum ImportedWorkGeometryTypes { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the import units type.
    /// </summary>
    ImportUnitsTypeEnum ImportUnitsType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the IFC import method. This is only applicable when import IFC file.
    /// </summary>
    IFCImportMethodEnum IFCImportMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to import IFC geometry as mesh.&nbsp;This is only applicable when import IFC file.
    /// </summary>
    bool ImportIFCGeometryAsMesh { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to import IFC properties as Inventor parameters. This is applicable when the ImportMethod is set to kAsAssemblyImportMethod when import IFC file.
    /// </summary>
    bool ImportIFCPropertiesAsParameters { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to mark the parameters that are imported from IFC properties as export. This is applicable when the ImportMethod is set to kAsAssemblyImportMethod and ImoprtIFCPropertiesAsParameters is set to True when import IFC.
    /// </summary>
    bool ImportIFCPropertiesAsCustomProperties { get; set; }
    /// <summary>
    /// Method that causes all model entities to be excluded.
    /// </summary>
    [PreserveSig]
    void ExcludeAll();
    /// <summary>
    /// Method that causes all model entities to be included.
    /// </summary>
    [PreserveSig]
    void IncludeAll();
    /// <summary>
    /// Method that creates a copy of this ImportedGenericComponentDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ImportedGenericComponentDefinition Copy();
}
