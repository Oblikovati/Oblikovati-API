namespace Oblikovati.API;

public interface MiniToolbarDropdownSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void OnPreMenuDisplay();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ListItem">ListItem</param>
    [PreserveSig]
    void OnSelect([In] [MarshalAs(UnmanagedType.Interface)] MiniToolbarListItem ListItem);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ListItem">ListItem</param>
    [PreserveSig]
    void OnItemRemove([In] [MarshalAs(UnmanagedType.Interface)] MiniToolbarListItem ListItem);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ListItem">ListItem</param>
    [PreserveSig]
    void OnItemHoverEnd([In] [MarshalAs(UnmanagedType.Interface)] MiniToolbarListItem ListItem);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ListItem">ListItem</param>
    [PreserveSig]
    void OnItemHoverStart([In] [MarshalAs(UnmanagedType.Interface)] MiniToolbarListItem ListItem);
}
