namespace Oblikovati.API;

/// <summary>
/// HelicalCurveShapeDefinitionRow object.
/// </summary>
public interface HelicalCurveShapeDefinitionRow
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    HelicalCurveVariableShapeDefinition Parent { get; }
    /// <summary>
    /// Returns the index of the row.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets and sets the diameter of the helical curve.
    /// </summary>
    object Diameter { get; set; }
    /// <summary>
    /// Gets and sets the pitch of the helical curve.
    /// </summary>
    object Pitch { get; set; }
    /// <summary>
    /// Gets and sets the revolution of the helical curve.
    /// </summary>
    object Revolution { get; set; }
    /// <summary>
    /// Gets and sets the height of the helical curve.
    /// </summary>
    object Height { get; set; }
    /// <summary>
    /// Deletes this row.
    /// </summary>
    [PreserveSig]
    void Delete();
}
