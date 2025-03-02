namespace Oblikovati.API;

/// <summary>
/// PublicationTrail Object.
/// </summary>
public interface PublicationTrailSegment
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PublicationTrail Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTweakPath object this segment is associative with.
    /// </summary>
    PublicationTweakPath PublicationTweakPath { get; }
    /// <summary>
    /// Read-only property that returns the tweak trail representative geometry.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns the origin point of the publication trail segment.
    /// </summary>
    GeometryIntent Origin { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the publication&nbsp;trail segment is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Method that deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
