namespace Oblikovati.API;

/// <summary>
/// The HelpManager object encapsulates all of the help functionality.
/// </summary>
public interface HelpManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the full path location of the help directory.
    /// </summary>
    string HelpPath { get; }
    /// <summary>
    /// Gets the object that fires Help related events.
    /// </summary>
    HelpEvents HelpEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="TopicName">TopicName</param>
    [PreserveSig]
    void DisplayHelpTopic([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] [MarshalAs(UnmanagedType.BStr)] string TopicName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void DisplayHelpContext([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] int Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="Context">Context</param>
    /// <param name="ContextString">ContextString</param>
    [PreserveSig]
    void RegisterHelpContext([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] int Context, [In] [MarshalAs(UnmanagedType.BStr)] string ContextString);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Seed">Seed</param>
    /// <param name="Query">Query</param>
    [PreserveSig]
    string GetInventorHelpURL([In] [MarshalAs(UnmanagedType.BStr)] string Seed, [In] [MarshalAs(UnmanagedType.Struct)] object? Query = default);
}
