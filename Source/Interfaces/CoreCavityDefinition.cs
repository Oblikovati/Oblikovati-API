namespace Oblikovati.API;

/// <summary>
/// The CoreCavityDefinition object represents all of the information that defines a core-cavity feature. The CoreCavityDefinition object is used in two ways. First it is used as input when creating a core-cavity feature. Second it is used to query and edit existing core-cavity features.
/// </summary>
public interface CoreCavityDefinition
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
    /// Property that returns the parent CoreCavityDefintion object of this CoreCavityDefintion object.
    /// </summary>
    CoreCavityFeature Parent { get; }
    /// <summary>
    /// Property that gets and sets the solid, (SurfaceBody.IsSolid is True), SurfaceBody object used to define the geometry of the part. This body represents the part that is being molded.
    /// </summary>
    SurfaceBody PartBody { get; set; }
    /// <summary>
    /// Property that allows you to get and set the surfaces that define the run-off for the core-cavity feature. The ObjectCollection must consist of SurfaceBody objects and must contain at least one surface body. The input SurfaceBody objects must be open surfaces, (SurfaceBody.IsSolid is False).
    /// </summary>
    ObjectCollection RunoffSurfaces { get; set; }
    /// <summary>
    /// Property that allows you to get and set the surfaces that define any hole patches the core-cavity feature. The ObjectCollection must contain only SurfaceBody objects or it can be empty if there aren't any hole patches. The input SurfaceBody objects must be open surfaces, (SurfaceBody.IsSolid is False).
    /// </summary>
    ObjectCollection HolePatches { get; set; }
    /// <summary>
    /// Property that allows you to get and set the solids that define any inserts that are part of the core-cavity feature. The input SurfaceBody objects must be solids, (SurfaceBody.IsSolid is True), or the collection can be empty if there aren't any inserts.
    /// </summary>
    ObjectCollection Inserts { get; set; }
    /// <summary>
    /// Property that gets and sets the solid, (SurfaceBody.IsSolid is True), SurfaceBody object used to define the work piece used for a CoreCavityFeature object. The work piece is a solid that represents the shape of the mold base and will be split into the core and cavity pieces.
    /// </summary>
    SurfaceBody WorkpieceBody { get; set; }
    /// <summary>
    /// Property that gets and sets the pull direction of the CoreCavityFeature object. The portion generated on the positive direction side is the cavity, the other is the core.
    /// </summary>
    UnitVector PullDirection { get; set; }
    /// <summary>
    /// Property that defines the tolerance used when attempting to fix certain failure cases such as when small gaps are detected between individual runoff surfaces or between the runoff surface and the base. The default value is 0.00005 (cm). The units are centimeters.
    /// </summary>
    double Tolerance { get; set; }
    /// <summary>
    /// Method that creates a copy of this CoreCavityDefinition object. The new CoreCavityDefinition object is independent of any feature. It can be edited and used as input to edit an existing feature or to create a new core-cavity feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CoreCavityDefinition Copy();
}
