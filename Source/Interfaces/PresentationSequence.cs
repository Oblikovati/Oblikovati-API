namespace Oblikovati.API;

/// <summary>
/// PresentationSequence object.
/// </summary>
public interface PresentationSequence
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-only property that gets the presentation sequence name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the publication components which are hidden in this sequence.
    /// </summary>
    PublicationComponentsEnumerator HiddenComponents { get; }
    /// <summary>
    /// Gets the Id of this object.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Gets the interval of this sequence.
    /// </summary>
    int Interval { get; }
    /// <summary>
    /// Gets the camera that is set for this presentation sequence.
    /// </summary>
    Camera Camera { get; }
    /// <summary>
    /// Gets whether the override camera is saved for this presentation sequence.
    /// </summary>
    bool IsCameraSaved { get; }
    /// <summary>
    /// Read-only property that returns the PresentationTweaks collection object.
    /// </summary>
    PresentationTweaks Tweaks { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartTime">StartTime</param>
    /// <param name="EndTime">EndTime</param>
    [PreserveSig]
    void GetStartEndTime([Out] out double StartTime, [Out] out double EndTime);
}
