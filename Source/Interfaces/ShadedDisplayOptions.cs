namespace Oblikovati.API;

/// <summary>
/// The ShadedDisplayOptions object provides access to properties that provide read and write access of the shaded display related application options. This is equivalent to the Shaded Display Mode section of the Display tab on the Application Options dialog.
/// </summary>
public interface ShadedDisplayOptions
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DepthDimming { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EdgeDisplayForActiveComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EdgeDisplayForEnabledComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Color EdgeColorForActiveComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Color EdgeColorForEnabledComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShadedBackgroundComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShadedEnabledComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ShadeOpacityForBackgroundComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ShadeOpacityForEnabledComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SilhouettesForActiveComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SilhouettesForBackgroundComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SilhouettesForEnabledComponents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TransparencyTypeEnum TransparencyType { get; set; }
}
