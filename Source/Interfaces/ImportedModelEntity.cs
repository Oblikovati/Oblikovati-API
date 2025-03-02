namespace Oblikovati.API;

/// <summary>
/// ImportedModelEntity Object.
/// </summary>
public interface ImportedModelEntity
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the sub ImportedModelEntities collection.
    /// </summary>
    ImportedModelEntities SubEntities { get; }
    /// <summary>
    /// Read-only property that returns the ImportedModelEntityTypeEnum indicating the type of the ImportedModelEntity.
    /// </summary>
    ImportedModelEntityTypeEnum EntityType { get; }
    /// <summary>
    /// Read-only property that returns the name of this object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedComponentDefinition Parent { get; }
    /// <summary>
    /// Read-only property that returns the parent ImportedModelEntity object.
    /// </summary>
    ImportedModelEntity ParentEntity { get; }
    /// <summary>
    /// Read-write property that gets and set the imported status for the entity.
    /// </summary>
    ImportedModelEntityStatusEnum ImportedStatus { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
