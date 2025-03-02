namespace Oblikovati.API;

/// <summary>
/// The SurfaceGraphicsFace represents an individual face displayed by the SurfaceGraphics object.
/// </summary>
public interface SurfaceGraphicsFace
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the Face object associated with the SurfaceGraphicsFace.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Gets and sets color associated with this primitive.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle RenderStyle { get; set; }
    /// <summary>
    /// Property that returns the index of the SurfaceGraphicsFace object within the SurfaceGraphicsFaceList.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns the parent SurfaceGraphics object.
    /// </summary>
    SurfaceGraphics Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that specifies whether the surface graphics face can be selected or not.
    /// </summary>
    bool Selectable { get; set; }
    /// <summary>
    /// Gets and sets appearance associated with the surface graphics face.
    /// </summary>
    Asset Appearance { get; set; }
}
