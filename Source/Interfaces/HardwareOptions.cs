namespace Oblikovati.API;

/// <summary>
/// The HardwareOptions object provides access to properties that provide read and write access of the hardware related application options. This is somewhat equivalent to the Hardware tab of the Application Options dialog.
/// </summary>
public interface HardwareOptions
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GraphicsDriverTypeEnum GraphicsDriverType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool WarnForUnrecommendedDriver { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool WarnForDriverErrors { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GraphicsOptimizationEnum GraphicsOptimization { get; set; }
    /// <summary>
    /// Property that returns a string with results of diagnostic testing.
    /// </summary>
    string Diagnostics { get; }
    /// <summary>
    /// Read-write property that specifies the type of the graphics hardware setting to use.
    /// </summary>
    GraphicsSettingTypeEnum GraphicsSettingType { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to use software graphics.
    /// </summary>
    bool UseSoftwareGraphics { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to use GPU Raytracing.
    /// </summary>
    bool EnableViewportGPURayTracing { get; set; }
}
