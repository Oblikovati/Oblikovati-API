namespace Oblikovati.API;

/// <summary>
/// Object that represents an Application AddIn inside Autodesk Inventor.
/// </summary>
public interface ApplicationAddIn
{
    /// <summary>
    /// Gets the CLSID of the AddIn as the string used in the class moniker.
    /// </summary>
    string ClassIdString { get; }
    /// <summary>
    /// Gets the ProgID of the AddIn.
    /// </summary>
    string ProgId { get; }
    /// <summary>
    /// Gets the displayable name of the AddIn.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the short display name of the Add-in. Used in places to succinctly identify the AddIn inside Inventor's UI.
    /// </summary>
    string ShortDisplayName { get; }
    /// <summary>
    /// Gets the description of the AddIn.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool StartUpEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Version { get; }
    /// <summary>
    /// Gets and sets whether the AddIn is hidden or not.
    /// </summary>
    bool Hidden { get; set; }
    /// <summary>
    /// Gets and sets whether the AddIn is allowed to be unloaded by the user.
    /// </summary>
    bool UserUnloadable { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this AddIn.
    /// </summary>
    ApplicationAddInTypeEnum AddInType { get; }
    /// <summary>
    /// Gets a Boolean flag indicating whether this AddIn is currently active in the session.
    /// </summary>
    bool Activated { get; }
    /// <summary>
    /// Property that returns the Add-in's automation interface (if any). Fails if the Add-in is currently inactive.
    /// </summary>
    object Automation { get; }
    /// <summary>
    /// Gets and sets the current data version of the AddIn.&nbsp;This value corresponds to the 'Data Version' registry entry in the AddIn's registry hive.
    /// </summary>
    int DataVersion { get; set; }
    /// <summary>
    /// Gets the license status of the AddIn.
    /// </summary>
    AddInLicenseStatusEnum LicenseStatus { get; }
    /// <summary>
    /// Property that returns a GUID in string format that uniquely identifies this Add-in. This GUID is used as an identifier when creating Add-in specific objects such as user interface elements, client features, etc.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Application object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the full file name of the dll associated with this Add-in.
    /// </summary>
    string Location { get; }
    /// <summary>
    /// Property that returns the version of the user interface of the add-in. Incrementing this version results in all of the add-in"s UI getting cleaned up during Inventor start-up.
    /// </summary>
    int UserInterfaceVersion { get; }
    /// <summary>
    /// Gets a constant indicating the load behavior (load time) of the add-in. This applies only if the LoadAutomatically property is set to True.
    /// </summary>
    AddInLoadBehaviorEnum LoadBehavior { get; }
    /// <summary>
    /// Gets/Sets whether the add-in loads automatically based on the load behavior specified for the add-in.&nbsp;If set to False, the add-in needs to be manually loaded by the user.
    /// </summary>
    bool LoadAutomatically { get; set; }
    /// <summary>
    /// Creates and initializes the AddIn. No effect if AddIn already active.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Invokes the shutdown sequence on the AddIn. No effect if AddIn inactive.
    /// </summary>
    [PreserveSig]
    void Deactivate();
}
