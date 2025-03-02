namespace Oblikovati.API;

/// <summary>
/// The StylesManager object provides utilities to manage the various styles in a document.
/// </summary>
public interface StylesManager
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MaterialsEnumerator Materials { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="DisplayName">DisplayName</param>
    [PreserveSig]
    void GetStyleNameFromKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string DisplayName);
}
