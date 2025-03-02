namespace Oblikovati.API;

/// <summary>
/// Replace Face Definition object.
/// </summary>
public interface ReplaceFaceDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ReplaceFaceFeature Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the faces that are being replaced.
    /// </summary>
    FaceCollection ExistingFaces { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the new faces that are replacing the other faces.
    /// </summary>
    ObjectCollection NewFaces { get; set; }
    /// <summary>
    /// Method that creates a copy of this ReplaceFaceDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ReplaceFaceDefinition Copy();
}
