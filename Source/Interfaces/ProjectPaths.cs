namespace Oblikovati.API;

/// <summary>
/// The ProjectPaths collection object provides access to a list of folder paths and provides ability to add/remove paths.
/// </summary>
public interface ProjectPaths : IEnumerable
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
    /// Returns the specified ProjectPath object from the collection.
    /// </summary>
    ProjectPath Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a folder path after the target index and returns the newly created ProjectPath object.
    /// </summary>
    /// <param name="Name">Input String that specifies a display name for the path.</param>
    /// <param name="Path">Input String that specifies the folder path.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the position of the new path in the list.  If not specified, the value defaults to 0 and the new path is added to the end of the list.</param>
    /// <returns></returns>
    [PreserveSig]
    ProjectPath Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Path, [In] int? TargetIndex = default);
    /// <summary>
    /// Method that adds folder paths from an existing project (.ipj) \file.
    /// </summary>
    /// <param name="ProjectFullFileName">Input String that specifies the full \file name of an Inventor project file with an .ipj extension to add the paths from.</param>
    [PreserveSig]
    void AddFromFile([In] [MarshalAs(UnmanagedType.BStr)] string ProjectFullFileName);
    /// <summary>
    /// Method that deletes all the paths in the collection.
    /// </summary>
    [PreserveSig]
    void Clear();
}
