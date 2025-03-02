namespace Oblikovati.API;

/// <summary>
/// RevisionCloudControlPoint Object.
/// </summary>
public interface RevisionCloudControlPoint
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
    RevisionCloudDefinition Parent { get; }
    /// <summary>
    /// Returns the index of the control point in the RevisionCloudControlPoint collection.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets and sets the position of the control point.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Method that deletes the RevisionCloudControlPoint.
    /// </summary>
    [PreserveSig]
    void Delete();
}
