namespace Oblikovati.API;

/// <summary>
/// The CustomParameterGroup object represents a grouping of certain parameters in the parameters dialog. These groups serve as a logical grouping of parameters to allow the user to more easily find a specific parameter.
/// </summary>
public interface CustomParameterGroup : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Property that returns the number of parameters in this group.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets and sets the disabling of certain user actions on this object.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Gets the display name of the Custom Parameter Group.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Property that returns the name of the custom group. The name is the internal English name of the group. This name will remain constant and is not affected by locale. The name is never displayed to the user. The display name is what's shown to the user.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Returns the specified Parameter object.
    /// </summary>
    Parameter this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a parameter to the group. Adding a parameter to a group does not remove it from group(s) that it currently resides in.
    /// </summary>
    /// <param name="Parameter">Input Parameter object that represents the parameter to be added to this group.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] Parameter Parameter);
    /// <summary>
    /// Method that deletes the group and optionally deletes the parameters that it contains.
    /// </summary>
    /// <param name="DeleteParameters">Optional input Boolean value that indicates whether or not to additionally delete the parameters contained in the group. A value of True specifies that the parameters should be deleted. If not specified, a default of False is used indicating that the parameters in the group will not be deleted.</param>
    [PreserveSig]
    void Delete([In] bool? DeleteParameters = false);
    /// <summary>
    /// Method that removes a parameter from the group. This does not delete the parameter.
    /// </summary>
    /// <param name="Index">Input Long that specifies the index of the item within the list to be removed from this group.</param>
    [PreserveSig]
    void Remove([In] int Index);
}
