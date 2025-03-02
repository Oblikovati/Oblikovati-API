namespace Oblikovati.API;

/// <summary>
/// The FaceDefinition represents a transient definition of a Face object.
/// </summary>
public interface FaceDefinition
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
    /// Gets and sets the associate ID of this face.&nbsp;This ID will be transferred to the corresponding face&nbsp;when this SurfaceBodyDefinition is used to create a SurfaceBody.&nbsp;It is used by Inventor as the identifier for the face and is used for tracking this geometry.
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Property that returns the collection of EdgeLoopDefinition objects associated with this FaceDefinition object.
    /// </summary>
    EdgeLoopDefinitions EdgeLoopDefinitions { get; }
    /// <summary>
    /// Gets the collection of EdgeLoopDefinition objects associated with this FaceDefinition object.
    /// </summary>
    object SurfaceGeometry { get; set; }
    /// <summary>
    /// Read write property that indicates if the normal of this face is reversed with respect to the geometry associated with this face definition.
    /// </summary>
    bool IsParamReversed { get; set; }
}
