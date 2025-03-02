namespace Oblikovati.API;

/// <summary>
/// The EdgeDefinition represents a transient definition of an Edge object.
/// </summary>
public interface EdgeDefinition
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
    /// Gets and sets the associate ID of this edge.&nbsp;This ID will be transferred to the corresponding edge when this SurfaceBodyDefinition is used to create a SurfaceBody.&nbsp;It is used by Inventor as the identifier for the edge and is used for tracking this geometry f.
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Gets and sets the associated FaceDefinition object.&nbsp;This is used in two cases.&nbsp;The first case is where the edge is being defined by a parameter space curve and this face defines the parameter space of the curve provided through the ParameterSpaceCurveOne pro.
    /// </summary>
    FaceDefinition FaceOne { get; set; }
    /// <summary>
    /// Gets and sets the associated FaceDefinition object.&nbsp;This is used in two cases.&nbsp;The first case is where the edge is being defined by a parameter space curve and this face defines the parameter space of the curve provided through the ParameterSpaceCurveTwo pro.
    /// </summary>
    FaceDefinition FaceTwo { get; set; }
    /// <summary>
    /// Gets and sets if the orientation of this EdgeUse is in the same direction or not relative to the associated EdgeDefinition object.
    /// </summary>
    bool IsParamReversed { get; set; }
    /// <summary>
    /// Gets and sets the definition of the edge in model space.&nbsp;This can be Nothing in the case where no model space geometry is specified for this edge.
    /// </summary>
    object ModelSpaceCurve { get; set; }
    /// <summary>
    /// Gets and sets the definition of the edge in parameter space.&nbsp;If this is provided then the FaceOne property must also be set to define the parameter space this curve is defined within. This can be Nothing in the case where no parameter space curve is defined f.
    /// </summary>
    object ParameterSpaceCurveOne { get; set; }
    /// <summary>
    /// Gets and sets the definition of the edge in parameter space.&nbsp;If this is provided then the FaceTwo property must also be set to define the parameter space this curve is defined within. This can be Nothing in the case where no parameter space curve is defined f.
    /// </summary>
    object ParameterSpaceCurveTwo { get; set; }
    /// <summary>
    /// Gets and sets the starting vertex of the edge.&nbsp;This can be Nothing where no start vertex is specifically defined.
    /// </summary>
    VertexDefinition StartVertex { get; set; }
    /// <summary>
    /// Gets and sets the end vertex of the edge.&nbsp;This can be Nothing where no end vertex is specifically defined.
    /// </summary>
    VertexDefinition EndVertex { get; set; }
}
