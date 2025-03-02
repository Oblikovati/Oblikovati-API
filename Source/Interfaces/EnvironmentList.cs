namespace Oblikovati.API;

/// <summary>
/// The EnvironmentList object defines a list of environments that are displayed to the user in various contexts. For more information, refer to the Environments overviews.
/// </summary>
public interface EnvironmentList : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the number of environments currently in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified Environment object from the list.
    /// </summary>
    Environment this[int Index] { get; }
    /// <summary>
    /// Method that adds an Environment object to the list. The method returns an error if a built-in Environment is supplied.
    /// </summary>
    /// <param name="Environment">Input Environment object to add to the list.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] Environment Environment);
    /// <summary>
    /// Method that removes the specified Environment from the list.
    /// </summary>
    /// <param name="Index">Long that specifies the index of the Environment to remove from the list.</param>
    [PreserveSig]
    void Remove([In] int Index);
}
