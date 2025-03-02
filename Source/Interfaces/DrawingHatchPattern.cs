namespace Oblikovati.API;

/// <summary>
/// DrawingHatchPattern Object.
/// </summary>
public interface DrawingHatchPattern
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    DrawingHatchPatternsManager Parent { get; }
    /// <summary>
    /// Read-only property that returns the description of the hatch pattern.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Read-write property that gets and sets the offered status of the hatch pattern.
    /// </summary>
    bool Offered { get; set; }
    /// <summary>
    /// Read-only property that returns the name of the hatch pattern.
    /// </summary>
    string Name { get; }
}
