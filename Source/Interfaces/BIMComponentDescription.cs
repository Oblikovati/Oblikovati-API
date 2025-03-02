namespace Oblikovati.API;

/// <summary>
/// BIMComponentDescription object.
/// </summary>
public interface BIMComponentDescription
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
    /// Read-only property that returns the collection object containing the property sets for a BIM component.
    /// </summary>
    BIMComponentPropertySets ComponentPropertySets { get; }
    /// <summary>
    /// Read-write property that gets and sets the component type.
    /// </summary>
    string ComponentType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the standard Inventor iProperties that are exported with this component.
    /// </summary>
    ObjectCollection ModelProperties { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    UserCoordinateSystem Orientation { get; set; }
    /// <summary>
    /// Read-write property that specifies which orientation type will be used when exporting the BIM component.
    /// </summary>
    BIMComponentOrientationTypeEnum OrientationType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the thumbnail for this component.
    /// </summary>
    IPictureDisp Thumbnail { get; set; }
    /// <summary>
    /// Read-write property that defines which user coordinate system will be used when exporting the component. If the OrientationType is not kUserCoordinateSystemOrientationType this property returns Nothing.
    /// </summary>
    UserCoordinateSystem UserCoordinateSystemOrientation { get; set; }
    /// <summary>
    /// Read-write property that gets and set the origin of the coordinate system when the orientation is defined using the ViewCube.
    /// </summary>
    Point ViewCubeOrientationOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the family type. This is applicable for IFC and RFA formats.
    /// </summary>
    string FamilyType { get; set; }
    /// <summary>
    /// Method that lets you set the custom thumbnail by providing the filename of an image file.&nbsp;The file should be a bmp,&nbsp;jpg, or png format and should be 256x256 pixels.
    /// </summary>
    /// <param name="FullFileName">Input String of the full filename of the image file.</param>
    [PreserveSig]
    void SetCustomThumbnail([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
