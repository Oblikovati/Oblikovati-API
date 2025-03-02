namespace Oblikovati.API;

/// <summary>
/// Object required to be supported by Server to qualify as an Autodesk Inventor AddIn.
/// </summary>
public interface ApplicationAddInServer
{
    /// <summary>
    /// Gets the IUnknown of the object implemented inside the AddIn that supports AddIn-specific API.
    /// </summary>
    object Automation { get; }
    /// <summary>
    /// Invoked by  Oblikovati after creating the AddIn. AddIn should initialize within this call.
    /// </summary>
    /// <param name="AddInSiteObject">Input argument that specifies the object, which provides access to the Autodesk Inventor Application object.</param>
    /// <param name="FirstTime">The FirstTime flag, if True, indicates to the Addin that this is the first time it is being loaded and to take some specific action. It does not take these actions when this flag is False. Typically, when the flag is True, the AddIn proceeds to create all of the objects under the UserInterfaceManager that it needs - Environments, Ribbons and Controls. These objects are persistent, but if this is the first time the Addin is loaded, they need to be created from scratch. When the FirstTime flag is False, meaning the Addin has already been loaded, it only needs to create the objects under the CommandManager - CommandCategories and ControlDefinitions.</param>
    [PreserveSig]
    void Activate([In] [MarshalAs(UnmanagedType.Interface)] ApplicationAddInSite AddInSiteObject, [In] bool FirstTime);
    /// <summary>
    /// Invoked by  Oblikovati to shut down the AddIn. AddIn should complete shutdown within this call.
    /// </summary>
    [PreserveSig]
    void Deactivate();
    /// <summary>
    /// Invoked by  Oblikovati in response to user requesting the execution of an AddIn-supplied command. AddIn must perform the command within this call.
    /// </summary>
    /// <param name="CommandID">Input Long that specifies the command to execute.</param>
    [PreserveSig]
    void ExecuteCommand(int CommandID);
}
