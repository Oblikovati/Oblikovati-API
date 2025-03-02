namespace Oblikovati.API;

/// <summary>
/// The BendDefinition object represents all of the information that defines a bend.
/// </summary>
public interface BendDefinition
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
    /// Gets and sets the set of edges that define the location of the bend.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Gets and sets the bend radius.
    /// </summary>
    object BendRadius { get; set; }
    /// <summary>
    /// Specifies if the existing faces will be extended to the bend or if a perpendicular section should be created to connect to the bend.
    /// </summary>
    bool ExtendFaces { get; set; }
    /// <summary>
    /// Specifies if the bend is a double bend or not.
    /// </summary>
    DoubleBendTypeEnum DoubleBendType { get; set; }
    /// <summary>
    /// Specify which face remains fixed and which one is extended or trimmed in the case of double bends.
    /// </summary>
    bool IsDoubleBendFirstEdgeFixed { get; set; }
    /// <summary>
    /// Gets and sets the BendOptions object that defines the options for a bend.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Gets and sets the UnfoldMethod object that defines how this bend is unfolded.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Property that returns the parent feature of this BendDefinition object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-write property that gets and set whether the unfold method has been overridden for this feature. Setting this property to False clears the override.&nbsp;Setting the property to True returns a failure.
    /// </summary>
    bool IsUnfoldMethodOverridden { get; set; }
    /// <summary>
    /// Method that creates a copy of this BendDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BendDefinition Copy();
}
