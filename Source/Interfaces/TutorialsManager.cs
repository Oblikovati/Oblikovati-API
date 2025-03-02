namespace Oblikovati.API;

/// <summary>
/// The TutorialsManager provides functions for tutorials.
/// </summary>
public interface TutorialsManager
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DisplayBuiltInTutorials { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool InTutorialRecordStatus { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    [PreserveSig]
    void ShowTutorialCommandIndicator([In] [MarshalAs(UnmanagedType.BStr)] string CommandID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    /// <param name="Color">Color</param>
    /// <param name="Shape">Shape</param>
    [PreserveSig]
    void ShowTutorialCommandIndicatorWithStyles([In] [MarshalAs(UnmanagedType.BStr)] string CommandID, [In] ColorStyleEnum Color, [In] ShapeStyleEnum Shape);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearTutorialCommandIndicator();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AttibuteNAME">AttibuteNAME</param>
    [PreserveSig]
    void ShowTutorialHotspot([In] [MarshalAs(UnmanagedType.BStr)] string AttibuteNAME);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearTutorialHotspot();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VideoPath">VideoPath</param>
    [PreserveSig]
    void PlayVideo([In] [MarshalAs(UnmanagedType.BStr)] string VideoPath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FilePath">FilePath</param>
    /// <param name="SceneDoc">SceneDoc</param>
    [PreserveSig]
    void FlushDocument([In] [MarshalAs(UnmanagedType.BStr)] string FilePath, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref _Document SceneDoc);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeFullPath">BrowserNodeFullPath</param>
    [PreserveSig]
    void ShowTutorialBrowserIndicator([In] [MarshalAs(UnmanagedType.BStr)] string BrowserNodeFullPath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeFullPath">BrowserNodeFullPath</param>
    /// <param name="Color">Color</param>
    /// <param name="Shape">Shape</param>
    [PreserveSig]
    void ShowTutorialBrowserIndicatorWithStyles([In] [MarshalAs(UnmanagedType.BStr)] string BrowserNodeFullPath, [In] ColorStyleEnum Color, [In] ShapeStyleEnum Shape);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearTutorialBrowserIndicator();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    [PreserveSig]
    void SetDocumentTabTutorialColor([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject);
}
