namespace Oblikovati.API;

/// <summary>
/// The ConstantRadiusFaceSet object provides access to the faces for a constant radius fillet.
/// </summary>
public interface FilletConstantRadiusFaceSet
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
    /// FaceCollection object that contains the first set of faces for the face fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.
    /// </summary>
    FaceCollection FacesOne { get; }
    /// <summary>
    /// FaceCollection object that contains the second set of faces for the face fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.
    /// </summary>
    FaceCollection FacesTwo { get; }
    /// <summary>
    /// Property that returns the parameter that controls the radius of the fillet. This property will return Nothing if the fillet feature has not been created yet.
    /// </summary>
    Parameter Radius { get; }
    /// <summary>
    /// Boolean that indicates whether faces were tangential to the faces input in the FacesOne and FacesTwo arguments for the fillet creation.
    /// </summary>
    bool IncludeTangentFaces { get; }
    /// <summary>
    /// Optional input Point object that specifies a bias point to help choose between solutions if there are multiple possibilities.
    /// </summary>
    Point BiasPoint { get; }
    /// <summary>
    /// Boolean that indicates whether the side of the surface on which the fillet will be created is flipped. This only applies to faces of a surface and is ignored for faces of a solid.
    /// </summary>
    bool FacesOneReverseDirection { get; }
    /// <summary>
    /// Boolean that indicates whether the side of the surface on which the fillet was created is flipped. This only applies to faces of a surface and is ignored for faces of a solid.
    /// </summary>
    bool FacesTwoReverseDirection { get; }
}
