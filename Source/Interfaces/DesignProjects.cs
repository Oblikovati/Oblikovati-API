namespace Oblikovati.API;

/// <summary>
/// The DesignProjects collection object provides access to all the existing projects and provides methods to create additional projects.
/// </summary>
public interface DesignProjects : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DesignProject object from the collection.
    /// </summary>
    DesignProject Item { get; }
    /// <summary>
    /// Returns the specified DesignProject object from the collection.
    /// </summary>
    DesignProject ItemByName { get; }
    /// <summary>
    /// Method that creates a new DesignProject. The newly created DesignProject is returned.
    /// </summary>
    /// <param name="ProjectType">Input MultiUserModeEnum that specifies the type of project to create.</param>
    /// <param name="Name">Input String that specifies a name for the project.</param>
    /// <param name="ProjectPath">Input String that specifies the project (workspace or workgroup) folder for the project.</param>
    /// <returns></returns>
    [PreserveSig]
    DesignProject Add([In] MultiUserModeEnum ProjectType, [In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string ProjectPath);
    /// <summary>
    /// Method that adds an existing project file to the list of project files. This is equivalent of browsing to a specific ipj file on disk and choosing it in the Projects editor dialog. If the design project is already in the collection, the corresponding DesignProject object is returned.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name of an Inventor project file with an .ipj extension.</param>
    /// <returns></returns>
    [PreserveSig]
    DesignProject AddExisting([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
