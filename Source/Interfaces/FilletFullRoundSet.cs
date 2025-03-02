namespace Oblikovati.API;

/// <summary>
/// The FilletFullRoundSet object provides access to the inputs used to create a full round fillet feature.
/// </summary>
public interface FilletFullRoundSet
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
    /// Property that returns the first set of side faces for the full round fillet feature.
    /// </summary>
    FaceCollection SideFacesOne { get; }
    /// <summary>
    /// Property that returns the center faces for the full round fillet feature.
    /// </summary>
    FaceCollection CenterFaces { get; }
    /// <summary>
    /// Property that returns the second set of side faces for the full round fillet feature.
    /// </summary>
    FaceCollection SideFacesTwo { get; }
    /// <summary>
    /// Property that returns whether to include faces that are tangential to the faces specified in the SideFacesOne, CenterFaces and SideFacesTwo properties for the fillet creation.
    /// </summary>
    bool IncludeTangentFaces { get; }
}
