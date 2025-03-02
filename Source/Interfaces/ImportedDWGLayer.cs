namespace Oblikovati.API;

/// <summary>
/// The ImportedDWGLayer object.
/// </summary>
public interface ImportedDWGLayer
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
    /// Read-only property that returns the name of the imported DWG layer.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of the imported DWG layer.
    /// </summary>
    bool Visible { get; set; }
}
