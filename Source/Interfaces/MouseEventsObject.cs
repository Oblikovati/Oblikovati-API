namespace Oblikovati.API;

public interface MouseEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionEvents Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MouseMoveEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool PointInferenceEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PointInferenceEnumerator PointInferences { get; }
}
