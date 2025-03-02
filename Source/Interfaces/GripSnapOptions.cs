namespace Oblikovati.API;

/// <summary>
/// The GripSnapOptions object provides access to various grip snap related application level options. This object is obtained from the GeneralOptions.GripSnapOptions property.
/// </summary>
public interface GripSnapOptions
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
    /// Gets and sets whether or not to maintain a static reference image of the selection set while transient graphics represent the translation or rotation in drag and snap and reference geometry workflows.
    /// </summary>
    bool DisplayObjectInOriginalLocation { get; set; }
    /// <summary>
    /// Gets and sets whether grounded components and work geometries can be included for move/rotate.
    /// </summary>
    bool SelectGroundedComponentsAndWorkGeometry { get; set; }
    /// <summary>
    /// Gets and sets whether or not to add boxes to the end of the heads-up display (HUD) for translational and rotational degrees of freedom related to the active component or assembly selection.
    /// </summary>
    bool ShowDegreesOfFreedom { get; set; }
    /// <summary>
    /// Gets and sets whether or not to use the free drag option for each geometry type, skipping the step to select Free Drag from the Grip Snap move options.
    /// </summary>
    bool UseFreeDrag { get; set; }
    /// <summary>
    /// Gets and sets whether or not to use transient constraints during multiple manipulations of the same selection set.
    /// </summary>
    bool UseTemporaryConstraints { get; set; }
}
