namespace Oblikovati.API;

/// <summary>
/// The ClientView object represents a view of the document/drawing sheet attached to a user-specified window handle. See the article in the overviews section.
/// </summary>
public interface ClientView
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    ClientViews Parent { get; }
    /// <summary>
    /// Property that returns the document object this is a view of.
    /// </summary>
    object Document { get; }
    /// <summary>
    /// Property that returns the camera for the view.
    /// </summary>
    Camera Camera { get; }
    /// <summary>
    /// Rendering mode of view (shaded, hidden, hidden line).
    /// </summary>
    DisplayModeEnum DisplayMode { get; set; }
    /// <summary>
    /// Property that returns the hWnd (the handle assigned by Windows to the current window) of the view.
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BackgroundDisplay { get; set; }
    /// <summary>
    /// Gets and sets the ground shadow setting on the view!/s window.
    /// </summary>
    GroundShadowEnum GroundShadow { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double DisplayScaleFactor { get; set; }
    /// <summary>
    /// Method that closes out the graphics context for the view. The hWnd is not affected.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that redraws the view.
    /// </summary>
    /// <param name="Interactive">Input Boolean that specifies the type of update to perform. Interactive update should be used when the user is dynamically modifying the view. During interactive update Autodesk Inventor takes steps to optimize the display in an attempt to achieve a higher frame rate. For example it will create simplified displays of parts and eliminate the display of small parts in assemblies. Setting the Interactive argument to True allows Autodesk Inventor to perform these optimizations. Setting this argument to False causes Autodesk Inventor to perform a complete rendering without any optimizations. Typically you will set the Interactive argument to True while the user is dynamically modifying the view (while the mouse button is down). A final update (When the mouse button is released) is performed with the Interactive argument set to False to get an accurate rendering.</param>
    [PreserveSig]
    void Update([In] bool Interactive);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetTransform">TargetTransform</param>
    /// <param name="NumberOfTransitions">NumberOfTransitions</param>
    [PreserveSig]
    void Animate([In] [MarshalAs(UnmanagedType.Interface)] Matrix TargetTransform, [In] int NumberOfTransitions);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Top">Top</param>
    /// <param name="Left">Left</param>
    /// <param name="Width">Width</param>
    /// <param name="Height">Height</param>
    [PreserveSig]
    void GetSubsetExtents([Out] out int Top, [Out] out int Left, [Out] out int Width, [Out] out int Height);
}
