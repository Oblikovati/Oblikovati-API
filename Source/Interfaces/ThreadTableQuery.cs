namespace Oblikovati.API;

/// <summary>
/// The ThreadTableQuery object has methods to query the thread table data contained in the Thread.xls spreadsheet.
/// </summary>
public interface ThreadTableQuery
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that returns all the available thread types (families).
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    string[] GetAvailableThreadTypes();
    /// <summary>
    /// Method that returns all the available thread sizes for a given thread type.
    /// </summary>
    /// <param name="Internal">Input Boolean that indicates if the thread is an internal or external thread.  A value of True indicates an Internal thread.</param>
    /// <param name="ThreadType">Thread type identifier string.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetAvailableThreadSizes([In] bool Internal, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType);
    /// <summary>
    /// Method that returns all the available thread designations for a thread type of a given size.
    /// </summary>
    /// <param name="Internal">Input Boolean that indicates if the thread is an internal or external thread.  A value of True indicates an Internal thread.</param>
    /// <param name="ThreadType">Thread type identifier string.</param>
    /// <param name="NominalSize">The description of the nominal size.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetAvailableDesignations([In] bool Internal, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string NominalSize);
    /// <summary>
    /// Method that returns all the available classes for a thread type of a given thread designation.
    /// </summary>
    /// <param name="Internal">Input Boolean that indicates if the thread is an internal or external thread.  A value of True indicates an Internal thread.</param>
    /// <param name="ThreadType">Thread type identifier string.</param>
    /// <param name="ThreadDesignation">A string that contains the thread designation. This is the full thread designation that is used in a drawing for the thread callout.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetAvailableClasses([In] bool Internal, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation);
    /// <summary>
    /// Method that returns the non-localized thread type identifier given the localized thread type name
    /// </summary>
    /// <param name="ThreadTypeName">Thread type identifier string.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetThreadTypeIdentifier([In] [MarshalAs(UnmanagedType.BStr)] string ThreadTypeName);
    /// <summary>
    /// Method that returns the localized thread type name given the non-localized thread type identifier
    /// </summary>
    /// <param name="ThreadTypeIdentifier">The thread type identifier.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetThreadTypeName([In] [MarshalAs(UnmanagedType.BStr)] string ThreadTypeIdentifier);
    /// <summary>
    /// Method that creates a new ThreadInfo object that can be used in creating thread features. The object returned is a StandardThreadInfo for parallel threads and TaperedThreadInfo for tapered threads. See the Thread.xls file that is delivered with  Oblikovati for examples of valid input for these arguments.
    /// </summary>
    /// <param name="Internal">Input Boolean that indicates if the thread is an internal or external thread.  A value of True indicates an Internal thread.</param>
    /// <param name="RightHanded">Input Boolean that indicates if the thread is right or left\-handed thread. A value of True indicates a right\-handed thread.</param>
    /// <param name="ThreadType">Input String that specifies the thread type. The thread type is the name of the sheet in the Thread.xls file that is used by the Thread command to define valid thread definitions.</param>
    /// <param name="ThreadDesignation">Input String that contains the thread designation. This is input as the full thread designation that will be used in a drawing for the thread callout. The nominal size and pitch information are extracted from the designation. For \example valid inch thread designations are '10\-24 UNC' and '7/16\-20 UNF'. Examples of valid metric designations are 'M16x1.5' and 'M55x1.5'.</param>
    /// <param name="Class">Optional input String that defines the thread class. For example a valid class for an inch internal thread is '2B'. A valid class for a metric external thread is '6g'. Null strings are valid for some thread types.</param>
    /// <returns></returns>
    [PreserveSig]
    ThreadInfo CreateThreadInfo([In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string? Class = "");
}
