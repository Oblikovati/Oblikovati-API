namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface GroundPlaneSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets or sets whether the ground plane should be resized automatically based on the component size.
    /// </summary>
    bool AutoResize { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color for the ground plane for the area inside the margin.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to display grid lines.
    /// </summary>
    bool DisplayGridLines { get; set; }
    /// <summary>
    /// Gets and sets the offset of the ground plane from the specified position.
    /// </summary>
    double HeightOffset { get; set; }
    /// <summary>
    /// Gets and sets the spacing between minor grid lines in centimeters.
    /// </summary>
    double MinorGridLineSpacing { get; set; }
    /// <summary>
    /// Gets and sets the number of minor lines to appear between major lines.
    /// </summary>
    int MinorLinesPerMajorGridLine { get; set; }
    /// <summary>
    /// Gets and sets the opacity of the ground plane.
    /// </summary>
    double Opacity { get; set; }
    /// <summary>
    /// Property that returns the geometry of the ground plane. The returned Plane object provides information about the position and normal of the work plane.
    /// </summary>
    Plane Plane { get; }
    /// <summary>
    /// Gets and sets the position of the ground plane.
    /// </summary>
    object Position { get; set; }
    /// <summary>
    /// Gets and sets the reflection’s blurriness, specifying the amount of blur the ground plane surface will produce.
    /// </summary>
    double ReflectionBlur { get; set; }
    /// <summary>
    /// Gets and sets where the model reflection seems to fade away.
    /// </summary>
    double ReflectionBlurFalloff { get; set; }
    /// <summary>
    /// Gets and sets the reflectivity of the ground plane.
    /// </summary>
    double Reflectivity { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets front directon of the ground plane.
    /// </summary>
    UnitVector FrontDirection { get; }
    /// <summary>
    /// Gets up directon of the ground plane.
    /// </summary>
    UnitVector UpDirection { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PointOne">PointOne</param>
    /// <param name="PointTwo">PointTwo</param>
    [PreserveSig]
    void GetSize([Out] [MarshalAs(UnmanagedType.Interface)] out Point PointOne, [Out] [MarshalAs(UnmanagedType.Interface)] out Point PointTwo);
    /// <summary>
    /// Method that sets the current size of the displayed graphics for the ground plane. The plane is functionally infinite but has a plane that is displayed to allow the user to visualize it. This method will fail if the AutoResize property is set to True.
    /// </summary>
    /// <param name="PointOne">Point object that defines the first corner of the ground plane in model space. If the input point does not lie on the ground plane, the point is projected to the plane.</param>
    /// <param name="PointTwo">Point object that defines the diagonally opposite corner of the ground plane in model space. If the input point does not lie on the ground plane, the point is projected to the plane.</param>
    [PreserveSig]
    void SetSize([In] [MarshalAs(UnmanagedType.Interface)] Point PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point PointTwo);
}
