namespace Oblikovati.API;

/// <summary>
/// This object provides methods and properties to get and set the base and override environments for this document. For more information, refer to the Environments overviews.
/// </summary>
public interface EnvironmentManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent of the EnvironmentManager.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the Environment that is defined as the default for this document. This is the environment displayed when the document is opened unless an override environment has been specified for this document.
    /// </summary>
    Environment BaseEnvironment { get; }
    /// <summary>
    /// Gets and sets the current override environment for this document.
    /// </summary>
    Environment OverrideEnvironment { get; set; }
    /// <summary>
    /// This method returns the environment associated with the currently active edit object. This is the environment which is the topmost entry in the Application menu. Since Autodesk Inventor 10, the active environment and EditObjectEnvironment are not necessarily the same. Using parallel environments, one can switch to a parallel environment for the same edit object.
    /// </summary>
    Environment EditObjectEnvironment { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Environment">Environment</param>
    /// <param name="EditTargetId">EditTargetId</param>
    [PreserveSig]
    void GetCurrentEnvironment([Out] [MarshalAs(UnmanagedType.Interface)] out Environment Environment, [Out] [MarshalAs(UnmanagedType.BStr)] out string EditTargetId);
    /// <summary>
    /// Method that sets the current Environment for this document. This is the environment that the document is currently displayed in. The change is not persisted with the document; i.e. the next time the document is opened, it will show up in its base environment or the override environment if specified.
    /// </summary>
    /// <param name="Environment">Environment that the document should be displayed in.</param>
    [PreserveSig]
    void SetCurrentEnvironment([In] [MarshalAs(UnmanagedType.Interface)] Environment Environment, [In] [MarshalAs(UnmanagedType.BStr)] string? EditObjectId = "");
}
