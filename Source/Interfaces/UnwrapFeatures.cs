namespace Oblikovati.API;

/// <summary>
/// Part Unwrap Features Collection Object.
/// </summary>
public interface UnwrapFeatures : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    UnwrapFeature Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Unwrap feature.&nbsp;The newly created UnwrapFeature object is returned.
    /// </summary>
    /// <param name="Definition">Input UnwrapDefinition object that defins the unwrap feature you want to create.An UnwrapDefinition object can be created using the UnwrapFeatures.CreateDefinition method. It can also be obtained from an existing UnwrapFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    UnwrapFeature Add([In] [MarshalAs(UnmanagedType.Interface)] UnwrapDefinition Definition);
    /// <summary>
    /// Method that creates a new UnwrapDefinition object.&nbsp;The object created does not represent a Unwrap feature but instead is a representation of the information that defines a Unwrap feature.&nbsp;You can use this object as input to the UnwrapFeatures.Add method to create the actual feature.
    /// </summary>
    /// <param name="Faces">Input FaceCollection object that specifies the faces to Unwrap. The faces should be from the same body, otherwise an error would occur.</param>
    /// <param name="pOrigin">Optional input a Vertex object that specifies the origin.</param>
    /// <param name="Align">Optional input UnwrapResultAlignmentEnum that specifies the alignment of the deformed result. This defaults to kOriginAlignment if it is not specified.</param>
    /// <param name="LinearResult">Optional input EdgeCollection that specifies a set of consecutive edges to become a single colinear segment in the result.
    /// The edges should be from the faces in the InputFaces property and only outer edges that enclose the faces are valid.</param>
    /// <param name="RigidResult">Optional input EdgeCollection that specifies a set of
    /// consecutive planar edges to remain rigid in the result. The edges should be from the faces in the InputFaces property and only outer edges that enclose the faces are valid.</param>
    /// <param name="AutomaticFaceChain">Optional input Boolean that defines if automatic face chaining along tangentially connected faces should be performed. The default value is True.</param>
    /// <param name="MergeResultBody">Optional input Boolean that defines if merge result body or not. The default value is True.</param>
    /// <returns></returns>
    [PreserveSig]
    UnwrapDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Struct)] object? pOrigin = default, [In] UnwrapResultAlignmentEnum? Align = UnwrapResultAlignmentEnum.kOriginAlignment, [In] [MarshalAs(UnmanagedType.Struct)] object? LinearResult = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RigidResult = default, [In] bool? AutomaticFaceChain = true, [In] bool? MergeResultBody = true);
    /// <summary>
    /// Method that creates the UnwrapDefinition. The object created does not represent a Unwrap feature but instead is a representation of the information that defines a Unwrap feature.&nbsp;You can use this object as input to the UnwrapFeatures.Add method to create the.
    /// </summary>
    /// <param name="Faces">Input FaceCollection object that specifies the faces to Unwrap. The faces should be from the same body, otherwise an error would occur.</param>
    /// <param name="pOrigin">Optional input a Vertex object that specifies the origin.</param>
    /// <param name="Align">Optional input UnwrapResultAlignmentEnum that specifies the alignment of the deformed result. This defaults to kOriginAlignment if it is not specified.</param>
    /// <param name="LinearResult">Optional input EdgeCollection that specifies a set of consecutive edges to become a single colinear segment in the result.
    /// The edges should be from the faces in the InputFaces property and only outer edges that enclose the faces are valid.</param>
    /// <param name="RigidResult">Optional input EdgeCollection that specifies a set of
    /// consecutive planar edges to remain rigid in the result. The edges should be from the faces in the InputFaces property and only outer edges that enclose the faces are valid.</param>
    /// <param name="AutomaticFaceChain">Optional input Boolean that defines if automatic face chaining along tangentially connected faces should be performed. The default value is True.</param>
    /// <param name="MergeResultBody">Optional input Boolean that defines if merge result body or not. The default value is True.</param>
    /// <param name="MoreOptions">Optional input NameValueMap that defines more options for the unwrap definition.
    /// Valid options are:
    /// Name = SeamEdges. Value = EdgeCollection that specifies the seam edges.</param>
    /// <returns></returns>
    [PreserveSig]
    UnwrapDefinition CreateDefinitionWithOptions([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Struct)] object? pOrigin = default, [In] UnwrapResultAlignmentEnum? Align = UnwrapResultAlignmentEnum.kOriginAlignment, [In] [MarshalAs(UnmanagedType.Struct)] object? LinearResult = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RigidResult = default, [In] bool? AutomaticFaceChain = true, [In] bool? MergeResultBody = true, [In] [MarshalAs(UnmanagedType.Struct)] object? MoreOptions = default);
}
