namespace Oblikovati.API;

/// <summary>
/// The View object represents a view in a document.
/// </summary>
public interface View
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
    /// Property that returns the parent <link Inventor::Document, Document> object from whom this object can logically be reached.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Property that returns the <link Inventor::Document, Document> the view is associated with.
    /// </summary>
    _Document Document { get; }
    /// <summary>
    /// Property that returns a Camera object which contains the information that defines the current contents of the view.
    /// </summary>
    Camera Camera { get; }
    /// <summary>
    /// Gets/Sets the caption on this View's window.
    /// </summary>
    string Caption { get; set; }
    /// <summary>
    /// Gets/Sets the visibility of this View.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets/Sets the Display Mode on this View's window.
    /// </summary>
    DisplayModeEnum DisplayMode { get; set; }
    /// <summary>
    /// Property that returns the hWnd for the window. This provides convenient access to the window's hWnd. Having the hWnd allows you to use various Windows API calls with the window.
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Gets/Sets the distance between the top of the view window and top of the frame window.
    /// </summary>
    int Top { get; set; }
    /// <summary>
    /// Gets/Sets the distance between the left edge of the view window and left edge of the frame window.
    /// </summary>
    int Left { get; set; }
    /// <summary>
    /// Gets/Sets the Height of the view window.
    /// </summary>
    int Height { get; set; }
    /// <summary>
    /// Gets/Sets the Width of the view window.
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Gets/Sets this windows state.
    /// </summary>
    WindowsSizeEnum WindowState { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GroundShadowEnum GroundShadow { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ViewCubeEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SteeringWheelEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool NavigationBarEnabled { get; set; }
    /// <summary>
    /// Gets and sets whether to display the ground plane.
    /// </summary>
    bool ShowGroundPlane { get; set; }
    /// <summary>
    /// Gets and sets whether to display ground reflections.
    /// </summary>
    bool ShowGroundReflections { get; set; }
    /// <summary>
    /// Gets and sets whether to display ambient shadows.
    /// </summary>
    bool ShowAmbientShadows { get; set; }
    /// <summary>
    /// Gets and sets whether to display ground shadows.
    /// </summary>
    bool ShowGroundShadows { get; set; }
    /// <summary>
    /// Gets and sets whether to display object shadows.
    /// </summary>
    bool ShowObjectShadows { get; set; }
    /// <summary>
    /// Gets and sets whether to enable ray tracing for the view.
    /// </summary>
    bool RayTracing { get; set; }
    /// <summary>
    /// Gets and sets the quality used when ray tracing is enabled.
    /// </summary>
    RayTracingQualityEnum RayTracingQuality { get; set; }
    /// <summary>
    /// Gets and sets whether to turn textures on.
    /// </summary>
    bool AreTexturesOn { get; set; }
    /// <summary>
    /// Gets and sets whether the current ray tracing process is paused. If this property returns true then set it to false will continue the current ray tracing.
    /// </summary>
    bool IsRayTracingPaused { get; set; }
    /// <summary>
    /// Gets the progress in percentage of the ray tracing process.
    /// </summary>
    double RayTracingProgress { get; }
    /// <summary>
    /// Read-only property that returns the ViewFrame this view is located in.
    /// </summary>
    ViewFrame ViewFrame { get; }
    /// <summary>
    /// Read-only property that returns the ViewTab of this view.
    /// </summary>
    ViewTab ViewTab { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the noise reduction is enabled or not when ray tracing is enabled.
    /// </summary>
    bool NoiseReductionEnabled { get; set; }
    /// <summary>
    /// Read-write property that gets and sets which type of display separate colors will be applied.
    /// </summary>
    DisplaySeparateColorsTypeEnum DisplaySeparateColorsType { get; set; }
    /// <summary>
    /// Method that causes this view to become the active view (i.e. receive user-focus).
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that closes the view. If only one view exists for a document and the Close method is called it will also cause the Document to close.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that causes the view to update. In some cases, changes made to a model or to the view will not immediately be shown in the view and the Update method must be called to cause the view to refresh.
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that fits all of the contents of the document within the view. Can optionally cause the display of the view to be updated.
    /// </summary>
    /// <param name="DoUpdate">Input Boolean that specifies whether to update the view after the document contents have been fitted into it. The default is to perform the update.</param>
    [PreserveSig]
    void Fit([In] bool? DoUpdate = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Top">Top</param>
    /// <param name="Left">Left</param>
    /// <param name="Height">Height</param>
    /// <param name="Width">Width</param>
    [PreserveSig]
    void GetWindowExtents([Out] out int Top, [Out] out int Left, [Out] out int Height, [Out] out int Width);
    /// <summary>
    /// Method that saves the view as a bitmap.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of the file to which to save the view.</param>
    /// <param name="Width">Input Long that specifies the width of the view.</param>
    /// <param name="Height">Input Long that specifies the height of the view.</param>
    [PreserveSig]
    void SaveAsBitmap([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int Width, [In] int Height);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="maxFrames">maxFrames</param>
    [PreserveSig]
    void _GraphicsCollectionStart([In] int maxFrames);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="action">action</param>
    /// <param name="FilePath">FilePath</param>
    [PreserveSig]
    void _GraphicsCollectionEndDump([In] [MarshalAs(UnmanagedType.BStr)] string action, [In] [MarshalAs(UnmanagedType.BStr)] string FilePath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Top">Top</param>
    /// <param name="Left">Left</param>
    /// <param name="Height">Height</param>
    /// <param name="Width">Width</param>
    [PreserveSig]
    void Move([In] ref int Top, [In] ref int Left, [In] ref int Height, [In] ref int Width);
    /// <summary>
    /// Method that sets the view to the default view of the model.
    /// </summary>
    [PreserveSig]
    void GoHome();
    /// <summary>
    /// Method that resets the front view to the factory default.
    /// </summary>
    [PreserveSig]
    void ResetFront();
    /// <summary>
    /// Method that sets the current view as the front view.
    /// </summary>
    [PreserveSig]
    void SetCurrentAsFront();
    /// <summary>
    /// Method that sets the current view as the top view.
    /// </summary>
    [PreserveSig]
    void SetCurrentAsTop();
    /// <summary>
    /// Method that sets the current view as the home view.
    /// </summary>
    /// <param name="FitToView">Optional input Boolean that specifies whether to set the view extent as "view all" (fit to view) or to the extent of the model that currently fills the view (fixed distance).</param>
    [PreserveSig]
    void SetCurrentAsHome([In] bool? FitToView = true);
    /// <summary>
    /// Method that saves the view with ray tracing on as a bitmap in one of the following types: bmp, jpg, png, tiff, and gif.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of the file to which to save the view.  The extension of this filename controls the type of file that’s created.  Valid extensions are bmp, jpg, png, tiff, and gif.</param>
    [PreserveSig]
    void SaveAsBitmapWithRayTracing([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="iteration">iteration</param>
    /// <param name="frames">frames</param>
    /// <param name="frameRateType">frameRateType</param>
    /// <param name="FilePath">FilePath</param>
    [PreserveSig]
    void _GraphicsFrameRate([In] int iteration, [In] int frames, [In] int frameRateType, [In] [MarshalAs(UnmanagedType.BStr)] string FilePath);
    /// <summary>
    /// Method that saves the view as a bitmap with more options. The width and height arguments define the aspect ratio and the number of pixels in the output image. The Options argument allow you to define more effects for the bitmap.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of the file to which to save the view.  The extension of this filename controls the type of file that’s created.  Valid extensions are bmp, jpg, png, tiff, and gif.</param>
    /// <param name="Width">Input Long that specifies the width of the view.  A value of 0 will use the current width of the view.</param>
    /// <param name="Height">Input Long that specifies the height of the view.  A value of 0 will use the current height of the view.</param>
    /// <param name="Options">Input NameValueMap that specifies more options to create the bitmap. The valid values for the options are: NameValue TypeDescription
    /// TransparentBackgroundBooleanSpecifies whether the saved bitmap will have transparent background. If not specified this will default to False.</param>
    [PreserveSig]
    void SaveAsBitmapWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int Width, [In] int Height, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
    /// <summary>
    /// Method that starts a rendering rate record for the graphics window.
    /// </summary>
    [PreserveSig]
    void StartRenderingRateRecord();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="frames">frames</param>
    /// <param name="ElapsedTime">ElapsedTime</param>
    [PreserveSig]
    void StopRenderingRateRecord([Out] out int frames, [Out] out double ElapsedTime);
}
