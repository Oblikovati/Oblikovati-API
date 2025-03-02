namespace Oblikovati.API;

/// <summary>
/// UnwrapDefinition Object.
/// </summary>
public interface UnwrapDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    UnwrapFeature Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write Property that gets and sets whether or not to use all tangentially connected faces. A value of True indicates that automatic face chaining of tangentially connected faces should be performed.
    /// </summary>
    bool AutomaticFaceChain { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether merge the result body or not.
    /// </summary>
    bool MergeResultBody { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the faces to unwrap.
    /// </summary>
    FaceCollection InputFaces { get; set; }
    /// <summary>
    /// Read-write property that gets and sets an EdgeCollection that specifies a set of consecutive edges to become a single colinear segment in the result. The edges should be from the faces in the Faces property and only outer edges that enclose the faces are valid.
    /// </summary>
    EdgeCollection LinearResult { get; set; }
    /// <summary>
    /// Read-write property that gets and sets an EdgeCollection that specifies a set of consecutive planar edges to remain undeformed.
    /// </summary>
    EdgeCollection RigidResult { get; set; }
    /// <summary>
    /// Read-write property that gets and sets alignment of the deformed result.
    /// </summary>
    UnwrapResultAlignmentEnum ResultAlignment { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vertex as origin.
    /// </summary>
    Vertex Origin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets an EdgeCollection that specifies the seam edges.
    /// </summary>
    EdgeCollection SeamEdges { get; set; }
    /// <summary>
    /// Method that creates a copy of this UnwrapDefinition object.&nbsp;The new UnwrapDefinition object is independent of any feature.&nbsp;It can edited and used as input to edit an existing feature or to create a new unwrap feature.
    /// One typical use of this method is when you need to make several changes to an existing unwrap feature.&nbsp;If you edit the UnwrapDefinition object associated with the unwrap feature, the feature will recompute after each edit.&nbsp;It’s more efficient to make a copy, edit the copy, and then assign the copy to the feature.&nbsp;This will result in a single recompute.&nbsp;
    /// The UnwrapFeatures.CreateDefinition method can also be used to create an independent UnwrapDefinition object.&nbsp;The difference is that one created with the Copy method will have the same initial values as the object is was copied from.&nbsp;One that’s created with the CreateDefinition method will be initialized to predefined default values.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UnwrapDefinition Copy();
}
