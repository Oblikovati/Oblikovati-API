namespace Oblikovati.API;

/// <summary>
/// Inventor supports the creation of preview and overlay graphics.
/// </summary>
public interface InteractionGraphics
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// The object that can be used with the preview and overlay graphics properties.
    /// </summary>
    GraphicsDataSets GraphicsDataSets { get; }
    /// <summary>
    /// The top level object for graphics that are rendered independently from the main scene.
    /// </summary>
    ClientGraphics OverlayClientGraphics { get; }
    /// <summary>
    /// The top level object for graphics that are rendered with the main scene.
    /// </summary>
    ClientGraphics PreviewClientGraphics { get; }
    /// <summary>
    /// Redraw just the overlay graphics only in a specified view.
    /// </summary>
    /// <param name="TheView">View object representing the view to redraw.</param>
    [PreserveSig]
    void UpdateOverlayGraphics([In] [MarshalAs(UnmanagedType.Interface)] View TheView);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _EraseAll();
}
