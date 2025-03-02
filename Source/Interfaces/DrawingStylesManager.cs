namespace Oblikovati.API;

/// <summary>
/// The DrawingStylesManager object provides utilities to manage the various styles in a drawing document.
/// </summary>
public interface DrawingStylesManager
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the DrawingStandardStylesEnumerator object. This object provides access to all the standard styles.
    /// </summary>
    DrawingStandardStylesEnumerator StandardStyles { get; }
    /// <summary>
    /// Property that returns the DimensionStylesEnumerator object. This object provides access to all the dimension styles.
    /// </summary>
    DimensionStylesEnumerator DimensionStyles { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that gets the TextStyles collection object.
    /// </summary>
    TextStylesEnumerator TextStyles { get; }
    /// <summary>
    /// Gets and sets the active standard style.
    /// </summary>
    DrawingStandardStyle ActiveStandardStyle { get; set; }
    /// <summary>
    /// Property that gets the ObjectDefaultsStylesEnumerator collection object.
    /// </summary>
    ObjectDefaultsStylesEnumerator ObjectDefaultsStyles { get; }
    /// <summary>
    /// Property that returns the LayersEnumerator object. This object provides access to all the layers.
    /// </summary>
    LayersEnumerator Layers { get; }
    /// <summary>
    /// Read-only property that returns the Styles object.
    /// </summary>
    Styles Styles { get; }
    /// <summary>
    /// Property that returns the LeaderStylesEnumerator object.
    /// </summary>
    LeaderStylesEnumerator LeaderStyles { get; }
    /// <summary>
    /// Property that returns the BalloonStylesEnumerator object.
    /// </summary>
    BalloonStylesEnumerator BalloonStyles { get; }
    /// <summary>
    /// Property that returns the FeatureControlFrameStylesEnumerator object.
    /// </summary>
    FeatureControlFrameStylesEnumerator FeatureControlFrameStyles { get; }
    /// <summary>
    /// Property that returns the SurfaceTextureStylesEnumerator object.
    /// </summary>
    SurfaceTextureStylesEnumerator SurfaceTextureStyles { get; }
    /// <summary>
    /// Property that returns the HoleTableStylesEnumerator object.
    /// </summary>
    HoleTableStylesEnumerator HoleTableStyles { get; }
    /// <summary>
    /// Property that returns the CentermarkStylesEnumerator object. This object provides access to all the center mark styles.
    /// </summary>
    CentermarkStylesEnumerator CentermarkStyles { get; }
    /// <summary>
    /// Property that returns the PartsListStylesEnumerator object. This object provides access to all the parts list styles.
    /// </summary>
    PartsListStylesEnumerator PartsListStyles { get; }
    /// <summary>
    /// Property that returns the RevisionTableStylesEnumerator object. This object provides access to all the revision table styles.
    /// </summary>
    RevisionTableStylesEnumerator RevisionTableStyles { get; }
    /// <summary>
    /// Property that returns the TableStylesEnumerator object. This object provides access to all the general table styles.
    /// </summary>
    TableStylesEnumerator TableStyles { get; }
    /// <summary>
    /// Read-only property that returns the WeldSymbolStylesEnumerator object.
    /// </summary>
    WeldSymbolStylesEnumerator WeldSymbolStyles { get; }
    /// <summary>
    /// Read-only property that returns the EdgeSymbolStylesEnumerator object. This object provides access to all the edge symbol styles.
    /// </summary>
    EdgeSymbolStylesEnumerator EdgeSymbolStyles { get; }
    /// <summary>
    /// Method that replaces styles.
    /// </summary>
    /// <param name="ReplacedStyles">Input ObjectCollection object that specifies the styles to be replaced.</param>
    /// <param name="ReplaceStyle">Input Style object that specifies the replace style.</param>
    /// <param name="PurgeReplacedStyles">Optional input Boolean that specifies whether to purge the replaced styles or not. This default to False if not specified.</param>
    [PreserveSig]
    void ReplaceStyles([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ReplacedStyles, [In] [MarshalAs(UnmanagedType.Interface)] Style ReplaceStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? PurgeReplacedStyles = default);
}
