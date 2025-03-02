namespace Oblikovati.API;

/// <summary>
/// The FilletSetback object provides access to an edge and its setback value.
/// </summary>
public interface FilletSetback
{
    /// <summary>
    /// Property that returns the associated with this setback. This property is only available when a FilletDefinition object is being defined to use as input for creating a fillet. When the parent FilletDefinition object is obtained from an existing Fillet, the end-of-part marker should be placed above this fillet feature to allow access this property.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Gets and sets the setback value.
    /// </summary>
    object Setback { get; set; }
}
