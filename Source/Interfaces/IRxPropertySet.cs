namespace Oblikovati.API;

public interface IRxPropertySet
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid InternalName { get; }
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
    /// <param name="PropId">PropId</param>
    /// <param name="PropValue">PropValue</param>
    /// <param name="Name">Name</param>
    IRxProperty Create([In] int PropId, [In] [MarshalAs(UnmanagedType.Struct)] object PropValue, [In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropValue">PropValue</param>
    /// <param name="Name">Name</param>
    IRxProperty CreateByName([In] [MarshalAs(UnmanagedType.Struct)] object PropValue, [In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    IRxProperty GetByName([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropId">PropId</param>
    IRxProperty GetByPropId([In] int PropId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    IRxProperty GetByIndex([In] int Index);
}
