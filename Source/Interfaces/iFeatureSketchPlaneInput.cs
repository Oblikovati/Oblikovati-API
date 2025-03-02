namespace Oblikovati.API;

/// <summary>
/// The iFeatureSketchPlaneInput object represents the sketch plane input information of an iFeature. The iFeatureSketchPlaneInput object is used specify the geometry's and other data necessary for the sketch plane input of an iFeature.
/// </summary>
public interface iFeatureSketchPlaneInput
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
    /// Property that gets the prompt that is used for this input during the placement of the iFeature.
    /// </summary>
    string Prompt { get; }
    /// <summary>
    /// Property that gets the name associated with this input. When placing an iFeature using the API you can use the name to identify each input when assigning the desired values and entities.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property that returns the type of geometry that are valid. The value returned is the sum of values specifying the valid entity types.
    /// </summary>
    iFeatureEntityInputTypeEnum EntityType { get; }
    /// <summary>
    /// Gets and sets the geometry matching the sketch plane input.
    /// </summary>
    object PlaneInput { get; set; }
    /// <summary>
    /// Gets and sets whether the geometry selection needs to be flipped.
    /// </summary>
    bool FlipOption { get; set; }
    /// <summary>
    /// Method that sets the position of the iFeature on the plane provided.
    /// </summary>
    /// <param name="Point">Input object that specifies the 3D location of the iFeature on the plane.</param>
    /// <param name="Axis">Specifies the vector along which the X-axis of iFeature will be aligned.</param>
    /// <param name="RotationAngle">Specifies the angle in radians by which the axis will be rotated about a vector perpendicular to the plane used for placing the iFeature.</param>
    [PreserveSig]
    void SetPosition([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] [MarshalAs(UnmanagedType.Interface)] Vector Axis, [In] double RotationAngle);
}
