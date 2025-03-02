namespace Oblikovati.API;

/// <summary>
/// PublisherServer Object.
/// </summary>
public interface PublisherServer
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentName">DocumentName</param>
    /// <param name="ControlData">ControlData</param>
    /// <param name="OutputData">OutputData</param>
    /// <param name="Status">Status</param>
    [PreserveSig]
    void GetXMLData([In] [MarshalAs(UnmanagedType.Struct)] object DocumentName, [In] [MarshalAs(UnmanagedType.BStr)] string ControlData, [Out] [MarshalAs(UnmanagedType.BStr)] out string OutputData, [Out] [MarshalAs(UnmanagedType.BStr)] out string Status);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    PresentationScene GetActivePresentationScene([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    PresentationScenes GetPresentationScenes([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument Document);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="publicationInternalName">publicationInternalName</param>
    /// <param name="StoryboardId">StoryboardId</param>
    [PreserveSig]
    string GetStoryboardName([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument Document, [In] [MarshalAs(UnmanagedType.BStr)] string publicationInternalName, [In] int StoryboardId);
}
