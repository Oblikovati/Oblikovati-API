namespace Oblikovati.API;

/// <summary>
/// PublicationTweakPath object.
/// </summary>
public interface PublicationTweakPath
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PublicationTweak Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the publication tweak path is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns the PublicationTrailSegmentsEnumerator collection object.
    /// </summary>
    PublicationTrailSegmentsEnumerator TrailSegments { get; }
    /// <summary>
    /// Read-only property that returns the PublicationComponent object this path is associative with.
    /// </summary>
    PublicationComponent PublicationComponent { get; }
    /// <summary>
    /// Delete this object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that sets start time and end time of the publication tweak path.
    /// </summary>
    [PreserveSig]
    void SetTimeRange([In] double StartTime, [In] double EndTime);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartTime">StartTime</param>
    /// <param name="EndTime">EndTime</param>
    [PreserveSig]
    void GetTimeRange([Out] out double StartTime, [Out] out double EndTime);
}
