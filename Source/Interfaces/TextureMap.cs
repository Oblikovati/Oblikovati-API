namespace Oblikovati.API;

/// <summary>
/// Each TextureMap references a TextureCoordinateSet that defines the coordinates of the map on the face. Several TextureMaps could reference a single TextureCoordinateSet.
/// </summary>
public interface TextureMap
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the image for the texture map.
    /// </summary>
    IPictureDisp Image { get; }
    /// <summary>
    /// A matrix that defines how the coordinates map to the actual face coordinates.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Gets whether the texture map mask is in use.
    /// </summary>
    bool UseMask { get; }
    /// <summary>
    /// Gets the mask color for the texture map image.
    /// </summary>
    Color MaskColor { get; }
    /// <summary>
    /// Generates an image at the specified location.
    /// </summary>
    [PreserveSig]
    void GenerateImage([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Gets the TextureCoordinateSet for the input tolerance.
    /// </summary>
    /// <param name="Tolerance">Input tolerance value.</param>
    /// <returns></returns>
    [PreserveSig]
    TextureCoordinateSet GetTextureCoordinateSet([In] double Tolerance);
}
