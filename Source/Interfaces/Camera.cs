namespace Oblikovati.API;

/// <summary>
/// The Camera defines the view of the model shown within the window.
/// </summary>
public interface Camera
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object of the camera.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets/Sets the type of orientation of the camera (Top, Iso, etc. or arbitrary).
    /// </summary>
    ViewOrientationTypeEnum ViewOrientationType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Matrix WorldToView { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Matrix ViewToWorld { get; set; }
    /// <summary>
    /// Specifies the position of the observer's 'Eye' (View's center).
    /// </summary>
    Point Eye { get; set; }
    /// <summary>
    /// Specifies the position of the Target point the observer's viewing in the scene (View's Z-axis).
    /// </summary>
    Point Target { get; set; }
    /// <summary>
    /// Specifies the vector defining what is 'up' for the observer.
    /// </summary>
    UnitVector UpVector { get; set; }
    /// <summary>
    /// Gets/Sets a boolean flag indicating whether Perpspective viewing is on/off.
    /// </summary>
    bool Perspective { get; set; }
    /// <summary>
    /// Gets/Sets the Perspective Angle.
    /// </summary>
    double PerspectiveAngle { get; set; }
    /// <summary>
    /// Get/Set the contents of the scene for a camera. This is applicable only when the Camera is created from the TransientObjects.CreateCamera. Valid objects that can be set to this property are: ComponentDefinition, Sheet, and PresentationScene.
    /// </summary>
    object SceneObject { get; set; }
    /// <summary>
    /// Read-only property that returns the transformation matrix from model space to view space.
    /// </summary>
    Matrix ModelToViewTransformation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Animating { set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DumpingNodeCount { set; }
    /// <summary>
    /// Method that fits all the contents of the Document into the view.
    /// </summary>
    [PreserveSig]
    void Fit();
    /// <summary>
    /// Method that causes the changes made to the Camera object to be applied to the actual camera of the view. This will also cause the view to update.
    /// </summary>
    [PreserveSig]
    void Apply();
    /// <summary>
    /// Method that applies the current camera to the View without transition.
    /// </summary>
    [PreserveSig]
    void ApplyWithoutTransition();
    /// <summary>
    /// Method that sets the current extents of the camera. The camera extents define the area within the model that is visible in the view. Setting the extents results in the camera zooming in or out. The Apply method of the camera must be called before any changes are shown in the view.
    /// </summary>
    /// <param name="Width">Input Double that specifies the new width of the volume of the model to display within the view. For perspective views, the width is specified at the target point. The value is in centimeters.</param>
    /// <param name="Height">Input Double that specifies the new height of the volume of the model to display within the view. For perspective views, the height is specified at the target point. The value is in centimeters.</param>
    [PreserveSig]
    void SetExtents([In] double Width, [In] double Height);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Width">Width</param>
    /// <param name="Height">Height</param>
    [PreserveSig]
    void GetExtents([Out] out double Width, [Out] out double Height);
    /// <summary>
    /// Method that changes the view according mouse movement and view operation.
    /// </summary>
    /// <param name="FromPoint">Input point that specifies the starting point from which to move the view.</param>
    /// <param name="ToPoint">Input point that specifies the destination to which to move the view.</param>
    /// <param name="WheelDelta">Input Long that specifies the number of clicks (to zoom in or out) that have been made with the center mouse wheel. The WheelDelta is for the middle button wheel on the mouse. We use that for zoom in/out. The WheelDelta should represent the number of clicks that have been made with the wheel.</param>
    /// <param name="ViewOperation">Input constant that specifies the type of view operation (pan, rotate, or zoom).</param>
    [PreserveSig]
    void ComputeWithMouseInput([In] [MarshalAs(UnmanagedType.Interface)] Point2d FromPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ToPoint, [In] int WheelDelta, [In] ViewOperationTypeEnum ViewOperation);
    /// <summary>
    /// Method that converts a point in model space to the equivalent point on the view.
    /// </summary>
    /// <param name="ModelCoordinate">Input model space point to convert to view space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d ModelToViewSpace([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
    /// <summary>
    /// Method that converts a point in view space to the equivalent point in the model.
    /// </summary>
    /// <param name="ViewCoordinate">Input view point to convert to model space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point ViewToModelSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewCoordinate);
    /// <summary>
    /// Method that saves the current camera view to the specified file. The width and height arguments define the aspect ratio and the number of pixels in the output image.
    /// The CreateImage method is similar to this but instead of writing the image to a file it creates it in memory, which is more efficient than writing and reading if from disk if you need to use the image immediately.
    /// </summary>
    /// <param name="FullFileName">The full filename (path and filename) of the bitmap to create.  The type of image file to create is implied based on the extension of the filename.  Valid extensions are bmp, jpg, png, tiff, and gif.</param>
    /// <param name="Width">Specifies the number of horizontal pixels in the output image.</param>
    /// <param name="Height">Specifies the number of vertical pixels in the output image.</param>
    /// <param name="topColor">Optional argument that specifies the background color at the top of the image.  If a bottom background color is supplied, then the background will be a gradient between the top and bottom colors.  If only a top background color is supplied, the background will be a solid color using this color.  If no color is defined a default color will be used.</param>
    /// <param name="bottomColor">Optional argument that specified the background color at the bottom of the image.  This argument is only valid when the TopBackgroundColor argument has been supplied.  This argument defines the color of the background at the bottom of the image and a gradient background is created that varies from the top color to the bottom color.</param>
    [PreserveSig]
    void SaveAsBitmap([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int Width, [In] int Height, [In] [MarshalAs(UnmanagedType.Struct)] object? topColor = default, [In] [MarshalAs(UnmanagedType.Struct)] object? bottomColor = default);
    /// <summary>
    /// Creates an image based on the current camera view.
    /// </summary>
    /// <param name="Width">Specifies the number of horizontal pixels in the output image.</param>
    /// <param name="Height">Specifies the number of vertical pixels in the output image.</param>
    /// <param name="topColor">Optional argument that specifies the background color at the top of the image.  If a bottom background color is supplied, then the background will be a gradient between the top and bottom colors.  If only a top background color is supplied, the background will be a solid color using this color.  If no color is defined a default color will be used.</param>
    /// <param name="bottomColor">Optional argument that specified the background color at the bottom of the image.  This argument is only valid when the TopBackgroundColor argument has been supplied.  This argument defines the color of the background at the bottom of the image and a gradient background is created that varies from the top color to the bottom color.</param>
    /// <returns></returns>
    [PreserveSig]
    IPictureDisp CreateImage([In] int Width, [In] int Height, [In] [MarshalAs(UnmanagedType.Struct)] object? topColor = default, [In] [MarshalAs(UnmanagedType.Struct)] object? bottomColor = default);
    /// <summary>
    /// Creates an image based on the current camera view with options.
    /// </summary>
    /// <param name="Width">Specifies the number of horizontal pixels in the output image.</param>
    /// <param name="Height">Specifies the number of vertical pixels in the output image.</param>
    /// <param name="Options">Optional input NameValueMap that specifies more options to create the image. The valid values for the options are: NameValue TypeDescription
    /// TopBackgroundColorColorSpecifies the background color at the top of the image. If a bottom background color is supplied, then the background will be a gradient between the top and bottom colors. If only a top background color is supplied, the background will be a solid color using this color. If no color is defined a default color will be used.
    /// BottomBackgroundColorColorSpecified the background color at the bottom of the image. This argument is only valid when the TopBackgroundColor argument has been supplied. This argument defines the color of the background at the bottom of the image and a gradient background is created that varies from the top color to the bottom color.
    /// AntiAliasingBooleanSpecifies whether apply the anti-aliasing effect for the image. If not specified this will default to False.
    /// IncludeEditsBooleanSpecifies whether the saved image will include the edits to current camera even the edits are not applied yet. If not specified this will default to False.
    /// TransparentBackgroundBooleanSpecifies whether the saved image will have transparent background. If not specified this will default to False.</param>
    /// <returns></returns>
    [PreserveSig]
    IPictureDisp CreateImageWithOptions([In] int Width, [In] int Height, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
}
