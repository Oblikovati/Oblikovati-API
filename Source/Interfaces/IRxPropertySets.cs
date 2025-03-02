namespace Oblikovati.API;

public interface IRxPropertySets
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte Dirty { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="InternalName">InternalName</param>
    IRxPropertySet Create([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] ref Guid InternalName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DisplayName">DisplayName</param>
    IRxPropertySet GetByName([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    IRxPropertySet GetByFMTID([In] ref Guid InternalName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    IRxPropertySet GetByIndex([In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void RefreshFromFile();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void FlushToFile();
}
