namespace Oblikovati.API;

/// <summary>
/// The FilletSetbackVertex object provides access to a vertex that is valid to define fillet setbacks for. It also provides access to the edges connected to the vertex and each edge's associated setback value.
/// </summary>
public interface FilletSetbackVertex : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that returns the specified FilletSetback object from this vertex.
    /// </summary>
    FilletSetback SetbackItem { get; }
    /// <summary>
    /// Property that returns the number of edges connected to the vertex. Each edge is represented by a FilletSetback object which can be obtained using the Setback property.
    /// </summary>
    int SetbackCount { get; }
    /// <summary>
    /// Property that gets the vertex shared by the edges. This property is only available when a FilletDefinition object is being defined to use as input for creating a fillet. When the parent FilletDefinition object is obtained from an existing Fillet, the end-of-part marker should be placed above this fillet feature to allow access this property.
    /// </summary>
    Vertex Vertex { get; }
    /// <summary>
    /// Gets and sets whether or not to use setback values.
    /// </summary>
    bool UseSetbacks { get; set; }
    /// <summary>
    /// Gets and sets whether the minimum allowable setback should be used for this vertex.
    /// </summary>
    bool MinimalSetback { get; set; }
}
