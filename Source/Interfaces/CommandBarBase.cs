namespace Oblikovati.API;

/// <summary>
/// Use F1 key to display help topic.
/// </summary>
public interface CommandBarBase
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns Controls collection.
    /// </summary>
    CommandBarControls Controls { get; }
    /// <summary>
    /// Gets/Sets Display Name.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets/Sets Name of Command Bar.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Makes a copy of this command bar base object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CommandBarBase Copy([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    [PreserveSig]
    void _Remove([In] [MarshalAs(UnmanagedType.BStr)] string InternalName);
}
