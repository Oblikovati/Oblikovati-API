namespace Oblikovati.API;

/// <summary>
/// The FilletDefinition object is used to define all of the input required for fillet features. It is also used to query and edit existing fillet features.
/// </summary>
public interface FilletDefinition
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
    /// Property that returns the parent FilletFeature of the definition.
    /// </summary>
    FilletFeature Parent { get; }
    /// <summary>
    /// Property that returns the type of the fillet. Possible return values are kEdgeFillet, kFaceFillet and kFullRoundFillet.
    /// </summary>
    FilletTypeEnum FilletType { get; }
    /// <summary>
    /// Method that returns the specified FilletRadiusEdgeSet object from the collection. This will return either a FilletConstantRadiusEdgeSet or FilletVariableRadiusEdgeSet object.
    /// </summary>
    FilletRadiusEdgeSet EdgeSetItem { get; }
    /// <summary>
    /// Property that specifies the number of edge sets currently defined in the definition. This property always returns 0 if the FilletType is not kEdgeFillet.
    /// </summary>
    int EdgeSetCount { get; }
    /// <summary>
    /// Returns the specified FilletSetbackVertex object from the definition.
    /// </summary>
    FilletSetbackVertex SetbackVertexItem { get; }
    /// <summary>
    /// Property that specifies the number of possible vertex setbacks available for the current set of edges in the definition. This property always returns 0 if the FilletType is not kEdgeFillet.
    /// </summary>
    int SetbackVertexCount { get; }
    /// <summary>
    /// Property that returns the FilletConstantRadiusFaceSet object that defines the inputs used to create a face fillet. This property returns Nothing if the FilletType is not kFaceFillet.
    /// </summary>
    FilletConstantRadiusFaceSet FaceSet { get; }
    /// <summary>
    /// property that returns the FilletFullRoundSet object that defines the inputs used to create a full round fillet. This property returns Nothing if the FilletType is not kFullRoundFillet.
    /// </summary>
    FilletFullRoundSet FullRoundSet { get; }
    /// <summary>
    /// Method that creates a new constant radius edge set. The new FilletDefinition is returned.
    /// </summary>
    /// <param name="Edges">Input object that contains edges for the fillet feature.</param>
    /// <param name="ConstantRadius">Input Variant that defines the radius of the fillet. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletConstantRadiusEdgeSet AddConstantRadiusEdgeSet([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Struct)] object ConstantRadius);
    /// <summary>
    /// Method that creates a new variable radius edge set. Intermediate radii can be defined using the AddIntermediatePoint method of the FilletVariableRadiusEdgeSet object returned by this method.
    /// </summary>
    /// <param name="Edges">Input object that contains edges for the fillet feature. For variable radius fillets, this can contain more than one edge only if the edges are tangentially connected.</param>
    /// <param name="StartRadius">Input Variant that defines the start radius of the variable radius fillet. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="EndRadius">Input Variant that defines the end radius of the variable radius fillet. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletVariableRadiusEdgeSet AddVariableRadiusEdgeSet([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges, [In] [MarshalAs(UnmanagedType.Struct)] object StartRadius, [In] [MarshalAs(UnmanagedType.Struct)] object EndRadius);
    /// <summary>
    /// Method that creates a new constant radius face set used to create a face fillet. The new FilletFaceSet is returned. If a FilletFaceSet already exists in the definition, it is replaced with this new one.
    /// </summary>
    /// <param name="FacesOne">FaceCollection object that contains the first set of faces for the face fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.</param>
    /// <param name="FacesTwo">FaceCollection object that contains the second set of faces for the face fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.</param>
    /// <param name="Radius">Defines the radius of the face fillet. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="IncludeTangentFaces">Boolean that specifies whether to include faces that are tangential to the faces input in the FacesOne and FacesTwo arguments for the fillet creation. If not specified, a default of True is used, indicating that the tangential faces will be used in feature creation.</param>
    /// <param name="BiasPoint">Optional input Point object that specifies a bias point to help choose between solutions if there are multiple possibilities.</param>
    /// <param name="FacesOneReverseDirection">Optional input Boolean that specifies whether to flip the side of the surface on which the fillet will be created. This argument only applies to faces of a surface and is ignored for faces of a solid. Default value is False.</param>
    /// <param name="FacesTwoReverseDirection">Optional input Boolean that specifies whether to flip the side of the surface on which the fillet will be created. This argument only applies to faces of a surface and is ignored for faces of a solid. Default value is False.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletConstantRadiusFaceSet AddFaceSet([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection FacesOne, [In] [MarshalAs(UnmanagedType.Interface)] FaceCollection FacesTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] bool? IncludeTangentFaces = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] bool? FacesOneReverseDirection = false, [In] bool? FacesTwoReverseDirection = false);
    /// <summary>
    /// Method that creates a new full round set used to create a full round fillet. The new FilletFullRoundSet is returned. If a FilletFullRoundSet already exists in the definition, it is replaced with this new one.
    /// </summary>
    /// <param name="SideFacesOne">FaceCollection object that contains the first set of side faces for the full round fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.</param>
    /// <param name="CenterFaces">FaceCollection object that contains the center faces for the full round fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.</param>
    /// <param name="SideFacesTwo">FaceCollection object that contains the second set of side faces for the full round fillet feature. This can contain more than one face only if the faces are tangentially connected. The Face.TangentiallyConnectedFaces property can be used to get a collection of faces that are tangent to a given face.</param>
    /// <param name="IncludeTangentFaces">Optional input Boolean that specifies whether to include faces that are tangential to the faces input in the SideFacesOne, CenterFaces and SideFacesTwo arguments for the fillet creation. If not specified, a default of True is used, indicating that the tangential faces will be used in feature creation.</param>
    /// <returns></returns>
    [PreserveSig]
    FilletFullRoundSet AddFullRoundSet([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection SideFacesOne, [In] [MarshalAs(UnmanagedType.Interface)] FaceCollection CenterFaces, [In] [MarshalAs(UnmanagedType.Interface)] FaceCollection SideFacesTwo, [In] bool? IncludeTangentFaces = true);
}
