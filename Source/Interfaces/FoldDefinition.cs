namespace Oblikovati.API;

/// <summary>
/// The FoldDefinition object represents all of the information that defines a fold feature.
/// </summary>
public interface FoldDefinition
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
    /// Property that returns the parent FoldFeature object of this FoldDefinition object.
    /// </summary>
    FoldFeature Parent { get; }
    /// <summary>
    /// Gets and sets the bend angle of a sheet metal fold feature.
    /// </summary>
    object BendAngle { get; set; }
    /// <summary>
    /// Gets and sets the SketchLine object that defines the location of the bend line.
    /// </summary>
    SketchLine BendLine { get; set; }
    /// <summary>
    /// Gets and sets the position of the bend with respect to the bend line.
    /// </summary>
    BendLocationEnum BendLocation { get; set; }
    /// <summary>
    /// Gets and sets the BendOptions object that defines the bend options for this bend feature.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Gets and sets the bend radius of a sheet metal fold feature.
    /// </summary>
    object BendRadius { get; set; }
    /// <summary>
    /// Gets and sets whether the direction of the fold is in the positive or negative direction.
    /// </summary>
    bool IsPositiveBendDirection { get; set; }
    /// <summary>
    /// Gets and sets whether the flip direction is positive or negative.
    /// </summary>
    bool IsPositiveBendSide { get; set; }
    /// <summary>
    /// Gets and sets the UnfoldMethod object that defines how this bend is unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and set whether the unfold method has been overridden for this feature. Setting this property to False clears the override.&nbsp;Setting the property to True returns a failure.
    /// </summary>
    bool IsUnfoldMethodOverridden { get; set; }
    /// <summary>
    /// Function that creates a copy of this FoldDefinition object. The copy is independent of any fold feature and can be edited without affecting anything else. It can then be used as input to edit an existing fold feature or create a new fold feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FoldDefinition Copy();
}
