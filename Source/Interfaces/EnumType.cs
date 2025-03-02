namespace Oblikovati.API;

/// <summary>
/// Enum Type Wrapper Object.
/// </summary>
public interface EnumType
{
    /// <summary>
    /// Gets the name of the enum type wrapped by this object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets/sets a the enum value.
    /// </summary>
    int Value { get; set; }
    /// <summary>
    /// Gets/sets the current index indicating which enum value is stored from the available list of values (1 To Count).
    /// </summary>
    int CurrentIndex { get; set; }
    /// <summary>
    /// Gets the number of available enum values.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the string representation of the enum value.
    /// </summary>
    string ValueName { get; }
    /// <summary>
    /// Reset enum type to one before the first enum value.
    /// </summary>
    [PreserveSig]
    void Reset();
    /// <summary>
    /// Move to next enum value in the available list of values.
    /// </summary>
    [PreserveSig]
    void MoveNext();
}
