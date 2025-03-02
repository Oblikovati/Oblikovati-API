namespace Oblikovati.API;

/// <summary>
/// The Color object provides access to all of the components defining a color.
/// </summary>
public interface Color
{
    /// <summary>
    /// Specifies the blue component of the color.
    /// </summary>
    byte Blue { get; set; }
    /// <summary>
    /// Specifies the green component of the color.
    /// </summary>
    byte Green { get; set; }
    /// <summary>
    /// Specifies the opacity value.
    /// </summary>
    double Opacity { get; set; }
    /// <summary>
    /// Specifies the red component of the color.
    /// </summary>
    byte Red { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the color source type.
    /// </summary>
    ColorSourceTypeEnum ColorSourceType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the color components of the Color object.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    [PreserveSig]
    void SetColor([In] byte Red, [In] byte Green, [In] byte Blue);
}
