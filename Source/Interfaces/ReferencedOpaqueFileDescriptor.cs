namespace Oblikovati.API;

/// <summary>
/// Object that represents an opaque reference held in this Document to a file.
/// </summary>
public interface ReferencedOpaqueFileDescriptor
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the full path name of the file as currently found (or the last known full file name, if reference is not found).
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Deletes the opaque reference (does not delete the referenced file).
    /// </summary>
    [PreserveSig]
    void Delete();
}
