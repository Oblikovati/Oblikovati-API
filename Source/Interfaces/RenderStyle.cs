namespace Oblikovati.API;

/// <summary>
/// The RenderStyle object provides access to all of the properties that define a specific rendering style.
/// </summary>
public interface RenderStyle
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returning the parent of the object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that gets and sets the opacity of the render style. The opacity is defined using a value between 0 and 1. A value of 0 results in a completely translucent style while a value of 1 is completely opaque.
    /// </summary>
    double Opacity { get; set; }
    /// <summary>
    /// Property that gets and sets the reflectivity of the render style. The reflectivity is defined using a value between 0 and 1. A value of 0 results in a non-reflective rendering style while a value of 1 is very reflective.
    /// </summary>
    double Reflectivity { get; set; }
    /// <summary>
    /// Property that gets and sets the filename of the bitmap used for the texture. The texture can be cleared by setting this to an empty string.
    /// </summary>
    string TextureFilename { get; set; }
    /// <summary>
    /// Property that gets and sets the scale of the texture.
    /// </summary>
    double TextureScale { get; set; }
    /// <summary>
    /// Property that gets and sets the rotation of the texture. The angle is defined in radians.
    /// </summary>
    double TextureRotation { get; set; }
    /// <summary>
    /// Property that indicates the name of this object or instance.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets and sets the visibility of interior faces.
    /// </summary>
    bool DisplayInteriorFaces { get; set; }
    /// <summary>
    /// Property that gets the internal name of the render style.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// If a property of both a Local and Global style is changed, its UpToDate property returns False until UpdateFromGlobal is called. UpdateFromGlobal undoes any changes made locally on this style, so then the UpToDate property will return True.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Property that indicates the location status ( ) of this render style.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that indicates if this render style is in use in the document.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that gets and sets the filename of the bitmap used for the bump map. The bump map image can be cleared by setting this to an empty string.
    /// </summary>
    string BumpMapImageFilename { get; set; }
    /// <summary>
    /// Property that gets and sets the amount of apparent bumpiness provided by the bump image. Valid range of values is from 0 to 1.
    /// </summary>
    double BumpMapAmount { get; set; }
    /// <summary>
    /// Property that gets and sets the scale of the bump map. Valid range of values is .01 to 10 indicating a range of 1% to 1000%.
    /// </summary>
    double BumpMapScale { get; set; }
    /// <summary>
    /// Property that gets and sets the rotation of the bump map. The angle is defined in radians.
    /// </summary>
    double BumpMapRotation { get; set; }
    /// <summary>
    /// Property that gets and sets whether to invert the bump effect on the surface.
    /// </summary>
    bool BumpMapInvert { get; set; }
    /// <summary>
    /// Property that gets and sets the realistic material associated with this render style using the internal name of the realistic material. This property returns a null string if there is no associated realistic material and can be set to a null string to clear the associated material.
    /// </summary>
    string RealisticAppearanceInternalName { get; set; }
    /// <summary>
    /// Property that gets and sets the realistic material associated with this render style using the display name of the realistic material. This property returns a null string if there is no associated realistic material and can be set to a null string to clear the associated material.
    /// </summary>
    string RealisticAppearanceName { get; set; }
    /// <summary>
    /// Property that gets and sets the rotation to be applied to the realistic appearance texture. The angle is defined in radians. This property returns 0 if there is no associated realistic material.
    /// </summary>
    double RealisticAppearanceRotation { get; set; }
    /// <summary>
    /// Property that gets and sets the scale to be applied to the realistic appearance texture. Valid range of values is .01 to 10 indicating a range of 1% to 1000%. This property returns 1 if there is no associated realistic material.
    /// </summary>
    double RealisticAppearanceScale { get; set; }
    /// <summary>
    /// Property that returns the thumbnail image of the associated realistic material. This property returns Nothing if there is no associated realistic material.
    /// </summary>
    IPictureDisp RealisticAppearanceThumbnail { get; }
    /// <summary>
    /// Gets/Sets the category of the render style.
    /// </summary>
    string Category { get; set; }
    /// <summary>
    /// Gets/Sets the Reflection image file name of the render style.
    /// </summary>
    string ReflectionImageFilename { get; set; }
    /// <summary>
    /// Gets/Sets the Refraction of the render style.
    /// </summary>
    double Refraction { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetDiffuseColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the diffuse color of the rendering style.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    [PreserveSig]
    void SetDiffuseColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetSpecularColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the specular color of the rendering style.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    [PreserveSig]
    void SetSpecularColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetEmissiveColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the emissive color of the rendering style.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    [PreserveSig]
    void SetEmissiveColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetAmbientColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Method that sets the ambient color of the rendering style.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    [PreserveSig]
    void SetAmbientColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Method that copies the rendering style and assigns the specified name to the copy. The new style is returned by the method.
    /// </summary>
    /// <param name="NewName">Input String that specifies the name for the new rendering style. This name must be unique with respect to all other rendering styles in the document. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    RenderStyle Copy([In] [MarshalAs(UnmanagedType.BStr)] string NewName);
    /// <summary>
    /// Method that deletes the RenderStyle.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// This method saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style. This method fails if this style is already local. Use the Local property to determine whether the style is local.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RenderStyle ConvertToLocal();
    /// <summary>
    /// Method that extracts information (such as ambient color, diffuse color, etc.) from the associated realistic material and assigns it to the render style. Calling this method \returns an error if there is no associated realistic material.
    /// </summary>
    [PreserveSig]
    void ApproximateFromRealisticAppearance();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Stream">Stream</param>
    [PreserveSig]
    void GetProteinAsset([Out] [MarshalAs(UnmanagedType.IUnknown)] out object Stream);
}
