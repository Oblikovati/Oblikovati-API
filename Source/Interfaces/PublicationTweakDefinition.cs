namespace Oblikovati.API;

/// <summary>
/// PublicationTweakDefinition object.
/// </summary>
public interface PublicationTweakDefinition
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
    /// Read-write property that gets and sets whether to add or delete the full trail when edit.
    /// </summary>
    bool FullTrailOperationMode { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the trail segments to add.
    /// </summary>
    ObjectCollection TrailOriginsForAdd { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the trail segments to delete.
    /// </summary>
    ObjectCollection TrailSegmentsForDelete { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the publication components affected by the tweak.
    /// </summary>
    ObjectCollection PublicationComponents { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the UnitVector to define the translation direction or Line to define the rotation axis of the publication tweak.
    /// </summary>
    object DirectionOrAxis { get; set; }
    /// <summary>
    /// Read-write property that provides access to the rotation angle of a publication tweak.
    /// </summary>
    object RotationAngle { get; set; }
    /// <summary>
    /// Read-write property that provides access to the translation distance of the publication tweak.
    /// </summary>
    object Distance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the triad origin associated with the component.
    /// </summary>
    GeometryIntent TriadOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the X-axis alignment for triad.
    /// </summary>
    object TriadXAxisAlignment { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the triad is in local or world coordinate system.
    /// </summary>
    bool Local { get; set; }
    /// <summary>
    /// Read-only property that gets the type of this tweak definition.
    /// </summary>
    TweakTypeEnum TweakType { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to display the trails or not.
    /// </summary>
    PublicationTweakTrailsDisplayEnum DisplayTrails { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the transform of the publication tweak.
    /// </summary>
    Matrix Transform { get; set; }
    /// <summary>
    /// Create a copy of this PublicationTweakDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationTweakDefinition Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartTime">StartTime</param>
    /// <param name="EndTime">EndTime</param>
    [PreserveSig]
    void GetTimeRange([Out] out double StartTime, [Out] out double EndTime);
    /// <summary>
    /// Method that sets start time and end time of the the publication tweak in storyboard.
    /// </summary>
    [PreserveSig]
    void SetTimeRange([In] double StartTime, [In] double EndTime);
}
