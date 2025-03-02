namespace Oblikovati.API;

/// <summary>
/// The LightingStyle object provides access to all of the properties that define a specific lighting style.
/// </summary>
public interface LightingStyle
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent of the object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the lighting style name.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// property that returns the unique name of the style. The name is the internal English name of the style. This name will remain constant and is not affected by locale. This name is never displayed to the user.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets and sets the ambience of the lighting style.
    /// </summary>
    double Ambience { get; set; }
    /// <summary>
    /// Gets and sets the brightness of the lighting style.
    /// </summary>
    double Brightness { get; set; }
    /// <summary>
    /// Gets and sets the exposure of the lighting style.
    /// </summary>
    int Exposure { get; set; }
    /// <summary>
    /// Property that returns the Lights collection object.
    /// </summary>
    Lights Lights { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Property that returns the location of this lighting style, i.e. local to the document, cached locally in the document, exists in the library. Lighting styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Gets and sets the intensity of the ambient shadow (occlusion).
    /// </summary>
    double AmbientShadowIntensity { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the brightness of the lighting style.
    /// </summary>
    double ImageBasedLightingBrightness { get; set; }
    /// <summary>
    /// Gets and sets the rotation to be applied to the image.
    /// </summary>
    double ImageBasedLightingRotation { get; set; }
    /// <summary>
    /// Gets and sets the scale to be applied to the image.
    /// </summary>
    double ImageBasedLightingScale { get; set; }
    /// <summary>
    /// Gets and sets whether to display the image in the graphics scene.
    /// </summary>
    bool ImageBasedLightingShowImage { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ImageBasedLightingSourceInternalName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ImageBasedLightingSourceName { get; set; }
    /// <summary>
    /// Gets and sets the direction of the light source that controls the shadow.
    /// </summary>
    double ShadowDensity { get; set; }
    /// <summary>
    /// Gets and sets the direction of the light source that controls the shadow.
    /// </summary>
    ShadowDirectionEnum ShadowDirection { get; set; }
    /// <summary>
    /// Gets and sets the blending between shadowed and non-shadowed areas.
    /// </summary>
    double ShadowSoftness { get; set; }
    /// <summary>
    /// Gets the lighting style type.
    /// </summary>
    LightingStyleTypeEnum LightingStyleType { get; }
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style. This method fails if this style is already local. Use the StyleLocation property to determine whether the style is local.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LightingStyle ConvertToLocal();
    /// <summary>
    /// Method that copies the rendering style and assigns the specified name to the copy. The new style is returned by the method.
    /// </summary>
    /// <param name="NewName">Input String that specifies the name for the new lighting style. This name must be unique with respect to all other lighting styles in the document. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    LightingStyle Copy([In] [MarshalAs(UnmanagedType.BStr)] string NewName);
    /// <summary>
    /// Method that deletes the LightingStyle.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Upload an IBL image to current lighting style.
    /// </summary>
    /// <param name="ImageFileName">Input String value that specifies the image file name. Valid image extension types are: .hdr and .exr.</param>
    /// <param name="EnvName">Optional input String value that specifies the environment name. If not specified the default file name will be used.</param>
    [PreserveSig]
    void UploadImage([In] [MarshalAs(UnmanagedType.BStr)] string ImageFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? EnvName = default);
}
