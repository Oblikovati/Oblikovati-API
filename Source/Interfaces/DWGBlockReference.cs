namespace Oblikovati.API;

/// <summary>
/// DWGBlockReference Object.
/// </summary>
public interface DWGBlockReference
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the HandleID for the DWGEntity.
    /// </summary>
    string HandleID { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ImportedDWGComponent Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the parent DWGEntity of the entity.
    /// </summary>
    DWGEntity ParentEntity { get; }
    /// <summary>
    /// Read-only property that returns the definition object that this DWGBlockReference is an instance of.
    /// </summary>
    DWGBlockDefinition Definition { get; }
    /// <summary>
    /// Read-only property that returns the transformation matrix for the DWGBlockReference instance.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Method that returns the corresponding object in the block reference for the given object from its definition.
    /// </summary>
    /// <param name="ObjectInDefinition">Input Object to get the corresponding object (in the block reference) for. This can be any type of DWGEntity.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetObject([In] [MarshalAs(UnmanagedType.IDispatch)] object ObjectInDefinition);
}
