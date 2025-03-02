namespace Oblikovati.API;

/// <summary>
/// DSJointDefinition object.
/// </summary>
public interface DSJointDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent DSJoint object this definition is associated with.&nbsp;This can return Nothing in the case where the definition is not associated with any joint.
    /// </summary>
    DSJoint Parent { get; }
    /// <summary>
    /// Gets the DSDegreesOfFreedom collection object&nbsp;provides access to the degrees of freedom associated with this joint.
    /// </summary>
    DSDegreesOfFreedom DegreesOfFreedom { get; }
    /// <summary>
    /// Gets and sets the color of the force glyph as seen during the playback of the simulation.
    /// </summary>
    Color ForceGlyphColor { get; set; }
    /// <summary>
    /// Gets and sets the scale of the force glyph.
    /// </summary>
    double ForceGlyphScale { get; set; }
    /// <summary>
    /// Gets and sets whether the degrees of freedom are locked.
    /// </summary>
    bool IsDOFsLocked { get; set; }
    /// <summary>
    /// Gets and sets whether the force glyph is displayd.
    /// </summary>
    bool IsForceDisplayed { get; set; }
    /// <summary>
    /// Gets and sets whether the joint is suppressed.
    /// </summary>
    bool IsSuppressed { get; set; }
    /// <summary>
    /// Gets and sets whether the load glyph is displayed.
    /// </summary>
    bool IsLoadDisplayed { get; set; }
    /// <summary>
    /// Gets and sets the color of the load glyph as seen during the playback of the simulation.
    /// </summary>
    Color LoadGlyphColor { get; set; }
    /// <summary>
    /// Gets and sets the scale of the load glyph.
    /// </summary>
    double LoadGlyphScale { get; set; }
    /// <summary>
    /// Creates a copy of this DSJointDefinition object. The new DSJointDefinition object is independent of any joint. It can edited and used as input to edit an existing joint or to create a new joint.&nbsp;Creating a copy of a definition, editing it, and then assigning it back to the joint can be a more efficient way of editing multiple inputs because it results in a single recompute.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DSJointDefinition Copy();
}
