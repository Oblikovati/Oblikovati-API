namespace Oblikovati.API;

/// <summary>
/// The UserCoordinateSystemSettings object provides access to various UCS related document level settings. This object is obtained from the ModelingSettings.UserCoordinateSystemSettings property.
/// </summary>
public interface UserCoordinateSystemSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the prefix to use for the name of new user coordinate systems.
    /// </summary>
    string NamingPrefix { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to display the UCS triad.
    /// </summary>
    bool ShowTriad { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the origin visible.
    /// </summary>
    bool ShowOrigin { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the X axis visible.
    /// </summary>
    bool ShowXAxis { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the Y axis visible.
    /// </summary>
    bool ShowYAxis { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the Z axis visible.
    /// </summary>
    bool ShowZAxis { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the XY plane visible.
    /// </summary>
    bool ShowXYPlane { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the XZ plane visible.
    /// </summary>
    bool ShowXZPlane { get; set; }
    /// <summary>
    /// Gets and sets whether whether or not to make the YZ plane visible.
    /// </summary>
    bool ShowYZPlane { get; set; }
    /// <summary>
    /// Gets and sets the default plane to use for user coordinate systems.
    /// </summary>
    CoordinateSystemPlaneEnum DefaultPlane { get; set; }
}
