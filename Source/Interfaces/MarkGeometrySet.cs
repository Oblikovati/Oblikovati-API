namespace Oblikovati.API;

/// <summary>
/// MarkGeometrySet Object.
/// </summary>
public interface MarkGeometrySet
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that gets and sets the geometries for the mark geometry set.
    /// </summary>
    ObjectCollection Geometries { get; set; }
    /// <summary>
    /// Property that gets and sets the mark Style.
    /// </summary>
    MarkStyle Style { get; set; }
    /// <summary>
    /// Method that deletes the mark geometry set.
    /// </summary>
    [PreserveSig]
    void Delete();
}
