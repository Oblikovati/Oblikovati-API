namespace Oblikovati.API;

/// <summary>
/// Part Sketch Driven Pattern Feature Definition object.
/// </summary>
public interface SketchDrivenPatternDefinition
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
    /// Read-write property that gets and sets the collection of occurrences that should participate in this feature. If this property is not set, all possible occurrences will participate.&nbsp;This property applies only to features in an assembly.
    /// </summary>
    ObjectCollection AffectedOccurrences { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature. If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometry that defines the base point. When set this property, it can be a SketchPoint, SketchPoint3D, WorkPoint, GeometryIntent that indicates a point on geometry. If a GeometryIntent is provided, you can specify the mid-point of sketch line, start/end/mid-point of a linear edge, the center of a circular/elliptical edge, planar face center, the start/mid/end point of the axis of a cylindrical/conical face, or the center of torus/spherical face.
    /// </summary>
    object BasePoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets FaceCollection object to specify the reference faces.
    /// </summary>
    FaceCollection ReferenceFaces { get; set; }
    /// <summary>
    /// Read-write property that indicates the method of solution for the pattern.
    /// </summary>
    PatternComputeTypeEnum ComputeType { get; set; }
    /// <summary>
    /// Gets and sets the operation type.&nbsp;Valid values are kNewBodyOperation and kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the parent features of the pattern.&nbsp;The ObjectCollection returned by this property is a “tear off” and does not affect the pattern if its contents are modified.&nbsp;To change the which features are the parents of the pattern you need to use this property to set the parent features by providing an ObjectCollection that contains the desired set of parent features.
    /// </summary>
    ObjectCollection ParentFeatures { get; set; }
    /// <summary>
    /// Read-only property that gets whether this pattern resulted from patterning the Surface Body.
    /// </summary>
    bool PatternOfBody { get; }
    /// <summary>
    /// Read-write property that gets and sets PlanarSketch or Sketch3D object that contains the sketch points to locate the pattern occurrences.
    /// </summary>
    object Sketch { get; set; }
    /// <summary>
    /// Method that returns a copy of the SketchDrivenPatternDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SketchDrivenPatternDefinition Copy();
}
