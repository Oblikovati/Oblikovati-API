namespace Oblikovati.API;

/// <summary>
/// The DesignProjectManager object provides access to project files related functionality in Inventor.
/// </summary>
public interface DesignProjectManager
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
    /// Property that returns the DesignProjects collection object containing all the projects.
    /// </summary>
    DesignProjects DesignProjects { get; }
    /// <summary>
    /// Property that returns the currently active design project. Use DesignProject.Activate method to activate a project.
    /// </summary>
    DesignProject ActiveDesignProject { get; }
    /// <summary>
    /// Property that returns the parent Application or ApprenticeServerComponent object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="ProjectPathType">ProjectPathType</param>
    /// <param name="ProjectPathName">ProjectPathName</param>
    [PreserveSig]
    bool IsFileInActiveProject([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [Out] out LocationTypeEnum ProjectPathType, [Out] [MarshalAs(UnmanagedType.BStr)] out string ProjectPathName);
    /// <summary>
    /// Method that runs the file resolver from the source path and attempts to find the destination file name, in the active project. The full file name of the resolved file is returned. A null string is returned if no file was resolved to.
    /// </summary>
    /// <param name="SourcePath">Input String that specifies the source path to start the file resolution from.</param>
    /// <param name="DestinationFileName">Input String that specifies the destination file name to resolve to. This can either be a relative file name or a full file name.</param>
    /// <param name="Options">Optional input Variant reserved for future use. Currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    string ResolveFile([In] [MarshalAs(UnmanagedType.BStr)] string SourcePath, [In] [MarshalAs(UnmanagedType.BStr)] string DestinationFileName, [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that adds an options button to the Projects dialog. The returned button object can be used to receive an OnClick event fired when the user clicks the option button.
    /// </summary>
    /// <param name="ClientId">Input string that uniquely identifies the client.</param>
    /// <param name="DisplayName">Input string that specifies the dispaly name of the control.</param>
    /// <param name="ToolTipText">Input string that specifies the tooltip text.</param>
    /// <param name="StandardIcon">Optional input Picture (IPictureDisp) object that specifies the icon to use for the control.</param>
    /// <returns></returns>
    [PreserveSig]
    ProjectOptionsButton AddOptionsButton([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default);
}
