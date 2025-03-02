namespace Oblikovati.API;

public interface IRxProperty
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int PropId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Value { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte Dirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Delete();
}
