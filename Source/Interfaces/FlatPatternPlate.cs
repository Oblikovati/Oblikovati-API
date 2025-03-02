namespace Oblikovati.API;

/// <summary>
/// FlatPatternPlate Object.
/// </summary>
public interface FlatPatternPlate
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
    FlatPattern Parent { get; }
    /// <summary>
    /// Read-only property that returns the front faces in the flat pattern plate.
    /// </summary>
    Faces FrontFaces { get; }
    /// <summary>
    /// Read-only property that returns the back faces in the flat pattern plate.
    /// </summary>
    Faces BackFaces { get; }
    /// <summary>
    /// Read-only property that returns whether the flat pattern plate is from a rigid partition. This returns False if the plate is from a bend.
    /// </summary>
    bool IsRigid { get; }
    /// <summary>
    /// Method that returns a FlatBendResult for this plate. If the plate is Rigid return nothing. For a non-rigid plate this property can return the front or back FlatBendResult.
    /// </summary>
    /// <param name="FrontBendResult">Optional input Boolean value that specifies whether to return the bend extent edges from the front face or the back face from the flat pattern plate. If not specified, edges from the front face are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    FlatBendResult GetBendResult([In] bool? FrontBendResult = true);
    /// <summary>
    /// Method that returns the bend extent edges.
    /// </summary>
    /// <param name="FrontFaceEdges">Optional input Boolean value that specifies whether to return the FlatBendResult from the front face or the back face. If not specified, the FlatBendResult on the front face is returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Edges GetBendExtentEdges([In] bool? FrontFaceEdges = true);
}
