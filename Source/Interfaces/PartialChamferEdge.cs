namespace Oblikovati.API;

/// <summary>
/// Partial Chamfer edge object.
/// </summary>
public interface PartialChamferEdge
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ChamferDefinition Parent { get; }
    /// <summary>
    /// Returns the Edge or EdgeCollection contains the Edge objects of being partially chamfered.
    /// </summary>
    EdgeCollection Edge { get; }
    /// <summary>
    /// Gets and sets the start distance of the chamfer on the Edge or Edge chain.
    /// </summary>
    object StartDistance { get; set; }
    /// <summary>
    /// Gets and sets the distance of the chamfer on the Edge or Edge chain.
    /// </summary>
    object ChamferDistance { get; set; }
    /// <summary>
    /// Gets and sets the end distance of the chamfer on the Edge or Edge chain.
    /// </summary>
    object EndDistance { get; set; }
    /// <summary>
    /// Deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
