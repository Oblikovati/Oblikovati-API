namespace Oblikovati.API;

/// <summary>
/// The DraftingStandard object represent the currently applied drafting standard, and indicates whether the standard has been customized.
/// </summary>
public interface DraftingStandard
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the base drafting standard associated with this particular object.
    /// </summary>
    DraftingStandardEnum BaseStandard { get; }
    /// <summary>
    /// Gets the Boolean indicating if this object represents a built-in drafting standard. If FALSE, then this object represents a standard that has been customized.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that indicates the displayable name of this standard. No 'Set' allowed in Apprentice.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _DisplayName { get; }
}
